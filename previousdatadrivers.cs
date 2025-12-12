using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace STS
{
    public partial class previousdatadrivers : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["condb"].ConnectionString;
        public previousdatadrivers()
        {
            InitializeComponent();
        }

        private void previousdatadrivers_Load(object sender, EventArgs e)
        {
            bind_data();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void driversBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bind_data()
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Drivers", con);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousdata frm11 = new previousdata();
            frm11.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
