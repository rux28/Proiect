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
    
    public partial class Nivelul2 : Form
    {
        public static int ok = 0;

        bool touch()
        {
            if ((pictureBox1.Top >= pictureBox6.Top && pictureBox1.Top <= pictureBox6.Bottom && pictureBox1.Left >= pictureBox6.Left && pictureBox1.Left <= pictureBox6.Right) ||
               (pictureBox1.Top >= pictureBox6.Top && pictureBox1.Top <= pictureBox6.Bottom && pictureBox1.Right >= pictureBox6.Left && pictureBox1.Right <= pictureBox6.Right) ||
               (pictureBox1.Bottom <= pictureBox6.Bottom && pictureBox1.Bottom >= pictureBox6.Top && pictureBox1.Left >= pictureBox6.Left && pictureBox1.Left <= pictureBox6.Right) ||
               (pictureBox1.Bottom <= pictureBox6.Bottom && pictureBox1.Bottom >= pictureBox6.Top && pictureBox1.Right >= pictureBox6.Left && pictureBox1.Right <= pictureBox6.Right))
                return false;

            if ((pictureBox1.Top >= pictureBox5.Top && pictureBox1.Top <= pictureBox5.Bottom && pictureBox1.Left >= pictureBox5.Left && pictureBox1.Left <= pictureBox5.Right) ||
               (pictureBox1.Top >= pictureBox5.Top && pictureBox1.Top <= pictureBox5.Bottom && pictureBox1.Right >= pictureBox5.Left && pictureBox1.Right <= pictureBox5.Right) ||
               (pictureBox1.Bottom <= pictureBox5.Bottom && pictureBox1.Bottom >= pictureBox5.Top && pictureBox1.Left >= pictureBox5.Left && pictureBox1.Left <= pictureBox5.Right) ||
               (pictureBox1.Bottom <= pictureBox5.Bottom && pictureBox1.Bottom >= pictureBox5.Top && pictureBox1.Right >= pictureBox5.Left && pictureBox1.Right <= pictureBox5.Right))
                return false;

            if ((pictureBox1.Top >= pictureBox4.Top && pictureBox1.Top <= pictureBox4.Bottom && pictureBox1.Left >= pictureBox4.Left && pictureBox1.Left <= pictureBox4.Right) ||
               (pictureBox1.Top >= pictureBox4.Top && pictureBox1.Top <= pictureBox4.Bottom && pictureBox1.Right >= pictureBox4.Left && pictureBox1.Right <= pictureBox4.Right) ||
               (pictureBox1.Bottom <= pictureBox4.Bottom && pictureBox1.Bottom >= pictureBox4.Top && pictureBox1.Left >= pictureBox4.Left && pictureBox1.Left <= pictureBox4.Right) ||
               (pictureBox1.Bottom <= pictureBox4.Bottom && pictureBox1.Bottom >= pictureBox4.Top && pictureBox1.Right >= pictureBox4.Left && pictureBox1.Right <= pictureBox4.Right))
                return false;

            if ((pictureBox1.Top >= pictureBox3.Top && pictureBox1.Top <= pictureBox3.Bottom && pictureBox1.Left >= pictureBox3.Left && pictureBox1.Left <= pictureBox3.Right) ||
               (pictureBox1.Top >= pictureBox3.Top && pictureBox1.Top <= pictureBox3.Bottom && pictureBox1.Right >= pictureBox3.Left && pictureBox1.Right <= pictureBox3.Right) ||
               (pictureBox1.Bottom <= pictureBox3.Bottom && pictureBox1.Bottom >= pictureBox3.Top && pictureBox1.Left >= pictureBox3.Left && pictureBox1.Left <= pictureBox3.Right) ||
               (pictureBox1.Bottom <= pictureBox3.Bottom && pictureBox1.Bottom >= pictureBox3.Top && pictureBox1.Right >= pictureBox3.Left && pictureBox1.Right <= pictureBox3.Right))
                return false;

            if (pictureBox1.Bottom >= this.Height - 40 || pictureBox1.Left <= 0 || pictureBox1.Top <= 0 || pictureBox1.Right >= this.Width - 15)
                return false;

            return true;
        }

        bool win()
        {
            if ((pictureBox1.Top >= pictureBox2.Top && pictureBox1.Top <= pictureBox2.Bottom && pictureBox1.Left >= pictureBox2.Left && pictureBox1.Left <= pictureBox2.Right) ||
               (pictureBox1.Top >= pictureBox2.Top && pictureBox1.Top <= pictureBox2.Bottom && pictureBox1.Right >= pictureBox2.Left && pictureBox1.Right <= pictureBox2.Right) ||
               (pictureBox1.Bottom <= pictureBox2.Bottom && pictureBox1.Bottom >= pictureBox2.Top && pictureBox1.Left >= pictureBox2.Left && pictureBox1.Left <= pictureBox2.Right) ||
               (pictureBox1.Bottom <= pictureBox2.Bottom && pictureBox1.Bottom >= pictureBox2.Top && pictureBox1.Right >= pictureBox2.Left && pictureBox1.Right <= pictureBox2.Right))
                return true;

            return false;
        }

        public Nivelul2()
        {
            InitializeComponent();
            pictureBox1.Top = 6;
            pictureBox1.Left = 6;
        }

        private void Nivelul2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Move(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void Nivelul2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                pictureBox1.Top -= 5;
            if (e.KeyCode == Keys.S)
                pictureBox1.Top += 5;
            if (e.KeyCode == Keys.A)
                pictureBox1.Left -= 5;
            if (e.KeyCode == Keys.D)
                pictureBox1.Left += 5;

            if (touch() == false)
            {
                MessageBox.Show("Ai murit!");
                pictureBox1.Top = 5;
                pictureBox1.Left = 5;
                ok = 0;
            }

            if(win() == true)
            {
                MessageBox.Show("Ai câștigat! Poți trece la nivelul următor.");
                ok = 1;
                Nivelul2.ActiveForm.Close();
            }
        }
    }
}
