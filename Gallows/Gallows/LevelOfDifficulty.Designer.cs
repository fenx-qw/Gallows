
namespace Gallows
{
    partial class LevelOfDifficulty
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
            this.easyLevel = new System.Windows.Forms.Button();
            this.normalLevel = new System.Windows.Forms.Button();
            this.hardLevel = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // easyLevel
            // 
            this.easyLevel.Location = new System.Drawing.Point(93, 64);
            this.easyLevel.Name = "easyLevel";
            this.easyLevel.Size = new System.Drawing.Size(188, 56);
            this.easyLevel.TabIndex = 0;
            this.easyLevel.Text = "Легкий";
            this.easyLevel.UseVisualStyleBackColor = true;
            this.easyLevel.Click += new System.EventHandler(this.easyLevel_Click);
            // 
            // normalLevel
            // 
            this.normalLevel.Location = new System.Drawing.Point(93, 154);
            this.normalLevel.Name = "normalLevel";
            this.normalLevel.Size = new System.Drawing.Size(188, 56);
            this.normalLevel.TabIndex = 0;
            this.normalLevel.Text = "Средний";
            this.normalLevel.UseVisualStyleBackColor = true;
            this.normalLevel.Click += new System.EventHandler(this.normalLevel_Click);
            // 
            // hardLevel
            // 
            this.hardLevel.Location = new System.Drawing.Point(93, 248);
            this.hardLevel.Name = "hardLevel";
            this.hardLevel.Size = new System.Drawing.Size(188, 56);
            this.hardLevel.TabIndex = 0;
            this.hardLevel.Text = "Сложный";
            this.hardLevel.UseVisualStyleBackColor = true;
            this.hardLevel.Click += new System.EventHandler(this.hardLevel_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(294, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(104, 41);
            this.close.TabIndex = 2;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // LevelOfDifficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 367);
            this.Controls.Add(this.close);
            this.Controls.Add(this.hardLevel);
            this.Controls.Add(this.normalLevel);
            this.Controls.Add(this.easyLevel);
            this.Name = "LevelOfDifficulty";
            this.Text = "Уровень сложности";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button easyLevel;
        private System.Windows.Forms.Button normalLevel;
        private System.Windows.Forms.Button hardLevel;
        private System.Windows.Forms.Button close;
    }
}