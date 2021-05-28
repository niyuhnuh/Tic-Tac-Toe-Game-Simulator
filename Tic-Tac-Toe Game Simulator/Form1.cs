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

        string player1 = "";
        string player2 = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rb_X2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Play_Click(object sender, EventArgs e)
        {

            if (player1 != "" && player2 != "")
            {
                this.Hide();

                Form2 mainForm = new Form2();
                mainForm.ShowDialog();
          
            }

            else
            {
                MessageBox.Show("Please enter a name.");

            }

            

         
        }

        private void txtbx_Name1_TextChanged(object sender, EventArgs e)
        {
            player1 = txtbx_Name1.Text.ToString();

        }

        private void txtbx_Name2_TextChanged(object sender, EventArgs e)
        {
            player2 = txtbx_Name2.Text.ToString();

        }

        private void chckBox_X1_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBox_X1.Checked == true)
            {
                chckBox_X2.Visible = false;
                chckBox_O1.Visible = false;
                chckBox_O2.Checked = true;
            }
            else
            {
                chckBox_O1.Visible = true;
                chckBox_X2.Visible = true;
                chckBox_O2.Checked = false;
            }
        }

        private void chckBox_O1_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBox_O1.Checked == true)
            {
                chckBox_O2.Visible = false;
                chckBox_X1.Visible = false;
                chckBox_X2.Checked = true;
            }
            else
            {
                chckBox_X1.Visible = true;
                chckBox_O2.Visible = true;
                chckBox_X2.Checked = false;
            }
        }

        private void chckBox_X2_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBox_X2.Checked == true)
            {
                chckBox_O2.Visible = false;
                chckBox_X1.Visible = false;
                chckBox_O1.Checked = true;
            }
            else
            {
                chckBox_O2.Visible = true;
                chckBox_X1.Visible = true;
                chckBox_O1.Checked = false;
            }
        }

        private void chckBox_O2_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBox_O2.Checked == true)
            {
                chckBox_O1.Visible = false;
                chckBox_X2.Visible = false;
                chckBox_X1.Checked = true;
            }
            else
            {
                chckBox_X2.Visible = true;
                chckBox_O1.Visible = true;
                chckBox_X1.Checked = false;
            }
        }
    }
}
