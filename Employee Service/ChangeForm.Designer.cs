namespace Service_Application
{
    partial class ChangeForm
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
            this.surnameField = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.birthDateField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.peselField = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.countryField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cityField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addressField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.postcodeField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.phoneNumberField = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.companyNameComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.positionComboBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // surnameField
            // 
            this.surnameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameField.Location = new System.Drawing.Point(268, 81);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(197, 27);
            this.surnameField.TabIndex = 1;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(342, 585);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(123, 36);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(11, 585);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(123, 36);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // birthDateField
            // 
            this.birthDateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateField.Location = new System.Drawing.Point(12, 139);
            this.birthDateField.Name = "birthDateField";
            this.birthDateField.Size = new System.Drawing.Size(197, 27);
            this.birthDateField.TabIndex = 4;
            this.birthDateField.Validating += new System.ComponentModel.CancelEventHandler(this.birthDateField_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname:";
            // 
            // peselField
            // 
            this.peselField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peselField.Location = new System.Drawing.Point(268, 197);
            this.peselField.Name = "peselField";
            this.peselField.Size = new System.Drawing.Size(197, 27);
            this.peselField.TabIndex = 9;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(265, 139);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(41, 18);
            this.labelAge.TabIndex = 10;
            this.labelAge.Text = "Age: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Birth Date:";
            // 
            // genderCB
            // 
            this.genderCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderCB.Location = new System.Drawing.Point(12, 197);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(197, 28);
            this.genderCB.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "PESEL:";
            // 
            // countryField
            // 
            this.countryField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryField.Location = new System.Drawing.Point(12, 260);
            this.countryField.Name = "countryField";
            this.countryField.Size = new System.Drawing.Size(197, 27);
            this.countryField.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "City:";
            // 
            // cityField
            // 
            this.cityField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityField.Location = new System.Drawing.Point(268, 260);
            this.cityField.Name = "cityField";
            this.cityField.Size = new System.Drawing.Size(197, 27);
            this.cityField.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Country:";
            // 
            // addressField
            // 
            this.addressField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressField.Location = new System.Drawing.Point(12, 318);
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(453, 27);
            this.addressField.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Address:";
            // 
            // postcodeField
            // 
            this.postcodeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postcodeField.Location = new System.Drawing.Point(334, 380);
            this.postcodeField.MaxLength = 6;
            this.postcodeField.Name = "postcodeField";
            this.postcodeField.Size = new System.Drawing.Size(131, 27);
            this.postcodeField.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(252, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Postcode:";
            // 
            // phoneNumberField
            // 
            this.phoneNumberField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberField.Location = new System.Drawing.Point(12, 380);
            this.phoneNumberField.MaxLength = 12;
            this.phoneNumberField.Name = "phoneNumberField";
            this.phoneNumberField.Size = new System.Drawing.Size(197, 27);
            this.phoneNumberField.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Phone number:";
            // 
            // companyNameComboBox
            // 
            this.companyNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameComboBox.FormattingEnabled = true;
            this.companyNameComboBox.Items.AddRange(new object[] {
            "DHS, ul. 1234",
            "Tower Klok, ul. 332211"});
            this.companyNameComboBox.Location = new System.Drawing.Point(12, 448);
            this.companyNameComboBox.Name = "companyNameComboBox";
            this.companyNameComboBox.Size = new System.Drawing.Size(197, 28);
            this.companyNameComboBox.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 427);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 18);
            this.label11.TabIndex = 27;
            this.label11.Text = "Company name:";
            // 
            // positionComboBox
            // 
            this.positionComboBox.AutoSize = true;
            this.positionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionComboBox.Location = new System.Drawing.Point(271, 427);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(66, 18);
            this.positionComboBox.TabIndex = 28;
            this.positionComboBox.Text = "Position:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name:";
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.Location = new System.Drawing.Point(12, 81);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(197, 27);
            this.nameField.TabIndex = 29;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Line Leader",
            "Foreman",
            "Worker I category",
            "Worker II category",
            "Warehouse worker",
            ""});
            this.comboBoxPosition.Location = new System.Drawing.Point(268, 448);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(197, 28);
            this.comboBoxPosition.TabIndex = 26;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(9, 20);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(34, 20);
            this.labelID.TabIndex = 31;
            this.labelID.Text = "ID:";
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 633);
            this.ControlBox = false;
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.companyNameComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.phoneNumberField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.postcodeField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addressField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cityField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.countryField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.genderCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.peselField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.birthDateField);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.surnameField);
            this.Name = "ChangeForm";
            this.ShowIcon = false;
            this.Text = "Change Form";
            this.Load += new System.EventHandler(this.ChangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox birthDateField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox peselField;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox countryField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cityField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox postcodeField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phoneNumberField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox companyNameComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label positionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label labelID;
    }
}