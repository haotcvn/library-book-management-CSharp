using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyThuVien.Class;

namespace QuanLyThuVien
{
    public partial class frmLogin : Form
    {
        ConnectionDB db = new ConnectionDB();
        public frmLogin()
        {
            InitializeComponent();
        }
        
        // Kiểm tra tài khoản
        bool checkAccount(string username, string password)
        {
            try
            {
                return Account.Instance.checkAccount(username, password);
            }
            catch
            {
                return false;
            }
        }

        // Đăng nhập hệ thống
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassWord.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (checkAccount(txtUserName.Text, txtPassWord.Text))
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtUserName.Focus();
            }
        }

        // Ẩn/hiện mật khẩu
        private void chkBShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBShow.Checked)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }
    }
}
