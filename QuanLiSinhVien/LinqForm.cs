using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien
{
    public partial class LinqForm : Form
    {
        public LinqForm()
        {
            InitializeComponent();
        }

        private void LinqForm_Load(object sender, EventArgs e)
        {
            DataClassesSinhVienDataContext db = new DataClassesSinhVienDataContext();
            Table<sinhvien> sv = db.GetTable<sinhvien>();
            var query = from sv1 in sv select sv1;
            dataGridView1.DataSource = query;
        }
    }
}
