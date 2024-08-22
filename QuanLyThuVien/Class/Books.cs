using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuanLyThuVien.Class
{
    public class Books
    {
        private int id { get; set; }
        private string name { get; set; }
        private int topic { get; set; }
        private int author { get; set; }
        private int publisher { get; set; }
        private int year { get; set; }
        private int numpage { get; set; }
        public int quantity { get; set; }
        public int Quantity
        {
            set { quantity = value; }
            get { return quantity; }
        }
        ConnectionDB db;
        public Books()
        {
            db = new ConnectionDB();
        }
        public Books(int id, string name, int topic, int author, int publisher, int year, int numpage, int quantity)
        {
            this.id = id;
            this.name = name;
            this.topic = topic;
            this.author = author;
            this.publisher = publisher;
            this.year = year;
            this.numpage = numpage;
            this.quantity = quantity;
        }

        // Tất cả sách trong thư viện
        public DataTable listBooks()
        {
            string sql = "SELECT SACH.MASACH, SACH.TENSACH, CHUDE.TENCD, TACGIA.TENTG, NHAXB.TENNXB, SACH.NAMXB, SACH.SOTRANG, SACH.SOLUONG " + 
                "FROM SACH, CHUDE, TACGIA, NHAXB " +
                "WHERE SACH.MACD = CHUDE.MACD AND SACH.MATG = TACGIA.MATG AND SACH.MANXB = NHAXB.MANXB";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        // Thống kê tất cả sách đang được mượn
        public DataTable listBooked()
        {
            string sql = "SELECT SACH.MASACH, SACH.TENSACH, CHUDE.TENCD, TACGIA.TENTG, NHAXB.TENNXB, SACH.NAMXB, SACH.SOTRANG, Sum(CHITIETPHIEUMUON.SOLUONG) as 'SOLUONG' " +
                        "FROM SACH, CHUDE, TACGIA, NHAXB, CHITIETPHIEUMUON " +
                        "WHERE SACH.MACD = CHUDE.MACD AND SACH.MATG = TACGIA.MATG AND SACH.MANXB = NHAXB.MANXB and CHITIETPHIEUMUON.MASACH = SACH.MASACH " +
                        "GROUP BY SACH.MASACH, SACH.TENSACH, CHUDE.TENCD, TACGIA.TENTG, NHAXB.TENNXB, SACH.NAMXB, SACH.SOTRANG";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        // Thống kê tất cả sách độc giả mượn đã quá hạn trả
        public DataTable listLimitBook()
        {
            string sql = "SELECT DOCGIA.TENDG, SACH.TENSACH, CHUDE.TENCD, TACGIA.TENTG, NHAXB.TENNXB, SACH.NAMXB, CHITIETPHIEUMUON.SOLUONG " +
                        "FROM DOCGIA, SACH, CHUDE, TACGIA, NHAXB, CHITIETPHIEUMUON, PHIEUMUON " +
                        "WHERE SACH.MACD = CHUDE.MACD AND SACH.MATG = TACGIA.MATG AND SACH.MANXB = NHAXB.MANXB AND CHITIETPHIEUMUON.MASACH = SACH.MASACH AND DATEDIFF(day,CHITIETPHIEUMUON.NGAYTRA,GETDATE()) >= 1 AND DOCGIA.MADG = PHIEUMUON.MADG AND PHIEUMUON.STT_PHIEU = CHITIETPHIEUMUON.STT_PHIEU";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        public DataTable listTopic()
        {
            string sql = "SELECT * FROM CHUDE";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        public DataTable listAuthor()
        {
            string sql = "SELECT * FROM TACGIA";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        public DataTable listPublisher()
        {
            string sql = "SELECT * FROM NHAXB";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        // Thêm mới sách
        public bool Create(Books book)
        {
            try 
            {
                string sql = string.Format("INSERT INTO SACH VALUES (N'{0}', {1}, {2}, {3}, {4}, {5}, {6})", book.name, book.topic, book.author, book.publisher, book.year, book.numpage, book.quantity);
                db.ExecuteNonQuery(sql);
            }
            catch
            {
                return false;
            }
            return true;
        }

        // Chỉnh sửa sách
        public void Edit(int id, string name, int topic, int author, int publisher, int year, int numpage, int quantity)
        {
            string sql = string.Format("UPDATE SACH SET TENSACH = N'{0}', MACD = {1}, MATG = {2}, MANXB = {3}, NAMXB = {4}, SOTRANG = {5}, SOLUONG  = {6} WHERE MASACH = {7}", name, topic, author, publisher, year, numpage, quantity, id);
            db.ExecuteNonQuery(sql);
        }

        // Xóa sách
        public void Delete(int id)
        {
            string sql = string.Format("DELETE FROM SACH WHERE MASACH = {0}", id);
            db.ExecuteNonQuery(sql);
        }

        // Tìm sách theo tên sách
        public DataTable Search(int id)
        {
            string sql = "SELECT SACH.MASACH, SACH.TENSACH, CHUDE.TENCD, TACGIA.TENTG, NHAXB.TENNXB, SACH.NAMXB, SACH.SOTRANG, SACH.SOLUONG " +
                        "FROM SACH, CHUDE, TACGIA, NHAXB " +
                        "WHERE SACH.MACD = CHUDE.MACD AND SACH.MATG = TACGIA.MATG AND SACH.MANXB = NHAXB.MANXB AND SACH.MASACH = '" + id + "'";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        // Tìm sách theo chủ đề
        public DataTable Search(string name)
        {
            string sql = "SELECT SACH.MASACH, SACH.TENSACH, CHUDE.TENCD, TACGIA.TENTG, NHAXB.TENNXB, SACH.NAMXB, SACH.SOTRANG, SACH.SOLUONG " +
                        "FROM SACH, CHUDE, TACGIA, NHAXB " +
                        "WHERE SACH.MACD = CHUDE.MACD AND SACH.MATG = TACGIA.MATG AND SACH.MANXB = NHAXB.MANXB AND SACH.TENSACH LIKE N'%" + name + "%'";
            db.Execute(sql);
            return db.ds.Tables[0];
        }

        // Export
        public void ExportExcel(string path)
        {
            
        }
    }
}
