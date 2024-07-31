using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Proje
{
    public partial class Form3 : Form
    {
        public string username;
        public Form3(string username_)
        {

            this.username = username_;

            InitializeComponent();

            var lines = File.ReadAllLines("users.csv");
            for (int i = 1; i < lines.Length; i++)
            {
                var lineArr = lines[i].Split(',');

                GroupBox groupBox = new GroupBox();
                groupBox.Name = "grp" + i.ToString();
                groupBox.Text = lineArr[0];
                groupBox.Size = new Size(500, 150);
                groupBox.Location = new Point(this.Width / 5, i * 150);
                groupBox.SendToBack();


                RadioButton adminRB = new RadioButton();
                adminRB.Text = "Admin";
                adminRB.Name = "radioButtonAdmin" + i.ToString();
                adminRB.Location = new Point(10, 30);
                adminRB.Parent = groupBox;
                adminRB.CheckedChanged += adminRBEvent;
                adminRB.BringToFront();
                if (lineArr[2] == "admin")
                {
                    adminRB.Checked = true;
                }
                groupBox.Controls.Add((RadioButton) adminRB);

                RadioButton userRB = new RadioButton();
                userRB.Text = "User";
                userRB.Name = "radioButtonUser" + i.ToString();
                userRB.Location = new Point(150, 30);
                userRB.Parent = groupBox;
                userRB.BringToFront();
                userRB.CheckedChanged += userRBEvent;
                if (lineArr[2] == "user")
                {
                    userRB.Checked = true;
                }
                groupBox.Controls.Add((RadioButton)userRB);

                RadioButton partRB = new RadioButton();
                partRB.Text = "Part-Time User";
                partRB.Name = "radioButtonPart" + i.ToString();
                partRB.Location = new Point(300, 30);
                partRB.Parent = groupBox;
                partRB.CheckedChanged += partRBEvent;
                partRB.BringToFront();
                if (lineArr[2] == "part-time user")
                {
                    partRB.Checked = true;
                }
                groupBox.Controls.Add((RadioButton)partRB);

                Label label = new Label();
                label.Name = "label" + i.ToString();
                label.Text = "Set Password: ";
                label.Location = new Point(10, 60);
                label.Parent = groupBox;
                label.BringToFront();
                groupBox.Controls.Add(label);

                TextBox textBox = new TextBox();
                textBox.Name = "textBox" + i.ToString();
                textBox.Text = lineArr[0];
                textBox.Location = new Point(10, 100);
                textBox.Size = new Size(100, 20);
                textBox.Parent = groupBox;
                textBox.BringToFront();
                groupBox.Controls.Add(textBox);

                Button button = new Button();
                button.Name = "button" + i.ToString();
                button.Text = "Change Password";
                button.Location = new Point(150, 100);
                button.Parent = groupBox;
                button.Click += buttonEvent;
                button.BringToFront();
                groupBox.Controls.Add(button);

                this.Controls.Add(groupBox);
            }
        }

        public void buttonEvent(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int row = Int32.Parse(button.Name[button.Name.Length - 1].ToString());

            var lines = File.ReadAllLines("users.csv");

            var line = lines[row].Split(',');
            string username = line[0];

            var userProfileLines = File.ReadAllLines(username + "_profile.csv");
            if (userProfileLines.Length< 2)
            {
                MessageBox.Show("User email is empty!");
                return;
            }

            var userProfileLine = userProfileLines[1].Split(',');
            string userEmail = userProfileLine[4];
            

            var groupBox = (GroupBox)button.Parent;

            var textBox = (TextBox)groupBox.Controls.Find("textBox" + row.ToString(), true)[0];

            line[1] = textBox.Text;


            var newLine = line[0] + "," + line[1] + "," + line[2];

            lines[row] = newLine;

            File.WriteAllLines("users.csv", lines);




            //send an email to the user to inform about the password change
            try
            {
                progressBar1.Visible = true;
                progressBar1.Value = 10;
                // Gönderenin ve alıcının e-posta adresleri
                string fromEmail = "testoopproject12@gmail.com";
                string toEmail = userEmail;

                // SMTP sunucu ayarları
                string smtpServer = "smtp.gmail.com";
                int smtpPort = 587;
                string smtpUser = "testoopproject12@gmail.com";
                string smtpPass = "xzkb ibcz ejjg olfo";

                // E-posta içeriği
                string subject = "New Password";
                string body = "This is your new password : \n" + textBox.Text;

                // MailMessage nesnesi oluşturma
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true; // HTML içeriği için true olarak ayarlayın
                progressBar1.Value = 50;

                progressBar1.Value = 70;
                // SmtpClient nesnesi oluşturma
                var smtpClient = new SmtpClient
                {
                    Host = smtpServer,
                    Port = smtpPort,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(smtpUser, smtpPass)
                };
                progressBar1.Value = 90;
                // E-posta gönderme
                
                smtpClient.Send(mail);
                progressBar1.Value = 100;
                //sleep 1 second
                label2.Visible = true;
                System.Threading.Thread.Sleep(1000);
                progressBar1.Visible = false;
                label2.Visible = false; 
            }
            catch (Exception ex)
            {
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                failLabel.Visible = true;
                //sleep 2 second
                System.Threading.Thread.Sleep(2000);
                failLabel.Visible = false;
                Console.WriteLine("E-posta gönderilirken bir hata oluştu: " + ex.Message);
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Formun kapanmasını engelle
            }
        }

        public void adminRBEvent(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                int row = Int32.Parse(rb.Name[rb.Name.Length - 1].ToString());

                var lines = File.ReadAllLines("users.csv");

                var line = lines[row].Split(',');
                line[2] = "admin";
                var newLine = line[0] + "," + line[1] + "," + line[2];

                lines[row] = newLine;

                File.WriteAllLines("users.csv", lines);
            }
        }

        public void userRBEvent(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                int row = Int32.Parse(rb.Name[rb.Name.Length - 1].ToString());

                var lines = File.ReadAllLines("users.csv");

                var line = lines[row].Split(',');
                line[2] = "user";
                var newLine = line[0] + "," + line[1] + "," + line[2];

                lines[row] = newLine;

                File.WriteAllLines("users.csv", lines);
            }
        }

        public void partRBEvent(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                int row = Int32.Parse(rb.Name[rb.Name.Length - 1].ToString());

                var lines = File.ReadAllLines("users.csv");

                var line = lines[row].Split(',');
                line[2] = "part-time user";
                var newLine = line[0] + "," + line[1] + "," + line[2];

                lines[row] = newLine;

                File.WriteAllLines("users.csv", lines);
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(username);
            form2.Show();
            this.Visible = false;
        }
    }
}
