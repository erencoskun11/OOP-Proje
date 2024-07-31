using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data.SqlClient;


namespace OOP_Proje
{
    public partial class SalaryCalculatorForm : Form
    {
        private string username;
        public SalaryCalculatorForm(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void btnCalculateSalary_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(txtExperienceYears.Text) ||
                string.IsNullOrWhiteSpace(txtCity.Text) ||
                string.IsNullOrWhiteSpace(txtHighestDegree.Text) ||
                string.IsNullOrWhiteSpace(txtKnownLanguages.Text) ||
                string.IsNullOrWhiteSpace(txtNumberOfChildren.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(txtUserType.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            
            int experienceYears = int.Parse(txtExperienceYears.Text);
            string city = txtCity.Text;
            string highestDegree = txtHighestDegree.Text;
            string knownLanguages = txtKnownLanguages.Text;
            string managerialPosition = txtManagerialPosition.SelectedItem != null ? txtManagerialPosition.Text : "No Position";
            bool isMarried = chkIsMarried.Checked;
            bool spouseWorks = chkSpouseWorks.Checked;
            int numberOfChildren = int.Parse(txtNumberOfChildren.Text);
            int child1Age = int.Parse(textBox1.Text);
            int child2Age = int.Parse(textBox2.Text);
            string userType=txtUserType.Text;
            
            double minimumGrossSalary = SalaryCalculator.CalculateMinimumGrossSalary(experienceYears, city, highestDegree, knownLanguages, managerialPosition, isMarried, spouseWorks, numberOfChildren, child1Age, child2Age);
            if(userType=="part-time user")
            {
                minimumGrossSalary = minimumGrossSalary / 2;
            }
          
            MessageBox.Show($"Minimum Gross Salary: {minimumGrossSalary:C}");
        }

        private void txtNumberOfChildren_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNumberOfChildren.Text == "0")
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                }
                else if (txtNumberOfChildren.Text == "1")
                {
                    textBox2.Enabled = false;
                    textBox1.Enabled = true;
                }
                else if (Int32.Parse(txtNumberOfChildren.Text) >= 2)
                {
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter a valid number.");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label7.Visible = true;
                txtManagerialPosition.Visible = true;
            }
            else
            {
                label7.Visible = false;
                txtManagerialPosition.Visible = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(username);
            form2.Show();
            this.Hide();
        }
    }

    public static class SalaryCalculator
    {
        public static double CalculateMinimumGrossSalary(int experienceYears, string city, string highestDegree, string knownLanguages, string managerialPosition, bool isMarried, bool spouseWorks, int numberOfChildren, int child1Age, int child2Age)
        {
            double baseSalary = 13414.50 * 2; 

            double experienceCoefficient = GetExperienceCoefficient(experienceYears);
            double cityCoefficient = GetCityCoefficient(city);
            double educationCoefficient = GetEducationCoefficient(highestDegree);
            double languageCoefficient = GetLanguageCoefficient(knownLanguages);
            double managerialCoefficient = GetManagerialCoefficient(managerialPosition);
            double familyCoefficient = GetFamilyCoefficient(isMarried, spouseWorks, numberOfChildren, child1Age, child2Age);

            double totalCoefficient = 1 + experienceCoefficient + cityCoefficient + educationCoefficient + languageCoefficient + managerialCoefficient + familyCoefficient;

            return baseSalary * totalCoefficient;
        }

        private static double GetExperienceCoefficient(int years)
        {
            if (years >= 2 && years <= 4) return 0.60;
            if (years >= 5 && years <= 9) return 1.00;
            if (years >= 10 && years <= 14) return 1.20;
            if (years >= 15 && years <= 20) return 1.35;
            if (years > 20) return 1.50;
            return 0.0;
        }

        private static double GetCityCoefficient(string city)
        {
            switch (city)
            {
                case "Istanbul": return 0.30;
                case "Ankara": return 0.20;
                case "Izmir": return 0.20;
                case "Kocaeli": case "Sakarya": case "Düzce": case "Bolu": case "Yalova": return 0.10;
                case "Edirne": case "Kırklareli": case "Tekirdağ": return 0.10;
                case "Trabzon": case "Ordu": case "Giresun": case "Rize": case "Artvin": case "Gümüşhane": return 0.05;
                case "Bursa": case "Eskişehir": case "Bilecik": return 0.05;
                case "Aydın": case "Denizli": case "Muğla": return 0.05;
                case "Adana": case "Mersin": return 0.05;
                case "Balıkesir": case "Çanakkale": return 0.05;
                case "Antalya": case "Isparta": case "Burdur": return 0.05;
                default: return 0.0;

            }
        }

        private static double GetEducationCoefficient(string degree)
        {
            switch (degree)
            {
                case "Meslek alanı ile ilgili yüksek lisans": return 0.10;
                case "Meslek alanı ile ilgili doktora": return 0.30;
                case "Meslek alanı ile ilgili doçentlik": return 0.35;
                case "Meslek alanı ile ilgili olmayan yüksek lisans": return 0.05;
                case "Meslek alanı ile ilgili olmayan doktora/doçentlik": return 0.15;
                default: return 0.0;
            }
        }

        private static double GetLanguageCoefficient(string languages)
        {
            double coefficient = 0.0;
            if (languages.Contains("Belgelendirilmiş İngilizce bilgisi")) coefficient += 0.20;
            if (languages.Contains("İngilizce eğitim veren okul mezuniyeti ")) coefficient += 0.20;
            if (languages.Contains("Belgelendirilmiş diğer yabancı dil bilgisi (her dil için) ")) coefficient += 0.05;
            if(languages.Contains("Hiçbiri")) coefficient += 0.0;
            return coefficient;
        }

        private static double GetManagerialCoefficient(string position)
        {
            switch (position)
            {
                case "Takım Lideri/Grup Yöneticisi/Teknik Yönetici/Yazılım Mimarı": return 0.50;
                case "Proje Yöneticisi": return 0.75;
                case "Direktör/Projeler Yöneticisi": return 0.85;
                case "CTO/Genel Müdür": return 1.00;
                case "Bilgi İşlem Sorumlusu/Müdürü (5'ten az personel)": return 0.40;
                case "Bilgi İşlem Sorumlusu/Müdürü (5'ten çok personel)": return 0.60;
                case "No Position": return 0.0;
                default: return 0.0;
            }
        }

        private static double GetFamilyCoefficient(bool isMarried, bool spouseWorks, int numberOfChildren, int child1Age, int child2Age)
        {
            double coefficient = 0.0;
            if (isMarried && !spouseWorks) coefficient += 0.20;
            if (child1Age >= 0 && child1Age <= 6) coefficient += 0.20;
            if (child1Age >= 7 && child1Age <= 18) coefficient += 0.30;
            if (child1Age > 18) coefficient += 0.40;
            if (child2Age >= 0 && child2Age <= 6) coefficient += 0.20;
            if (child2Age >= 7 && child2Age <= 18) coefficient += 0.30;
            if (child2Age > 18) coefficient += 0.40;
            return coefficient;

        }
    }
}

