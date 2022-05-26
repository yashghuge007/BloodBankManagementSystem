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
    public partial class UpdateDonorDetails : Form
    {
        function fn = new function();
        public UpdateDonorDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Int64 id = Int64.Parse(txtDonorID.Text.ToString());
            string query = "select * from newDonor where did = " + id + "";
            DataSet ds = fn.getData(query);

            if(ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtFatherName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtMotherName.Text = ds.Tables[0].Rows[0][3].ToString();
                txtDOB.Text = ds.Tables[0].Rows[0][4].ToString();
                txtMobileNo.Text = ds.Tables[0].Rows[0][5].ToString();
                txtGender.Text = ds.Tables[0].Rows[0][6].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][7].ToString();
                txtBloodGroup.Text = ds.Tables[0].Rows[0][8].ToString();
                txtCity.Text = ds.Tables[0].Rows[0][9].ToString();
                txtState.Text=ds.Tables[0].Rows[0][10].ToString();
                txtCountry.Text = ds.Tables[0].Rows[0][11].ToString();
                rtbAddress.Text=ds.Tables[0].Rows[0][12].ToString();
            }
            else
            {
                MessageBox.Show("Invalid Id","Error",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtDonorID_TextChanged(object sender, EventArgs e)
        {
            if(txtDonorID.Text == "")
            {
                txtBloodGroup.ResetText();
                txtDOB.ResetText();
                txtCity.Clear();
                txtState.Clear();
                txtCountry.Clear();
                txtEmail.Clear();
                txtFatherName.Clear();
                txtGender.ResetText();
                txtMobileNo.Clear();
                txtMotherName.Clear();
                txtName.Clear();
                rtbAddress.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDonorID.Clear();
        }

        private void UpdateDonorDetails_Load(object sender, EventArgs? e)
        {
            txtDonorID.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "update newDonor set dname='" + txtName.Text + "', fname= '" + txtFatherName.Text + "', mname= '" + txtMotherName.Text + "', dob= '" + txtDOB.Text + "' ,mobile= " + txtMobileNo.Text + " ,gender= '" + txtGender.Text + "', email= '" + txtEmail.Text + "', bloodgroup= '" + txtBloodGroup.Text + "' ,city= '" + txtCity.Text + "' ,dstate= '" + txtState.Text + "' ,dcountry= '" + txtCountry.Text + "' ,daddress= '" + rtbAddress.Text + "' where did= " + txtDonorID.Text + "";
            fn.setData(query);
            UpdateDonorDetails_Load(this, e: null);
        }
    }
}
