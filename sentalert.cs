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
    public partial class sentalert : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["condb"].ConnectionString;
        public sentalert()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            schoolsystems frm30= new schoolsystems();
            frm30.Show();
        }
        private void bind_data6()
        {
            using (SqlConnection onnn = new SqlConnection(connstring))
            {
                onnn.Open();
                SqlDataAdapter ssDaaa = new SqlDataAdapter("SELECT * FROM Alerts", onnn);
                DataTable dddttt0 = new DataTable();
                ssDaaa.Fill(dddttt0);
                dataGridView6.DataSource = dddttt0;
            }
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sentalert_Load(object sender, EventArgs e)
        {
            bind_data6();
        }
    }
}
