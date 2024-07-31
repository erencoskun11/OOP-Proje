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


namespace OOP_Proje
{
    public partial class Form2 : Form
    {
        public string username;

        Dictionary<string, Form> buttonToForm;

        
        public Form2(string username_)
        {
            
            this.username = username_;
            InitializeComponent();
            buttonToForm = new Dictionary<string, Form>()
            {
                {"btnUserManagement", new Form3(username)},
                {"btnNotes", new NotesForm(username)},
                {"btnReminder", new ReminderForm(username)},
                {"btnPersonalInformation", new ProfileForm(username)},
                {"btnPhoneBook", new PhoneBookForm(username)},
                {"btnSalaryCalculator", new SalaryCalculatorForm(username)}
            };
            if (checkIsAdmin())
            {
                btnUserManagement.Visible = true;
            }
            else
            {
                btnUserManagement.Visible = false;
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
        public bool checkIsAdmin()
        {
            var lines = File.ReadAllLines("users.csv");
            foreach (var line in lines)
            {
                var lineArray = line.Split(',');   
                if (lineArray[0] == username)
                {
                    if (lineArray[2] == "admin")
                    {   
                        return true;
                    }
                }
            }
            return false;
        }

        public void buttonEvent(Object sender, EventArgs eventHandler)
        {
            Button button = (Button)sender;
            string buttonName = button.Name;
            Form form = buttonToForm[buttonName];
            form.Show();
            this.Visible = false;
        }
    }
}
