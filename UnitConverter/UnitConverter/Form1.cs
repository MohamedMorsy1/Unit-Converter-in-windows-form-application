using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value;

            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Only numbers are allowed.");
                textBox1.Text.Remove(textBox1.Text.Length - 1);
            }

            else if (textBox1.Text.Length == 0) MessageBox.Show("Enter a value to convert.");



            else
            {

                value = Double.Parse(textBox1.Text);

                /////////////////////////




                if (listBox1.SelectedItem == listBox2.SelectedItem)
                {
                    textBox2.Text = textBox1.Text;
                }

                if (listBox1.SelectedItem == "ft" && listBox2.SelectedItem == "inches")
                {

                    textBox2.Text = (value * 12).ToString();
                }

                if (listBox1.SelectedItem == "inches" && listBox2.SelectedItem == "ft")
                {

                    textBox2.Text = (value / 12).ToString();
                }

                if (listBox1.SelectedItem == "yard" && listBox2.SelectedItem == "ft")
                {

                    textBox2.Text = (value * 3).ToString();
                }

                if (listBox1.SelectedItem == "ft" && listBox2.SelectedItem == "yard")
                {

                    textBox2.Text = (value / 3).ToString();
                }

                if (listBox1.SelectedItem == "yard" && listBox2.SelectedItem == "inches")
                {

                    textBox2.Text = (value * 36).ToString();
                }

                if (listBox1.SelectedItem == "inches" && listBox2.SelectedItem == "yard")
                {

                    textBox2.Text = (value / 36).ToString();
                }







                if (listBox1.SelectedItem == "inches" && listBox2.SelectedItem == "m")
                {

                    textBox2.Text = (value / 39.370).ToString();
                }

                if (listBox1.SelectedItem == "m" && listBox2.SelectedItem == "inches")
                {

                    textBox2.Text = (value * 39.370).ToString();
                }

                if (listBox1.SelectedItem == "m" && listBox2.SelectedItem == "ft")
                {

                    textBox2.Text = (value * 3.2808).ToString();
                }

                if (listBox1.SelectedItem == "ft" && listBox2.SelectedItem == "m")
                {

                    textBox2.Text = (value / 3.2808).ToString();
                }

                if (listBox1.SelectedItem == "m" && listBox2.SelectedItem == "yard")
                {

                    textBox2.Text = (value * 1.0936).ToString();
                }

                if (listBox1.SelectedItem == "yard" && listBox2.SelectedItem == "m")
                {

                    textBox2.Text = (value / 1.0936).ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
