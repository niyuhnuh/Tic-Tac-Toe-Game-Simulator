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
        string player_X = "X";
        string player_O = "O";
        int turn_count = 1;

        private void lbl_Turn_Click(object sender, EventArgs e)
        {

        }

        private void Tic_Tac_Toe_Load(object sender, EventArgs e)
        { 
            
            if (turn_count % 2 == 0)
            {
                lbl_Turn.Text = "O's Turn";
            }

            else 
            {
                lbl_Turn.Text = "X's Turn";
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            
            for (turn = 1; turn <= 9; turn++)
            {
                if (turn_count % 2 == 0)
                {
                    button.Text = player_O.ToString();
                }

                else 
                {
                    button.Text = player_X.ToString();
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn1.Text = "X";
                turn = false;
            }
            
            else
            {
                btn1.Text = "O";
                turn = true;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                btn2.Text = "X";
                turn = false;
            }

            else
            {
                btn2.Text = "O";
                turn = true;
            }
        }
    }
}
