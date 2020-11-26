using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace blockedNOT
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string usernameText = username.Text;
            string passwordText = password.Text;
            string repass = RPassword.Text;

            if (usernameText != "")
            {
                if (passwordText == repass)
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"accountcreation.bat"))
                    {
                        file.WriteLine("net users " + usernameText + " " + passwordText + " /add");
                        file.WriteLine("net localgroup administrators " + usernameText + " /add");
                    }
                    username.Text = "";
                    password.Text = "";
                    ExecuteAsAdmin("accountcreation.bat");
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label11.Hide();
                    username.Hide();
                    password.Hide();
                    RPassword.Hide();
                    button1.Hide();
                    button2.Hide();
                    label7.Show();
                    label8.Text = label8.Text + Environment.MachineName + "/" + usernameText + "\nYour password is the one you set";
                    label8.Show();
                    button6.Show();
                    Thread.Sleep(500);
                    File.Delete(@"accountcreation.bat");
                }
            }
        }

        public void ExecuteAsAdmin(string fileName)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = fileName;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            username.Hide();
            password.Hide();
            RPassword.Hide();
            button1.Hide();
            button2.Hide();
            label6.Show();
            button3.Show();
            button4.Show();
            label9.Show();
            label10.Show();
            button5.Show();
            label11.Hide();
            username.Text = "";
            password.Text = "";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            label6.Hide();
            button3.Hide();
            button4.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            button5.Hide();
            label10.Hide();
            button6.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            username.Show();
            password.Show();
            RPassword.Show();
            button1.Show();
            button2.Show();
            label6.Hide();
            button3.Hide();
            button4.Hide();
            label9.Hide();
            label10.Hide();
            button5.Hide();
            label11.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.techspot.com/downloads/downloadnow/5711/?evp=9ac22ecd801a0ccf9ee380fd5ca119a7&file=1");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Process.Start("http://download1592.mediafire.com/wzgqx48chsng/6npiopibghmz918/uninstaller.exe");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label11.Show();
            username.Show();
            password.Show();
            RPassword.Show();
            button1.Show();
            button2.Show();
            label7.Hide();
            label8.Hide();
            button6.Hide();
        }
    }
}
