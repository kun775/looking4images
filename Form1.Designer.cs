namespace Looking4Images
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.button_GO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_process = new System.Windows.Forms.Label();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Clean = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Setting = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_ImageCount = new System.Windows.Forms.TextBox();
            this.textBox_HtmlPrefix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Directory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_ImageSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Deepth = new System.Windows.Forms.ComboBox();
            this.textBox_Host = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_ImagesList = new System.Windows.Forms.TextBox();
            this.textBox_CurrentImages = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Failed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_Success = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_HtmlList = new System.Windows.Forms.TextBox();
            this.textBox_CurrentHtml = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_Speed = new System.Windows.Forms.Label();
            this.label_Html = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label_Running = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox.Location = new System.Drawing.Point(6, 15);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(744, 278);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.TabStop = false;
            this.richTextBox.Text = "";
            // 
            // button_GO
            // 
            this.button_GO.BackColor = System.Drawing.Color.Transparent;
            this.button_GO.BackgroundImage = global::Looking4Images.Properties.Resources.button;
            this.button_GO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_GO.FlatAppearance.BorderSize = 0;
            this.button_GO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GO.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_GO.Location = new System.Drawing.Point(609, 307);
            this.button_GO.Name = "button_GO";
            this.button_GO.Size = new System.Drawing.Size(145, 52);
            this.button_GO.TabIndex = 3;
            this.button_GO.Text = "去吧！皮卡丘";
            this.button_GO.UseVisualStyleBackColor = false;
            this.button_GO.Click += new System.EventHandler(this.Button_GO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "整体进度";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(61, 347);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(451, 12);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 5;
            // 
            // label_process
            // 
            this.label_process.AutoSize = true;
            this.label_process.BackColor = System.Drawing.Color.Transparent;
            this.label_process.Location = new System.Drawing.Point(514, 347);
            this.label_process.Name = "label_process";
            this.label_process.Size = new System.Drawing.Size(89, 12);
            this.label_process.TabIndex = 6;
            this.label_process.Text = "[  0/  0]   0%";
            // 
            // button_Stop
            // 
            this.button_Stop.BackColor = System.Drawing.Color.Transparent;
            this.button_Stop.BackgroundImage = global::Looking4Images.Properties.Resources.button;
            this.button_Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Stop.FlatAppearance.BorderSize = 0;
            this.button_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Stop.Location = new System.Drawing.Point(275, 97);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(75, 23);
            this.button_Stop.TabIndex = 7;
            this.button_Stop.Text = "终止";
            this.button_Stop.UseVisualStyleBackColor = false;
            this.button_Stop.Click += new System.EventHandler(this.Button_Stop_Click);
            // 
            // button_Clean
            // 
            this.button_Clean.BackColor = System.Drawing.Color.Transparent;
            this.button_Clean.BackgroundImage = global::Looking4Images.Properties.Resources.button;
            this.button_Clean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Clean.FlatAppearance.BorderSize = 0;
            this.button_Clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clean.Location = new System.Drawing.Point(190, 97);
            this.button_Clean.Name = "button_Clean";
            this.button_Clean.Size = new System.Drawing.Size(75, 23);
            this.button_Clean.TabIndex = 10;
            this.button_Clean.Text = "清空";
            this.button_Clean.UseVisualStyleBackColor = false;
            this.button_Clean.Click += new System.EventHandler(this.Button_Clean_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button_Setting);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBox_ImageCount);
            this.groupBox1.Controls.Add(this.textBox_HtmlPrefix);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox_Directory);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox_ImageSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_Deepth);
            this.groupBox1.Controls.Add(this.textBox_Host);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 128);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "爬虫设置";
            // 
            // button_Setting
            // 
            this.button_Setting.BackColor = System.Drawing.Color.Transparent;
            this.button_Setting.BackgroundImage = global::Looking4Images.Properties.Resources.button;
            this.button_Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Setting.FlatAppearance.BorderSize = 0;
            this.button_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Setting.Location = new System.Drawing.Point(309, 97);
            this.button_Setting.Name = "button_Setting";
            this.button_Setting.Size = new System.Drawing.Size(75, 23);
            this.button_Setting.TabIndex = 26;
            this.button_Setting.Text = "设置";
            this.button_Setting.UseVisualStyleBackColor = false;
            this.button_Setting.Click += new System.EventHandler(this.Button_Setting_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 12);
            this.label23.TabIndex = 8;
            this.label23.Text = "网址";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(155, 102);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(149, 12);
            this.label22.TabIndex = 13;
            this.label22.Text = "其他设置（代理，cookie）";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(126, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 7;
            this.label15.Text = "张";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(124, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 6;
            this.label14.Text = "层";
            // 
            // textBox_ImageCount
            // 
            this.textBox_ImageCount.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_ImageCount.Location = new System.Drawing.Point(60, 98);
            this.textBox_ImageCount.MaxLength = 5;
            this.textBox_ImageCount.Name = "textBox_ImageCount";
            this.textBox_ImageCount.Size = new System.Drawing.Size(60, 21);
            this.textBox_ImageCount.TabIndex = 4;
            this.textBox_ImageCount.Text = "1000";
            this.textBox_ImageCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_ImageSize_KeyPress);
            // 
            // textBox_HtmlPrefix
            // 
            this.textBox_HtmlPrefix.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_HtmlPrefix.Location = new System.Drawing.Point(211, 45);
            this.textBox_HtmlPrefix.MaxLength = 100;
            this.textBox_HtmlPrefix.Name = "textBox_HtmlPrefix";
            this.textBox_HtmlPrefix.Size = new System.Drawing.Size(173, 21);
            this.textBox_HtmlPrefix.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "图片数量";
            // 
            // comboBox_Directory
            // 
            this.comboBox_Directory.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_Directory.FormattingEnabled = true;
            this.comboBox_Directory.Items.AddRange(new object[] {
            "当天日期",
            "网站域名"});
            this.comboBox_Directory.Location = new System.Drawing.Point(211, 71);
            this.comboBox_Directory.Name = "comboBox_Directory";
            this.comboBox_Directory.Size = new System.Drawing.Size(173, 20);
            this.comboBox_Directory.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "KB";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(155, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 8;
            this.label20.Text = "保存目录";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(155, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "跳转前缀";
            // 
            // textBox_ImageSize
            // 
            this.textBox_ImageSize.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_ImageSize.Location = new System.Drawing.Point(60, 71);
            this.textBox_ImageSize.MaxLength = 4;
            this.textBox_ImageSize.Name = "textBox_ImageSize";
            this.textBox_ImageSize.Size = new System.Drawing.Size(60, 21);
            this.textBox_ImageSize.TabIndex = 0;
            this.textBox_ImageSize.Text = "1";
            this.textBox_ImageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_ImageSize_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "图片大小";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "爬虫深度";
            // 
            // comboBox_Deepth
            // 
            this.comboBox_Deepth.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_Deepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Deepth.FormatString = "N0";
            this.comboBox_Deepth.FormattingEnabled = true;
            this.comboBox_Deepth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_Deepth.Location = new System.Drawing.Point(60, 45);
            this.comboBox_Deepth.Name = "comboBox_Deepth";
            this.comboBox_Deepth.Size = new System.Drawing.Size(60, 20);
            this.comboBox_Deepth.TabIndex = 0;
            this.comboBox_Deepth.TabStop = false;
            // 
            // textBox_Host
            // 
            this.textBox_Host.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Host.Location = new System.Drawing.Point(62, 18);
            this.textBox_Host.Name = "textBox_Host";
            this.textBox_Host.Size = new System.Drawing.Size(322, 21);
            this.textBox_Host.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.button_Clean);
            this.groupBox2.Controls.Add(this.button_Stop);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox_ImagesList);
            this.groupBox2.Controls.Add(this.textBox_CurrentImages);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_Failed);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBox_Success);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_HtmlList);
            this.groupBox2.Controls.Add(this.textBox_CurrentHtml);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(413, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 128);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "进程";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(141, 75);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 12);
            this.label25.TabIndex = 25;
            this.label25.Text = "个页面";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(141, 51);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 12);
            this.label24.TabIndex = 24;
            this.label24.Text = "个页面";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(315, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 23;
            this.label18.Text = "个";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(141, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 17;
            this.label13.Text = "张";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(141, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "个页面";
            // 
            // textBox_ImagesList
            // 
            this.textBox_ImagesList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_ImagesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ImagesList.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ImagesList.ForeColor = System.Drawing.Color.Crimson;
            this.textBox_ImagesList.Location = new System.Drawing.Point(245, 50);
            this.textBox_ImagesList.MaxLength = 5;
            this.textBox_ImagesList.Name = "textBox_ImagesList";
            this.textBox_ImagesList.ReadOnly = true;
            this.textBox_ImagesList.Size = new System.Drawing.Size(64, 14);
            this.textBox_ImagesList.TabIndex = 21;
            this.textBox_ImagesList.Text = "0";
            this.textBox_ImagesList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CurrentImages
            // 
            this.textBox_CurrentImages.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_CurrentImages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CurrentImages.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_CurrentImages.ForeColor = System.Drawing.Color.Crimson;
            this.textBox_CurrentImages.Location = new System.Drawing.Point(72, 101);
            this.textBox_CurrentImages.MaxLength = 5;
            this.textBox_CurrentImages.Name = "textBox_CurrentImages";
            this.textBox_CurrentImages.ReadOnly = true;
            this.textBox_CurrentImages.Size = new System.Drawing.Size(65, 14);
            this.textBox_CurrentImages.TabIndex = 12;
            this.textBox_CurrentImages.Text = "0";
            this.textBox_CurrentImages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(190, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 22;
            this.label19.Text = "图片队列";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "已爬图片";
            // 
            // textBox_Failed
            // 
            this.textBox_Failed.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Failed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Failed.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Failed.ForeColor = System.Drawing.Color.Crimson;
            this.textBox_Failed.Location = new System.Drawing.Point(72, 74);
            this.textBox_Failed.MaxLength = 5;
            this.textBox_Failed.Name = "textBox_Failed";
            this.textBox_Failed.ReadOnly = true;
            this.textBox_Failed.Size = new System.Drawing.Size(65, 14);
            this.textBox_Failed.TabIndex = 10;
            this.textBox_Failed.Text = "0";
            this.textBox_Failed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "失败爬取";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(315, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 20;
            this.label16.Text = "个";
            // 
            // textBox_Success
            // 
            this.textBox_Success.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Success.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Success.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Success.ForeColor = System.Drawing.Color.Crimson;
            this.textBox_Success.Location = new System.Drawing.Point(72, 50);
            this.textBox_Success.MaxLength = 5;
            this.textBox_Success.Name = "textBox_Success";
            this.textBox_Success.ReadOnly = true;
            this.textBox_Success.Size = new System.Drawing.Size(65, 14);
            this.textBox_Success.TabIndex = 8;
            this.textBox_Success.Text = "0";
            this.textBox_Success.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "成功爬取";
            // 
            // textBox_HtmlList
            // 
            this.textBox_HtmlList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_HtmlList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_HtmlList.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_HtmlList.ForeColor = System.Drawing.Color.Crimson;
            this.textBox_HtmlList.Location = new System.Drawing.Point(245, 23);
            this.textBox_HtmlList.MaxLength = 5;
            this.textBox_HtmlList.Name = "textBox_HtmlList";
            this.textBox_HtmlList.ReadOnly = true;
            this.textBox_HtmlList.Size = new System.Drawing.Size(64, 14);
            this.textBox_HtmlList.TabIndex = 18;
            this.textBox_HtmlList.Text = "0";
            this.textBox_HtmlList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CurrentHtml
            // 
            this.textBox_CurrentHtml.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_CurrentHtml.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CurrentHtml.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_CurrentHtml.ForeColor = System.Drawing.Color.Crimson;
            this.textBox_CurrentHtml.Location = new System.Drawing.Point(72, 23);
            this.textBox_CurrentHtml.MaxLength = 5;
            this.textBox_CurrentHtml.Name = "textBox_CurrentHtml";
            this.textBox_CurrentHtml.ReadOnly = true;
            this.textBox_CurrentHtml.Size = new System.Drawing.Size(65, 14);
            this.textBox_CurrentHtml.TabIndex = 6;
            this.textBox_CurrentHtml.Text = "0";
            this.textBox_CurrentHtml.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(190, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 19;
            this.label17.Text = "页面队列";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "正在爬取第";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label_Speed);
            this.groupBox3.Controls.Add(this.label_Html);
            this.groupBox3.Controls.Add(this.button_GO);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label_Running);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.label_process);
            this.groupBox3.Controls.Add(this.richTextBox);
            this.groupBox3.Location = new System.Drawing.Point(13, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 370);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输出区";
            // 
            // label_Speed
            // 
            this.label_Speed.AutoSize = true;
            this.label_Speed.Location = new System.Drawing.Point(514, 325);
            this.label_Speed.Name = "label_Speed";
            this.label_Speed.Size = new System.Drawing.Size(77, 12);
            this.label_Speed.TabIndex = 11;
            this.label_Speed.Text = "[    0 KB/s]";
            // 
            // label_Html
            // 
            this.label_Html.AutoSize = true;
            this.label_Html.Location = new System.Drawing.Point(61, 303);
            this.label_Html.Name = "label_Html";
            this.label_Html.Size = new System.Drawing.Size(29, 12);
            this.label_Html.TabIndex = 10;
            this.label_Html.Text = "就绪";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(3, 303);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 12);
            this.label21.TabIndex = 9;
            this.label21.Text = "正在访问";
            // 
            // label_Running
            // 
            this.label_Running.AutoSize = true;
            this.label_Running.BackColor = System.Drawing.Color.Transparent;
            this.label_Running.Location = new System.Drawing.Point(61, 325);
            this.label_Running.Name = "label_Running";
            this.label_Running.Size = new System.Drawing.Size(29, 12);
            this.label_Running.TabIndex = 8;
            this.label_Running.Text = "就绪";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(3, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 7;
            this.label12.Text = "正在下载";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Looking4Images.Properties.Resources.bg2;
            this.ClientSize = new System.Drawing.Size(775, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片下载器v1.3 By 北海小王子";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button button_GO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_process;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Clean;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Host;
        private System.Windows.Forms.ComboBox comboBox_Deepth;
        private System.Windows.Forms.TextBox textBox_ImageSize;
        private System.Windows.Forms.TextBox textBox_ImageCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Failed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Success;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_CurrentHtml;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_CurrentImages;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_ImagesList;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_HtmlList;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox_Directory;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_HtmlPrefix;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_Running;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label_Html;
        private System.Windows.Forms.Label label_Speed;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button_Setting;
        private System.Windows.Forms.Label label22;
    }
}

