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
      

        private void winner()
        {
            //Horizontal Wins for X 

            if ((btn1.Text == btn2.Text) && (btn1.Text == btn3.Text))
            {
                lbl_Status.Visible = true;
                lbl_Status.Text = "Game Over!";
                lbl_Turn.Text = "X is a Winner!";
            }
        }

        private void Tic_Tac_Toe_Load(object sender, EventArgs e)
        { 
            

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn1.Text = "X";
                turn = false;
                lbl_Turn.Text = "O's Turn";
                btn1.Enabled = false;
                winner();
            }
            
            else
            {
                btn1.Text = "O";
                turn = true;
                lbl_Turn.Text = "X's Turn";
                btn1.Enabled = false;
                winner();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn2.Text = "X";
                turn = false;
                lbl_Turn.Text = "O's Turn";
                btn2.Enabled = false;
                winner();
            }

            else
            {
                btn2.Text = "O";
                turn = true;
                lbl_Turn.Text = "X's Turn";
                btn2.Enabled = false;
                winner();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn3.Text = "X";
                turn = false;
                lbl_Turn.Text = "O's Turn";
                btn3.Enabled = false;
                winner();
            }

            else
            {
                btn3.Text = "O";
                turn = true;
                lbl_Turn.Text = "X's Turn";
                btn3.Enabled = false;
                winner();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn4.Text = "X";
                turn = false;
                lbl_Turn.Text = "O's Turn";
                btn4.Enabled = false;
                winner();
            }

            else
            {
                btn4.Text = "O";
                turn = true;
                lbl_Turn.Text = "X's Turn";
                btn4.Enabled = false;
                winner();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn5.Text = "X";
                turn = false;
                lbl_Turn.Text = "O's Turn";
                btn5.Enabled = false;
                winner();
            }

            else
            {
                btn5.Text = "O";
                turn = true;
                lbl_Turn.Text = "X's Turn";
                btn5.Enabled = false;
                winner();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn6.Text = "X";
                turn = false;
                lbl_Turn.Text = "O's Turn";
                btn6.Enabled = false;
                winner();
            }

            else
            {
                btn6.Text = "O";
                turn = true;
                lbl_Turn.Text = "X's Turn";
                btn6.Enabled = false;
                winner();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn7.Text = "X";
                turn = false;
                lbl_Turn.Text = "O's Turn";
                btn7.Enabled = false;
                winner();
            }

            else
            {
                btn7.Text = "O";
                turn = true;
                lbl_Turn.Text = "X's Turn";
                btn7.Enabled = false;
                winner();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn8.Text = "X";
                turn = false;
                lbl_Turn.Text = "O's Turn";
                btn8.Enabled = false;
                winner();
            }

            else
            {
                btn8.Text = "O";
                turn = true;
                lbl_Turn.Text = "X's Turn";
                btn8.Enabled = false;
                winner();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn9.Text = "X";
                turn = false;
                lbl_Turn.Text = "O's Turn";
                btn9.Enabled = false;
                winner();
            }

            else
            {
                btn9.Text = "O";
                turn = true;
                lbl_Turn.Text = "X's Turn";
                btn9.Enabled = false;
                winner();
            }
        }
    }
}
