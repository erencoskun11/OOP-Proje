using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP_Proje
{
    public partial class ProfileForm : Form
    {
        private UserProfile currentUserProfile;
        private Caretaker caretaker;
        public string username;

        public ProfileForm(string username_)
        {
            this.username = username_;
            InitializeComponent();
            currentUserProfile = LoadProfileFromCsv(username + "_profile.csv");
            caretaker = new Caretaker();
            LoadProfile();
            this.KeyPreview = true;  // Enable form to capture key presses before controls
            SaveCurrentState();
            
        }

        private void LoadProfile()
        {
            // Load user profile information from a data source (omitted for brevity)
            UpdateUI();
        }

        private void UpdateUI()
        {
            // Update UI controls with currentUserProfile data
            txtName.Text = currentUserProfile.Name;
            txtSurname.Text = currentUserProfile.Surname;
            txtPhoneNumber.Text = currentUserProfile.PhoneNumber;
            txtAddress.Text = currentUserProfile.Address;
            txtEmail.Text = currentUserProfile.Email;
            txtPassword.Text = currentUserProfile.Password;
            if (!string.IsNullOrEmpty(currentUserProfile.PhotoBase64))
            {
                picPhoto.Image = Base64ToImage(currentUserProfile.PhotoBase64);
            }
        }

        private UserProfile currentProfile()
        {
            return new UserProfile() { 
                Name = txtName.Text,
                Surname = txtSurname.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Address = txtAddress.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                PhotoBase64 = ImageToBase64(picPhoto.Image)
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtPhoneNumber.Text, @"^\(\d{3}\) \d{3} \d{2} \d{2}$"))
            {
                MessageBox.Show("Enter the phone number as (555) 555 55 55 format.");
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Enter a valid e-mail address.");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password can not be empty!");
                return;
            }
            SaveCurrentState();
            SaveProfileToCsv(currentUserProfile, username+"_profile.csv");
            MessageBox.Show("Information Saved.");
        }

        private void SaveCurrentState()
        {
            caretaker.SaveState(currentUserProfile.Clone());

            // Update currentUserProfile with data from UI controls
            currentUserProfile.Name = txtName.Text;
            currentUserProfile.Surname = txtSurname.Text;
            currentUserProfile.PhoneNumber = txtPhoneNumber.Text;
            currentUserProfile.Address = txtAddress.Text;
            currentUserProfile.Email = txtEmail.Text;
            currentUserProfile.Password = txtPassword.Text;
            currentUserProfile.PhotoBase64 = ImageToBase64(picPhoto.Image);

            // Save profile to data source (omitted for brevity)
        }

        private void ProfileForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                UndoChange(currentProfile());
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.Y)
            {
                RedoChange(currentProfile());
                e.Handled = true;
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

        private void UndoChange(UserProfile userProfile)
        {
            var state = caretaker.Undo(userProfile);
            if (state != null)
            {
                currentUserProfile = state;
                UpdateUI();
            }
        }

        private void RedoChange(UserProfile userProfile)
        {

            var state = caretaker.Redo(userProfile);
            if (state != null)
            {
                currentUserProfile = state;
                UpdateUI();
            }
        }

        private string ImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        private Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                return Image.FromStream(ms, true);
            }
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picPhoto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void SaveProfileToCsv(UserProfile profile, string filePath)
        {
            var lines = new List<string>
            {
                "Name,Surname,PhoneNumber,Address,Email,Password,PhotoBase64",
                $"{profile.Name},{profile.Surname},{profile.PhoneNumber},{profile.Address},{profile.Email},{profile.Password},{profile.PhotoBase64}"
            };
            File.WriteAllLines(filePath, lines);


            var usersFileLines = File.ReadAllLines("users.csv");
            for (int i = 0; i < usersFileLines.Length; i++)
            {
                string[] usersLine = usersFileLines[i].Split(',');
                if (usersLine[0] == username)
                {
                    string newLine = username + "," + profile.Password + "," + usersLine[2];
                    usersFileLines[i] = newLine;
                    File.WriteAllLines("users.csv", usersFileLines);
                    break;
                }
            }
        }

        private UserProfile LoadProfileFromCsv(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            if (lines.Length > 1)
            {
                var values = lines[1].Split(',');
                return new UserProfile
                {
                    Name = values[0],
                    Surname = values[1],
                    PhoneNumber = values[2],
                    Address = values[3],
                    Email = values[4],
                    Password = values[5],
                    PhotoBase64 = values[6]
                };
            }
            return new UserProfile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(username);
            form2.Show();
            this.Visible = false;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }
    }
    // UserProfile Class
    public class UserProfile
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhotoBase64 { get; set; } // Store photo as base64 string
    }

    // Memento Pattern Classes
    public class UserProfileMemento
    {
        public UserProfile State { get; private set; }

        public UserProfileMemento(UserProfile state)
        {
            State = state;
        }
    }

    public class Caretaker
    {
        private Stack<UserProfileMemento> undoStack = new Stack<UserProfileMemento>();
        private Stack<UserProfileMemento> redoStack = new Stack<UserProfileMemento>();

        public void SaveState(UserProfile state)
        {
            undoStack.Push(new UserProfileMemento(state.Clone()));
        }

        public UserProfile Undo(UserProfile current)
        {
            if (undoStack.Count > 0)
            {
                var memento = undoStack.Pop();
                redoStack.Push(new UserProfileMemento(current.Clone()));
                return memento.State;
            }
            return null;
        }

        public UserProfile Redo(UserProfile current)
        {
            if (redoStack.Count > 0)
            {
                var memento = redoStack.Pop();
                undoStack.Push(new UserProfileMemento(current.Clone()));
                return memento.State;
            }
            return null;
        }
    }

    public static class ExtensionMethods
    {
        public static UserProfile Clone(this UserProfile userProfile)
        {
            return new UserProfile
            {
                Name = userProfile.Name,
                Surname = userProfile.Surname,
                PhoneNumber = userProfile.PhoneNumber,
                Address = userProfile.Address,
                Email = userProfile.Email,
                Password = userProfile.Password,
                PhotoBase64 = userProfile.PhotoBase64
            };
        }
    }

    
}
