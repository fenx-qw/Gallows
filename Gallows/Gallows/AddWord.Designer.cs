
namespace Gallows
{
    partial class AddWord
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
            this.addNewWord = new System.Windows.Forms.Button();
            this.word = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hardRadio = new System.Windows.Forms.RadioButton();
            this.normalRadio = new System.Windows.Forms.RadioButton();
            this.easyRadio = new System.Windows.Forms.RadioButton();
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNewWord
            // 
            this.addNewWord.Location = new System.Drawing.Point(397, 98);
            this.addNewWord.Name = "addNewWord";
            this.addNewWord.Size = new System.Drawing.Size(103, 37);
            this.addNewWord.TabIndex = 0;
            this.addNewWord.Text = "Добавить";
            this.addNewWord.UseVisualStyleBackColor = true;
            this.addNewWord.Click += new System.EventHandler(this.addNewWord_Click);
            // 
            // word
            // 
            this.word.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.word.Location = new System.Drawing.Point(36, 57);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(152, 26);
            this.word.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hardRadio);
            this.groupBox1.Controls.Add(this.normalRadio);
            this.groupBox1.Controls.Add(this.easyRadio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(205, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Уровень сложности";
            // 
            // hardRadio
            // 
            this.hardRadio.AutoSize = true;
            this.hardRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hardRadio.Location = new System.Drawing.Point(6, 103);
            this.hardRadio.Name = "hardRadio";
            this.hardRadio.Size = new System.Drawing.Size(93, 22);
            this.hardRadio.TabIndex = 0;
            this.hardRadio.TabStop = true;
            this.hardRadio.Text = "Сложный";
            this.hardRadio.UseVisualStyleBackColor = true;
            // 
            // normalRadio
            // 
            this.normalRadio.AutoSize = true;
            this.normalRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normalRadio.Location = new System.Drawing.Point(6, 66);
            this.normalRadio.Name = "normalRadio";
            this.normalRadio.Size = new System.Drawing.Size(86, 22);
            this.normalRadio.TabIndex = 0;
            this.normalRadio.TabStop = true;
            this.normalRadio.Text = "Средний";
            this.normalRadio.UseVisualStyleBackColor = true;
            // 
            // easyRadio
            // 
            this.easyRadio.AutoSize = true;
            this.easyRadio.Checked = true;
            this.easyRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.easyRadio.Location = new System.Drawing.Point(7, 29);
            this.easyRadio.Name = "easyRadio";
            this.easyRadio.Size = new System.Drawing.Size(75, 22);
            this.easyRadio.TabIndex = 0;
            this.easyRadio.TabStop = true;
            this.easyRadio.Text = "Легкий";
            this.easyRadio.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(396, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(104, 41);
            this.close.TabIndex = 3;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите слово";
            // 
            // AddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 147);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.word);
            this.Controls.Add(this.addNewWord);
            this.Name = "AddWord";
            this.Text = "Добавить слово";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewWord;
        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton hardRadio;
        private System.Windows.Forms.RadioButton normalRadio;
        private System.Windows.Forms.RadioButton easyRadio;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
    }
}