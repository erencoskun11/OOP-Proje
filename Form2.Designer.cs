namespace OOP_Proje
{
    partial class Form2
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
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPhoneBook = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnPersonalInformation = new System.Windows.Forms.Button();
            this.btnReminder = new System.Windows.Forms.Button();
            this.btnSalaryCalculator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserManagement.Location = new System.Drawing.Point(8, 12);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(248, 57);
            this.btnUserManagement.TabIndex = 0;
            this.btnUserManagement.Text = "User Managament";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.buttonEvent);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnPhoneBook
            // 
            this.btnPhoneBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPhoneBook.Location = new System.Drawing.Point(8, 75);
            this.btnPhoneBook.Name = "btnPhoneBook";
            this.btnPhoneBook.Size = new System.Drawing.Size(248, 57);
            this.btnPhoneBook.TabIndex = 2;
            this.btnPhoneBook.Text = "Phone Book";
            this.btnPhoneBook.UseVisualStyleBackColor = true;
            this.btnPhoneBook.Click += new System.EventHandler(this.buttonEvent);
            // 
            // btnNotes
            // 
            this.btnNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotes.Location = new System.Drawing.Point(8, 138);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(248, 57);
            this.btnNotes.TabIndex = 3;
            this.btnNotes.Text = "Notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.buttonEvent);
            // 
            // btnPersonalInformation
            // 
            this.btnPersonalInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonalInformation.Location = new System.Drawing.Point(8, 201);
            this.btnPersonalInformation.Name = "btnPersonalInformation";
            this.btnPersonalInformation.Size = new System.Drawing.Size(248, 57);
            this.btnPersonalInformation.TabIndex = 4;
            this.btnPersonalInformation.Text = "Personal Information";
            this.btnPersonalInformation.UseVisualStyleBackColor = true;
            this.btnPersonalInformation.Click += new System.EventHandler(this.buttonEvent);
            // 
            // btnReminder
            // 
            this.btnReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReminder.Location = new System.Drawing.Point(8, 327);
            this.btnReminder.Name = "btnReminder";
            this.btnReminder.Size = new System.Drawing.Size(248, 57);
            this.btnReminder.TabIndex = 5;
            this.btnReminder.Text = "Reminder";
            this.btnReminder.UseVisualStyleBackColor = true;
            this.btnReminder.Click += new System.EventHandler(this.buttonEvent);
            // 
            // btnSalaryCalculator
            // 
            this.btnSalaryCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalaryCalculator.Location = new System.Drawing.Point(8, 264);
            this.btnSalaryCalculator.Name = "btnSalaryCalculator";
            this.btnSalaryCalculator.Size = new System.Drawing.Size(248, 57);
            this.btnSalaryCalculator.TabIndex = 6;
            this.btnSalaryCalculator.Text = "Salary Calculator";
            this.btnSalaryCalculator.UseVisualStyleBackColor = true;
            this.btnSalaryCalculator.Click += new System.EventHandler(this.buttonEvent);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalaryCalculator);
            this.Controls.Add(this.btnReminder);
            this.Controls.Add(this.btnPersonalInformation);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.btnPhoneBook);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUserManagement);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPhoneBook;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnPersonalInformation;
        private System.Windows.Forms.Button btnReminder;
        private System.Windows.Forms.Button btnSalaryCalculator;
    }
}