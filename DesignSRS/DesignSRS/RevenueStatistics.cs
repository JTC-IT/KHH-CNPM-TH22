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
    public partial class RevenueStatistics : Form
    {
        public RevenueStatistics()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            HistoryImport_Export hie = new HistoryImport_Export();
            hie.ShowDialog();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            HistoryIncome_Spend his = new HistoryIncome_Spend();
            his.ShowDialog();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ReportMonth pm = new ReportMonth();
            pm.ShowDialog();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            RecentActivity ra = new RecentActivity();
            ra.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
