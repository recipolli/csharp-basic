using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variables
{
    public partial class Form1 : Form
    {

        // Global Variable
        string firstTextBox;
        string lastTextBox;
        
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

        private void submit_Click(object sender, EventArgs e)
        {
            //Local variable Examples

            //string firstTextBox = firstNameTextBox.Text;
            //string lastTextBox = lastNameTextBox.Text;
            //label3.Text = firstTextBox + " " + lastTextBox;

           
            firstTextBox = firstNameTextBox.Text;
            lastTextBox = lastNameTextBox.Text;
            label3.Text = firstTextBox + " " + lastTextBox;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
