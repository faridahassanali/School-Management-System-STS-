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
    public partial class students : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["condb"].ConnectionString;
        public students()
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
            schoolsystems frm23= new schoolsystems();   
            frm23.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            newdatastudent frm24=new newdatastudent();
            frm24.Show();
            this.Close();
        }
        private void bind_data5()
        {
            using (SqlConnection oonnn = new SqlConnection(connstring))
            {
                oonnn.Open();
                SqlDataAdapter sslDaaa = new SqlDataAdapter("SELECT * FROM Students", oonnn);
                DataTable dddttt = new DataTable();
                sslDaaa.Fill(dddttt);
                dataGridView5.DataSource = dddttt;
            }
        }

        private void students_Load(object sender, EventArgs e)
        {
            bind_data5();
        }
    }
}
