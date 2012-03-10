using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using System.Xml.Linq;
using System.Linq;

namespace RegExplore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxRegEx.Text = Properties.Settings.Default.RegEx;
            textBoxSample.Text = Properties.Settings.Default.Sample;
            FillTemplate();
        }

        private void buttonMatch_Click(object sender, EventArgs e)
        {
            var re = new Regex(textBoxRegEx.Text);
            var ms = re.Matches(textBoxSample.Text);
            labelMatchesCount.Text = ms.Count.ToString();

            Properties.Settings.Default.RegEx = textBoxRegEx.Text;
            Properties.Settings.Default.Sample = textBoxSample.Text;
            Properties.Settings.Default.Save();

            listBoxMatches.Items.Clear();

            foreach (var m in ms)
            {
                listBoxMatches.Items.Add(m.ToString());
            }
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            var re = new Regex(textBoxRegEx.Text);
            var ms = re.Matches(textBoxSample.Text);
            labelMatchesCount.Text = ms.Count.ToString();

            Properties.Settings.Default.RegEx = textBoxRegEx.Text;
            Properties.Settings.Default.Sample = textBoxSample.Text;
            Properties.Settings.Default.Save();

            var rep = re.Replace(textBoxSample.Text, textBoxReplaceText.Text);

            listBoxMatches.Items.Clear();
            listBoxMatches.Items.Add(rep);
        }

        Dictionary<string,string> items = new Dictionary<string, string>();

        private void FillTemplate()
        {
            var xd = XDocument.Load("RegExTemplate.xml");

            var xr = from x in xd.Elements("template")
                 select x;


            foreach (var y in xr.Elements())
            {
                var d = y.Attribute("d").Value;
                var e = y.Attribute("ex").Value;
                items.Add(e, d);
            }

            foreach (var i in items)
            {
       
                listBoxTemplates.Items.Add(i);
            }

            
            
        }

        private void listBoxTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = (KeyValuePair<string,string>)listBoxTemplates.SelectedItem;
            textBoxRegEx.Text = textBoxRegEx.Text + i.Key;
            
        }
    }
}
