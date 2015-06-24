using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
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
            
            Form2 frm = new Form2();
            frm.Show();
           /* this.Close();*/
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        /* Examples of CheckBox */

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.BackColor = Color.Magenta;
                checkBox1.Text = "B";
            }
            else 
            {
                checkBox1.BackColor = Color.Lime;
                checkBox1.Text = "1";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) 
            {
                checkBox2.BackColor = Color.Magenta;
                checkBox2.Text = "B";
            }
            else
            {
                checkBox2.BackColor = Color.Lime;
                checkBox2.Text = "2";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox3.BackColor = Color.Magenta;
                checkBox3.Text = "B";
            }
            else
            {
                checkBox3.BackColor = Color.Lime;
                checkBox3.Text = "3";
            }
        }        
      
        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBox4.Checked)
            {
                checkBox4.BackColor = Color.Magenta;
                checkBox4.Text = "B";
            }
            else
            {
                checkBox4.BackColor = Color.Lime;
                checkBox4.Text = "4";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox5.BackColor = Color.Magenta;
                checkBox5.Text = "B";
            }
            else
            {
                checkBox5.BackColor = Color.Lime;
                checkBox5.Text = "5";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox6.BackColor = Color.Magenta;
                checkBox6.Text = "B";
            }
            else
            {
                checkBox6.BackColor = Color.Lime;
                checkBox6.Text = "6";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox7.BackColor = Color.Magenta;
                checkBox7.Text = "B";
            }
            else
            {
                checkBox7.BackColor = Color.Lime;
                checkBox7.Text = "7";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                checkBox8.BackColor = Color.Magenta;
                checkBox8.Text = "B";
            }
            else
            {
                checkBox8.BackColor = Color.Lime;
                checkBox8.Text = "8";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                checkBox9.BackColor = Color.Magenta;
                checkBox9.Text = "B";
            }
            else
            {
                checkBox9.BackColor = Color.Lime;
                checkBox9.Text = "9";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                checkBox10.BackColor = Color.Magenta;
                checkBox10.Text = "B";
            }
            else
            {
                checkBox10.BackColor = Color.Lime;
                checkBox10.Text = "10";
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                checkBox11.BackColor = Color.Magenta;
                checkBox11.Text = "B";
            }
            else
            {
                checkBox11.BackColor = Color.Lime;
                checkBox11.Text = "11";
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                checkBox12.BackColor = Color.Magenta;
                checkBox12.Text = "B";
            }
            else
            {
                checkBox12.BackColor = Color.Lime;
                checkBox12.Text = "12";
            }
        } /* End of CheckBox */


        /* Examples of Button */
        private void button2_Click(object sender, EventArgs e)
        {
                       
            if (button2.Text == "1")
            {
                button2.Text = "B";
                button2.BackColor = Color.Magenta;
            }
            else if (button2.Text == "B")
            {
                button2.Text = "1";
                button2.BackColor = Color.Lime;            
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "2")
            {
                button3.Text = "B";
                button3.BackColor = Color.Magenta;
            }
            else if (button3.Text == "B")
            {
                button3.Text = "2";
                button3.BackColor = Color.Lime;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "3")
            {
                button4.Text = "B";
                button4.BackColor = Color.Magenta;
            }
            else if (button4.Text == "B")
            {
                button4.Text = "3";
                button4.BackColor = Color.Lime;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "4")
            {
                button5.Text = "B";
                button5.BackColor = Color.Magenta;
            }
            else if (button5.Text == "B")
            {
                button5.Text = "4";
                button5.BackColor = Color.Lime;
            }
        }      

       private void button6_Click(object sender, EventArgs e)
       {
            if (button6.Text == "5")
            {
                button6.Text = "B";
                button6.BackColor = Color.Magenta;
            }
            else if (button6.Text == "B")
            {
                button6.Text = "5";
                button6.BackColor = Color.Lime;
            }
        }

       

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "8")
            {
                button9.Text = "B";
                button9.BackColor = Color.Magenta;
            }
            else if (button9.Text == "B")
            {
                button9.Text = "8";
                button9.BackColor = Color.Lime;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == "9")
            {
                button10.Text = "B";
                button10.BackColor = Color.Magenta;
            }
            else if (button10.Text == "B")
            {
                button10.Text = "9";
                button10.BackColor = Color.Lime;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.Text == "10")
            {
                button11.Text = "B";
                button11.BackColor = Color.Magenta;
            }
            else if (button11.Text == "B")
            {
                button11.Text = "10";
                button11.BackColor = Color.Lime;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "6")
            {
                button7.Text = "B";
                button7.BackColor = Color.Magenta;                
            }
            else if (button7.Text == "B")
            {
                button7.Text = "6";
                button7.BackColor = Color.Lime;
            
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "7")
            {
                button8.Text = "B";
                button8.BackColor = Color.Magenta;
            }
            else if (button8.Text == "B")
            {
                button8.Text = "7";
                button8.BackColor = Color.Lime;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.Text == "11")
            {
                button12.Text = "B";
                button12.BackColor = Color.Magenta;
            }
            else if (button12.Text == "B")
            {
                button12.Text = "11";
                button12.BackColor = Color.Lime;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.Text == "12")
            {
                button13.Text = "B";
                button13.BackColor = Color.Magenta;            
            }
            else if (button13.Text == "B")
            {
                button13.Text = "12";
                button13.BackColor = Color.Lime;            
            }
        }
       /* End of Button */
              
    }
}
