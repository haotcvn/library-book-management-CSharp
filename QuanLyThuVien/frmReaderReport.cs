using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmReaderReport : Form
    {
        public frmReaderReport()
        {
            InitializeComponent();
        }

        private void frmReaderReport_Load(object sender, EventArgs e)
        {
            this.option();
            this.reportViewer1.RefreshReport();
        }

        void option()
        {
            this.cboOption.Items.Add("Tất độc giả");
            this.cboOption.Items.Add("Độc giả đang mượn sách");
            this.cboOption.Items.Add("Độc giả mượn sách quá hạn");
        }
    }
}
