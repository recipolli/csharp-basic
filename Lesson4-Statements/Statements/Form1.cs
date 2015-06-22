using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statements
{
    public partial class Form1 : Form
    {          

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (boxNames.Text != "Renata")
            {
                // nested if and else
                if (boxNames.Text == "Rena" || boxNames.Text == "Re")
                {
                    MessageBox.Show("You picked wrong name, try again!");
                }
                else
                {
                    MessageBox.Show("You have to find the correct name!");
                }                
            } // end if
            else
            {
                MessageBox.Show("Congrats! You picked the correct name Renata");
            } // end else          
        } 
    }
}
