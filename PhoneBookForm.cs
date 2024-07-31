using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP_Proje
{
    public partial class PhoneBookForm : Form
    {
        // Girilen bilgilerin kaydedileceği dosya yolu oluşturulur
        private string filePath;
        private DataTable phonebookTable;
        private string username;

        public PhoneBookForm(string username)
        {
            this.username = username;
            filePath = $"{username}_phonebook.csv";
            InitializeComponent();
            InitializeDataTable();
            LoadPhonebook();
        }
        
        private void InitializeDataTable()
        {
            // Bilgilerin gösterileceği tablonun sütunlarının isimlendirilmesi yapılır
            phonebookTable = new DataTable();
            phonebookTable.Columns.Add("Ad", typeof(string));
            phonebookTable.Columns.Add("Soyad", typeof(string));
            phonebookTable.Columns.Add("Telefon", typeof(string));
            phonebookTable.Columns.Add("Adres", typeof(string));
            phonebookTable.Columns.Add("Açıklama", typeof(string));
            phonebookTable.Columns.Add("E-mail", typeof(string));
            dataGridView1.DataSource = phonebookTable;
        }

        private void LoadPhonebook()
        {
            // Daha önceden girilmiş bilgiler tabloya doldurulur
            phonebookTable.Clear();
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var fields = line.Split(',');
                    phonebookTable.Rows.Add(fields[0], fields[1], fields[2], fields[3], fields[4], fields[5]);
                }
            }
        }

        // Yeni bir kişinin bilgilerinin eklendiği buton
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                phonebookTable.Rows.Add(txtName.Text, txtSurname.Text, txtPhone.Text, txtAddress.Text, txtDescription.Text, txtEmail.Text);
                SavePhonebook();
                ClearInputs();
            }
        }

        // Girilmiş herhangi bir bilginin güncellemesinin yapıldığı buton
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && ValidateInputs())
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                row.Cells[0].Value = txtName.Text;
                row.Cells[1].Value = txtSurname.Text;
                row.Cells[2].Value = txtPhone.Text;
                row.Cells[3].Value = txtAddress.Text;
                row.Cells[4].Value = txtDescription.Text;
                row.Cells[5].Value = txtEmail.Text;
                SavePhonebook();
                ClearInputs();
            }
        }

        // Seçilen kişinin bilgilerinin silme işleminin yapıldığı buton
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                dataGridView1.Rows.Remove(row);
                SavePhonebook();
                ClearInputs();
            }
        }

        // Girilen bilgiler kaydedilir
        private void SavePhonebook()
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (DataRow row in phonebookTable.Rows)
                {
                    sw.WriteLine(string.Join(",", row.ItemArray));
                }
            }
        }

        // Girilen bilgilerde hata olup olmadığı kontrol edilir ve duruma göre hata mesajı verilir
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill all the fields.");
                return false;
            }

            if (!Regex.IsMatch(txtPhone.Text, @"^\(\d{3}\) \d{3} \d{2} \d{2}$"))
            {
                MessageBox.Show("Please enter the phone number as (555) 555 55 55 format.");
                return false;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid e-mail.");
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtDescription.Clear();
            txtEmail.Clear();
        }

        // Tabloda seçilen bir index olması durumunda hangi bilginin handi değişkene atanacağına karar verilir
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                txtName.Text = row.Cells[0].Value.ToString();
                txtSurname.Text = row.Cells[1].Value.ToString();
                txtPhone.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
                txtDescription.Text = row.Cells[4].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(username);
            form2.Show();
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
    }
}
