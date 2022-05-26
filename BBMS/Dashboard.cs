using System;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Hide();
        }

        private void addNewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDonor nd = new NewDonor();
            nd.Show();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDonorDetails udd = new UpdateDonorDetails();
            udd.Show();
        }

        private void allDonorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonorDetails dd = new DonorDetails();
            dd.Show();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressSearch asd = new AddressSearch();
            asd.Show();
        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BGSearch bgs = new BGSearch();
            bgs.Show();
        }

        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncStock inc = new IncStock();
            inc.Show();
        }

        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DecStock de = new DecStock();
            de.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDetails sd = new StockDetails();
            sd.Show();
        }

        private void deleteDonorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteDonor dd = new DeleteDonor();
            dd.Show();
        }
    }
}
