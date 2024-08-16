using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Display "Hello, World!" when the form loads
            MessageBox.Show("Hello, World!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            MessageBox.Show($"Nice to meet you, {name}!");
        }
    }
}
