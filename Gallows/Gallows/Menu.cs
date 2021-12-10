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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            LevelOfDifficulty form = new LevelOfDifficulty();
            form.ShowDialog();

        }

        private void addWord_Click(object sender, EventArgs e)
        {
            AddWord form = new AddWord();
            form.ShowDialog();
        }

        private void leaderboard_Click(object sender, EventArgs e)
        {
            Leaderboard form = new Leaderboard();
            form.ShowDialog();
        }

        private void reference_Click(object sender, EventArgs e)
        {
            Info form = new Info();
            form.ShowDialog();
        }
    }
}
