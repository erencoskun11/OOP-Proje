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
    public partial class NotesForm : Form
    {
        private string filePath;
        private string username;
        public NotesForm(string username)
        {
            this.username = username;
            filePath = $"{username}_notes.txt";
            InitializeComponent();
            LoadNotes();
        }

        private void LoadNotes()
        {
            if (File.Exists(filePath))
            {
                var notes = File.ReadAllLines(filePath).ToList();
                lstNotes.Items.Clear();
                foreach (var note in notes)
                {
                    lstNotes.Items.Add(note);
                }
            }
        }

        private void SaveNotes()
        {
            var notes = lstNotes.Items.Cast<string>().ToList();
            File.WriteAllLines(filePath, notes);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNote.Text))
            {
                lstNotes.Items.Add(txtNote.Text);
                txtNote.Clear();
                SaveNotes();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstNotes.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(txtNote.Text))
            {
                lstNotes.Items[lstNotes.SelectedIndex] = txtNote.Text;
                txtNote.Clear();
                SaveNotes();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstNotes.SelectedIndex != -1)
            {
                lstNotes.Items.RemoveAt(lstNotes.SelectedIndex);
                txtNote.Clear();
                SaveNotes();
            }
        }

        private void lstNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNotes.SelectedIndex != -1)
            {
                txtNote.Text = lstNotes.SelectedItem.ToString();
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
 