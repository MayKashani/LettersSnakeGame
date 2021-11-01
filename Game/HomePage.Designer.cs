namespace Game
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnClientWord = new System.Windows.Forms.Button();
            this.btnByABC = new System.Windows.Forms.Button();
            this.txtboxPlayerWord = new System.Windows.Forms.TextBox();
            this.btnStartPlaying = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.ttInstractions = new System.Windows.Forms.ToolTip(this.components);
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Snap ITC", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(288, 84);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(281, 63);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome!";
            // 
            // btnClientWord
            // 
            this.btnClientWord.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientWord.Location = new System.Drawing.Point(222, 185);
            this.btnClientWord.Name = "btnClientWord";
            this.btnClientWord.Size = new System.Drawing.Size(425, 59);
            this.btnClientWord.TabIndex = 1;
            this.btnClientWord.Text = "Play with your word";
            this.btnClientWord.UseVisualStyleBackColor = true;
            this.btnClientWord.Click += new System.EventHandler(this.btnClientWord_Click);
            // 
            // btnByABC
            // 
            this.btnByABC.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByABC.Location = new System.Drawing.Point(222, 328);
            this.btnByABC.Name = "btnByABC";
            this.btnByABC.Size = new System.Drawing.Size(425, 59);
            this.btnByABC.TabIndex = 2;
            this.btnByABC.Text = "Play by ABC order";
            this.btnByABC.UseVisualStyleBackColor = true;
            this.btnByABC.Click += new System.EventHandler(this.btnByABC_Click);
            // 
            // txtboxPlayerWord
            // 
            this.txtboxPlayerWord.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPlayerWord.Location = new System.Drawing.Point(222, 250);
            this.txtboxPlayerWord.Name = "txtboxPlayerWord";
            this.txtboxPlayerWord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtboxPlayerWord.Size = new System.Drawing.Size(353, 40);
            this.txtboxPlayerWord.TabIndex = 3;
            this.txtboxPlayerWord.Text = "Write a word to play with!";
            this.txtboxPlayerWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxPlayerWord.Visible = false;
            // 
            // btnStartPlaying
            // 
            this.btnStartPlaying.Location = new System.Drawing.Point(581, 250);
            this.btnStartPlaying.Name = "btnStartPlaying";
            this.btnStartPlaying.Size = new System.Drawing.Size(66, 43);
            this.btnStartPlaying.TabIndex = 4;
            this.btnStartPlaying.Text = "Start";
            this.btnStartPlaying.UseVisualStyleBackColor = true;
            this.btnStartPlaying.Visible = false;
            this.btnStartPlaying.Click += new System.EventHandler(this.btnStartPlaying_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblInstructions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInstructions.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(31, 28);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblInstructions.Size = new System.Drawing.Size(46, 52);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = "?";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ttInstractions.SetToolTip(this.lblInstructions, resources.GetString("lblInstructions.ToolTip"));
            // 
            // ttInstractions
            // 
            this.ttInstractions.AutomaticDelay = 200;
            this.ttInstractions.AutoPopDelay = 10000;
            this.ttInstractions.InitialDelay = 200;
            this.ttInstractions.IsBalloon = true;
            this.ttInstractions.ReshowDelay = 0;
            this.ttInstractions.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttInstractions.ToolTipTitle = "Game instructions";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(236, 293);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(348, 18);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "* Please enter only ENGLISH LETTERS word";
            this.lblError.Visible = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnStartPlaying);
            this.Controls.Add(this.txtboxPlayerWord);
            this.Controls.Add(this.btnByABC);
            this.Controls.Add(this.btnClientWord);
            this.Controls.Add(this.lblWelcome);
            this.Name = "HomePage";
            this.Text = "Snake Homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnClientWord;
        private System.Windows.Forms.Button btnByABC;
        private System.Windows.Forms.TextBox txtboxPlayerWord;
        private System.Windows.Forms.Button btnStartPlaying;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.ToolTip ttInstractions;
        private System.Windows.Forms.Label lblError;
    }
}

