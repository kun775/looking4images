using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using CsharpHttpHelper;
using CsharpHttpHelper.Item;
using CsharpHttpHelper.Enum;
using System.Drawing;

namespace Looking4Images
{
    public struct HtmlDeepth
    {
        public int deepth;
        public string url;
    };
    public partial class MainForm : Form
    {
        public static object locker = new object();//添加一个对象作为锁
        public static List<string> already_html = new List<string> { };//已经访问过的链接
        public static List<string> already_images = new List<string> { };//已经下载过的图片
        public static List<HtmlDeepth> html_list = new List<HtmlDeepth> { };//将要访问的链接
        public static List<string> images_list = new List<string> { };//保存将要下载的图片链接
        public static List<string> format_list = new List<string> { };//下载的图片格式
        public static readonly List<string> domain_list = new List<string> { "vip", "club", "com", "net", "cn", "xyz", "org",
                "info", "name", "mobi", "wang", "ac", "在线", "中国", "中文网", "top", "work",
                "fashion", "yoga", "beer", "luxe", "网址", "love", "online", "购物", "ltd",
                "chat", "group", "pub", "run", "city", "live", "pro", "red", "网店", "kim",
                "blue", "pet", "移动", "ski", "pink", "space", "tech", "host", "fun", "site", "store" };

        public string charset = "gbk";
        public static MainForm  mainForm = null;
        private readonly Setting setting = new Setting()
        {
            ShowInTaskbar = false,
        };


        /*********************每次爬取前需要重置的变量*****************/
        public static bool stop_download = false;
        public static bool output_finish_message = false;
        public static int request_count = 0;            //请求的链接数
        public static int current_count = 0;            //当前请求链接数
        public static int failed_count = 0;             //失败的链接数
        public static int success_count = 0;            //成功的链接数
        public static int current_deepth = 0;           //当前深度
        public static int current_image_count = 0;      //当前图片数量
        public static int total_image_count = 0;        //此次总共下载的图片数
        public static long block_size = 0;              //每秒下载的大小
        public static long start_time = 0;              //开始爬取时间戳
        public static long stop_time = 0;               //结束爬取时间戳
        /*****************************************************************/

        /********************每次爬取前需要赋值的变量*********************/
        public string request_host = "";                //请求的地址
        public static string domain = "";               //域名
        public string html_prefix = "";                 //跳转前缀
        public int request_deepth = 1;                  //搜索的深度
        public int image_size = 500;                    //图片大小
        public int image_count = 1000;                  //图片数量
        private string save_path = "images";            //保存图片的路径
        
        /*****************************************************************/

        /***********************代理**************************************/
        public static string proxy_ip = "";
        public static string proxy_username = "";
        public static string proxy_password = "";
        /******************************************************************/

        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            mainForm = this;
            setting.Owner = this;
            
            button_Stop.Enabled = false;
            comboBox_Deepth.SelectedIndex = 1;
            comboBox_Directory.SelectedIndex = 1;

