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
    public partial class schoolsystems : Form
    {
        public schoolsystems()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            welcomeform frm21= new welcomeform();
            frm21.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewDrivers_Click(object sender, EventArgs e)
        {
            students frm22= new students();
            frm22.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sentalert frm29= new sentalert();
            frm29.Show();
            this.Close();
        }
    }
}
