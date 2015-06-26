using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace assignment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog courseNames = new OpenFileDialog(); // created a new object
            courseNames.Title = "Dialog Box";
            courseNames.Filter = "File Txt|*.txt";
            courseNames.InitialDirectory = @"C:\Users\blue15\Documents\vsProjects\csharp-basic\assignment\CourseNames.txt";

            if (courseNames.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {

                StreamReader sr = new StreamReader(File.OpenRead(courseNames.FileName));
                listBoxCourseNames.Items.Add(sr.ReadToEnd());
                // listBoxCourseNames.Items.Add(Environment.NewLine);
             
                /*string s = "First line" +
                Environment.NewLine +
                "Second line";*/

            }                 
        
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            /*
            if (SaveFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(SaveFD.FileName, textBox4.Text);
            }  */
            
        }

      
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
