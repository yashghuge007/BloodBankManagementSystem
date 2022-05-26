namespace BBMS
{
    partial class IncStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncStock));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBG = new System.Windows.Forms.ComboBox();
            this.txtUnits = new System.Windows.Forms.ComboBox();
            this.btnIncr = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(813, 672);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 37);
            this.btnClose.TabIndex = 44;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(29, 673);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(79, 34);
            this.btnPrint.TabIndex = 45;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(47, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "Blood Group";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(863, 454);
            this.dataGridView1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(322, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 40);
            this.label1.TabIndex = 40;
            this.label1.Text = "Stock Increase";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(417, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 29);
            this.label3.TabIndex = 42;
            this.label3.Text = "Units";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1233, 673);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 37);
            this.button1.TabIndex = 44;
            this.button1.Text = "Units";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBG
            // 
            this.txtBG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBG.FormattingEnabled = true;
            this.txtBG.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "O+",
            "A-",
            "B-",
            "AB-",
            "O-"});
            this.txtBG.Location = new System.Drawing.Point(217, 92);
            this.txtBG.Name = "txtBG";
            this.txtBG.Size = new System.Drawing.Size(151, 29);
            this.txtBG.TabIndex = 46;
            // 
            // txtUnits
            // 
            this.txtUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUnits.FormattingEnabled = true;
            this.txtUnits.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.txtUnits.Location = new System.Drawing.Point(493, 94);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(151, 29);
            this.txtUnits.TabIndex = 46;
            // 
            // btnIncr
            // 
            this.btnIncr.BackColor = System.Drawing.Color.Transparent;
            this.btnIncr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncr.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIncr.Image = ((System.Drawing.Image)(resources.GetObject("btnIncr.Image")));
            this.btnIncr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncr.Location = new System.Drawing.Point(690, 94);
            this.btnIncr.Name = "btnIncr";
            this.btnIncr.Size = new System.Drawing.Size(110, 31);
            this.btnIncr.TabIndex = 47;
            this.btnIncr.Text = "Increase";
            this.btnIncr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncr.UseVisualStyleBackColor = false;
            this.btnIncr.Click += new System.EventHandler(this.btnIncr_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // IncStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 738);
            this.Controls.Add(this.btnIncr);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.txtBG);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IncStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncStock";
            this.Load += new System.EventHandler(this.IncStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private Button btnPrint;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label3;
        private Button button1;
        private ComboBox txtBG;
        private ComboBox txtUnits;
        private Button btnIncr;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}