
namespace Tic_Tac_Toe_Game_Simulator
{
    partial class Tic_Tac_Toe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameTitle = new System.Windows.Forms.Label();
            this.lbl_playerOne = new System.Windows.Forms.Label();
            this.lbl_playerTwo = new System.Windows.Forms.Label();
            this.txtbx_Name1 = new System.Windows.Forms.TextBox();
            this.txtbx_Name2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Play = new System.Windows.Forms.Button();
            this.chckBox_X1 = new System.Windows.Forms.CheckBox();
            this.chckBox_O1 = new System.Windows.Forms.CheckBox();
            this.chckBox_X2 = new System.Windows.Forms.CheckBox();
            this.chckBox_O2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameTitle.Location = new System.Drawing.Point(12, 98);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(342, 54);
            this.gameTitle.TabIndex = 0;
            this.gameTitle.Text = "Tic-Tac-Toe";
            // 
            // lbl_playerOne
            // 
            this.lbl_playerOne.AutoSize = true;
            this.lbl_playerOne.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_playerOne.Location = new System.Drawing.Point(46, 205);
            this.lbl_playerOne.Name = "lbl_playerOne";
            this.lbl_playerOne.Size = new System.Drawing.Size(108, 18);
            this.lbl_playerOne.TabIndex = 1;
            this.lbl_playerOne.Text = "PLAYER 1: ";
            this.lbl_playerOne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_playerTwo
            // 
            this.lbl_playerTwo.AutoSize = true;
            this.lbl_playerTwo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_playerTwo.Location = new System.Drawing.Point(198, 205);
            this.lbl_playerTwo.Name = "lbl_playerTwo";
            this.lbl_playerTwo.Size = new System.Drawing.Size(98, 18);
            this.lbl_playerTwo.TabIndex = 2;
            this.lbl_playerTwo.Text = "PLAYER 2:";
            this.lbl_playerTwo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbx_Name1
            // 
            this.txtbx_Name1.Location = new System.Drawing.Point(32, 226);
            this.txtbx_Name1.Name = "txtbx_Name1";
            this.txtbx_Name1.Size = new System.Drawing.Size(120, 23);
            this.txtbx_Name1.TabIndex = 3;
            this.txtbx_Name1.TextChanged += new System.EventHandler(this.txtbx_Name1_TextChanged);
            // 
            // txtbx_Name2
            // 
            this.txtbx_Name2.Location = new System.Drawing.Point(183, 226);
            this.txtbx_Name2.Name = "txtbx_Name2";
            this.txtbx_Name2.Size = new System.Drawing.Size(120, 23);
            this.txtbx_Name2.TabIndex = 4;
            this.txtbx_Name2.TextChanged += new System.EventHandler(this.txtbx_Name2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "PLAY AS: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(200, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "PLAY AS: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Play
            // 
            this.btn_Play.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Play.Location = new System.Drawing.Point(100, 314);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(132, 23);
            this.btn_Play.TabIndex = 11;
            this.btn_Play.Text = "Let\'s Play!";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // chckBox_X1
            // 
            this.chckBox_X1.AutoSize = true;
            this.chckBox_X1.Location = new System.Drawing.Point(49, 275);
            this.chckBox_X1.Name = "chckBox_X1";
            this.chckBox_X1.Size = new System.Drawing.Size(33, 19);
            this.chckBox_X1.TabIndex = 12;
            this.chckBox_X1.Text = "X";
            this.chckBox_X1.UseVisualStyleBackColor = true;
            this.chckBox_X1.CheckedChanged += new System.EventHandler(this.chckBox_X1_CheckedChanged);
            // 
            // chckBox_O1
            // 
            this.chckBox_O1.AutoSize = true;
            this.chckBox_O1.Location = new System.Drawing.Point(100, 275);
            this.chckBox_O1.Name = "chckBox_O1";
            this.chckBox_O1.Size = new System.Drawing.Size(35, 19);
            this.chckBox_O1.TabIndex = 13;
            this.chckBox_O1.Text = "O";
            this.chckBox_O1.UseVisualStyleBackColor = true;
            this.chckBox_O1.CheckedChanged += new System.EventHandler(this.chckBox_O1_CheckedChanged);
            // 
            // chckBox_X2
            // 
            this.chckBox_X2.AutoSize = true;
            this.chckBox_X2.Location = new System.Drawing.Point(198, 275);
            this.chckBox_X2.Name = "chckBox_X2";
            this.chckBox_X2.Size = new System.Drawing.Size(33, 19);
            this.chckBox_X2.TabIndex = 14;
            this.chckBox_X2.Text = "X";
            this.chckBox_X2.UseVisualStyleBackColor = true;
            this.chckBox_X2.CheckedChanged += new System.EventHandler(this.chckBox_X2_CheckedChanged);
            // 
            // chckBox_O2
            // 
            this.chckBox_O2.AutoSize = true;
            this.chckBox_O2.Location = new System.Drawing.Point(249, 275);
            this.chckBox_O2.Name = "chckBox_O2";
            this.chckBox_O2.Size = new System.Drawing.Size(35, 19);
            this.chckBox_O2.TabIndex = 15;
            this.chckBox_O2.Text = "O";
            this.chckBox_O2.UseVisualStyleBackColor = true;
            this.chckBox_O2.CheckedChanged += new System.EventHandler(this.chckBox_O2_CheckedChanged);
            // 
            // Tic_Tac_Toe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 407);
            this.Controls.Add(this.chckBox_O2);
            this.Controls.Add(this.chckBox_X2);
            this.Controls.Add(this.chckBox_O1);
            this.Controls.Add(this.chckBox_X1);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_Name2);
            this.Controls.Add(this.txtbx_Name1);
            this.Controls.Add(this.lbl_playerTwo);
            this.Controls.Add(this.lbl_playerOne);
            this.Controls.Add(this.gameTitle);
            this.Name = "Tic_Tac_Toe";
            this.Text = "Tic-Tac-Toe ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Label lbl_playerOne;
        private System.Windows.Forms.Label lbl_playerTwo;
        private System.Windows.Forms.TextBox txtbx_Name1;
        private System.Windows.Forms.TextBox txtbx_Name2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.CheckBox chckBox_X1;
        private System.Windows.Forms.CheckBox chckBox_O1;
        private System.Windows.Forms.CheckBox chckBox_X2;
        private System.Windows.Forms.CheckBox chckBox_O2;
    }
}

