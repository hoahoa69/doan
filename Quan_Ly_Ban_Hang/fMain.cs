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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Login = new fLogin();
            Login.ShowDialog();
        }
         public void XemDanhMuc(int intDanhMuc)
        {
           Form fXemDanhMuc = new fXemDanhMuc();
            fXemDanhMuc.Text = intDanhMuc.ToString();
            fXemDanhMuc.ShowDialog();
        }

        private void danhMụcThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(1);
        }

        private void danhMụcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XemDanhMuc(2);
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(3);
        }

        private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(4);
        }

        private void danhMụcHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(5);
        }
        private void danhMụcToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            XemDanhMuc(6);
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form fQLDMthanhpho = new fQLDMthanhpho();
            fQLDMthanhpho.ShowDialog();
        }
    }
}
