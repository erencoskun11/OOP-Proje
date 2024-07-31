namespace OOP_Proje
{
    partial class SalaryCalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculateSalary = new System.Windows.Forms.Button();
            this.lblSalary = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.txtHighestDegree = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.ComboBox();
            this.txtUserType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtManagerialPosition = new System.Windows.Forms.ComboBox();
            this.txtKnownLanguages = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chkSpouseWorks = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtExperienceYears = new System.Windows.Forms.TextBox();
            this.chkIsMarried = new System.Windows.Forms.CheckBox();
            this.txtNumberOfChildren = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculateSalary
            // 
            this.btnCalculateSalary.Location = new System.Drawing.Point(673, 195);
            this.btnCalculateSalary.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateSalary.Name = "btnCalculateSalary";
            this.btnCalculateSalary.Size = new System.Drawing.Size(65, 33);
            this.btnCalculateSalary.TabIndex = 0;
            this.btnCalculateSalary.Text = "calculate";
            this.btnCalculateSalary.UseVisualStyleBackColor = true;
            this.btnCalculateSalary.Click += new System.EventHandler(this.btnCalculateSalary_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(28, 123);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(98, 13);
            this.lblSalary.TabIndex = 1;
            this.lblSalary.Text = "The city you live in:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Years of experience:";
            // 
            // txtExperience
            // 
            this.txtExperience.Location = new System.Drawing.Point(169, 49);
            this.txtExperience.Margin = new System.Windows.Forms.Padding(2);
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.Size = new System.Drawing.Size(68, 20);
            this.txtExperience.TabIndex = 3;
            // 
            // txtHighestDegree
            // 
            this.txtHighestDegree.FormattingEnabled = true;
            this.txtHighestDegree.Items.AddRange(new object[] {
            "Meslek alanı ile ilgili yüksek lisans ",
            "Meslek alanı ile ilgili doktora ",
            "Meslek alanı ile ilgili doçentlik ",
            "Meslek alanı ile ilgili olmayan yüksek lisans  ",
            "Meslek alanı ile ilgili olmayan doktora/doçentlik"});
            this.txtHighestDegree.Location = new System.Drawing.Point(177, 80);
            this.txtHighestDegree.Margin = new System.Windows.Forms.Padding(2);
            this.txtHighestDegree.Name = "txtHighestDegree";
            this.txtHighestDegree.Size = new System.Drawing.Size(169, 21);
            this.txtHighestDegree.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.FormattingEnabled = true;
            this.txtCity.Items.AddRange(new object[] {
            "TR10: İstanbul ",
            "TR51: Ankara ",
            "TR31: İzmir ",
            "TR42: Kocaeli, Sakarya, Düzce, Bolu, Yalova ",
            "TR21: Edirne, Kırklareli, Tekirdağ ",
            "TR90: Trabzon, Ordu, Giresun, Rize, Artvin, Gümüşhane ",
            "TR41: Bursa, Eskişehir, Bilecik ",
            "TR32: Aydın, Denizli, Muğla ",
            "TR62: Adana, Mersin ",
            "TR22: Balıkesir, Çanakkale ",
            "TR61: Antalya, Isparta, Burdur ",
            "Diğer İller"});
            this.txtCity.Location = new System.Drawing.Point(169, 118);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(177, 21);
            this.txtCity.TabIndex = 5;
            // 
            // txtUserType
            // 
            this.txtUserType.FormattingEnabled = true;
            this.txtUserType.Items.AddRange(new object[] {
            "admin",
            "user",
            "part-time user"});
            this.txtUserType.Location = new System.Drawing.Point(169, 161);
            this.txtUserType.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(177, 21);
            this.txtUserType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "User type:";
            // 
            // txtManagerialPosition
            // 
            this.txtManagerialPosition.FormattingEnabled = true;
            this.txtManagerialPosition.Items.AddRange(new object[] {
            "Takım Lideri/Grup Yöneticisi/Teknik Yönetici/Yazılım Mimarı ",
            "Proje Yöneticisi ",
            "Direktör/Projeler Yöneticisi ",
            "CTO/Genel Müdür ",
            "Bilgi İşlem Sorumlusu/Müdürü (Bilgi İşlem biriminde en çok 5 bilişim personeli va" +
                "rsa) ",
            "Bilgi İşlem Sorumlusu/Müdürü (Bilgi İşlem biriminde 5\'ten çok bilişim personeli v" +
                "arsa) "});
            this.txtManagerialPosition.Location = new System.Drawing.Point(169, 248);
            this.txtManagerialPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtManagerialPosition.Name = "txtManagerialPosition";
            this.txtManagerialPosition.Size = new System.Drawing.Size(177, 21);
            this.txtManagerialPosition.TabIndex = 5;
            this.txtManagerialPosition.Visible = false;
            // 
            // txtKnownLanguages
            // 
            this.txtKnownLanguages.FormattingEnabled = true;
            this.txtKnownLanguages.Items.AddRange(new object[] {
            "Belgelendirilmiş İngilizce bilgisi  ",
            "İngilizce eğitim veren okul mezuniyeti ",
            "Belgelendirilmiş diğer yabancı dil bilgisi (her dil için) ",
            "Hiçbiri"});
            this.txtKnownLanguages.Location = new System.Drawing.Point(207, 273);
            this.txtKnownLanguages.Margin = new System.Windows.Forms.Padding(2);
            this.txtKnownLanguages.Name = "txtKnownLanguages";
            this.txtKnownLanguages.Size = new System.Drawing.Size(217, 21);
            this.txtKnownLanguages.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "The academic degree received:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Certified foreign language proficiency:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 253);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Managerial role:";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(532, 55);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Marital status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "min wage:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Base salary:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(601, 175);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "26.828";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(629, 205);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(540, 126);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "First child\'s age:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(537, 146);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Second child\'s age:";
            // 
            // chkSpouseWorks
            // 
            this.chkSpouseWorks.AutoSize = true;
            this.chkSpouseWorks.Location = new System.Drawing.Point(604, 74);
            this.chkSpouseWorks.Margin = new System.Windows.Forms.Padding(2);
            this.chkSpouseWorks.Name = "chkSpouseWorks";
            this.chkSpouseWorks.Size = new System.Drawing.Size(130, 17);
            this.chkSpouseWorks.TabIndex = 8;
            this.chkSpouseWorks.Text = "My spouse is working.";
            this.chkSpouseWorks.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(165, 6);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(221, 31);
            this.label13.TabIndex = 9;
            this.label13.Text = "Salary Calculator";
            // 
            // txtExperienceYears
            // 
            this.txtExperienceYears.Location = new System.Drawing.Point(169, 49);
            this.txtExperienceYears.Margin = new System.Windows.Forms.Padding(2);
            this.txtExperienceYears.Name = "txtExperienceYears";
            this.txtExperienceYears.Size = new System.Drawing.Size(120, 20);
            this.txtExperienceYears.TabIndex = 3;
            // 
            // chkIsMarried
            // 
            this.chkIsMarried.AutoSize = true;
            this.chkIsMarried.Location = new System.Drawing.Point(604, 52);
            this.chkIsMarried.Margin = new System.Windows.Forms.Padding(2);
            this.chkIsMarried.Name = "chkIsMarried";
            this.chkIsMarried.Size = new System.Drawing.Size(86, 17);
            this.chkIsMarried.TabIndex = 8;
            this.chkIsMarried.Text = "I am married.";
            this.chkIsMarried.UseVisualStyleBackColor = true;
            // 
            // txtNumberOfChildren
            // 
            this.txtNumberOfChildren.Location = new System.Drawing.Point(684, 101);
            this.txtNumberOfChildren.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumberOfChildren.Name = "txtNumberOfChildren";
            this.txtNumberOfChildren.Size = new System.Drawing.Size(68, 20);
            this.txtNumberOfChildren.TabIndex = 10;
            this.txtNumberOfChildren.TextChanged += new System.EventHandler(this.txtNumberOfChildren_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(517, 105);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "How many chidren do you have?: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(632, 125);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(641, 149);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(180, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Do you Have Any Managerial Role : ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(217, 214);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(308, 214);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backButton.Location = new System.Drawing.Point(604, 262);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(105, 34);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // SalaryCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 317);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNumberOfChildren);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.chkIsMarried);
            this.Controls.Add(this.chkSpouseWorks);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKnownLanguages);
            this.Controls.Add(this.txtManagerialPosition);
            this.Controls.Add(this.txtUserType);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtExperienceYears);
            this.Controls.Add(this.txtHighestDegree);
            this.Controls.Add(this.txtExperience);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.btnCalculateSalary);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalaryCalculatorForm";
            this.Text = "User";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.ComboBox txtHighestDegree;
        private System.Windows.Forms.ComboBox txtCity;
        private System.Windows.Forms.ComboBox txtUserType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtManagerialPosition;
        private System.Windows.Forms.ComboBox txtKnownLanguages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkSpouseWorks;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtExperienceYears;
        private System.Windows.Forms.CheckBox chkIsMarried;
        private System.Windows.Forms.TextBox txtNumberOfChildren;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button backButton;
    }
}

