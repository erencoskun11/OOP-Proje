using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace OOP_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (isEmpty(txtLoginUsername.Text) || isEmpty(txtLoginPassword.Text))
            {
                MessageBox.Show("Username or Password cannot be empty!");
                return;
            }

            var usersLines = File.ReadAllLines("users.csv");

            if (usersLines.Length == 1)
            {
                var adminLines = new List<string>
                {
                    $"{txtLoginUsername.Text},{txtLoginPassword.Text},{"admin"}"
                };

                File.AppendAllLines("users.csv", adminLines);
                createAllFilesForUser(txtLoginUsername.Text);
                return;
            }

            foreach (var line in usersLines)
            {
                var values = line.Split(',');
                if (values[0] == txtLoginUsername.Text)
                {
                    if (values[1] == txtLoginPassword.Text)
                    {
                        Form2 form2 = new Form2(txtLoginUsername.Text);
                        form2.Show();
                        this.Visible = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password!");
                        return;
                    }
                }
            }

            var lines = new List<string>
             {
                 $"{txtLoginUsername.Text},{txtLoginPassword.Text},{"user"}"
             };

            File.AppendAllLines("users.csv", lines);
            createAllFilesForUser(txtLoginUsername.Text);

            MessageBox.Show("User Saved.");
            Form2 form22 = new Form2(txtLoginUsername.Text);
            form22.Show();
            this.Visible = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Formun kapanmasını engelle
            }
        }

        private bool isEmpty(string input)
        {
            bool isEmpty = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    isEmpty = false;
                    break;
                }
            }
            return isEmpty;
        }

        private void createAllFilesForUser(string username)
        {
            try 
            {
                using (StreamWriter sw = new StreamWriter(username + "_profile.csv"))
                {
                    sw.WriteLine("Name,Surname,PhoneNumber,Address,Email,Password,PhotoBase64");
                }
                using (StreamWriter sw = new StreamWriter(username + "_notes.csv"))
                {
                }
                using (StreamWriter sw = new StreamWriter(username + "_phonebook.csv"))
                {
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtLoginUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoginPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
