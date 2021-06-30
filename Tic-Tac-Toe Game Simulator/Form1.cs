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

        
        bool turn = true; //Assigning boolean variable for turns
        int countingTurns = 0; //The actual turn count value

       
        private void checkWinner()
        {
           //Horizontal Wins 
           if ((btn1.Text == btn2.Text) && (btn2.Text == btn3.Text) && (btn1.Text == btn3.Text) && (countingTurns >= 5) && (turn = true) && (!btn1.Enabled))
           {
                txtbx_Status.Visible = true;
                txtbx_Status.Text = "Game Over!";
                txtbx_Turn.Text = "Game Over!";

                
                btn1.BackColor = Color.PaleGreen;
           
                btn2.BackColor = Color.PaleGreen;
            
                btn3.BackColor = Color.PaleGreen;
                
                if (btn4.Enabled != false || btn5.Enabled != false || btn6.Enabled != false || btn7.Enabled != false || btn8.Enabled != false || btn9.Enabled != false)
                {
                    btn4.Enabled = false;
                    btn5.Enabled = false;
                    btn6.Enabled = false;
                    btn7.Enabled = false;
                    btn8.Enabled = false;
                    btn9.Enabled = false;
                }
           }

            else if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text) && (btn6.Text == btn4.Text) && (countingTurns >= 5) && (!btn4.Enabled))
            {

                txtbx_Status.Visible = true;
                txtbx_Status.Text = "Game Over!";
                txtbx_Turn.Text = "Game Over!";

                
                btn4.BackColor = Color.PaleGreen;
             
                btn5.BackColor = Color.PaleGreen;
             
                btn6.BackColor = Color.PaleGreen;

                if (btn1.Enabled != false || btn2.Enabled != false || btn3.Enabled != false || btn7.Enabled != false || btn8.Enabled != false || btn9.Enabled != false)
                {
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn7.Enabled = false;
                    btn8.Enabled = false;
                    btn9.Enabled = false;
                }
            }

           else if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && (btn9.Text == btn7.Text) && (countingTurns >= 5) && (!btn7.Enabled))
           {
                txtbx_Status.Visible = true;
                txtbx_Status.Text = "Game Over!";
                txtbx_Turn.Text = "Game Over!";

            
                btn7.BackColor = Color.PaleGreen;
                
                btn8.BackColor = Color.PaleGreen;
               
                btn9.BackColor = Color.PaleGreen;

                if (btn1.Enabled != false || btn2.Enabled != false || btn3.Enabled != false || btn4.Enabled != false || btn5.Enabled != false || btn6.Enabled != false)
                {
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                    btn5.Enabled = false;
                    btn6.Enabled = false;
                }
           }

            //Vertical Wins

            else if ((btn1.Text == btn4.Text) && (btn4.Text == btn7.Text) && (btn7.Text == btn1.Text) && (countingTurns >= 5) && (!btn1.Enabled))
            {
                txtbx_Status.Visible = true;
                txtbx_Status.Text = "Game Over!";
                txtbx_Turn.Text = "Game Over!";

             
                btn1.BackColor = Color.PaleGreen;
           
                btn4.BackColor = Color.PaleGreen;
         
                btn7.BackColor = Color.PaleGreen;

                if (btn2.Enabled != false || btn3.Enabled != false || btn6.Enabled != false || btn5.Enabled != false || btn8.Enabled != false || btn9.Enabled != false)
                {
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn5.Enabled = false;
                    btn6.Enabled = false;
                    btn8.Enabled = false;
                    btn9.Enabled = false;
                }
            }

            else if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && (btn8.Text == btn2.Text) && (countingTurns >= 5) && (!btn2.Enabled))
            {
                txtbx_Status.Visible = true;
                txtbx_Status.Text = "Game Over!";
                txtbx_Turn.Text = "Game Over!";

               
                btn2.BackColor = Color.PaleGreen;
              
                btn5.BackColor = Color.PaleGreen;
             
                btn8.BackColor = Color.PaleGreen;

                if (btn1.Enabled != false || btn3.Enabled != false || btn6.Enabled != false || btn4.Enabled != false || btn7.Enabled != false || btn9.Enabled != false)
                {
                    btn1.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                    btn6.Enabled = false;
                    btn7.Enabled = false;
                    btn9.Enabled = false;
                }
            }

           else if ((btn3.Text == btn6.Text) && (btn6.Text == btn9.Text) && (btn9.Text == btn3.Text) && (countingTurns >= 5) && (!btn3.Enabled))
           {
                txtbx_Status.Visible = true;
                txtbx_Status.Text = "Game Over!";
                txtbx_Turn.Text = "Game Over!";

             
                btn3.BackColor = Color.PaleGreen;
           
                btn6.BackColor = Color.PaleGreen;

                btn9.BackColor = Color.PaleGreen;

                if (btn1.Enabled != false || btn2.Enabled != false || btn5.Enabled != false || btn4.Enabled != false || btn7.Enabled != false || btn8.Enabled != false)
                {
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn4.Enabled = false;
                    btn5.Enabled = false;
                    btn7.Enabled = false;
                    btn8.Enabled = false;
                }
           }

            //Diagonal Wins

            else if ((btn1.Text == btn5.Text) && (btn5.Text == btn9.Text) && (btn9.Text == btn1.Text) && (countingTurns >= 5) && (!btn1.Enabled))
            {
                txtbx_Status.Visible = true;
                txtbx_Status.Text = "Game Over!";
                txtbx_Turn.Text = "Game Over!";

               
                btn1.BackColor = Color.PaleGreen;
         
                btn5.BackColor = Color.PaleGreen;

                btn9.BackColor = Color.PaleGreen;

                if (btn2.Enabled != false || btn3.Enabled != false || btn6.Enabled != false || btn4.Enabled != false || btn7.Enabled != false || btn8.Enabled != false)
                {
                    btn3.Enabled = false;
                    btn2.Enabled = false;
                    btn4.Enabled = false;
                    btn6.Enabled = false;
                    btn7.Enabled = false;
                    btn8.Enabled = false;
                }
            }

            else if ((btn3.Text == btn5.Text) && (btn5.Text == btn7.Text) && (btn7.Text == btn3.Text) && (countingTurns >= 5) && (!btn3.Enabled))
            {
                txtbx_Status.Visible = true;
                txtbx_Status.Text = "Game Over!";
                txtbx_Turn.Text = "Game Over!";

         
                btn3.BackColor = Color.PaleGreen;
            
                btn5.BackColor = Color.PaleGreen;
         
                btn7.BackColor = Color.PaleGreen;

                if (btn2.Enabled != false || btn1.Enabled != false || btn6.Enabled != false || btn4.Enabled != false || btn9.Enabled != false || btn8.Enabled != false)
                {
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn4.Enabled = false;
                    btn6.Enabled = false;
                    btn9.Enabled = false;
                    btn8.Enabled = false;
                }
            }

            else if (!btn1.Enabled && !btn2.Enabled && !btn3.Enabled && !btn4.Enabled && !btn5.Enabled && !btn6.Enabled && !btn7.Enabled && !btn8.Enabled && !btn9.Enabled)
            {
                txtbx_Status.Visible = true;
                txtbx_Status.Text = "Its a Tie!";
                txtbx_Turn.Text = "Its a Tie!";

            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn1.Text = "X";
                turn = false;
                txtbx_Turn.Text = "O's Turn";
                btn1.Enabled = false;
                countingTurns++;
                lbl_countingTurns.Text = Convert.ToString(countingTurns);
                checkWinner();
            }         
            else
            {
                btn1.Text = "O";
                turn = true;
                txtbx_Turn.Text = "X's Turn";
                btn1.Enabled = false;
                countingTurns++;
                lbl_countingTurns.Text = Convert.ToString(countingTurns);
                checkWinner();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn2.Text = "X";
                turn = false;
                txtbx_Turn.Text = "O's Turn";
                btn2.Enabled = false;
                countingTurns++;
                lbl_countingTurns.Text = Convert.ToString(countingTurns);

                
                checkWinner();
            }
            else
            {
                btn2.Text = "O";
                turn = true;
                txtbx_Turn.Text = "X's Turn";
                btn2.Enabled = false;
                countingTurns++;
                lbl_countingTurns.Text = Convert.ToString(countingTurns);
                
                checkWinner();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn3.Text = "X";
                turn = false;
                txtbx_Turn.Text = "O's Turn";
                btn3.Enabled = false;
                countingTurns++;
                lbl_countingTurns.Text = Convert.ToString(countingTurns);
             
                checkWinner();
            }
            else
            {
                btn3.Text = "O";
                turn = true;
                txtbx_Turn.Text = "X's Turn";
                btn3.Enabled = false;
                countingTurns++;
                lbl_countingTurns.Text = Convert.ToString(countingTurns);

                checkWinner();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn4.Text = "X";
                turn = false;
                txtbx_Turn.Text = "O's Turn";
                btn4.Enabled = false;
                countingTurns++;
                lbl_countingTurns.Text = Convert.ToString(countingTurns);
            
                checkWinner();
            }
            else
            {
                btn4.Text = "O";
                turn = true;
                txtbx_Turn.Text = "X's Turn";
                btn4.Enabled = false;
                countingTurns++;
                lbl_countingTurns.Text = Convert.ToString(countingTurns);
           
                checkWinner();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn5.Text = "X";
                turn = false;
                txtbx_Turn.Text = "O's Turn";
                btn5.Enabled = false;
                countingTurns++;
                lbl_countingTurns.Text = Convert.ToString(countingTurns);
        
                checkWinner();
            }
            else
            {
                btn5.Text = "O";
                turn = true;
                txtbx_Turn.Text = "X's Turn";
                btn5.Enabled = false;
                countingTurns++;
                lbl_countingTurns.Text = Convert.ToString(countingTurns);
           
                checkWinner();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn6.Text = "X";
                turn = false;
                txtbx_Turn.Text = "O's Turn";
                btn6.Enabled = false;
                countingTurns++;
                lbl_countingTurns.Text = Convert.ToString(countingTurns);
     
                checkWinner();
            }
            else
            {
                btn6.Text = "O";
                turn = true;
                txtbx_Turn.Text = "X's Turn";
                btn6.Enabled = false;
                countingTurns++;
                lbl_countingTurns.Text = Convert.ToString(countingTurns);
       
                checkWinner();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn7.Text = "X";
                turn = false;
                txtbx_Turn.Text = "O's Turn";
                btn7.Enabled = false;
                countingTurns++;
                lbl_countingTurns.Text = Convert.ToString(countingTurns);

                checkWinner();
            }
            else
            {
                btn7.Text = "O";
                turn = true;
                txtbx_Turn.Text = "X's Turn";
                btn7.Enabled = false;
                countingTurns++;
                lbl_countingTurns.Text = Convert.ToString(countingTurns);
    
                checkWinner();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn8.Text = "X";
                turn = false;
                txtbx_Turn.Text = "O's Turn";
                btn8.Enabled = false;
                countingTurns++;
                lbl_countingTurns.Text = Convert.ToString(countingTurns);
                
                checkWinner();
            }
            else
            {
                btn8.Text = "O";
                turn = true;
                txtbx_Turn.Text = "X's Turn";
                btn8.Enabled = false;
                countingTurns++;
                lbl_countingTurns.Text = Convert.ToString(countingTurns);
               
                checkWinner();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn9.Text = "X";
                turn = false;
                txtbx_Turn.Text = "O's Turn";
                btn9.Enabled = false;
                countingTurns++;
                lbl_countingTurns.Text = Convert.ToString(countingTurns);

      
                checkWinner();
            }
            else
            {
                btn9.Text = "O";
                turn = true;
                txtbx_Turn.Text = "X's Turn";
                btn9.Enabled = false;
                countingTurns++;
                lbl_countingTurns.Text = Convert.ToString(countingTurns);
             
                checkWinner();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            btn1.BackColor = SystemColors.Control;
            btn2.BackColor = SystemColors.Control;
            btn3.BackColor = SystemColors.Control;
            btn4.BackColor = SystemColors.Control;
            btn5.BackColor = SystemColors.Control;
            btn6.BackColor = SystemColors.Control;
            btn7.BackColor = SystemColors.Control;
            btn8.BackColor = SystemColors.Control;
            btn9.BackColor = SystemColors.Control;

            turn = true;
            countingTurns = 0;
            txtbx_Status.Visible = false;
            txtbx_Turn.Text = "X's Turn";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }    
    }
}
