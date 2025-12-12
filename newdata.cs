using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS
{
    public partial class newdata : Form
    {
        public newdata()
        {
            InitializeComponent();
        }

        private void newdata_Load(object sender, EventArgs e)
        {

        }

        private void C_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            welcomeform frm1 = new welcomeform();
            frm1.Show();
        }

        private void btnNewDrivers_Click(object sender, EventArgs e)
        {
            newdatadriverscs frm2 = new newdatadriverscs();
            frm2.Show();
            this.Hide();
        }

        private void btnNewSupervisors_Click(object sender, EventArgs e)
        {
            newdatasupervisors frm4=new newdatasupervisors();
            frm4.Show();
            this.Hide();
        }

        private void btnNewBuses_Click(object sender, EventArgs e)
        {
            newdatabuses frm6 = new newdatabuses();
            frm6.Show();
            this.Hide();
        }
    }
}
