using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Class
{
    class ConnectionDB
    {
        SqlConnection conn; // Đối tượng kết nối CSDL
        public SqlDataAdapter da; // Bộ điều phối dữ liệu
        public DataSet ds; // Đối tượng chưa CSDL khi giáo tiếp

        public ConnectionDB()
        {
            //Integrated security
            string strconn = @"Data Source = .\SQLEXPRESS; Database = QuanLyThuVien; Integrated security = True";
            conn = new SqlConnection(strconn);
        }

        // Phương thức mở kết nối
        public void openConnection() 
        {
            if (conn.State == ConnectionState.Closed) //kiểm tra nếu trường hợp chưa kết nối thì mở kêt nối
            {
                conn.Open();
            }
        }

        // Phương thức đóng kết nối
        public void closeConnection()//kiểm tra nếu trường hợp mở kết nối thì đóng kêt nối
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }

        // Phương thức thực hiện lệnh strSQL truy vấn
        public DataTable Execute(string sql)
        {
            openConnection();
            try 
            {
                ds = new DataSet();
                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds);
            }
            catch
            {
                ds = null;
            }
            closeConnection();
            return ds.Tables[0];
        }

        // Phương thức thực hiện thêm, sửa, xóa
        public void ExecuteNonQuery(string sql)
        {
            try 
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                openConnection();
                cmd.ExecuteNonQuery();//Lenh hien lenh Them/Xoa/Sua
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            closeConnection();
        }
    }
}
