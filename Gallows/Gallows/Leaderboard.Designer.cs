
namespace Gallows
{
    partial class Leaderboard
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
            this.leaderboardDataGrid = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Button();
            this.NameLeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // leaderboardDataGrid
            // 
            this.leaderboardDataGrid.AllowUserToAddRows = false;
            this.leaderboardDataGrid.AllowUserToDeleteRows = false;
            this.leaderboardDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.leaderboardDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaderboardDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameLeader,
            this.Rating});
            this.leaderboardDataGrid.Location = new System.Drawing.Point(28, 59);
            this.leaderboardDataGrid.Name = "leaderboardDataGrid";
            this.leaderboardDataGrid.ReadOnly = true;
            this.leaderboardDataGrid.Size = new System.Drawing.Size(426, 283);
            this.leaderboardDataGrid.TabIndex = 0;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(350, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(104, 41);
            this.close.TabIndex = 2;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            // 
            // NameLeader
            // 
            this.NameLeader.FillWeight = 70F;
            this.NameLeader.HeaderText = "Имя";
            this.NameLeader.Name = "NameLeader";
            // 
            // Rating
            // 
            this.Rating.FillWeight = 30F;
            this.Rating.HeaderText = "Количество очков";
            this.Rating.Name = "Rating";
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 362);
            this.Controls.Add(this.close);
            this.Controls.Add(this.leaderboardDataGrid);
            this.Name = "Leaderboard";
            this.Text = "Таблица лидеров";
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView leaderboardDataGrid;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameLeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
    }
}