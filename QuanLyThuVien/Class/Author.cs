using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Class
{
    class Author
    {
        ConnectionDB db;

        public Author()
        {
            db = new ConnectionDB();
        }

        public DataTable listAuthor()
        {
            string sql = "SELECT * FROM TACGIA";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        // Thêm mới sách
        public void Create(string name)
        {
            string sql = string.Format("INSERT INTO TACGIA VALUES (N'{0}')", name);
            db.ExecuteNonQuery(sql);
        }

        // Chỉnh sửa sách
        public void Edit(int id, string name)
        {
            string sql = string.Format("UPDATE TACGIA SET TENTG = N'{0}' WHERE MATG = {1}", name, id);
            db.ExecuteNonQuery(sql);
        }

        // Xóa sách
        public void Delete(int id)
        {
            string sql = string.Format("DELETE FROM TACGIA WHERE MATG = {0}", id);
            db.ExecuteNonQuery(sql);
        }

        // Tìm sách theo mã tác giả
        public DataTable Search(int id)
        {
            string sql = "SELECT * FROM TACGIA WHERE MATG = '" + id + "' ";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        // Tìm sách theo tên tác giả
        public DataTable Search(string name)
        {
            string sql = "SELECT * FROM TACGIA WHERE TENTG LIKE N'%" + name + "%'";
            db.Execute(sql);
            return db.ds.Tables[0];
        }
    }
}
