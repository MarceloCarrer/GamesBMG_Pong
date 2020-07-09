using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {               
        public Form1()
        {
            InitializeComponent();            
        }

        //Level Beginner
        private void Beginner_btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(10, 127, 5, 5);
            form2.ShowDialog();
        }

        //Level Medium
        private void Medium_btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(13, 150, 10, 10);
            form2.ShowDialog();
        }

        //Level Hard
        private void Hard_btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(16, 180, 15, 15);
            form2.ShowDialog();
        }

        //Level Insane
        private void Insane_btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(19, 250, 20, 20);
            form2.ShowDialog();
        }
    }
}
