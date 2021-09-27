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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThemHang add = new frmThemHang();
            add.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmBanHang bh = new frmBanHang();
            bh.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
           
        }

        private void button18_Click(object sender, EventArgs e)
        {
            EditProduct smh = new EditProduct();
            smh.ShowDialog();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AddProduct tmh = new AddProduct();
            tmh.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            EditProduct smh = new EditProduct();
            smh.ShowDialog();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có chắc chắn muốn xóa mặt hàng không?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
