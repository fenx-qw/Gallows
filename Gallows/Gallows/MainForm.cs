﻿using System;
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
        public MainForm(int levelGame)
        {
            InitializeComponent();
            level = levelGame;
        }
    }
}
