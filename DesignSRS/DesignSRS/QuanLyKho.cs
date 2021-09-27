using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignSRS
{
    public partial class QuanLyKho : Form
    {
        public QuanLyKho()
        {
            InitializeComponent();
        }

        private void QuanLyKho_Load(object sender, EventArgs e)
        {

        }

        private void iconBtnSua_Click(object sender, EventArgs e)
        {
            EditProduct ed = new EditProduct();
            ed.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconBtnThem_Click(object sender, EventArgs e)
        {
            AddProduct a = new AddProduct();
            a.ShowDialog();
        }

        private void iconBtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dal;
            dal = MessageBox.Show("Bạn có chắc chắn muốn xóa hay không?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dal == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
