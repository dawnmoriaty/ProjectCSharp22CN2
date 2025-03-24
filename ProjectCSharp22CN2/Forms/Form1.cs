using ProjectCSharp22CN2.UsersControl;

namespace ProjectCSharp22CN2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelRegister.Visible = false;
            header1.SetMainForm(this);
        }
        // ===========================Form Login ===========================
        private void login_Click(object sender, EventArgs e)
        {

        }

        private void ClearForm_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
            txtUserName.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        
        public void ShowLoginPanel()
        {
            panelRegister.Visible = false;
            panelLogin.Visible = true;
            panelLogin.BringToFront();

        }

        private void btnCloseLoginModal_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
        // ===========================Form Register ===========================
        public void ShowRegisterPanel()
        {
            panelLogin.Visible = false;
            panelRegister.Visible = true;
            panelRegister.BringToFront();

        }

        private void btnExitRegister_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = false;
            txtUserNameRegister.Text = "";
            txtPasswordRegister.Text = "";
            txtConfirmPasswordRegister.Text = "";
        }

        private void btnClearFormRegister_Click(object sender, EventArgs e)
        {
            txtUserNameRegister.Text = "";
            txtPasswordRegister.Text = "";
            txtConfirmPasswordRegister.Text = "";
        }

        private void ShowPasswordRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordRegister.Checked)
            {
                txtPasswordRegister.UseSystemPasswordChar = false;
                txtConfirmPasswordRegister.UseSystemPasswordChar = false;
            }
            else
            {
                txtPasswordRegister.UseSystemPasswordChar = true;
                txtConfirmPasswordRegister.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmPasswordRegister_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
            CheckPasswordMatch();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            CheckPasswordMatch();
        }
        private void CheckPasswordMatch()
        {
            if (txtPasswordRegister.Text == txtConfirmPasswordRegister.Text)
            {
                errorProvider1.SetError(txtConfirmPasswordRegister, "");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPasswordRegister, "❌ Mật khẩu không khớp!");
            }
        }

        
    }
}
