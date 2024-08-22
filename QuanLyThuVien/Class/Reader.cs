using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QuanLyThuVien.Class
{
    public class Reader
    {
        ConnectionDB db;
        public Reader()
        {
            db = new ConnectionDB();
        }

        public DataTable listReader()
        {
            string sql = "SELECT DOCGIA.MADG, DOCGIA.TENDG, DOCGIA.GIOITINH, LOAIDOCGIA.TENLOAIDG, DOCGIA.DIACHI, DOCGIA.SDT " +
                "FROM DOCGIA, LOAIDOCGIA " +
                "WHERE DOCGIA.MALOAIDG = LOAIDOCGIA.MALOAIDG";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        public DataTable listTypeReader()
        {
            string sql = "SELECT * FROM LOAIDOCGIA";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        // Thêm mới đọc giả
        public void Create(int type, string name, string sex, string address, string numphone)
        {
            string sql = string.Format("INSERT INTO DOCGIA (MALOAIDG, TENDG, GIOITINH, DIACHI, SDT) VALUES ({0}, N'{1}', N'{2}', N'{3}', '{4}')", type, name, sex, address, numphone);
            db.ExecuteNonQuery(sql);
        }

        // Chỉnh sửa đọc giả
        public void Edit(int id, int type, string name, string sex, string address, string numphone)
        {
            string sql = string.Format("UPDATE DOCGIA SET MALOAIDG = {0}, TENDG = N'{1}', GIOITINH = N'{2}', DIACHI = N'{3}', SDT = '{4}' WHERE MADG = {5}", type, name, sex, address, numphone, id);
            db.ExecuteNonQuery(sql);
        }

        // Xóa đọc giả
        public void Delete(int id)
        {
            string sql = string.Format("DELETE FROM DOCGIA WHERE MADG = {0}", id);
            db.ExecuteNonQuery(sql);
        }

        // Tìm đọc giả theo tên
        public DataTable Search(int id)
        {
            string sql = "SELECT DOCGIA.MADG, DOCGIA.TENDG, DOCGIA.GIOITINH, LOAIDOCGIA.TENLOAIDG, DOCGIA.DIACHI, DOCGIA.SDT " +
                   "FROM DOCGIA, LOAIDOCGIA " +
                   "WHERE DOCGIA.MALOAIDG = LOAIDOCGIA.MALOAIDG AND DOCGIA.MADG = '"+ id +"' ";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        // Tìm đọc giả theo loại
        public DataTable Search(string name)
        {
            string sql = "SELECT DOCGIA.MADG, DOCGIA.TENDG, DOCGIA.GIOITINH, LOAIDOCGIA.TENLOAIDG, DOCGIA.DIACHI, DOCGIA.SDT " +
                   "FROM DOCGIA, LOAIDOCGIA " +
                   "WHERE DOCGIA.MALOAIDG = LOAIDOCGIA.MALOAIDG AND DOCGIA.TENDG LIKE N'%" + name + "%' ";
            db.Execute(sql);
            return db.ds.Tables[0];
        }
    }
}
