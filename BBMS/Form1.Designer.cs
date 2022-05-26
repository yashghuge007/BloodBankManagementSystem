namespace BBMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbShow);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.checkBox);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(109, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 722);
            this.panel1.TabIndex = 0;
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cbShow.Location = new System.Drawing.Point(452, 419);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(70, 27);
            this.cbShow.TabIndex = 6;
            this.cbShow.Text = "Show";
            this.cbShow.UseVisualStyleBackColor = true;
            this.cbShow.CheckedChanged += new System.EventHandler(this.cbShow_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(267, 548);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 39);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkBox.Location = new System.Drawing.Point(137, 505);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(257, 27);
            this.checkBox.TabIndex = 3;
            this.checkBox.Text = "I Accept Terms and Conditions";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(137, 452);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(385, 34);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(137, 320);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(394, 34);
            this.txtUsername.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(216, 628);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "Read Terms and Conditions";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(137, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(137, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(137, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnExit.Location = new System.Drawing.Point(1879, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 39);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private CheckBox checkBox;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label4;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private Button btnExit;
        private CheckBox cbShow;
    }
}