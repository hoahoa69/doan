using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quan_Ly_Ban_Hang
{
    public partial class fQLDMthanhpho : Form
    {


        public fQLDMthanhpho()
        {
            InitializeComponent();
            connect();
        }

        private void fQLDMthanhpho_Load(object sender, EventArgs e)
        {

        
        }
        bool Them;
        public void connect()
        {

            String Strconnection = @"Data Source=.\SQLEXPRESS;Initial Catalog=quanlybanhang;Integrated Security=True";
            SqlConnection connect = new SqlConnection(Strconnection);
            SqlDataAdapter daThanhPho = null;

            try
            {
                 daThanhPho = new SqlDataAdapter("SELECT * FROM dbo.ThanhPho", connect);
                DataTable dtThanhPho = new DataTable();
                dtThanhPho.Clear();
                daThanhPho.Fill(dtThanhPho);
                dtgvThanhPho.DataSource = dtThanhPho;
                dtgvThanhPho.AutoResizeColumns();
                this.txtThanhPho.ResetText();
                this.txtTenThanhPho.ResetText();
                this.btnCancel.Enabled = false;
                this.btnSave.Enabled = false;
                this.panel.Enabled = false;
            }
            catch(SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong  table THANHPHO.Lỗi rồi!!!");


            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            connect();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Them = true;
            
            this.txtThanhPho.ResetText();
            this.txtTenThanhPho.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnBack.Enabled = false;
            // Đưa con trỏ đến TextField txtThanhPho
            this.txtThanhPho.Focus();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            // Thứ tự dòng hiện hành
            int r = dtgvThanhPho.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtThanhPho.Text = dtgvThanhPho.Rows[r].Cells[0].Value.ToString();
            this.txtTenThanhPho.Text = dtgvThanhPho.Rows[r].Cells[1].Value.ToString();
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnBack.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH
            this.txtThanhPho.Focus();

        }
    }
}
