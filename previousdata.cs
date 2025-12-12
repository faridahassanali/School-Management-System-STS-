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
    public partial class previousdata : Form
    {
        public previousdata()
        {
            InitializeComponent();
        }

        private void previousdata_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            welcomeform frm9 = new welcomeform();
            frm9.Show();
        }

        private void btnNewDrivers_Click(object sender, EventArgs e)
        {
            previousdatadrivers frm10 = new previousdatadrivers();
            frm10.Show();
            this.Close();
        }

        private void btnPreSupervisors_Click(object sender, EventArgs e)
        {
            previousdatasupervisors frm12 = new previousdatasupervisors();
            frm12.Show();
            this.Close();
        }

        private void btnPreBuses_Click(object sender, EventArgs e)
        {
            previousdatabuses frm14 = new previousdatabuses();
            frm14.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scheduling frm16 = new scheduling();
            frm16.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
