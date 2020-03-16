using System;
using System.Windows.Forms;
using System.Threading;

namespace Looking4Images
{
    public struct SettingItem
    {
        public bool html;
        public bool images;
        public int download_type;
        public string ip;
        public string port;
        public string username;
        public string password;
        public string format;
        public string cookie;
    };
    public partial class MainForm : Form
    {
        public string cookies = "";
        public static int download_type = 0;//下载图片的方式
        public static bool show_html = false;
        public static bool show_images = false;
        private const int DAY = 24 * 60 * 60;
        private const int HOUR = 60 * 60;
        //创建一个委托，是为访问TextBox控件服务的。
        public delegate void UpdateTxt(string msg);
        //定义一个委托变量
        public UpdateTxt updateTxt;

        //此为在非创建线程中的调用方法，其实是使用TextBox的Invoke方法。
        public void ThreadMethodTxt(string content)
        {
            this.BeginInvoke(updateTxt, content);
        }
        //修改TextBox值的方法。
        public void UpdateTxtMethod(string content)
        {
            string now = DateTime.Now.ToString();
            richTextBox.AppendText(now + " " + content + "\n");
            richTextBox.ScrollToCaret();
        }
        /// <summary>
        /// 接收端对话框显示消息
        /// </summary>
        /// <param name="content"></param>
        private void AddContent(string content)
        {
            Thread objThread = new Thread(new ThreadStart(delegate
            {
                ThreadMethodTxt(content);
            }));
            objThread.Start();
        }
        private void Button_Stop_Click(object sender, EventArgs e)
        {
            stop_download = true;
            button_GO.Enabled = true;
            button_Stop.Enabled = false;
            groupBox1.Enabled = true;
        }

        private void Button_Clean_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        public static long GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds) / 1000;
        }
        private string GetRunningTime(long seconds)
        {
            long day = seconds / DAY;
            long hour = seconds % DAY / HOUR;
            long min = seconds % DAY % HOUR / 60;
            long sec = seconds % DAY % HOUR % 60;

            return string.Format("{0} 天 {1} 小时 {2} 分钟 {3} 秒", day, hour, min, sec);
        }
        public void Setting(SettingItem item)
        {
            if (item.ip != "")
            {
                proxy_ip = item.ip;
                if (item.port != "")
                    proxy_ip = proxy_ip + ":" + item.port;
            }
            download_type = item.download_type;
            show_html = item.html;
            show_images = item.images;
            proxy_username = item.username;
            proxy_password = item.password;
            cookies = item.cookie;
            if (item.format != "")
            {
                format_list.Clear();
                string[] vs = item.format.Split(' ');
                string _format = "";
                foreach (string s in vs)
                {
                    format_list.Add(s);
                    _format += (s + " ");
                }
                mainForm.AddContent(string.Format("图片格式[{0}]: {1}",format_list.Count, _format));
            }
            setting.Hide();
        }
    }
}