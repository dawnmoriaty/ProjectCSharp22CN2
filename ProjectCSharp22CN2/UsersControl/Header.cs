using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCSharp22CN2.UsersControl
{
    public partial class Header : UserControl
    {
        private Form1 _mainForm;

        public Header()
        {
            InitializeComponent();
        }

        // Thêm phương thức này để gán Form1 sau khi tạo
        public void SetMainForm(Form1 mainForm)
        {
            _mainForm = mainForm;
        }

        private void btnLoginModal_Click(object sender, EventArgs e)
        {
            _mainForm.ShowLoginPanel();
        }

        private void btnRegisterModal_Click(object sender, EventArgs e)
        {
            _mainForm.ShowRegisterPanel();
        }
    }
}
