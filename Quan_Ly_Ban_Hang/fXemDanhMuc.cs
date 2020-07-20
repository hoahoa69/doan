using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Ban_Hang
{
    public partial class fXemDanhMuc : Form
    {
        public fXemDanhMuc()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fXemDanhMuc_Load(object sender, EventArgs e)
        {
            connectdb();
        }
        private void connectdb()
        {
          
            String Strconnection = @"Data Source=.\SQLEXPRESS;Initial Catalog=quanlybanhang;Integrated Security=True";
            SqlConnection connect = new SqlConnection(Strconnection);
            SqlDataAdapter daTable = null;
            try
            {
               
                string intDM = this.Text;
                switch (intDM)
                {
                    case "1":
                        lbDanhMuc.Text = "Danh mục Thành phố";
                        daTable = new SqlDataAdapter("SELECT * FROM dbo.ThanhPho", connect);
                        break;
                    case "2":
                        lbDanhMuc.Text = "Danh mục Khách hàng"; daTable = new SqlDataAdapter("SELECT * FROM dbo.KhachHang", connect);
                        break;
                    case "3":
                        lbDanhMuc.Text = "Danh mục Nhân viên";
                        daTable = new SqlDataAdapter("SELECT * FROM dbo.NhanVien", connect);
                        break;
                    case "4":
                        lbDanhMuc.Text = "Danh mục Sản phẩm";
                        daTable = new SqlDataAdapter("SELECT * FROM dbo.SanPham", connect);
                        break;
                    case "5":
                        lbDanhMuc.Text = "Danh mục Hóa đơn";
                        daTable = new SqlDataAdapter("SELECT * FROM dbo.HoaDon", connect);
                        break;
                    case "6":
                        lbDanhMuc.Text = "Danh mục Chi tiết Hóa đơn"; daTable = new SqlDataAdapter("SELECT * FROM dbo.ChiTietHoaDon", connect);
                        break;
                    default:
                        break;
                }

                // Vận chuyển dữ liệu lên DataTable dtTable
                DataTable dtTable = new DataTable();
                dtTable.Clear();
                daTable.Fill(dtTable);
                // Đưa dữ liệu lên DataGridView
                dtgvDM.DataSource = dtTable;
                // Thay đổi độ rộng cột
                dtgvDM.AutoResizeColumns();

            }
            catch (SqlException)
            {
                MessageBox.Show("Error");
               
            }
    }

        private void btn_Xemdanhmuc_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
