using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal num1;
            if (decimal.TryParse(textBox1.Text, out num1))
              
            {

                decimal ans = num1 * 3.14m;
                textBox2.Text = ans.ToString();

            }
            else
            {
                MessageBox.Show("That doesn't look like a Number to me...");
            }

        }
    }
}
