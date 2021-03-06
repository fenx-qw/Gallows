using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Gallows
{
    public partial class MainForm : Form
    {
        int level;
        string word = "";
        byte step = 0;
        int score = 0;

        List<string> words = new List<string>();
        public MainForm(int levelGame)
        {
            InitializeComponent();
            level = levelGame;
        }

        private void LoadWords()
        {
            string path="";
            switch (level)
            {
                case 0:
                    path = "./easyWords.xml";
                    break;
                case 1:
                    path = "./mediumWords.xml";
                    break;
                case 2:
                    path = "./hardWords.xml";
                    break;
            }


            XmlReader xmlReader = XmlReader.Create(path);

            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "word"))                
                    if (xmlReader.HasAttributes)                    
                        words.Add(xmlReader.GetAttribute("value"));                
            }
            
        }

        private void NewWord()
        {
            foreach (Button btn in this.Controls.OfType<Button>())            
                btn.Enabled = true;
            
            if (words.Count > 0)
            {
                Random r = new Random();
                int n = r.Next(words.Count);
                word = words[n];
                words.RemoveAt(n);
                wordLabel.Text = "";
                for (int i = 0; i < word.Length * 2; i += 2)
                    wordLabel.Text = wordLabel.Text.Insert(i, "_ ");
            }
            else
                MessageBox.Show("Закончились слова в списке");
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadWords();
            NewWord();
        }

        private bool ChekWin()
        {
            if (wordLabel.Text.IndexOf("_") >= 0)
                return false;
            else
            {
                score += (level + 1) * word.Length;
                scoreInfo.Text = "Количество очков: " + score;
                NewWord();
                return true;
            }
                
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
                    MessageBox.Show("Вы проиграли, загаданное слово - " + word);
                    NewLeaderFormShow();
                    
                }
            }

        }

        private void NewLeaderFormShow()
        {
            string filename = "./leaders.xml";

            XmlReader xmlReader = XmlReader.Create(filename);

            int minScore = 0;
            
            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "leader"))
                {
                    minScore = Convert.ToInt32(xmlReader.GetAttribute("rating"));
                }
            }
            xmlReader.Close();

            if (score > minScore)
            {
                NewLeader form = new NewLeader(score);
                form.ShowDialog();
                score = 0;
            }
            else
            {
                foreach (Button btn in this.Controls.OfType<Button>())
                    btn.Enabled = false;
                restart.Enabled = true;
                close.Enabled = true;

            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            gallowProgress.ImageLocation = "img/Gallows-step 0.jpg";
            step = 0;
            foreach (Button btn in this.Controls.OfType<Button>())
                btn.Enabled = true;
            score = 0;
            scoreInfo.Text = "Количество очков: 0";
            NewWord();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NewLeaderFormShow();
        }
    }
}
