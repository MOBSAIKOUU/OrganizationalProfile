namespace OrganizationalProfile
{
    partial class frmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            registrationTxt = new Label();
            txtStudentNo = new TextBox();
            studentNumLbl = new Label();
            lastNameLbl = new Label();
            txtLastName = new TextBox();
            ageLbl = new Label();
            txtAge = new TextBox();
            firstNameLbl = new Label();
            txtFirstName = new TextBox();
            txtMiddleInitial = new TextBox();
            middleInitialLbl = new Label();
            cbPrograms = new ComboBox();
            programsLbl = new Label();
            cbGender = new ComboBox();
            genderLbl = new Label();
            datePickerBirthday = new DateTimePicker();
            birthdayPickerLbl = new Label();
            btnRegister = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtContactNo = new TextBox();
            ContactNoLbl = new Label();
            SuspendLayout();
            // 
            // registrationTxt
            // 
            registrationTxt.AutoSize = true;
            registrationTxt.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registrationTxt.Location = new Point(12, 9);
            registrationTxt.Name = "registrationTxt";
            registrationTxt.Size = new Size(175, 37);
            registrationTxt.TabIndex = 0;
            registrationTxt.Text = "Registration";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(116, 63);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(100, 23);
            txtStudentNo.TabIndex = 1;
            // 
            // studentNumLbl
            // 
            studentNumLbl.AutoSize = true;
            studentNumLbl.Location = new Point(42, 71);
            studentNumLbl.Name = "studentNumLbl";
            studentNumLbl.Size = new Size(68, 15);
            studentNumLbl.TabIndex = 2;
            studentNumLbl.Text = "Student no.";
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.Location = new Point(42, 112);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(63, 15);
            lastNameLbl.TabIndex = 3;
            lastNameLbl.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(116, 104);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 4;
            // 
            // ageLbl
            // 
            ageLbl.AutoSize = true;
            ageLbl.Location = new Point(77, 156);
            ageLbl.Name = "ageLbl";
            ageLbl.Size = new Size(28, 15);
            ageLbl.TabIndex = 5;
            ageLbl.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(116, 148);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(71, 23);
            txtAge.TabIndex = 6;
            // 
            // firstNameLbl
            // 
            firstNameLbl.AutoSize = true;
            firstNameLbl.Location = new Point(259, 112);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(64, 15);
            firstNameLbl.TabIndex = 7;
            firstNameLbl.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(329, 104);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(123, 23);
            txtFirstName.TabIndex = 8;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(518, 104);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(100, 23);
            txtMiddleInitial.TabIndex = 9;
            // 
            // middleInitialLbl
            // 
            middleInitialLbl.AutoSize = true;
            middleInitialLbl.Location = new Point(482, 112);
            middleInitialLbl.Name = "middleInitialLbl";
            middleInitialLbl.Size = new Size(30, 15);
            middleInitialLbl.TabIndex = 10;
            middleInitialLbl.Text = "M. I.";
            // 
            // cbPrograms
            // 
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(329, 63);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(289, 23);
            cbPrograms.TabIndex = 11;
            // 
            // programsLbl
            // 
            programsLbl.AutoSize = true;
            programsLbl.Location = new Point(270, 71);
            programsLbl.Name = "programsLbl";
            programsLbl.Size = new Size(53, 15);
            programsLbl.TabIndex = 12;
            programsLbl.Text = "Program";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(329, 148);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(100, 23);
            cbGender.TabIndex = 13;
            // 
            // genderLbl
            // 
            genderLbl.AutoSize = true;
            genderLbl.Location = new Point(278, 156);
            genderLbl.Name = "genderLbl";
            genderLbl.Size = new Size(45, 15);
            genderLbl.TabIndex = 14;
            genderLbl.Text = "Gender";
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Location = new Point(116, 196);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(200, 23);
            datePickerBirthday.TabIndex = 15;
            // 
            // birthdayPickerLbl
            // 
            birthdayPickerLbl.AutoSize = true;
            birthdayPickerLbl.Location = new Point(54, 204);
            birthdayPickerLbl.Name = "birthdayPickerLbl";
            birthdayPickerLbl.Size = new Size(51, 15);
            birthdayPickerLbl.TabIndex = 16;
            birthdayPickerLbl.Text = "Birthday";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(314, 357);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(117, 59);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(430, 196);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(100, 23);
            txtContactNo.TabIndex = 18;
            // 
            // ContactNoLbl
            // 
            ContactNoLbl.AutoSize = true;
            ContactNoLbl.Location = new Point(355, 204);
            ContactNoLbl.Name = "ContactNoLbl";
            ContactNoLbl.Size = new Size(69, 15);
            ContactNoLbl.TabIndex = 19;
            ContactNoLbl.Text = "Contact no.";
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(ContactNoLbl);
            Controls.Add(txtContactNo);
            Controls.Add(btnRegister);
            Controls.Add(birthdayPickerLbl);
            Controls.Add(datePickerBirthday);
            Controls.Add(genderLbl);
            Controls.Add(cbGender);
            Controls.Add(programsLbl);
            Controls.Add(cbPrograms);
            Controls.Add(middleInitialLbl);
            Controls.Add(txtMiddleInitial);
            Controls.Add(txtFirstName);
            Controls.Add(firstNameLbl);
            Controls.Add(txtAge);
            Controls.Add(ageLbl);
            Controls.Add(txtLastName);
            Controls.Add(lastNameLbl);
            Controls.Add(studentNumLbl);
            Controls.Add(txtStudentNo);
            Controls.Add(registrationTxt);
            Name = "frmRegistration";
            Text = "OrganizationProfile";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label registrationTxt;
        private TextBox txtStudentNo;
        private Label studentNumLbl;
        private Label lastNameLbl;
        private TextBox txtLastName;
        private Label ageLbl;
        private TextBox txtAge;
        private Label firstNameLbl;
        private TextBox txtFirstName;
        private TextBox txtMiddleInitial;
        private Label middleInitialLbl;
        private ComboBox cbPrograms;
        private Label programsLbl;
        private ComboBox cbGender;
        private Label genderLbl;
        private DateTimePicker datePickerBirthday;
        private Label birthdayPickerLbl;
        private Button btnRegister;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtContactNo;
        private Label ContactNoLbl;
    }
}
