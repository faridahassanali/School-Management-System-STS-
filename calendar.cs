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
    public partial class calendar : Form
    {
        public calendar()
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
            welcomeform frm33=new welcomeform();
            frm33.Show();
        }

        private void calendar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
