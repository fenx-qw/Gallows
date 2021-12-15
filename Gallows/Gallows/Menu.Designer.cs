
namespace Gallows
{
    partial class Menu
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
            this.startGame = new System.Windows.Forms.Button();
            this.leaderboard = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.reference = new System.Windows.Forms.Button();
            this.addWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startGame
            // 
            this.startGame.Location = new System.Drawing.Point(117, 39);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(160, 57);
            this.startGame.TabIndex = 0;
            this.startGame.Text = "Играть";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // leaderboard
            // 
            this.leaderboard.Location = new System.Drawing.Point(117, 209);
            this.leaderboard.Name = "leaderboard";
            this.leaderboard.Size = new System.Drawing.Size(160, 57);
            this.leaderboard.TabIndex = 2;
            this.leaderboard.Text = "Список лидеров";
            this.leaderboard.UseVisualStyleBackColor = true;
            this.leaderboard.Click += new System.EventHandler(this.leaderboard_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(117, 379);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(160, 57);
            this.exit.TabIndex = 4;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // reference
            // 
            this.reference.Location = new System.Drawing.Point(117, 294);
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(160, 57);
            this.reference.TabIndex = 3;
            this.reference.Text = "Справка";
            this.reference.UseVisualStyleBackColor = true;
            this.reference.Click += new System.EventHandler(this.reference_Click);
            // 
            // addWord
            // 
            this.addWord.Location = new System.Drawing.Point(117, 124);
            this.addWord.Name = "addWord";
            this.addWord.Size = new System.Drawing.Size(160, 57);
            this.addWord.TabIndex = 1;
            this.addWord.Text = "Добавить слова";
            this.addWord.UseVisualStyleBackColor = true;
            this.addWord.Click += new System.EventHandler(this.addWord_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 485);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.reference);
            this.Controls.Add(this.addWord);
            this.Controls.Add(this.leaderboard);
            this.Controls.Add(this.startGame);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Button leaderboard;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button reference;
        private System.Windows.Forms.Button addWord;
    }
}