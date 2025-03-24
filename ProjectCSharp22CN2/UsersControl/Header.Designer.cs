namespace ProjectCSharp22CN2.UsersControl
{
    partial class Header
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HomePage = new Label();
            btnLoginModal = new Button();
            btnRegisterModal = new Button();
            SuspendLayout();
            // 
            // HomePage
            // 
            HomePage.AutoSize = true;
            HomePage.BackColor = Color.FromArgb(94, 181, 114);
            HomePage.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomePage.ForeColor = SystemColors.ButtonHighlight;
            HomePage.Location = new Point(16, 16);
            HomePage.Name = "HomePage";
            HomePage.Size = new Size(266, 31);
            HomePage.TabIndex = 0;
            HomePage.Text = "Quản lý thu chi cá nhân";
            // 
            // btnLoginModal
            // 
            btnLoginModal.Location = new Point(569, 21);
            btnLoginModal.Name = "btnLoginModal";
            btnLoginModal.Size = new Size(94, 29);
            btnLoginModal.TabIndex = 1;
            btnLoginModal.Text = "Login";
            btnLoginModal.UseVisualStyleBackColor = true;
            btnLoginModal.Click += btnLoginModal_Click;
            // 
            // btnRegisterModal
            // 
            btnRegisterModal.Location = new Point(679, 21);
            btnRegisterModal.Name = "btnRegisterModal";
            btnRegisterModal.Size = new Size(94, 29);
            btnRegisterModal.TabIndex = 2;
            btnRegisterModal.Text = "Register";
            btnRegisterModal.UseVisualStyleBackColor = true;
            btnRegisterModal.Click += btnRegisterModal_Click;
            // 
            // Header
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(94, 181, 114);
            Controls.Add(btnRegisterModal);
            Controls.Add(btnLoginModal);
            Controls.Add(HomePage);
            Name = "Header";
            Size = new Size(802, 72);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HomePage;
        private Button btnLoginModal;
        private Button btnRegisterModal;
    }
}