            updateTxt = new UpdateTxt(UpdateTxtMethod);
        }
        /// <summary>
        /// 进行一些初始化
        /// </summary>
        public void InitBeforeStart()
        {
            progressBar1.Value = 0;
            label_process.Text = "[  0/  0]   0%";
            current_count = 0;
            request_count = 0;
            current_image_count = 0;
            total_image_count = 0;
            failed_count = 0;
            success_count = 0;
            block_size = 0;
            start_time = GetTimeStamp();
            stop_time = 0;

            already_html.Clear();
            html_list.Clear();
            images_list.Clear();
            stop_download = false;
            output_finish_message = false;
            button_GO.Enabled = false;
            button_Stop.Enabled = true;

            textBox_CurrentHtml.Text = "0";
            textBox_CurrentImages.Text = "0";
            textBox_Failed.Text = "0";
            textBox_Success.Text = "0";
            textBox_HtmlList.Text = "0";
            textBox_ImagesList.Text = "0";

            groupBox1.Enabled = false;
            timer1.Start();
        }
        /// <summary>
        /// 爬取完成调用
        /// </summary>
        public void Finish()
        {
            if (!output_finish_message)
            {
                output_finish_message = true;
                stop_time = GetTimeStamp();
                mainForm.AddContent("");
                mainForm.AddContent("");
                mainForm.AddContent(string.Format("爬取完成，总共下载图片: {0} 张，其中有效图片: {1} 张",
                                total_image_count, current_image_count));
                mainForm.AddContent("爬取共用时: " + GetRunningTime(stop_time - start_time));

                mainForm.button_GO.Enabled = true;
                stop_download = true;
                mainForm.groupBox1.Enabled = true;
                mainForm.timer1.Stop();
            }
        }
        /// <summary>
        /// 开始爬取按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_GO_Click(object sender, EventArgs e)
        {
            request_host = textBox_Host.Text.Trim();//获取请求地址
            request_deepth = comboBox_Deepth.SelectedIndex + 1;//获取请求深度
            html_prefix = textBox_HtmlPrefix.Text;
            if (textBox_ImageSize.Text == "")
                textBox_ImageSize.Text = "500";
            if (textBox_ImageCount.Text == "")
                textBox_ImageCount.Text = "1000";
            image_size = Int32.Parse(textBox_ImageSize.Text);//获取图片大小
            image_count = Int32.Parse(textBox_ImageCount.Text);//获取图片数量

            if (request_host == "")
            {
                MessageBox.Show("请输入地址");
                return;
            }
            domain = request_host.Replace("https://", "").Replace("http://", "").Split('/')[0];
            string[] list = domain.Split('.');
            if (domain_list.Contains(list[list.Length - 2]))
                domain = list[list.Length - 3];
            else if (domain_list.Contains(list[list.Length - 1]))
                domain = list[list.Length - 2];

            Starting();
        }
        /// <summary>
        /// 真正的开始函数
        /// </summary>
        public void Starting()
        {
            InitBeforeStart();//开始爬取前进行一些初始化

            string directory = comboBox_Directory.Text;
            if (directory == "当天日期")
            {
                directory = DateTime.Now.ToString("yyyyMMdd");
            }
            else if (directory == "网站域名")
            {
                directory = request_host.Replace("https://", "").Replace("http://", "").Split('/')[0];
            }
            save_path = "images\\" + directory;

            AddContent("开始爬取:" + request_host);
            AddContent("域名:" + domain);
            AddContent("保存目录:" + save_path);
            AddContent("爬虫深度:" + request_deepth.ToString());
            AddContent(string.Format("代理:{0,-20} 用户名:{1,-10} 密码:{2,-10}", proxy_ip, proxy_username, proxy_password));
            AddContent("Cookie:" + cookies);

            Thread thread = new Thread(new ThreadStart(ThreadGetHtml))
            {
                IsBackground = true
            };
            thread.Start();
            thread = new Thread(new ThreadStart(ThreadGetImages))
            {
                IsBackground = true
            };
            thread.Start();
        }
        /// <summary>
        /// 获取网页中的图片链接
        /// </summary>
        /// <param name="html"></param>
        private static void HttpHelperParse_Images(string html)
        {
            if (stop_download)
            {
                mainForm.Finish();
                return;
            }
            List<ImgItem> imglist = HttpHelper.GetImgList(html);
            if (imglist != null && imglist.Count != 0)
            {
                foreach (var item in imglist)
                {
                    string src = item.Src;
                    if (src[0] == '/' && src[1] != '/')
                        src = mainForm.html_prefix + src;
                    if (src.Length < 6 || src[0] == '.' || src[0] == '/')
                        continue;

                    string[] filenames = src.Split('.');
                    string format = filenames[filenames.Length - 1];
                    if (format_list.Count > 0 && !format_list.Contains(format))
                        continue;
                    if (show_images)
                        mainForm.AddContent(src);
                    lock (locker)
                    {
                        if (!images_list.Contains(src))
                            images_list.Add(src);
                    }
                }
            }
        }
        /// <summary>
        /// 获取网页中的子页面链接
        /// </summary>
        /// <param name="input"></param>
        /// <param name="deepth"></param>
        private static void HttpHelperParse_Html(string input, int deepth)
        {
            if (stop_download)
            {
                mainForm.Finish();
                return;
            }
            //深度超过设定深度，不解析
            if (deepth >= mainForm.request_deepth)
                return;
           
            List<AItem> alist = HttpHelper.GetAList(input);
            if (alist == null || alist.Count == 0)
                return;
            HtmlDeepth htmlDeepth = new HtmlDeepth();
            foreach (var item in alist)
            {
                string href = item.Href;
                if (href.Length < 5)
                    continue;

                //过滤非正常子页面链接
                if (href.IndexOf("javascript") != -1 || href.IndexOf("search") != -1
                    || href.IndexOf(".css") != -1
                    || href.IndexOf(".js") != -1)
                    continue;
                if (href[0] == '/' || href[0] == '.')
                    continue;
                //判断是否要加前缀
                if (href.Substring(0, 3) != "htt" && href.Substring(0, 3) != "www")
                    href = mainForm.html_prefix + href;
                //如果包含域名，则表示不是站内子页面，不访问
                if (href.IndexOf(domain) == -1)
                    continue;
                //已经访问过的页面
                if (already_html.Contains(href))
                    continue;
                //去掉链接中的双引号和单引号
                htmlDeepth.url = href.Replace("\"", "").Replace("\'", ""); 
                htmlDeepth.deepth = deepth + 1;
                if (show_html)
                    mainForm.AddContent(htmlDeepth.url);
                lock (locker)
                {
                    if (!html_list.Contains(htmlDeepth))
                        html_list.Add(htmlDeepth);
                }
            }
        }

