using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Class
{
    class Account
    {
        private static Account instance;

        public static Account Instance
        {
            get { if (instance == null) instance = new Account(); return instance; }
            private set { instance = value; }
        }

        private Account() { }

        public bool checkAccount(string username, string password)
        {
            string sql = string.Format("Select * From TAIKHOAN Where TenDangNhap = '{0}' and MatKhau = '{1}'", username, password);
            DataTable result = new ConnectionDB().Execute(sql);

            return result.Rows.Count == 1;
        }
    }
}
