using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Xml.Linq;

namespace StudentProfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox7.Text = openFileDialog.FileName; // Show file path in TextBox
                pictureBox1.Image = new Bitmap(openFileDialog.FileName); // Display the image
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust size
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear text boxes
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox7.Text = "";

            // Reset radio buttons
            radioButton1.Checked = radioButton2.Checked = false;

            // Clear PictureBox
            pictureBox1.Image = null;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Collect data from input fields
            string name = textBox1.Text, roll = textBox2.Text, regID = textBox3.Text, semester = textBox4.Text, bloodGroup = textBox5.Text, gender = radioButton1.Checked ? "Male" : "Female", photoPath = textBox7.Text;

            // Open Form2 and pass the collected data
            Form2 form2 = new Form2(name, roll, regID, semester, bloodGroup, gender, photoPath);
            form2.Show();

            // Hide Form1 (optional)
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
