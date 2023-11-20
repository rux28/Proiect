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
    public partial class Nivelul1 : Form
    {
        public static int ok = 0;

        private bool isCorrect()
        {
            if (radioButton4.Checked && checkBox1.Checked && checkBox2.Checked && checkBox4.Checked && !checkBox3.Checked)
                return true;
            return false;
        }

        public Nivelul1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isCorrect())
            {
                MessageBox.Show("Felicitări! Poți trece la următorul nivel.");
                ok = 1;
                Nivelul1.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Ai greșit! Mai încearcă o dată.");
                ok = 0;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
