namespace BBMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox.Checked == true)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Yash" && txtPassword.Text == "pass")
            {
                Dashboard db = new Dashboard();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShow.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}