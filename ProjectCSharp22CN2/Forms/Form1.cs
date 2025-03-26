using ProjectCSharp22CN2.Dao;
using ProjectCSharp22CN2.Forms;
using ProjectCSharp22CN2.Model;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserDao userDAO = new UserDao();
            User? user = userDAO.CheckLogin(username, password);

            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide(); 
                // điều hướng
                UserForm userForm = new UserForm(user); 
                userForm.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                btnRegister.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPasswordRegister, "❌ Mật khẩu không khớp!");
                btnRegister.Enabled = false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUserNameRegister.Text.Trim();
            string password = txtPasswordRegister.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserDao userDao = new UserDao();
            string result = userDao.Register(userName, password);

            if (result == "Đăng ký thành công")
            {
                MessageBox.Show("Đăng ký thành công! 🎉", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserNameRegister.Clear();
                txtPasswordRegister.Clear();
                txtConfirmPasswordRegister.Clear();
                panelRegister.Visible = false;
                panelLogin.Visible = true;
            }
            else
            {
                MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
