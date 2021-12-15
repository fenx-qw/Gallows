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
    public partial class LevelOfDifficulty : Form
    {
        public LevelOfDifficulty()
        {
            InitializeComponent();
        }

        private void easyLevel_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(0);
            form.ShowDialog();
        }

        private void normalLevel_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(1);
            form.ShowDialog();
        }

        private void hardLevel_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(2);
            form.ShowDialog();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