        /// <summary>
        /// 下载图片
        /// </summary>
        /// <param name="title"></param>
        /// <param name="url"></param>
        private static void DownloadImages(object data)
        {
            if (stop_download)
                return;

            string url = data as string;
            if (!Directory.Exists(mainForm.save_path))
            {
                try
                {
                    Directory.CreateDirectory(mainForm.save_path);
                }
                catch (Exception e)
                {
                    mainForm.AddContent("创建文件夹失败:" + mainForm.save_path + "\n"+ e.Message);
                    return;
                }
            }

            long file_size;
            string img_url = url.Replace("\"", "").Replace("\'", "");
            string[] filenames = img_url.Split('.');
            string filename = DateTime.Now.ToString("yyyyMMddHHmmssff.") + filenames[filenames.Length -1];
            filename = mainForm.save_path + "\\" + filename;
            if (File.Exists(filename))
            {
                FileInfo fileInfo = new FileInfo(filename);
                file_size = fileInfo.Length / 1024;
                if (file_size >= mainForm.image_size)
                    return;
                else
                    fileInfo.Delete();
            }

            try
            {
                mainForm.label_Running.Text = img_url;

                if (download_type == 1)
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(img_url, filename);
                }
                else
                {
                    HttpHelper http = new HttpHelper();
                    HttpItem item = new HttpItem()
                    {
                        URL = img_url,//URL     必需项    
                        Method = "get",//URL     可选项 默认为Get   
                        ResultType = ResultType.Byte
                    };
                    HttpResult result = http.GetHtml(item);

                    Image img = HttpHelper.GetImage(result.ResultByte);
                    if (img == null)
                    {
                        return;
                    }

                    img.Save(filename);
                    //释放资源
                    img.Dispose();
                }

                current_image_count++;
                total_image_count++;
                FileInfo fileInfo = new FileInfo(filename);
                file_size = fileInfo.Length / 1024;
                block_size += file_size;
                if (file_size < mainForm.image_size)
                {
                    fileInfo.Delete();
                    current_image_count--;
                }
                else
                {
                    mainForm.AddContent(string.Format("{0, -75} * 下载完成 [{1, 4}]KB", url, file_size));
                }

                var bi = mainForm.BeginInvoke(new MethodInvoker(delegate
                {
                    mainForm.textBox_CurrentImages.Text = current_image_count.ToString();
                    
                    int process = current_image_count * 100 / mainForm.image_count;
                    mainForm.progressBar1.Value = process;
                    mainForm.label_process.Text = string.Format("[{0,3}/{1,3}]{2,3}%", current_image_count, mainForm.image_count, process);
                    }));
                mainForm.EndInvoke(bi);
                if (current_image_count >= mainForm.image_count)
                {
                    mainForm.Finish();
                }
            }
            catch (WebException ex)
            {
                mainForm.AddContent(img_url + " " + ex.Message);
            }
        }
        /// <summary>
        /// 爬取子页面的进程
        /// </summary>
        private static void ThreadGetHtml()
        {
            html_list.Clear();
            HtmlDeepth htmlDeepth = new HtmlDeepth()
            {
                deepth = 1,
                url = mainForm.request_host
            };
            html_list.Add(htmlDeepth);
            while (!stop_download)
            {
                if (html_list.Count > 0)
                {
                    
                    lock (locker)
                    {
                        htmlDeepth = html_list[0];
                        html_list.RemoveAt(0);
                    }
                    mainForm.textBox_HtmlList.Text = html_list.Count.ToString();
                    string html = GetHtml_v1(htmlDeepth.url, htmlDeepth.deepth);
                    HttpHelperParse_Html(html, htmlDeepth.deepth);
                    HttpHelperParse_Images(html);
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
        }
        /// <summary>
        /// 下载图片的进程
        /// </summary>
        private static void ThreadGetImages()
        {
            images_list.Clear();
            while (!stop_download)
            {
                if (images_list.Count > 0)
                {
                    string url;
                    lock (locker)
                    {
                        url = images_list[0];
                        images_list.RemoveAt(0);
                    }
                    mainForm.textBox_ImagesList.Text = images_list.Count.ToString();
                    DownloadImages(url);
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
        }
        /// <summary>
        /// 获取网页内容 使用httphelper
        /// </summary>
        /// <param name="inner_url"></param>
        /// <param name="deepth"></param>
        /// <returns></returns>
        private static string GetHtml_v1(string inner_url, int deepth = 1)
        {
            if (already_html.Contains(inner_url))
                return "";

            request_count++;

            already_html.Add(inner_url);
            mainForm.textBox_CurrentHtml.Text = request_count.ToString();
            mainForm.label_Html.Text = string.Format("深度[{0}] {1}", deepth, inner_url);

            //创建Httphelper对象
            HttpHelper http = new HttpHelper();
            //创建Httphelper参数对象
            HttpItem item = new HttpItem()
            {
                URL = inner_url,//URL     必需项    
                Method = "get",//URL     可选项 默认为Get   
                ContentType = "text/html",//返回类型    可选项有默认值   
                Referer = "https://www.google.com",
                Cookie = mainForm.cookies,
                ProxyIp = proxy_ip,
                ProxyUserName = proxy_username,
                ProxyPwd = proxy_password,
                UserAgent = @"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/76.0.3809.132 Safari/537.36",
        };
            //请求的返回值对象
            HttpResult result = http.GetHtml(item);
            //状态码
            HttpStatusCode code = result.StatusCode;
            //状态描述
            string Des = result.StatusDescription;
            string html = "";
            if (code != HttpStatusCode.NotFound)
            {
                html = result.Html;
                mainForm.cookies = result.Cookie;

                success_count++;
                mainForm.textBox_Success.Text = success_count.ToString();
            }
            else
            {
                failed_count++;
                mainForm.AddContent(inner_url + " : " + Des);
                mainForm.textBox_Failed.Text = failed_count.ToString();
                if (already_html.Contains(inner_url))
                    already_html.Remove(inner_url);
            }
            //mainForm.AddContent(html);
            return html;
        }

        private void TextBox_ImageSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }
        /// <summary>
        /// 统计网速
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            label_Speed.Text = string.Format("[{0, 4} KB/s]", block_size / 2);
            block_size = 0;
            if (images_list.Count == 0 && html_list.Count == 0)
            {
                stop_download = true;
                Finish();
            }
        }

        private void Button_Setting_Click(object sender, EventArgs e)
        {
            setting.ShowDialog();
        }
    }
}
