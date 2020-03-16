using System;
using System.Windows.Forms;

namespace Looking4Images
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            string ip = textBox_IP.Text;
            string port = textBox_Port.Text;
            string username = textBox_Username.Text;
            string password = textBox_Password.Text;
            string format = textBox_Format.Text;
            string cookie = richTextBox1.Text;
            int download_type = 0;
            if (radioButton2.Checked)
                download_type = 1;

            SettingItem item = new SettingItem()
            {
                html = checkBox_Html.Checked,
                images = checkBox_Images.Checked,
                download_type = download_type,
                ip = ip,
                port = port,
                username = username,
                password = password,
                format = format,
                cookie = cookie
            };

            MainForm mainForm = (MainForm)this.Owner;
            mainForm.Setting(item);
        }
    }
}
