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
    public partial class Nivelul3 : Form
    {
        public static int ok = 0;

        int[] line1;
        int[] line2;
        int[] line3;
        int[] column1;
        int[] column2;
        int[] column3;

        public Nivelul3()
        {
            InitializeComponent();
            line1 = new int[3];
            line2 = new int[3];
            line3 = new int[3];
            column1 = new int[3];
            column2 = new int[3];
            column3 = new int[3];
            line1[0] = line1[1] = line1[2] = column1[0] = column1[1] = column1[2] = 0;
            line2[0] = line2[1] = line2[2] = column2[0] = column2[1] = column2[2] = 0;
            line3[0] = line3[1] = line3[2] = column3[0] = column3[1] = column3[2] = 0;
        }

        bool verify()
        {
            if ((line1[0] == 1 && line1[1] == 1 && line1[2] == 1) ||
               (line2[0] == 1 && line2[1] == 1 && line2[2] == 1) ||
               (line3[0] == 1 && line3[1] == 1 && line3[2] == 1) ||
               (column1[0] == 1 && column1[1] == 1 && column1[2] == 1) ||
               (column2[0] == 1 && column2[1] == 1 && column2[2] == 1) ||
               (column3[0] == 1 && column3[1] == 1 && column3[2] == 1) ||
               (line1[0] == 1 && line2[1] == 1 && line3[2] == 1) ||
               (line1[2] == 1 && line2[1] == 1 && line3[0] == 1))
                return true;
            return false;
        }

        int player()
        {
            if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") ||
                (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") ||
                (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") ||
                (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") ||
                (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") ||
                (button3.Text == "X" && button5.Text == "X" && button7.Text == "X"))
                return 1;
            else if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") ||
                (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") ||
                (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") ||
                (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") ||
                (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") ||
                (button3.Text == "O" && button5.Text == "O" && button7.Text == "O"))
                return 2;
            return 3;
        }

        void win()
        {
            putO();
            if (verify() == true && player() == 1)
            {
                MessageBox.Show("Ai câștigat jocul!");
                ok = 1;
                Nivelul3.ActiveForm.Close();
            }
            else if (verify() == true && player() == 2)
            {
                MessageBox.Show("Ai pierdut!");
                line1[0] = line1[1] = line1[2] = column1[0] = column1[1] = column1[2] = 0;
                line2[0] = line2[1] = line2[2] = column2[0] = column2[1] = column2[2] = 0;
                line3[0] = line3[1] = line3[2] = column3[0] = column3[1] = column3[2] = 0;
                button1.Text = button2.Text = button3.Text = "";
                button4.Text = button5.Text = button6.Text = "";
                button7.Text = button8.Text = button9.Text = "";
            }
        }

        void putO()
        {
            if (line1[0] == 0 && column1[0] == 0)
            {
                button1.Text = "O";
                line1[0] = 1;
                column1[0] = 1;
            }
            else if (line1[1] == 0 && column2[0] == 0)
            {
                button2.Text = "O";
                line1[1] = 1;
                column2[0] = 1;
            }
            else if (line1[2] == 0 && column3[0] == 0)
            {
                button3.Text = "O";
                line1[2] = 1;
                column3[0] = 1;
            }
            else if (line2[0] == 0 && column1[1] == 0)
            {
                button4.Text = "O";
                line2[0] = 1;
                column1[1] = 1;
            }
            else if (line2[1] == 0 && column2[1] == 0)
            {
                button5.Text = "O";
                line2[1] = 1;
                column2[1] = 1;
            }
            else if (line2[2] == 0 && column3[1] == 0)
            {
                button6.Text = "O";
                line2[2] = 1;
                column3[1] = 1;
            }
            else if (line3[0] == 0 && column1[2] == 0)
            {
                button7.Text = "O";
                line3[0] = 1;
                column1[2] = 1;
            }
            else if (line3[1] == 0 && column2[2] == 0)
            {
                button8.Text = "O";
                line3[1] = 1;
                column2[2] = 1;
            }
            else if (line3[2] == 0 && column3[2] == 0)
            {
                button9.Text = "O";
                line3[2] = 1;
                column3[2] = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "X";
            line1[0] = 1;
            column1[0] = 1;
            win();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "X";
            line1[1] = 1;
            column2[0] = 1;
            win();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "X";
            line1[2] = 1;
            column3[0] = 1;
            win();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "X";
            line2[0] = 1;
            column1[1] = 1;
            win();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "X";
            line2[1] = 1;
            column2[1] = 1;
            win();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "X";
            line2[2] = 1;
            column3[1] = 1;
            win();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "X";
            line3[0] = 1;
            column1[2] = 1;
            win();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "X";
            line3[1] = 1;
            column2[2] = 1;
            win();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "X";
            line3[2] = 1;
            column3[2] = 1;
            win();
        }
    }
}
