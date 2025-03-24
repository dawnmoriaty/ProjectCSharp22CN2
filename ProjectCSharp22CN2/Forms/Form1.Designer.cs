namespace ProjectCSharp22CN2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelLogin = new Panel();
            btnCloseLoginModal = new Button();
            Roles = new ComboBox();
            ClearForm = new Button();
            login = new Button();
            checkBox1 = new CheckBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label1 = new Label();
            panelRegister = new Panel();
            txtConfirmPasswordRegister = new TextBox();
            btnExitRegister = new Button();
            SelectRoleRegister = new ComboBox();
            btnClearFormRegister = new Button();
            btnRegister = new Button();
            ShowPasswordRegister = new CheckBox();
            txtPasswordRegister = new TextBox();
            txtUserNameRegister = new TextBox();
            RegisterLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            imageHome = new PictureBox();
            header1 = new ProjectCSharp22CN2.UsersControl.Header();
            panelLogin.SuspendLayout();
            panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageHome).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(94, 181, 114);
            panelLogin.BorderStyle = BorderStyle.Fixed3D;
            panelLogin.Controls.Add(btnCloseLoginModal);
            panelLogin.Controls.Add(Roles);
            panelLogin.Controls.Add(ClearForm);
            panelLogin.Controls.Add(login);
            panelLogin.Controls.Add(checkBox1);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(txtUserName);
            panelLogin.Controls.Add(label1);
            panelLogin.Location = new Point(52, 114);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(309, 382);
            panelLogin.TabIndex = 0;
            // 
            // btnCloseLoginModal
            // 
            btnCloseLoginModal.BackColor = Color.SteelBlue;
            btnCloseLoginModal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseLoginModal.ForeColor = Color.White;
            btnCloseLoginModal.Location = new Point(156, 321);
            btnCloseLoginModal.Name = "btnCloseLoginModal";
            btnCloseLoginModal.Size = new Size(105, 45);
            btnCloseLoginModal.TabIndex = 9;
            btnCloseLoginModal.Text = "Exit";
            btnCloseLoginModal.UseVisualStyleBackColor = false;
            btnCloseLoginModal.Click += btnCloseLoginModal_Click;
            // 
            // Roles
            // 
            Roles.FormattingEnabled = true;
            Roles.Items.AddRange(new object[] { "ADMIN", "USER" });
            Roles.Location = new Point(52, 80);
            Roles.Name = "Roles";
            Roles.Size = new Size(209, 28);
            Roles.TabIndex = 8;
            // 
            // ClearForm
            // 
            ClearForm.BackColor = Color.SteelBlue;
            ClearForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearForm.ForeColor = Color.White;
            ClearForm.Location = new Point(52, 321);
            ClearForm.Name = "ClearForm";
            ClearForm.Size = new Size(105, 45);
            ClearForm.TabIndex = 7;
            ClearForm.Text = "Clear";
            ClearForm.UseVisualStyleBackColor = false;
            ClearForm.Click += ClearForm_Click;
            // 
            // login
            // 
            login.BackColor = Color.SteelBlue;
            login.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.ForeColor = Color.White;
            login.Location = new Point(52, 270);
            login.Name = "login";
            login.Size = new Size(209, 45);
            login.TabIndex = 6;
            login.Text = " Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(121, 225);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(140, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(52, 192);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(209, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(52, 138);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "UserName";
            txtUserName.Size = new Size(209, 27);
            txtUserName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(108, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 43);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // panelRegister
            // 
            panelRegister.BackColor = Color.FromArgb(94, 181, 114);
            panelRegister.BorderStyle = BorderStyle.Fixed3D;
            panelRegister.Controls.Add(txtConfirmPasswordRegister);
            panelRegister.Controls.Add(btnExitRegister);
            panelRegister.Controls.Add(SelectRoleRegister);
            panelRegister.Controls.Add(btnClearFormRegister);
            panelRegister.Controls.Add(btnRegister);
            panelRegister.Controls.Add(ShowPasswordRegister);
            panelRegister.Controls.Add(txtPasswordRegister);
            panelRegister.Controls.Add(txtUserNameRegister);
            panelRegister.Controls.Add(RegisterLabel);
            panelRegister.Location = new Point(585, 112);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(309, 382);
            panelRegister.TabIndex = 10;
            // 
            // txtConfirmPasswordRegister
            // 
            txtConfirmPasswordRegister.Location = new Point(52, 147);
            txtConfirmPasswordRegister.MaxLength = 20;
            txtConfirmPasswordRegister.Name = "txtConfirmPasswordRegister";
            txtConfirmPasswordRegister.PlaceholderText = "Confirm Password";
            txtConfirmPasswordRegister.Size = new Size(209, 27);
            txtConfirmPasswordRegister.TabIndex = 10;
            txtConfirmPasswordRegister.UseSystemPasswordChar = true;
            txtConfirmPasswordRegister.TextChanged += txtConfirmPasswordRegister_TextChanged;
            // 
            // btnExitRegister
            // 
            btnExitRegister.BackColor = Color.SteelBlue;
            btnExitRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExitRegister.ForeColor = Color.White;
            btnExitRegister.Location = new Point(156, 321);
            btnExitRegister.Name = "btnExitRegister";
            btnExitRegister.Size = new Size(105, 45);
            btnExitRegister.TabIndex = 9;
            btnExitRegister.Text = "Exit";
            btnExitRegister.UseVisualStyleBackColor = false;
            btnExitRegister.Click += btnExitRegister_Click;
            // 
            // SelectRoleRegister
            // 
            SelectRoleRegister.FormattingEnabled = true;
            SelectRoleRegister.Items.AddRange(new object[] { "ADMIN", "USER" });
            SelectRoleRegister.Location = new Point(52, 191);
            SelectRoleRegister.Name = "SelectRoleRegister";
            SelectRoleRegister.Size = new Size(209, 28);
            SelectRoleRegister.TabIndex = 8;
            // 
            // btnClearFormRegister
            // 
            btnClearFormRegister.BackColor = Color.SteelBlue;
            btnClearFormRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearFormRegister.ForeColor = Color.White;
            btnClearFormRegister.Location = new Point(52, 321);
            btnClearFormRegister.Name = "btnClearFormRegister";
            btnClearFormRegister.Size = new Size(105, 45);
            btnClearFormRegister.TabIndex = 7;
            btnClearFormRegister.Text = "Clear";
            btnClearFormRegister.UseVisualStyleBackColor = false;
            btnClearFormRegister.Click += btnClearFormRegister_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SteelBlue;
            btnRegister.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(52, 270);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(209, 45);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // ShowPasswordRegister
            // 
            ShowPasswordRegister.AutoSize = true;
            ShowPasswordRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowPasswordRegister.Location = new Point(121, 225);
            ShowPasswordRegister.Name = "ShowPasswordRegister";
            ShowPasswordRegister.Size = new Size(140, 24);
            ShowPasswordRegister.TabIndex = 5;
            ShowPasswordRegister.Text = "Show Password";
            ShowPasswordRegister.UseVisualStyleBackColor = true;
            ShowPasswordRegister.CheckedChanged += ShowPasswordRegister_CheckedChanged;
            // 
            // txtPasswordRegister
            // 
            txtPasswordRegister.Location = new Point(52, 104);
            txtPasswordRegister.MaxLength = 20;
            txtPasswordRegister.Name = "txtPasswordRegister";
            txtPasswordRegister.PlaceholderText = "Password";
            txtPasswordRegister.Size = new Size(209, 27);
            txtPasswordRegister.TabIndex = 4;
            txtPasswordRegister.UseSystemPasswordChar = true;
            // 
            // txtUserNameRegister
            // 
            txtUserNameRegister.Location = new Point(52, 61);
            txtUserNameRegister.Name = "txtUserNameRegister";
            txtUserNameRegister.PlaceholderText = "UserName";
            txtUserNameRegister.Size = new Size(209, 27);
            txtUserNameRegister.TabIndex = 3;
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.BorderStyle = BorderStyle.Fixed3D;
            RegisterLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterLabel.ForeColor = Color.White;
            RegisterLabel.Location = new Point(89, 0);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(136, 43);
            RegisterLabel.TabIndex = 0;
            RegisterLabel.Text = "Register";
            // 
            // timer1
            // 
            timer1.Interval = 3000;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // imageHome
            // 
            imageHome.BackgroundImageLayout = ImageLayout.Zoom;
            imageHome.Image = (Image)resources.GetObject("imageHome.Image");
            imageHome.Location = new Point(-4, 74);
            imageHome.Name = "imageHome";
            imageHome.Size = new Size(907, 460);
            imageHome.SizeMode = PictureBoxSizeMode.StretchImage;
            imageHome.TabIndex = 12;
            imageHome.TabStop = false;
            // 
            // header1
            // 
            header1.BackColor = Color.FromArgb(94, 181, 114);
            header1.Location = new Point(-4, 1);
            header1.Name = "header1";
            header1.Size = new Size(907, 75);
            header1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(906, 546);
            Controls.Add(panelRegister);
            Controls.Add(panelLogin);
            Controls.Add(header1);
            Controls.Add(imageHome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Label label1;
        private TextBox txtUserName;
        private Button login;
        private CheckBox checkBox1;
        private TextBox txtPassword;
        private ComboBox Roles;
        private Button ClearForm;
        private Button btnCloseLoginModal;
        private Panel panelRegister;
        private Button btnExitRegister;
        private ComboBox SelectRoleRegister;
        private Button btnClearFormRegister;
        private Button btnRegister;
        private CheckBox ShowPasswordRegister;
        private TextBox txtPasswordRegister;
        private TextBox txtUserNameRegister;
        private Label RegisterLabel;
        private TextBox txtConfirmPasswordRegister;
        private System.Windows.Forms.Timer timer1;
        private ErrorProvider errorProvider1;
        private PictureBox imageHome;
        private UsersControl.Header header1;
    }
}
