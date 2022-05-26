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
    public partial class NewDonor : Form
    {
        function fn = new function();
        public NewDonor()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewDonor_Load(object sender, EventArgs e)
        {
            int count = 0;
            string query = "select max(did) from newDonor";
            DataSet ds = fn.getData(query);
            int.TryParse(ds.Tables[0].Rows[0][0].ToString(),out count);
            lblNewID.Text = (count+1).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" && txtFatherName.Text != "" && txtMotherName.Text != ""
                && txtDOB.Text != "" && txtMobileNo.Text != "" && txtGender.Text != "" &&
                txtEmail.Text != "" && txtBloodGroup.Text != "" && txtCity.Text != "" &&
                txtCountry.Text != "" && txtState.Text != "" && rtbAddress.Text != "")
            {
                
                string dname = txtName.Text;
                string fname = txtFatherName.Text;
                string mname = txtMotherName.Text;
                string dob = txtDOB.Text;
                Int64 mobile = Int64.Parse(txtMobileNo.Text);
                string gender = txtGender.Text;
                string email = txtEmail.Text;
                string bloodgroup = txtBloodGroup.Text;
                string city = txtCity.Text;
                string dstate = txtState.Text;
                string dcountry = txtCountry.Text;
                string daddress = rtbAddress.Text +"\n"+city+"\n"+dstate+"\n" + dcountry;

                string query = "insert into newDonor (dname,fname,mname,dob,mobile,gender,email,bloodgroup,city,dstate,dcountry,daddress) values ('" + dname + "','" + fname + "','" + mname + "','" + dob + "'," + mobile + ",'" + gender + "','" + email + "','" + bloodgroup + "','" + city + "','" + dstate + "','" + dcountry + "','" + daddress + "')"; 
                fn.setData(query);
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Fill all Fields", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
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
}
