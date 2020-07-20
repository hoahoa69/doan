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
    public partial class fWelcome : Form
    {
        public fWelcome()
        {
            InitializeComponent();
          
        }
        private void btnGo_Click(object sender, EventArgs e)
        {

            Form Login = new fLogin();
            Login.ShowDialog();
        

        }

    }
}
