using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Class
{
    class Note
    {
        ConnectionDB db;
        public Note()
        {
            db = new ConnectionDB();
        }
        public DataTable listNote()
        {
            string sql = "SELECT PHIEUMUON.STT_PHIEU, DOCGIA.TENDG, NHANVIEN.TENNV " + 
                "FROM PHIEUMUON, DOCGIA, NHANVIEN " +
                "WHERE PHIEUMUON.MADG = DOCGIA.MADG AND PHIEUMUON.MANV = NHANVIEN.MANV";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        public DataTable listReader()
        {
            string sql = "SELECT * FROM DOCGIA";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        public DataTable listEmployee()
        {
            string sql = "SELECT * FROM NHANVIEN";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        // Thêm mới phiếu mượn
        public void Create(int readerID, int employeeID)
        {
            string sql = string.Format("INSERT INTO PHIEUMUON (MADG, MANV) VALUES ({0}, {1})", readerID, employeeID);
            db.ExecuteNonQuery(sql);
        }

        // Chỉnh sửa phiếu mượn
        public void Edit(int stt, int readerID, int employeeID)
        {
            string sql = string.Format("UPDATE PHIEUMUON SET MADG = {0}, MANV = {1} WHERE STT_PHIEU = {2}", readerID, employeeID, stt);
            db.ExecuteNonQuery(sql);
        }

        // Xóa phiếu mượn
        public void Delete(int stt)
        {
            string sql = string.Format("DELETE FROM PHIEUMUON WHERE STT_PHIEU = {0}", stt);
            db.ExecuteNonQuery(sql);
        }
    }
}
