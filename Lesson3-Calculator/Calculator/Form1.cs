using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calculator : Form
    {

        int firstTextBoxNum;
        int secondTextBoxNum;
        int result;

        public calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstTextBoxNum = int.Parse(firstNumber.Text);
            secondTextBoxNum = int.Parse(secondNumber.Text);
            result = firstTextBoxNum + secondTextBoxNum;
            label5.Text = result.ToString();           
            
        }

        private void firstNumber_TextChanged(object sender, EventArgs e)
        {

        }       

        private void calculator_Load(object sender, EventArgs e)
        {

        }
               
    }
}
