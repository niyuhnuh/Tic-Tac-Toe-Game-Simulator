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
            int turn = 1;
            while (turn <= 9)
            {
                if (turn_count % 2 == 0)
                {
                    btn1.Text = player_O.ToString();
                    turn++;
                }

                else 
                {
                    btn1.Text = player_X.ToString();
                    turn++;
                }
            }
        }
    }
}
