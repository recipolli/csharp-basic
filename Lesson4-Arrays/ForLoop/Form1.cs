using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] myLoopArray = {"Cat", "Dog", "Bird", "Fish"};

            for (int i = 0; i < myLoopArray.Length;)
            {
               //MessageBox.Show(i.ToString());  

                /* using foreach as a nested loop to get the itens name */
                foreach (var nickNames in myLoopArray)
                {
                    MessageBox.Show(i++ + " " + nickNames);
                }

                
                /* with if statement
                if (myLoopArray[i] == "Fish")
                {
                    MessageBox.Show("Congrats Fish is in the list");
                }*/

            } 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
