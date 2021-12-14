
namespace Gallows
{
    partial class NewLeader
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
            this.leaderName = new System.Windows.Forms.TextBox();
            this.addLeader = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leaderName
            // 
            this.leaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leaderName.Location = new System.Drawing.Point(29, 95);
            this.leaderName.Name = "leaderName";
            this.leaderName.Size = new System.Drawing.Size(223, 26);
            this.leaderName.TabIndex = 0;
            // 
            // addLeader
            // 
            this.addLeader.Location = new System.Drawing.Point(302, 95);
            this.addLeader.Name = "addLeader";
            this.addLeader.Size = new System.Drawing.Size(112, 26);
            this.addLeader.TabIndex = 1;
            this.addLeader.Text = "ОК";
            this.addLeader.UseVisualStyleBackColor = true;
            this.addLeader.Click += new System.EventHandler(this.addLeader_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите ваше имя";
            // 
            // scoreInfo
            // 
            this.scoreInfo.AutoSize = true;
            this.scoreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.scoreInfo.Location = new System.Drawing.Point(26, 31);
            this.scoreInfo.Name = "scoreInfo";
            this.scoreInfo.Size = new System.Drawing.Size(222, 18);
            this.scoreInfo.TabIndex = 3;
            this.scoreInfo.Text = "Количество набраных очков - ";
            // 
            // NewLeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 146);
            this.Controls.Add(this.scoreInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addLeader);
            this.Controls.Add(this.leaderName);
            this.Name = "NewLeader";
            this.Text = "Имя игрока";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox leaderName;
        private System.Windows.Forms.Button addLeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreInfo;
    }
}