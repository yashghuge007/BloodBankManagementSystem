namespace BBMS
{
    partial class DecStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecStock));
            this.btnDecr = new System.Windows.Forms.Button();
            this.txtUnits = new System.Windows.Forms.ComboBox();
            this.txtBG = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDecr
            // 
            this.btnDecr.BackColor = System.Drawing.Color.Transparent;
            this.btnDecr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecr.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDecr.Image = ((System.Drawing.Image)(resources.GetObject("btnDecr.Image")));
            this.btnDecr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecr.Location = new System.Drawing.Point(692, 99);
            this.btnDecr.Name = "btnDecr";
            this.btnDecr.Size = new System.Drawing.Size(110, 31);
            this.btnDecr.TabIndex = 56;
            this.btnDecr.Text = "Decrease";
            this.btnDecr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDecr.UseVisualStyleBackColor = false;
            this.btnDecr.Click += new System.EventHandler(this.btnDecr_Click);
            // 
            // txtUnits
            // 
            this.txtUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUnits.FormattingEnabled = true;
            this.txtUnits.Items.AddRange(new object[] {
            "-1",
            "-2",
            "-3",
            "-4",
            "-5",
            "-6",
            "-7",
            "-8",
            "-9",
            "-10"});
            this.txtUnits.Location = new System.Drawing.Point(495, 99);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(151, 29);
            this.txtUnits.TabIndex = 54;
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
            this.txtBG.Location = new System.Drawing.Point(219, 97);
            this.txtBG.Name = "txtBG";
            this.txtBG.Size = new System.Drawing.Size(151, 29);
            this.txtBG.TabIndex = 55;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(815, 677);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 37);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(419, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 29);
            this.label3.TabIndex = 50;
            this.label3.Text = "Units";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(31, 678);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(79, 34);
            this.btnPrint.TabIndex = 53;
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
            this.label2.Location = new System.Drawing.Point(49, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 51;
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
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(863, 454);
            this.dataGridView1.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(324, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 40);
            this.label1.TabIndex = 48;
            this.label1.Text = "Stock Decrease";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // DecStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 738);
            this.Controls.Add(this.btnDecr);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.txtBG);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DecStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DecStock";
            this.Load += new System.EventHandler(this.DecStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDecr;
        private ComboBox txtUnits;
        private ComboBox txtBG;
        private Button btnClose;
        private Label label3;
        private Button btnPrint;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}