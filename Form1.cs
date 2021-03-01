using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_Assignment_1_3
{
    public partial class Form1 : Form
    {
        double height;
        int age;
        string name;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = txtName.Text;

            age = Convert.ToInt32(numUD.Value);
            int exp = 82 - age;

            height = Convert.ToDouble(txtHeight.Text);
            double tallman = 2.72 - height;
            double heightFinal = Math.Round(tallman, 2);



            lblState.Text = $"Hello {name},";

            lblStateA.Text = $"You're currently {exp} years away from the average life expectancy.";

            lblStateH.Text = $"The tallest man in the world is {heightFinal} m taller than you.";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
