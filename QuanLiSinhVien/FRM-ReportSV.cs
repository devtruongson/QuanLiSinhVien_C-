using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien
{
    public partial class FRM_ReportSV : Form
    {
        public FRM_ReportSV()
        {
            InitializeComponent();
        }

        private void FRM_ReportSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlsinhvien15a10DataSet.sinhvien' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter1.Fill(this.qlsinhvien15a10DataSet.sinhvien);
            // TODO: This line of code loads data into the 'qlsinhvien15a10DataSet4.sinhvien' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter.Fill(this.qlsinhvien15a10DataSet4.sinhvien);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {


        }
    }
}
