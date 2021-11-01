namespace Game
{
    partial class GameBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbGameLayots = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreCounter = new System.Windows.Forms.Label();
            this.lblCollectedLetters = new System.Windows.Forms.Label();
            this.lbNextLetter = new System.Windows.Forms.Label();
            this.lblalreadycollected = new System.Windows.Forms.Label();
            this.lblnextocollect = new System.Windows.Forms.Label();
            this.lblHearts = new System.Windows.Forms.Label();
            this.lblHeartsCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameLayots)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbGameLayots
            // 
            this.pbGameLayots.BackColor = System.Drawing.SystemColors.ControlText;
            this.pbGameLayots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGameLayots.Location = new System.Drawing.Point(0, 0);
            this.pbGameLayots.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbGameLayots.Name = "pbGameLayots";
            this.pbGameLayots.Size = new System.Drawing.Size(600, 510);
            this.pbGameLayots.TabIndex = 0;
            this.pbGameLayots.TabStop = false;
            this.pbGameLayots.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGameLayots_Paint_1);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(608, 50);
            this.lblScore.Name = "lblScore";
            this.lblScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblScore.Size = new System.Drawing.Size(103, 37);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score:";
            // 
            // lblScoreCounter
            // 
            this.lblScoreCounter.AutoSize = true;
            this.lblScoreCounter.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreCounter.Location = new System.Drawing.Point(757, 50);
            this.lblScoreCounter.Name = "lblScoreCounter";
            this.lblScoreCounter.Size = new System.Drawing.Size(27, 26);
            this.lblScoreCounter.TabIndex = 2;
            this.lblScoreCounter.Text = "0";
            // 
            // lblCollectedLetters
            // 
            this.lblCollectedLetters.AutoSize = true;
            this.lblCollectedLetters.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollectedLetters.Location = new System.Drawing.Point(611, 116);
            this.lblCollectedLetters.Name = "lblCollectedLetters";
            this.lblCollectedLetters.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCollectedLetters.Size = new System.Drawing.Size(188, 25);
            this.lblCollectedLetters.TabIndex = 3;
            this.lblCollectedLetters.Text = "Collected Letters:";
            // 
            // lbNextLetter
            // 
            this.lbNextLetter.AutoSize = true;
            this.lbNextLetter.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNextLetter.Location = new System.Drawing.Point(610, 248);
            this.lbNextLetter.Name = "lbNextLetter";
            this.lbNextLetter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbNextLetter.Size = new System.Drawing.Size(244, 25);
            this.lbNextLetter.TabIndex = 4;
            this.lbNextLetter.Text = "Next Letter to collect:";
            // 
            // lblalreadycollected
            // 
            this.lblalreadycollected.AutoSize = true;
            this.lblalreadycollected.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalreadycollected.Location = new System.Drawing.Point(632, 159);
            this.lblalreadycollected.Name = "lblalreadycollected";
            this.lblalreadycollected.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblalreadycollected.Size = new System.Drawing.Size(0, 22);
            this.lblalreadycollected.TabIndex = 5;
            // 
            // lblnextocollect
            // 
            this.lblnextocollect.AutoSize = true;
            this.lblnextocollect.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnextocollect.Location = new System.Drawing.Point(642, 293);
            this.lblnextocollect.Name = "lblnextocollect";
            this.lblnextocollect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblnextocollect.Size = new System.Drawing.Size(0, 26);
            this.lblnextocollect.TabIndex = 6;
            // 
            // lblHearts
            // 
            this.lblHearts.AutoSize = true;
            this.lblHearts.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHearts.Location = new System.Drawing.Point(611, 357);
            this.lblHearts.Name = "lblHearts";
            this.lblHearts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHearts.Size = new System.Drawing.Size(84, 25);
            this.lblHearts.TabIndex = 7;
            this.lblHearts.Text = "Hearts:";
            // 
            // lblHeartsCounter
            // 
            this.lblHeartsCounter.AutoSize = true;
            this.lblHeartsCounter.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeartsCounter.Location = new System.Drawing.Point(711, 353);
            this.lblHeartsCounter.Name = "lblHeartsCounter";
            this.lblHeartsCounter.Size = new System.Drawing.Size(31, 31);
            this.lblHeartsCounter.TabIndex = 8;
            this.lblHeartsCounter.Text = "3";
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.lblHeartsCounter);
            this.Controls.Add(this.lblHearts);
            this.Controls.Add(this.lblnextocollect);
            this.Controls.Add(this.lblalreadycollected);
            this.Controls.Add(this.lbNextLetter);
            this.Controls.Add(this.lblCollectedLetters);
            this.Controls.Add(this.lblScoreCounter);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbGameLayots);
            this.Name = "GameBoard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Snake GameBoard";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameBoard_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameLayots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbGameLayots;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreCounter;
        private System.Windows.Forms.Label lblCollectedLetters;
        private System.Windows.Forms.Label lbNextLetter;
        private System.Windows.Forms.Label lblalreadycollected;
        private System.Windows.Forms.Label lblnextocollect;
        private System.Windows.Forms.Label lblHearts;
        private System.Windows.Forms.Label lblHeartsCounter;
    }
}