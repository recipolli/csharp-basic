using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @switch
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

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
            
                switch (listBox1.SelectedItems[i].ToString())
                { 
                    case "Foobar":
                        MessageBox.Show("You picked Foobar");
                    break;

                    case "Bazquirk":
                        MessageBox.Show("You picked Bazquirk");
                    break;

                    case "Widgets":
                        MessageBox.Show("You picked Widgets");
                    break;

                    case "Gadgets":
                        MessageBox.Show("You picked Gadgets");
                    break;
                  
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
