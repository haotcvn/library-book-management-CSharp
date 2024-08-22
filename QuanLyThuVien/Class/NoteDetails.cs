using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Class
{
    class NoteDetails
    {
        ConnectionDB db;
        public NoteDetails()
        {
            db = new ConnectionDB();
        }
        public DataTable listNoteDetails()
        {
            string sql = "SELECT CHITIETPHIEUMUON.STT_PHIEU, SACH.TENSACH, CHITIETPHIEUMUON.NGAYMUON, CHITIETPHIEUMUON.NGAYTRA, CHITIETPHIEUMUON.SOLUONG, CHITIETPHIEUMUON.GHICHU " +
                "FROM CHITIETPHIEUMUON, PHIEUMUON, SACH " +
                "WHERE CHITIETPHIEUMUON.STT_PHIEU = PHIEUMUON.STT_PHIEU AND CHITIETPHIEUMUON.MASACH = SACH.MASACH";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        public DataTable listNoteM()
        {
            string sql = "SELECT * FROM PHIEUMUON";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        public DataTable listBook()
        {
            string sql = "SELECT * FROM SACH";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        // Mượn sách
        public void Create(int stt, int bookID, string dateStart, string dateEnd, int quantity, string notes)
        {
            string sql = string.Format("INSERT INTO CHITIETPHIEUMUON (STT_PHIEU, MASACH, NGAYMUON, NGAYTRA, SOLUONG, GHICHU) VALUES ({0}, {1}, '{2}', '{3}', {4}, N'{5}')", stt, bookID, dateStart, dateEnd, quantity, notes);
            db.ExecuteNonQuery(sql);
        }

        // Gia hạn mượn
        public void Edit(int stt, int bookID, string dateStart, string dateEnd, int quantity, string notes)
        {
            string sql = string.Format("UPDATE CHITIETPHIEUMUON SET STT_PHIEU = {0}, MASACH = {1}, NGAYMUON = '{2}', NGAYTRA = '{3}', SOLUONG = {4}, GHICHU = N'{5}' WHERE STT_PHIEU = {6} AND MASACH = {7}", stt, bookID, dateStart, dateEnd, quantity, notes, stt, bookID);
            db.ExecuteNonQuery(sql);
        }

        // Trả sách đã mượn
        public void Delete(int stt, int id)
        {
            string sql = string.Format("DELETE FROM CHITIETPHIEUMUON WHERE STT_PHIEU = {0} AND MASACH = {1}", stt, id);
            db.ExecuteNonQuery(sql);
        }

        // Tìm phiếu mượn chi tiết
        public DataTable Search(int id)
        {
            string sql = string.Format("SELECT CHITIETPHIEUMUON.STT_PHIEU, SACH.TENSACH, CHITIETPHIEUMUON.NGAYMUON, CHITIETPHIEUMUON.NGAYTRA, CHITIETPHIEUMUON.SOLUONG, CHITIETPHIEUMUON.GHICHU " +
                "FROM CHITIETPHIEUMUON, PHIEUMUON, SACH " +
                "WHERE CHITIETPHIEUMUON.STT_PHIEU = PHIEUMUON.STT_PHIEU AND CHITIETPHIEUMUON.MASACH = SACH.MASACH AND CHITIETPHIEUMUON.STT_PHIEU = {0}", id);
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        public DataTable Search(string date)
        {
            string sql = string.Format("SELECT CHITIETPHIEUMUON.STT_PHIEU, SACH.TENSACH, CHITIETPHIEUMUON.NGAYMUON, CHITIETPHIEUMUON.NGAYTRA, CHITIETPHIEUMUON.SOLUONG, CHITIETPHIEUMUON.GHICHU " +
                "FROM CHITIETPHIEUMUON, PHIEUMUON, SACH " +
                "WHERE CHITIETPHIEUMUON.STT_PHIEU = PHIEUMUON.STT_PHIEU AND CHITIETPHIEUMUON.MASACH = SACH.MASACH AND CHITIETPHIEUMUON.NGAYMUON = '{0}'", date);
            db.Execute(sql);
            return db.ds.Tables[0];
        }
    }
}
