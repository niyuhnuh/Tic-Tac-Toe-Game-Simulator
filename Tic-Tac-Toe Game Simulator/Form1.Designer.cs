
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
            this.SuspendLayout();
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.Location = new System.Drawing.Point(65, 72);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(38, 15);
            this.gameTitle.TabIndex = 0;
            this.gameTitle.Text = "label1";
            // 
            // Tic_Tac_Toe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 345);
            this.Controls.Add(this.gameTitle);
            this.Name = "Tic_Tac_Toe";
            this.Text = "Tic-Tac-Toe ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameTitle;
    }
}

