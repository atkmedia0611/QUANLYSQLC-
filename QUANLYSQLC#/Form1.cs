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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           if( MessageBox.Show("Bạn có muốn thoát không?" ,"thông báo", MessageBoxButtons.OKCancel) !=  System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            table f = new table();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
