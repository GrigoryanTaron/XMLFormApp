using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XMLFormApp
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
    }

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }
        public void CreatePerson()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("XMLFile1.xml");
            XmlElement? xRoot = xDoc.DocumentElement;
            XmlElement personElem = xDoc.CreateElement("person");
            XmlElement nameElem = xDoc.CreateElement("name");
            XmlElement companyElem = xDoc.CreateElement("company");
            XmlElement ageElem = xDoc.CreateElement("age");
            XmlText nameText = xDoc.CreateTextNode("Elon");
            XmlText companyText = xDoc.CreateTextNode("Tesla");
            XmlText ageText = xDoc.CreateTextNode("51");
            nameElem.AppendChild(nameText);
            companyElem.AppendChild(companyText);
            ageElem.AppendChild(ageText);
            personElem.AppendChild(nameElem);
            personElem.AppendChild(companyElem);
            personElem.AppendChild(ageElem);
            xRoot?.AppendChild(personElem);
            xDoc.Save("XMLFile1.xml");
        }
        public void GetAll()
        {
            XDocument xDoc = XDocument.Load("XMLFile1.xml");
            var persons = xDoc.Element("persons")
                .Elements("person")
                .Select(p => new Person
                {
                    Age = int.Parse(p.Element("age").Value.ToString()),
                    Name = p.Element("name").Value.ToString(),
                    Company = p.Element("company").Value.ToString()
                });
            XMLView.DataSource = persons.ToList();
        }
        public void Delete1()
        {
            XDocument xDoc = XDocument.Load("XMLFile1.xml");
            xDoc.Remove();
        }

        private void XMLView_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void GetBtn_Click(object sender, EventArgs e)
        {

        }

        private void CrateBtn_Click(object sender, EventArgs e)
        {
            CreatePerson();
            XMLView.DataSource = null;
            GetAll();
        }

        private void XMLView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
