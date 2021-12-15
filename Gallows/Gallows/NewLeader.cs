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
    public partial class NewLeader : Form
    {
        int score;
        public NewLeader(int sc)
        {
            InitializeComponent();
            score = sc;
            scoreInfo.Text = "Количество набраных очков - " + score;
        }

        private void addLeader_Click(object sender, EventArgs e)
        {
            string filename = "./leaders.xml";

            XmlReader xmlReader = XmlReader.Create(filename);

            List<string> leadersName = new List<string>();
            List<int> leadersRating = new List<int>();
            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "leader"))
                {
                    leadersName.Add(xmlReader.GetAttribute("name"));
                    leadersRating.Add(Convert.ToInt32(xmlReader.GetAttribute("rating")));                    
                }
            }
            xmlReader.Close();





            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Leaders");
            xmlDoc.AppendChild(rootNode);

            for (int i = 0; i < leadersName.Count && i < 19; i++)
            {

                if(score> leadersRating[i])
                { 
                    XmlNode cellNodeNew = xmlDoc.CreateElement("leader");
                    XmlAttribute attribute1New = xmlDoc.CreateAttribute("name");
                    attribute1New.Value = leaderName.Text;
                    cellNodeNew.Attributes.Append(attribute1New);
                    XmlAttribute attribute2New = xmlDoc.CreateAttribute("rating");
                    attribute2New.Value = score.ToString();
                    cellNodeNew.Attributes.Append(attribute2New);
                    rootNode.AppendChild(cellNodeNew);
                    score = 0;
                }

                XmlNode cellNode = xmlDoc.CreateElement("leader");
                XmlAttribute attribute1 = xmlDoc.CreateAttribute("name");
                attribute1.Value = leadersName[i];
                cellNode.Attributes.Append(attribute1);
                XmlAttribute attribute2 = xmlDoc.CreateAttribute("rating");
                attribute2.Value = leadersRating[i].ToString();
                cellNode.Attributes.Append(attribute2);
                rootNode.AppendChild(cellNode);
            }               

            xmlDoc.Save(filename);

            MessageBox.Show("Запись добавлена");
            this.Close();
        }

        
    }
}
