using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Ban_Hang
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

 

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(this.txtLogin.Text =="admin" && this.txtPassWord.Text=="root")
            {
                Form fMain = new fMain();
                fMain.ShowDialog();            }
            else
            {
                MessageBox.Show("Không đúng tên người dùng hoặc mật khẩu !!!", "Thông báo");
                this.txtLogin.Focus();


            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn Có chắc muốn thoát chương trình không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();

        }
    }
}
