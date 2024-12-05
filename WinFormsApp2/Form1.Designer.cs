namespace WinFormsApp2
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            txtGuess = new TextBox();
            lblMessage = new Label();
            btnNewGame = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 148);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 106);
            label2.Name = "label2";
            label2.Size = new Size(297, 40);
            label2.TabIndex = 1;
            label2.Text = "I have a number between 1 and 100\r\nCan you guess mu number? Enter you guess\r\n";
            // 
            // txtGuess
            // 
            txtGuess.AccessibleName = "";
            txtGuess.Location = new Point(184, 179);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(125, 27);
            txtGuess.TabIndex = 2;
            txtGuess.TextChanged += txtGuess_TextChanged;
            txtGuess.KeyPress += txtGuess_KeyPress;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(329, 182);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(198, 20);
            lblMessage.TabIndex = 3;
            lblMessage.Text = "Guess result will appear here";
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(291, 228);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(94, 29);
            btnNewGame.TabIndex = 4;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNewGame);
            Controls.Add(lblMessage);
            Controls.Add(txtGuess);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Guessing Game ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtGuess;
        private Label lblMessage;
        private Button btnNewGame;
    }
}
