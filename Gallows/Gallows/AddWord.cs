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
    public partial class AddWord : Form
    {
        public AddWord()
        {
            InitializeComponent();
        }

        List<string> words = new List<string>();


        private void addNewWord_Click(object sender, EventArgs e)
        {
            string path = "";
            
                if(easyRadio.Checked)
                    path = "./easyWords.xml";
                else if(normalRadio.Checked)
                    path = "./mediumWords.xml";
                    else
                    path = "./hardWords.xml";    

            XmlReader xmlReader = XmlReader.Create(path);

            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "word"))
                    if (xmlReader.HasAttributes)
                        words.Add(xmlReader.GetAttribute("value"));
            }
            words.Add(word.Text.ToUpper());
            xmlReader.Close();

            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Words");
            xmlDoc.AppendChild(rootNode);

            for (int i = 0; i < words.Count; i++)
            {
               
                XmlNode cellNode = xmlDoc.CreateElement("word");
                XmlAttribute attribute1 = xmlDoc.CreateAttribute("value");
                attribute1.Value = words[i];
                cellNode.Attributes.Append(attribute1);
                rootNode.AppendChild(cellNode);
            }
            xmlDoc.Save(path);
            word.Text = "";
            MessageBox.Show("Запись добавлена");
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
