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
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            string filename = "./leaders.xml";

            XmlReader xmlReader = XmlReader.Create(filename);

            List<string> leadersName = new List<string>();
            List<int> leadersRating = new List<int>();
            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "leader"))
                {
                    leaderboardDataGrid.Rows.Add(xmlReader.GetAttribute("name"), xmlReader.GetAttribute("rating"));
                }
            }
            xmlReader.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
