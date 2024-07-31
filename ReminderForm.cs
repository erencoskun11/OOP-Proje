using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Proje
{
    public partial class ReminderForm : Form
    {
        public string username;
        public ReminderForm(string username_)
        {
            this.username = username_;

            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TextBox1 ve TextBox2'deki metinleri al
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;

            // ComboBox'dan seçilen öğeyi al
            string selectedType = comboBox1.SelectedItem?.ToString();

            // DataGridView'e yeni bir satır ekleyin
            dataGridView1.Rows.Add(selectedType, text1, text2, dateTimePicker1.Value.Date.ToShortDateString(), dateTimePicker1.Value.TimeOfDay.ToString(@"hh\:mm"));

            // TextBox'ları temizle
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1; // ComboBox'ı temizle
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // DataGridView'de seçili satırı kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // İlk seçili satırı al
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // DataGridView'den seçili satırı kaldır
                dataGridView1.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // dataGridView1 i listBox1 e aktar
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string task_or_meeting = row.Cells["Column1"].Value?.ToString();
                string summary = row.Cells["Column2"].Value?.ToString();
                string description = row.Cells["Column3"].Value?.ToString();
                string date = row.Cells["Column4"].Value?.ToString();
                string hour = row.Cells["Column5"].Value?.ToString();

                listBox1.Items.Add($"{task_or_meeting} - {summary} - {description} - {date} - {hour}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox1 ve TextBox2'deki metinleri al
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;

            // ComboBox'dan seçilen öğeyi al
            string selectedType = comboBox1.SelectedItem?.ToString();

            // DataGridView'de seçili satırı kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // İlk seçili satırı al
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Seçili satırın hücrelerini güncelle
                selectedRow.Cells["Column1"].Value = selectedType;
                selectedRow.Cells["Column2"].Value = text1;
                selectedRow.Cells["Column3"].Value = text2;
                selectedRow.Cells["Column4"].Value = dateTimePicker1.Value;
                selectedRow.Cells["Column5"].Value = dateTimePicker1.Value;

                // TextBox'ları temizle
                textBox1.Clear();
                textBox2.Clear();
                comboBox1.SelectedIndex = -1; // ComboBox'ı temizle

                // Kullanıcıya bilgi mesajı göster
                MessageBox.Show("Selected row updated successfully.");
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //window' u 2 saniye boyunca salla 
            for (int i = 0; i < 20; i++)
            {
                this.Location = new Point(this.Location.X + 10, this.Location.Y);
                System.Threading.Thread.Sleep(50);
                this.Location = new Point(this.Location.X - 10, this.Location.Y);
                System.Threading.Thread.Sleep(50);
            }

            // seçili hücrenin hangi satırda olduğu bilgisinşi al
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                this.Text = (string)row.Cells["Column2"].Value;
                return;
            }


            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // İlk seçili satırı al
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                this.Text = (string)selectedRow.Cells["Column2"].Value;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // DataGridView için kolonları ayarla (tasarım zamanında da yapabilirsiniz)
            dataGridView1.Columns.Add("Column1", "Task_or_Meeting");
            dataGridView1.Columns.Add("Column2", "Summary");
            dataGridView1.Columns.Add("Column3", "Description");
            dataGridView1.Columns.Add("Column4", "Date");
            dataGridView1.Columns.Add("Column5", "Hour");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void button5_Click(object sender, EventArgs e)
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
