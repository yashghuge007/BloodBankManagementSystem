﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class DecStock : Form
    {
        function fn = new function();
        public DecStock()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void btnDecr_Click(object sender, EventArgs e)
        {
            string query = "update stock set quantity = quantity+ " + txtUnits.Text + " where blood_group = '" + txtBG.Text + "' ";
            fn.setData(query);
            DecStock_Load(this, null);
        }

        private void DecStock_Load(object sender, EventArgs? e)
        {
            string query = "select blood_group,quantity from stock";
            DataSet dataSet = fn.getData(query);
            DataSet ds = dataSet;
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
