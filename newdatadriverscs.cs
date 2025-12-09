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
    public partial class newdatadriverscs : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["condb"].ConnectionString;
        public newdatadriverscs()
        {
            InitializeComponent();
        }

        private void newdatadriverscs_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            newdata frm3 = new newdata();
            frm3.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           

            Image ppimgg = pictureLicenceFront.Image;
            ImageConverter Converterrr = new ImageConverter();
            var ImageConverttt = Converterrr.ConvertTo(ppimgg, typeof(byte[]));

            Image pppimgg = pictureLicenceBack.Image;
            ImageConverter Converterrrr = new ImageConverter();
            var ImageConvertttt = Converterrrr.ConvertTo(pppimgg, typeof(byte[]));

            Image pimg = pictureIDfront.Image;
            ImageConverter Converter = new ImageConverter();
            var ImageConvert = Converter.ConvertTo(pimg, typeof(byte[]));

            Image pimgg = pictureIDback.Image;
            ImageConverter Converterr = new ImageConverter();
            var ImageConvertt = Converterr.ConvertTo(pimgg, typeof(byte[]));

            Image pppiimgg = pictureCriminal.Image;
            ImageConverter Converterrrrr = new ImageConverter();
            var ImageConverttttt = Converterrrrr.ConvertTo(pppiimgg, typeof(byte[]));

            using (SqlConnection con = new SqlConnection(connstring))
            {
                con.Open();
                string sql = "INSERT INTO Drivers ([Name], [Address], [Age], [National ID], [Copy of licence (front)], [Copy of licence (back)], [Copy of ID card (front)], [Copy of ID card (back)], [Copy of criminal records certificate], [Previous experience necessary]) " +
                             "VALUES (@Name, @Address, @Age, @NationalID, @LicenceFront, @LicenceBack, @IDFront, @IDBack, @CriminalRecords, @Experience)";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@NationalID", txtNationalID.Text);
                    cmd.Parameters.AddWithValue("@LicenceFront", ImageConverttt);
                    cmd.Parameters.AddWithValue("@LicenceBack", ImageConvertttt);
                    cmd.Parameters.AddWithValue("@IDFront", ImageConvert);
                    cmd.Parameters.AddWithValue("@IDBack", ImageConvertt);
                    cmd.Parameters.AddWithValue("@CriminalRecords", ImageConverttttt);
                    cmd.Parameters.AddWithValue("@Experience", txtExperience.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Added Successfully");
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtAge.Text = "";
            txtNationalID.Text = "";
            pictureLicenceFront.Image = null;
            pictureLicenceBack.Image = null;
            pictureIDfront.Image = null;
            pictureIDback.Image = null;
            pictureCriminal.Image = null;
            txtExperience.Text = "";
        }

        private void btnInsertPhoto_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog ofdlggg = new OpenFileDialog();
            ofdlggg.Title = "Open Image";
            ofdlggg.Filter = "Image Files(*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF";
            if (ofdlggg.ShowDialog() == DialogResult.OK)
            {
                pictureLicenceFront.Image = Image.FromFile(ofdlggg.FileName);

            }
            OpenFileDialog oofdlggg = new OpenFileDialog();
            oofdlggg.Title = "Open Image";
            oofdlggg.Filter = "Image Files(*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF";
            if (oofdlggg.ShowDialog() == DialogResult.OK)
            {
                pictureLicenceBack.Image = Image.FromFile(oofdlggg.FileName);

            }
            OpenFileDialog ofdlg = new OpenFileDialog();
            ofdlg.Title = "Open Image";
            ofdlg.Filter = "Image Files(*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF";
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                pictureIDfront.Image = Image.FromFile(ofdlg.FileName);

            }
            OpenFileDialog ofdlgg = new OpenFileDialog();
            ofdlgg.Title = "Open Image";
            ofdlgg.Filter = "Image Files(*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF";
            if (ofdlgg.ShowDialog() == DialogResult.OK)
            {
                pictureIDback.Image = Image.FromFile(ofdlgg.FileName);

            }
            OpenFileDialog ooofdlggg = new OpenFileDialog();
            ooofdlggg.Title = "Open Image";
            ooofdlggg.Filter = "Image Files(*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF";
            if (ooofdlggg.ShowDialog() == DialogResult.OK)
            {
                pictureCriminal.Image = Image.FromFile(ooofdlggg.FileName);

            }

        }

        private void pictureIDback_Click(object sender, EventArgs e)
        {

        }

        private void pictureCriminal_Click(object sender, EventArgs e)
        {

        }

        private void newdatadrivers_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
