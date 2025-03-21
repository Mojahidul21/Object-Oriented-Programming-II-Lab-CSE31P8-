using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProfile
{
    public partial class Form2 : Form
    {
        public Form2(string name, string roll, string regID, string semester, string bloodGroup, string gender, string photoPath)
        {
            InitializeComponent();

            // Assign values to labels
            label1.Text = "Name: " + name;
            label2.Text = "Roll: " + roll;
            label3.Text = "Reg ID: " + regID;
            label4.Text = "Semester: " + semester;
            label5.Text = "Blood Group: " + bloodGroup;
            label6.Text = "Gender: " + gender;

            // Load Image if provided
            if (!string.IsNullOrEmpty(photoPath))
            {
                pictureBox1.Image = new Bitmap(photoPath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
