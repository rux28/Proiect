using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Nivelul1();
            form2.ShowDialog();
            if(Nivelul1.ok == 1)
                button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form3 = new Nivelul2();
            form3.ShowDialog();
            if (Nivelul2.ok == 1)
                button3.Enabled = true;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form4 = new Nivelul3();
            form4.Show();
        }
    }
}
