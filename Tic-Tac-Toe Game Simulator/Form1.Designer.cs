
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
            this.lbl_playerOne = new System.Windows.Forms.Label();
            this.lbl_playerTwo = new System.Windows.Forms.Label();
            this.txtbx_Name1 = new System.Windows.Forms.TextBox();
            this.txtbx_Name2 = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_Turn = new System.Windows.Forms.Label();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_playerOne
            // 
            this.lbl_playerOne.AutoSize = true;
            this.lbl_playerOne.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_playerOne.Location = new System.Drawing.Point(53, 309);
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
            this.lbl_playerTwo.Location = new System.Drawing.Point(205, 309);
            this.lbl_playerTwo.Name = "lbl_playerTwo";
            this.lbl_playerTwo.Size = new System.Drawing.Size(98, 18);
            this.lbl_playerTwo.TabIndex = 2;
            this.lbl_playerTwo.Text = "PLAYER 2:";
            this.lbl_playerTwo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbx_Name1
            // 
            this.txtbx_Name1.Location = new System.Drawing.Point(39, 330);
            this.txtbx_Name1.Name = "txtbx_Name1";
            this.txtbx_Name1.Size = new System.Drawing.Size(120, 23);
            this.txtbx_Name1.TabIndex = 3;
            this.txtbx_Name1.TextChanged += new System.EventHandler(this.txtbx_Name1_TextChanged);
            // 
            // txtbx_Name2
            // 
            this.txtbx_Name2.Location = new System.Drawing.Point(190, 330);
            this.txtbx_Name2.Name = "txtbx_Name2";
            this.txtbx_Name2.Size = new System.Drawing.Size(120, 23);
            this.txtbx_Name2.TabIndex = 4;
            this.txtbx_Name2.TextChanged += new System.EventHandler(this.txtbx_Name2_TextChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.Location = new System.Drawing.Point(268, 345);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 25;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Reset.Location = new System.Drawing.Point(12, 345);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 24;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Status.Location = new System.Drawing.Point(114, 345);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(129, 36);
            this.lbl_Status.TabIndex = 23;
            this.lbl_Status.Text = "label2";
            this.lbl_Status.Visible = false;
            // 
            // lbl_Turn
            // 
            this.lbl_Turn.AutoSize = true;
            this.lbl_Turn.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Turn.Location = new System.Drawing.Point(114, 25);
            this.lbl_Turn.Name = "lbl_Turn";
            this.lbl_Turn.Size = new System.Drawing.Size(148, 36);
            this.lbl_Turn.TabIndex = 22;
            this.lbl_Turn.Text = "\'s Turn";
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(221, 243);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(81, 69);
            this.btn9.TabIndex = 21;
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(134, 243);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(81, 69);
            this.btn8.TabIndex = 20;
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(47, 243);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(81, 69);
            this.btn7.TabIndex = 19;
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(221, 159);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(81, 69);
            this.btn6.TabIndex = 18;
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(134, 159);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(81, 69);
            this.btn5.TabIndex = 17;
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(47, 159);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(81, 69);
            this.btn4.TabIndex = 16;
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(221, 74);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(81, 69);
            this.btn3.TabIndex = 15;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(134, 74);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(81, 69);
            this.btn2.TabIndex = 14;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(47, 74);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(81, 69);
            this.btn1.TabIndex = 13;
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // Tic_Tac_Toe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 407);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_Turn);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtbx_Name2);
            this.Controls.Add(this.txtbx_Name1);
            this.Controls.Add(this.lbl_playerTwo);
            this.Controls.Add(this.lbl_playerOne);
            this.Name = "Tic_Tac_Toe";
            this.Text = "Tic-Tac-Toe ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_playerOne;
        private System.Windows.Forms.Label lbl_playerTwo;
        public System.Windows.Forms.TextBox txtbx_Name1;
        public System.Windows.Forms.TextBox txtbx_Name2;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_Turn;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
    }
}

