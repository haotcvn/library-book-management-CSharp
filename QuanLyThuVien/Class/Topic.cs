using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Class
{
    class Topic
    {
        ConnectionDB db;

        public Topic()
        {
            db = new ConnectionDB();
        }

        public DataTable listTopic()
        {
            string sql = "SELECT * FROM CHUDE";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        // Thêm mới chủ đề
        public void Create(string name)
        {
            string sql = string.Format("INSERT INTO CHUDE VALUES (N'{0}')", name);
            db.ExecuteNonQuery(sql);
        }

        // Chỉnh sửa chủ đề
        public void Edit(int id, string name)
        {
            string sql = string.Format("UPDATE CHUDE SET TENCD = N'{0}' WHERE MACD = {1}", name, id);
            db.ExecuteNonQuery(sql);
        }

        // Xóa chủ đề
        public void Delete(int id)
        {
            string sql = string.Format("DELETE FROM CHUDE WHERE MACD = {0}", id);
            db.ExecuteNonQuery(sql);
        }

        // Tìm chủ đề theo mã chủ đề
        public DataTable SearchByID(int id)
        {
            string sql = "SELECT * FROM CHUDE WHERE MACD = '" + id + "' ";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        // Tìm chủ đề theo tên chủ đề
        public DataTable SearchByName(string name)
        {
            string sql = "SELECT * FROM CHUDE WHERE TENCD LIKE N'%" + name + "%' ";
            db.Execute(sql);
            return db.ds.Tables[0];
        }
    }
}
