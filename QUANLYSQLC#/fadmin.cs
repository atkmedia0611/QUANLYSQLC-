using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYSQLC_
{
    public partial class fadmin : Form
    {
        public fadmin()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void fadmin_Load(object sender, EventArgs e)
        {
            InitializeComponent();

            LoadAccountlist();
        }
        void LoadAccountlist()
        { 
            String connectionSTR = "Data Source=CONHANH-1310;Initial Catalog=QLBHCAFE;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            //ket noi client
            String Query = "SELECT * FROM dbo.Accout";

            connection.Open();

            SqlCommand command = new SqlCommand(Query, connection);
            //truy van du lieu
            DataTable data = new DataTable();

            SqlDataAdapter Adapter = new SqlDataAdapter(command);
            //truy van lay du lieu
            Adapter.Fill(Data);

            connection.Close();

            dtgvaccout.DataSource = data;
        }
    }
}
