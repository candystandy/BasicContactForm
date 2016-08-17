namespace InfoForm
{
    partial class Form1
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
            this.salutationList = new System.Windows.Forms.ComboBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.addrOne = new System.Windows.Forms.TextBox();
            this.addrTwo = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.zipCode = new System.Windows.Forms.TextBox();
            this.eMail = new System.Windows.Forms.TextBox();
            this.stateList = new System.Windows.Forms.ComboBox();
            this.homePhone = new System.Windows.Forms.TextBox();
            this.workPhone = new System.Windows.Forms.TextBox();
            this.cellPhone = new System.Windows.Forms.TextBox();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.anniversary = new System.Windows.Forms.DateTimePicker();
            this.cardWorthy = new System.Windows.Forms.CheckBox();
            this.contactsBox = new System.Windows.Forms.ListBox();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.relationBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.married = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salutationList
            // 
            this.salutationList.FormattingEnabled = true;
            this.salutationList.Items.AddRange(new object[] {
            "Please select one...",
            "Mr.",
            "Mrs.",
            "Ms."});
            this.salutationList.Location = new System.Drawing.Point(106, 12);
            this.salutationList.Name = "salutationList";
            this.salutationList.Size = new System.Drawing.Size(100, 21);
            this.salutationList.TabIndex = 0;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(106, 39);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 20);
            this.firstName.TabIndex = 1;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(106, 65);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 20);
            this.lastName.TabIndex = 2;
            this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // addrOne
            // 
            this.addrOne.Location = new System.Drawing.Point(106, 91);
            this.addrOne.Name = "addrOne";
            this.addrOne.Size = new System.Drawing.Size(100, 20);
            this.addrOne.TabIndex = 3;
            // 
            // addrTwo
            // 
            this.addrTwo.Location = new System.Drawing.Point(106, 117);
            this.addrTwo.Name = "addrTwo";
            this.addrTwo.Size = new System.Drawing.Size(100, 20);
            this.addrTwo.TabIndex = 4;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(106, 143);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 20);
            this.city.TabIndex = 5;
            // 
            // zipCode
            // 
            this.zipCode.Location = new System.Drawing.Point(106, 196);
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(100, 20);
            this.zipCode.TabIndex = 7;
            // 
            // eMail
            // 
            this.eMail.Location = new System.Drawing.Point(106, 222);
            this.eMail.Name = "eMail";
            this.eMail.Size = new System.Drawing.Size(100, 20);
            this.eMail.TabIndex = 8;
            this.eMail.TextChanged += new System.EventHandler(this.eMail_TextChanged);
            // 
            // stateList
            // 
            this.stateList.FormattingEnabled = true;
            this.stateList.Items.AddRange(new object[] {
            "Please select one.",
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.stateList.Location = new System.Drawing.Point(106, 169);
            this.stateList.Name = "stateList";
            this.stateList.Size = new System.Drawing.Size(100, 21);
            this.stateList.TabIndex = 6;
            // 
            // homePhone
            // 
            this.homePhone.Location = new System.Drawing.Point(106, 248);
            this.homePhone.Name = "homePhone";
            this.homePhone.Size = new System.Drawing.Size(100, 20);
            this.homePhone.TabIndex = 9;
            // 
            // workPhone
            // 
            this.workPhone.Location = new System.Drawing.Point(106, 274);
            this.workPhone.Name = "workPhone";
            this.workPhone.Size = new System.Drawing.Size(100, 20);
            this.workPhone.TabIndex = 10;
            this.workPhone.TextChanged += new System.EventHandler(this.workPhone_TextChanged);
            // 
            // cellPhone
            // 
            this.cellPhone.Location = new System.Drawing.Point(106, 300);
            this.cellPhone.Name = "cellPhone";
            this.cellPhone.Size = new System.Drawing.Size(100, 20);
            this.cellPhone.TabIndex = 11;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(106, 326);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(100, 20);
            this.dateOfBirth.TabIndex = 12;
            // 
            // anniversary
            // 
            this.anniversary.Enabled = false;
            this.anniversary.Location = new System.Drawing.Point(106, 374);
            this.anniversary.Name = "anniversary";
            this.anniversary.Size = new System.Drawing.Size(100, 20);
            this.anniversary.TabIndex = 13;
            // 
            // cardWorthy
            // 
            this.cardWorthy.AutoSize = true;
            this.cardWorthy.Location = new System.Drawing.Point(10, 434);
            this.cardWorthy.Name = "cardWorthy";
            this.cardWorthy.Size = new System.Drawing.Size(85, 17);
            this.cardWorthy.TabIndex = 15;
            this.cardWorthy.Text = "Card Worthy";
            this.cardWorthy.UseVisualStyleBackColor = true;
            // 
            // contactsBox
            // 
            this.contactsBox.FormattingEnabled = true;
            this.contactsBox.Location = new System.Drawing.Point(227, 13);
            this.contactsBox.Name = "contactsBox";
            this.contactsBox.Size = new System.Drawing.Size(753, 407);
            this.contactsBox.TabIndex = 100;
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Location = new System.Drawing.Point(12, 462);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(52, 13);
            this.confirmLabel.TabIndex = 16;
            this.confirmLabel.Text = "feedback";
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(662, 457);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(75, 23);
            this.btnAddContact.TabIndex = 16;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(824, 457);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(75, 23);
            this.btnClearForm.TabIndex = 17;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Birthday";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Anniversary";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Salutation";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Street Address";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Email";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(905, 457);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Home Phone";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Cell Phone";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Work Phone";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Last Name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "First Name";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Zip Code";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "State";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "City";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Street Address 2";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // relationBox
            // 
            this.relationBox.FormattingEnabled = true;
            this.relationBox.Items.AddRange(new object[] {
            "Please select one...",
            "Friend",
            "Brothers / Sisters",
            "Parents",
            "Other Relative",
            "Doctor",
            "Other"});
            this.relationBox.Location = new System.Drawing.Point(106, 401);
            this.relationBox.Name = "relationBox";
            this.relationBox.Size = new System.Drawing.Size(100, 21);
            this.relationBox.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 409);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Relationship";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // married
            // 
            this.married.AutoSize = true;
            this.married.Location = new System.Drawing.Point(10, 354);
            this.married.Name = "married";
            this.married.Size = new System.Drawing.Size(67, 17);
            this.married.TabIndex = 101;
            this.married.Text = "Married?";
            this.married.UseVisualStyleBackColor = true;
            this.married.CheckedChanged += new System.EventHandler(this.married_CheckedChanged);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(743, 457);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 102;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 489);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.married);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.relationBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.contactsBox);
            this.Controls.Add(this.cardWorthy);
            this.Controls.Add(this.anniversary);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.cellPhone);
            this.Controls.Add(this.workPhone);
            this.Controls.Add(this.homePhone);
            this.Controls.Add(this.stateList);
            this.Controls.Add(this.eMail);
            this.Controls.Add(this.zipCode);
            this.Controls.Add(this.city);
            this.Controls.Add(this.addrTwo);
            this.Controls.Add(this.addrOne);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.salutationList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Contact Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox salutationList;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox addrOne;
        private System.Windows.Forms.TextBox addrTwo;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox zipCode;
        private System.Windows.Forms.TextBox eMail;
        private System.Windows.Forms.ComboBox stateList;
        private System.Windows.Forms.TextBox homePhone;
        private System.Windows.Forms.TextBox workPhone;
        private System.Windows.Forms.TextBox cellPhone;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.DateTimePicker anniversary;
        private System.Windows.Forms.CheckBox cardWorthy;
        private System.Windows.Forms.ListBox contactsBox;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox relationBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox married;
        private System.Windows.Forms.Button btnExport;
    }
}

