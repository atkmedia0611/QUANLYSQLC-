using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYSQLC_
{
    public partial class table : Form
    {
        public table()
        {
            InitializeComponent();
        }

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trangcanhan f = new trangcanhan();
            f.ShowDialog();
        }

        private void admimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fadmin f = new fadmin();
            f.ShowDialog();
        }
    }
}
