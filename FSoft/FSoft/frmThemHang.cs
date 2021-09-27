using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSoft
{
    public partial class frmThemHang : Form
    {
        public frmThemHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNhap nhap = new frmNhap();
            nhap.ShowDialog();
        }
    }
}
