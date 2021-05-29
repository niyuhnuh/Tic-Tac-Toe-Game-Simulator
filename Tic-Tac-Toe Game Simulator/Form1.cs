using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game_Simulator
{
    public partial class Tic_Tac_Toe : Form
    {
        public Tic_Tac_Toe()
        {
            InitializeComponent();
        }

        bool turn = true;
        int turn_count = 1;

        private void lbl_Turn_Click(object sender, EventArgs e)
        {

        }

        private void Tic_Tac_Toe_Load(object sender, EventArgs e)
        { 
            
            if (turn == true)
            {
                lbl_Turn.Text = "X's Turn";
            }

            else 
            {
                lbl_Turn.Text = "O's Turn";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn1.Text = "X";
                turn = false;
                lbl_Turn.Text = "O's Turn";
            }
            
            else
            {
                btn1.Text = "O";
                turn = true;
                lbl_Turn.Text = "X's Turn";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn2.Text = "X";
                turn = false;
                lbl_Turn.Text = "O's Turn";
            }

            else
            {
                btn2.Text = "O";
                turn = true;
                lbl_Turn.Text = "X's Turn";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn3.Text = "X";
                turn = false;
                lbl_Turn.Text = "O's Turn";
            }

            else
            {
                btn3.Text = "O";
                turn = true;
                lbl_Turn.Text = "X's Turn";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn4.Text = "X";
                turn = false;
                lbl_Turn.Text = "O's Turn";
            }

            else
            {
                btn4.Text = "O";
                turn = true;
                lbl_Turn.Text = "X's Turn";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn5.Text = "X";
                turn = false;
                lbl_Turn.Text = "O's Turn";
            }

            else
            {
                btn5.Text = "O";
                turn = true;
                lbl_Turn.Text = "X's Turn";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn6.Text = "X";
                turn = false;
                lbl_Turn.Text = "O's Turn";
            }

            else
            {
                btn6.Text = "O";
                turn = true;
                lbl_Turn.Text = "X's Turn";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn7.Text = "X";
                turn = false;
                lbl_Turn.Text = "O's Turn";
            }

            else
            {
                btn7.Text = "O";
                turn = true;
                lbl_Turn.Text = "X's Turn";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn8.Text = "X";
                turn = false;
                lbl_Turn.Text = "O's Turn";
            }

            else
            {
                btn8.Text = "O";
                turn = true;
                lbl_Turn.Text = "X's Turn";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn9.Text = "X";
                turn = false;
                lbl_Turn.Text = "O's Turn";
            }

            else
            {
                btn9.Text = "O";
                turn = true;
                lbl_Turn.Text = "X's Turn";
            }
        }
    }
}
