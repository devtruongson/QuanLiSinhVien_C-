using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien
{
    public partial class Form1 : Form
    {
        private int position = 0;
        private DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showData("select * from sinhvien");

        }

        public SqlConnection connectDB()
        {
            string connectSQL = "Data Source=(local);Initial Catalog=qlsinhvien15a10;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectSQL);
            return connection;
        }

        public void showData(string query)
        {
            txtMaSV.ReadOnly = false;
            demSinhVien(false);
            try
            {
                SqlConnection connection = connectDB();
                connection.Open();
                SqlDataAdapter result = new SqlDataAdapter(query, connection);
                this.ds = new DataSet();
                result.Fill(ds);
                gridView.Columns[0].HeaderText = "Mã Sinh Viên";
                gridView.Columns[1].HeaderText = "Họ Và Tên";
                gridView.Columns[2].HeaderText = "Giới Tính";
                gridView.Columns[2].Width = 80;
                gridView.Columns[3].HeaderText = "Quê Quán";
                gridView.Columns[4].HeaderText = "Mã Lớp";
                gridView.DataSource = ds.Tables[0];
                setDataForTextBox(ds);
                result.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
            }
        }


        public void resetFiled()
        {
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            txtQueQuan.Text = "";
            txtMaLop.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string goiTinh = "";
            if (rdoNam.Checked)
            {
                goiTinh = "Nam";
            }
            else
            {
                goiTinh = "Nu";
            }
            if (string.IsNullOrEmpty(txtMaSV.Text) || string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(goiTinh) || string.IsNullOrEmpty(txtQueQuan.Text) || string.IsNullOrEmpty(txtMaLop.Text))
            {
                MessageBox.Show("Ban Hay Nhap Day Du Cac Truong!");
                return;
            }

            try
            {
                string sql = "insert into sinhvien values(@masv, @hoten, @gioitinh, @quequan, @malop)";
                SqlConnection connection = connectDB();
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);


                command.Parameters.AddWithValue("@masv", txtMaSV.Text);
                command.Parameters.AddWithValue("@hoten", txtHoTen.Text);
                command.Parameters.AddWithValue("@gioitinh", goiTinh);
                command.Parameters.AddWithValue("@quequan", txtQueQuan.Text);
                command.Parameters.AddWithValue("@malop", txtMaLop.Text);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    resetFiled();
                    MessageBox.Show("Ban Da Them Thanh Cong Sinh Vien");
                    showData("select * from sinhvien");
                }
                else
                {
                    MessageBox.Show("Ban Ghi Chua Duoc Them!");
                }
                connection.Close();
                connection.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show("Trung Ma SV" + err);
            }
        }

        private void gridView_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = gridView.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = gridView.CurrentRow.Cells[1].Value.ToString();
            txtQueQuan.Text = gridView.CurrentRow.Cells[3].Value.ToString();
            txtMaLop.Text = gridView.CurrentRow.Cells[4].Value.ToString();
            txtMaSV.ReadOnly = true;
            string gioiTinh = gridView.CurrentRow.Cells[2].Value.ToString();

            if (gioiTinh.Equals("Nam") || gioiTinh.Equals("nam"))
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }
        }


        private void setDataForTextBox(DataSet ds)
        {
            if (ds != null)
            {
                txtMaSV.DataBindings.Add("text", ds.Tables[0], "masv");
                txtHoTen.DataBindings.Add("text", ds.Tables[0], "hoten");
                string gioiTinh = gridView.Rows[0].Cells["gioitinh"].Value.ToString();
                setGender(gioiTinh);
                txtQueQuan.DataBindings.Add("text", ds.Tables[0], "quequan");
                txtMaLop.DataBindings.Add("text", ds.Tables[0], "malop");
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

            string goiTinh = "";
            if (rdoNam.Checked)
            {
                goiTinh = "Nam";
            }
            else
            {
                goiTinh = "Nu";
            }
            if (string.IsNullOrEmpty(txtMaSV.Text) || string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(goiTinh) || string.IsNullOrEmpty(txtQueQuan.Text) || string.IsNullOrEmpty(txtMaLop.Text))
            {
                MessageBox.Show("Ban Hay Nhap Day Du Cac Truong!");
                return;
            }

            DialogResult resultDialog = MessageBox.Show("Bạn có chắc chắn muốn cap nhat?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.No)
            {
                return;
            }

            try
            {
                string sql = "update sinhvien set hoten = @hoten, gioitinh = @gioitinh, quequan = @quequan, malop =@malop where masv = @masv";
                SqlConnection connection = connectDB();
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@masv", txtMaSV.Text);
                command.Parameters.AddWithValue("@hoten", txtHoTen.Text);
                command.Parameters.AddWithValue("@gioitinh", goiTinh);
                command.Parameters.AddWithValue("@quequan", txtQueQuan.Text);
                command.Parameters.AddWithValue("@malop", txtMaLop.Text);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    resetFiled();
                    MessageBox.Show("Ban Da Cap Nhat Thanh Cong Sinh Vien");
                    showData("select * from sinhvien");
                }
                else
                {
                    MessageBox.Show("Ban Ghi Chua Duoc Cap Nhat!");
                }
                connection.Close();
                connection.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                MessageBox.Show("Ban Hay Nhap Day Du maSV!");
                return;
            }

            DialogResult resultDialog = MessageBox.Show("Bạn có chắc chắn muốn xoa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.No)
            {
                return;
            }

            try
            {
                string sql = "delete from sinhvien where masv = @masv";
                SqlConnection connection = connectDB();
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@masv", txtMaSV.Text);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    resetFiled();
                    MessageBox.Show("Ban Da Xoa Thanh Cong Sinh Vien");
                    showData("select * from sinhvien");
                }
                else
                {
                    MessageBox.Show("Ban Ghi Chua Duoc Xoa!");
                }
                connection.Close();
                connection.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng ứng dụng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDem_Click(object sender, EventArgs e)
        {
            demSinhVien(true);
        }

        public void demSinhVien(bool isShow)
        {
            try
            {
                string sql = "select count(*) from sinhvien";
                SqlConnection connection = connectDB();
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);

                Object count = command.ExecuteScalar();
                if (isShow)
                {
                    MessageBox.Show("Co tat ca " + count + " sinh vien!");
                }
                lblCount.Text = "Tổng Số Sinh Viên là: " + count;

                connection.Close();
                connection.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);

            }
        }

        private void setGender(string gt){
            if (gt.Equals("Nam") || gt.Equals("nam"))
            {
                rdoNam.Checked = true;
            }
            else { 
                rdoNu.Checked = true;
            }

        } 
        private void btnDoc_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from sinhvien";
                SqlConnection connection = connectDB();
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                String str = "";
                while(reader.Read())
                {
                    str += "MaSV: " +  reader.GetString(0).ToString() + ", ";
                    str += "Ho Ten: "  + reader.GetString(1).ToString() + ", ";
                    str += "Gioi Tinh: " + reader.GetString(2).ToString() + ", ";
                    str += "Dia Chi: " + reader.GetString(3).ToString() + ", ";
                    str += "Que Quan: "  + reader.GetString(4).ToString();
                    str += "r\n";
                }

                MessageBox.Show(str);

                connection.Close();
                connection.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);

            }
        }

        private void btnDemColumn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from sinhvien";
                SqlConnection connection = connectDB();
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();


                MessageBox.Show("Số lượng lolumn: " + reader.FieldCount);

                connection.Close();
                connection.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);

            }
        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            string value = gridView.CurrentCell.Value.ToString();
            MessageBox.Show(value);
            gridView.GridColor = Color.Red;
        }

        private void btnPrevLast_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds.Tables[0]].Position = 0;
            this.position = 0;
            string gioiTinh = gridView.Rows[0].Cells["gioitinh"].Value.ToString();
            setGender(gioiTinh);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int totalRecords = ds.Tables[0].Rows.Count;
            if (position == 0)
            {
                this.position = totalRecords - 1;
            }
            else
            {
                --this.position;
            }
            string gioiTinh = gridView.Rows[position].Cells["gioitinh"].Value.ToString();
            setGender(gioiTinh);
            this.BindingContext[ds.Tables[0]].Position = position;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalRecords = ds.Tables[0].Rows.Count;
            if (position < totalRecords - 1)
            {
                ++this.position;
                string gioiTinh = gridView.Rows[position].Cells["gioitinh"].Value.ToString();
                setGender(gioiTinh);
                this.BindingContext[ds.Tables[0]].Position = position;
            }
            else
            {
                this.position = 0;
                string gioiTinh = gridView.Rows[position].Cells["gioitinh"].Value.ToString();
                setGender(gioiTinh);
                this.BindingContext[ds.Tables[0]].Position = position;
            }
           
        }

        private void btnNextLast_Click(object sender, EventArgs e)
        {
            int totalRecords = ds.Tables[0].Rows.Count;
            this.BindingContext[ds.Tables[0]].Position = totalRecords - 1;
            this.position = totalRecords - 1;
            string gioiTinh = gridView.Rows[position].Cells["gioitinh"].Value.ToString();
            setGender(gioiTinh);
        }
    }
}
