using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShellSort
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
   

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            int randNum = (int)sortRandNum.Value;
            ShellSort shell = new ShellSort(randNum);
            shell.Show();
         
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
