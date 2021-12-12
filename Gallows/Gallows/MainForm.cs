using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gallows
{
    public partial class MainForm : Form
    {
        int level;
        string word = "БАЛДА";
        byte step = 0;
        public MainForm(int levelGame)
        {
            InitializeComponent();
            level = levelGame;
        }
        private void NewWord()
        {
            wordLabel.Text = "";
            for (int i=0; i<word.Length*2; i+=2)            
                wordLabel.Text = wordLabel.Text.Insert(i, "_ ");    
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NewWord();
        }

        private bool ChekWin()
        {
            if (wordLabel.Text.IndexOf("_") >= 0)
            {

                return false;
            }
            else
                return true;
        }


        private void char_Click(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            string ch = button.Text;
            (sender as Button).Enabled = false;
            if (word.IndexOf(ch) != -1)
            {
                char[] chArr = word.ToCharArray();
                for (int index = 0; index < chArr.Length; index++)
                {
                    if (chArr[index] == ch[0])
                    {
                        wordLabel.Text = wordLabel.Text.Remove(index * 2, 1).Insert(index * 2, ch);
                        if (ChekWin())
                        {
                            MessageBox.Show("Победа");
                            break;
                        }

                    }
                }
            }
            else
            {
                gallowProgress.ImageLocation = "img/Gallows-step " + ++step + ".jpg";
                if(step == 7)
                {
                    MessageBox.Show("Поражение");
                }
            }

        }
    }
}
