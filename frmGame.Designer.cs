namespace Part_8
{
    partial class frmHangMan
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.lblUsed = new System.Windows.Forms.Label();
            this.lstGuessedLetters = new System.Windows.Forms.ListBox();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.imgHang = new System.Windows.Forms.PictureBox();
            this.lblEnusre = new System.Windows.Forms.Label();
            this.lblGuess = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Yellow;
            this.lblWelcome.Location = new System.Drawing.Point(9, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(280, 24);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome to Hang-Man Lite";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.BackColor = System.Drawing.Color.Transparent;
            this.lblRules.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.ForeColor = System.Drawing.Color.Crimson;
            this.lblRules.Location = new System.Drawing.Point(12, 33);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(495, 23);
            this.lblRules.TabIndex = 2;
            this.lblRules.Text = "Enter a letter to reveal a hidden word. 3 strikes and you are out";
            // 
            // lblUsed
            // 
            this.lblUsed.AutoSize = true;
            this.lblUsed.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsed.Location = new System.Drawing.Point(342, 145);
            this.lblUsed.Name = "lblUsed";
            this.lblUsed.Size = new System.Drawing.Size(169, 19);
            this.lblUsed.TabIndex = 3;
            this.lblUsed.Text = "Used Letters";
            this.lblUsed.Click += new System.EventHandler(this.lblUsed_Click);
            // 
            // lstGuessedLetters
            // 
            this.lstGuessedLetters.FormattingEnabled = true;
            this.lstGuessedLetters.Location = new System.Drawing.Point(331, 167);
            this.lstGuessedLetters.Name = "lstGuessedLetters";
            this.lstGuessedLetters.Size = new System.Drawing.Size(195, 212);
            this.lstGuessedLetters.TabIndex = 4;
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(331, 385);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(114, 20);
            this.txtGuess.TabIndex = 5;
            this.txtGuess.TextChanged += new System.EventHandler(this.txtGuess_TextChanged);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(451, 383);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 6;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.SystemColors.Control;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWord.Location = new System.Drawing.Point(7, 475);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(0, 24);
            this.lblWord.TabIndex = 7;
            this.lblWord.Click += new System.EventHandler(this.lblWord_Click);
            // 
            // imgHang
            // 
            this.imgHang.BackColor = System.Drawing.Color.Transparent;
            this.imgHang.Image = global::Part_8.Properties.Resources.hangman_empty;
            this.imgHang.Location = new System.Drawing.Point(12, 131);
            this.imgHang.Name = "imgHang";
            this.imgHang.Size = new System.Drawing.Size(313, 291);
            this.imgHang.TabIndex = 0;
            this.imgHang.TabStop = false;
            // 
            // lblEnusre
            // 
            this.lblEnusre.AutoSize = true;
            this.lblEnusre.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnusre.Location = new System.Drawing.Point(342, 408);
            this.lblEnusre.Name = "lblEnusre";
            this.lblEnusre.Size = new System.Drawing.Size(0, 19);
            this.lblEnusre.TabIndex = 8;
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess.Location = new System.Drawing.Point(342, 434);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(117, 19);
            this.lblGuess.TabIndex = 9;
            this.lblGuess.Text = "Guesses: ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(342, 464);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 19);
            this.lblResult.TabIndex = 10;
            // 
            // frmHangMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Part_8.Properties.Resources.Lego;
            this.ClientSize = new System.Drawing.Size(540, 535);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.lblEnusre);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lstGuessedLetters);
            this.Controls.Add(this.lblUsed);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.imgHang);
            this.Name = "frmHangMan";
            this.Text = "HangMan";
            this.Load += new System.EventHandler(this.frmHangMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgHang;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Label lblUsed;
        private System.Windows.Forms.ListBox lstGuessedLetters;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblEnusre;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Label lblResult;
    }
}

