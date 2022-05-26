namespace BBMS
{
    partial class UpdateDonorDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDonorDetails));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.txtBloodGroup = new System.Windows.Forms.ComboBox();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.txtDOB = new System.Windows.Forms.DateTimePicker();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonorID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(207, 661);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 38);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(589, 661);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 38);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(396, 661);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 38);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rtbAddress
            // 
            this.rtbAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbAddress.Location = new System.Drawing.Point(679, 432);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(187, 152);
            this.rtbAddress.TabIndex = 33;
            this.rtbAddress.Text = "";
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBloodGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBloodGroup.FormattingEnabled = true;
            this.txtBloodGroup.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "O+",
            "A-",
            "B-",
            "AB-",
            "O-"});
            this.txtBloodGroup.Location = new System.Drawing.Point(679, 179);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(187, 31);
            this.txtBloodGroup.TabIndex = 32;
            // 
            // txtGender
            // 
            this.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.txtGender.Location = new System.Drawing.Point(212, 490);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(187, 31);
            this.txtGender.TabIndex = 31;
            // 
            // txtDOB
            // 
            this.txtDOB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDOB.Location = new System.Drawing.Point(212, 368);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(187, 30);
            this.txtDOB.TabIndex = 30;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMobileNo.Location = new System.Drawing.Point(212, 429);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(187, 30);
            this.txtMobileNo.TabIndex = 28;
            // 
            // txtMotherName
            // 
            this.txtMotherName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMotherName.Location = new System.Drawing.Point(212, 302);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(187, 30);
            this.txtMotherName.TabIndex = 27;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFatherName.Location = new System.Drawing.Point(212, 235);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(187, 30);
            this.txtFatherName.TabIndex = 26;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCity.Location = new System.Drawing.Point(679, 238);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(187, 30);
            this.txtCity.TabIndex = 25;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(212, 555);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 30);
            this.txtEmail.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(212, 176);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 30);
            this.txtName.TabIndex = 29;
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCountry.Location = new System.Drawing.Point(679, 368);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(187, 30);
            this.txtCountry.TabIndex = 23;
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtState.Location = new System.Drawing.Point(679, 305);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(187, 30);
            this.txtState.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(539, 435);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 23);
            this.label13.TabIndex = 20;
            this.label13.Text = "Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(63, 490);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 23);
            this.label14.TabIndex = 19;
            this.label14.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(63, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Mobile Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(539, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 23);
            this.label12.TabIndex = 17;
            this.label12.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(63, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Date of birth";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(539, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(63, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mothers Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(539, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(63, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fathers Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(539, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Blood Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(63, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(63, 561);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(286, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Donor ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Update Donor Details";
            // 
            // txtDonorID
            // 
            this.txtDonorID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDonorID.Location = new System.Drawing.Point(389, 79);
            this.txtDonorID.Name = "txtDonorID";
            this.txtDonorID.Size = new System.Drawing.Size(117, 30);
            this.txtDonorID.TabIndex = 29;
            this.txtDonorID.TextChanged += new System.EventHandler(this.txtDonorID_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(525, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 39);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // UpdateDonorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 738);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.rtbAddress);
            this.Controls.Add(this.txtBloodGroup);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.txtMotherName);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDonorID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateDonorDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Donor Details";
            this.Load += new System.EventHandler(this.UpdateDonorDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUpdate;
        private Button btnClose;
        private Button btnReset;
        private RichTextBox rtbAddress;
        private ComboBox txtBloodGroup;
        private ComboBox txtGender;
        private DateTimePicker txtDOB;
        private TextBox txtMobileNo;
        private TextBox txtMotherName;
        private TextBox txtFatherName;
        private TextBox txtCity;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtCountry;
        private TextBox txtState;
        private Label label13;
        private Label label14;
        private Label label7;
        private Label label12;
        private Label label6;
        private Label label11;
        private Label label5;
        private Label label10;
        private Label label4;
        private Label label9;
        private Label label3;
        private Label label8;
        private Label label2;
        private Label label1;
        private TextBox txtDonorID;
        private Button btnSearch;
    }
}