using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Docking2
{
    public partial class FormGrid : Form
    {
        // khai báo connect sql
        string connection = @"Data Source=DESKTOP;Initial Catalog=Asoft_Demo;User ID=sa;Password=sapassword";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable data = new DataTable();
        FormCreate formToOpen1;
        string txtMa = null;
        string txtName = null;
        string txtPass = null;
        string txtEmail = null;
        string txtTel = null;
        public FormGrid()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load lai grid
            this.nguoiDungTableAdapter.Fill(this.asoft_DemoDataSet.NguoiDung);

        }

        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formToOpen = new FormCreate();
            formToOpen.OnClodeModal += loadNewData;
            // Hiển thị Form
            formToOpen.Show();
        }
        private void loadNewData(object sender, EventArgs e)
        {
            loadData();
        }
        private void capNhatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formToOpen1 == null || formToOpen1.IsDisposed)
            {
                formToOpen1 = new FormCreate();
            }
            formToOpen1.Show();
        }

        private void c1FlexGrid1_CellButtonClick(object sender, EventArgs e)
        {
            int row = c1FlexGrid1.Row;
            if (formToOpen1 == null || formToOpen1.IsDisposed)
            {
                formToOpen1 = new FormCreate();
            }
            try
            {
                txtMa = c1FlexGrid1[row, "UserID"].ToString();
                // set textBox vào formCreate khi nhấn chọn dòng của gridNhanVien
                formToOpen1.SetTxtMaNVValue(c1FlexGrid1[row, "UserID"].ToString());
                formToOpen1.SetTxtTenNV2(c1FlexGrid1[row, "UserName"].ToString());
                formToOpen1.SetTxtEmailValue(c1FlexGrid1[row, "Email"].ToString());
                formToOpen1.SetTxtSDTValue(c1FlexGrid1[row, "Tel"].ToString());
                formToOpen1.SetTxtMKValue(c1FlexGrid1[row, "Password"].ToString());
                formToOpen1.SetTxtNhapLaiMKValue(c1FlexGrid1[row, "Password"].ToString());
                formToOpen1.SetBtnCapNhat("Cập nhật", btnCapNhatFormCreate);
                // ẩn nút nhập lại
                formToOpen1.SetButtonDisnable();
            }
            catch (Exception ex)
            {
                txtMa = "";
            }

        }


        // Xử lý sự kiện Click Cập nhật của form2
        private void btnCapNhatFormCreate(object sender, EventArgs e)
        {
            txtName = formToOpen1.GetTxtTenValue();
            txtEmail = formToOpen1.GetTxbEmailValue();
            txtTel = formToOpen1.GetTxbSDTValue3();
            txtPass = formToOpen1.GetTxbMKValue();
            con = new SqlConnection(connection);
            con.Open();

            //câu lệnh update
            string sqlInsert2 = ("update NguoiDung set UserName=N'" + txtName + "', Email=N'" + txtEmail + "', Tel=N'" + txtTel + "', Password='" + txtPass + "', Disable=1 where UserID= N'" + txtMa + "'");

            cmd = new SqlCommand(sqlInsert2, con);
            cmd.ExecuteNonQuery();
            con.Close();

            
            // tắt formCreate
            formToOpen1.Close();
            loadData();
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                con = new SqlConnection(connection);
                con.Open();

                string sqlInsert = ("delete from NguoiDung where UserID='" + txtMa + "'");
                cmd = new SqlCommand(sqlInsert, con);
                cmd.ExecuteNonQuery();

                con.Close();
                //load lại grid khi đã xóa dòng
                loadData();
            }
        }

        public void loadData()
        {
            con = new SqlConnection(connection);
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from NguoiDung", con);
                adapter = new SqlDataAdapter(cmd);
                data = new DataTable(); // Initialize data DataTable
                adapter.Fill(data);
                c1FlexGrid1.DataSource = data;
                // Ẩn cột "Password" nếu nó tồn tại
                if (c1FlexGrid1.Cols.Contains("Password"))
                {
                    c1FlexGrid1.Cols["Password"].Visible = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close(); // Always close the connection, whether an exception occurs or not
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
