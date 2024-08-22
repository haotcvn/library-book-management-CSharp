using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Class
{
    class Publisher
    {
        ConnectionDB db;

        public Publisher()
        {
            db = new ConnectionDB();
        }

        public DataTable listPublisher()
        {
            string sql = "SELECT * FROM NHAXB";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        // Thêm mới sách
        public void Create(string name, string address, string sdt)
        {
            string sql = string.Format("INSERT INTO NHAXB VALUES (N'{0}', N'{1}', '{2}')", name, address, sdt);
            db.ExecuteNonQuery(sql);
        }

        // Chỉnh sửa sách
        public void Edit(int id, string name, string address, string sdt)
        {
            string sql = string.Format("UPDATE NHAXB SET TENNXB = N'{0}', DIACHI = N'{1}', SDT = '{2}' WHERE MANXB = {3}", name, address, sdt, id);
            db.ExecuteNonQuery(sql);
        }

        // Xóa sách
        public void Delete(int id)
        {
            string sql = string.Format("DELETE FROM NHAXB WHERE MANXB = {0}", id);
            db.ExecuteNonQuery(sql);
        }

        // Tìm nhà xuất bản theo mã
        public DataTable Search(int id)
        {
            string sql = "SELECT * FROM NHAXB WHERE MANXB = '" + id + "' ";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        // Tìm nhà xuất bản theo tên
        public DataTable Search(string name)
        {
            string sql = "SELECT * FROM NHAXB WHERE TENNXB LIKE N'%" + name + "%'";
            db.Execute(sql);
            return db.ds.Tables[0];
        }
    }
}
