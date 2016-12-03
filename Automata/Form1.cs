using System;
using System.Collections.Generic;
//using System.Drawing;
using System.Windows.Forms;
using Automata.Properties;

namespace Automata
{
    public partial class Form1 : Form
    {
        private readonly List<Rule> _ruleList = new List<Rule>();
        private int _ruleCounter = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _ruleList.Add(new Rule(new[] {0, 0, 0}, 0, "Rule 0"));
            RepopulateRuleList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ruleList.Add(new Rule(new[] { 0, 0, 0 }, 0, "Rule " + _ruleCounter));
            _ruleCounter++;
            RepopulateRuleList();
        }
        /// <summary>
        /// Repopulates listBox1 items to reflect the current Rule list.
        /// </summary>
        private void RepopulateRuleList()
        {
            listBox1.Items.Clear();
            foreach (var rule in _ruleList)
            {
                listBox1.Items.Add(rule.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ruleList.RemoveAt(listBox1.SelectedIndex);
            RepopulateRuleList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _ruleList.Clear();
            RepopulateRuleList();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            SaveRuleProperties();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show(Resources.error1);
            }
            else
            {
                Rule temp = _ruleList[listBox1.SelectedIndex];
                textBox1.Text = temp.Name;
                numericUpDown1.Value = temp.Color;
                numericUpDown2.Value = temp.Pattern[0];
                numericUpDown3.Value = temp.Pattern[1];
                numericUpDown4.Value = temp.Pattern[2];
            }
        }
        /// <summary>
        /// Copies data from properties pane into the source Rule object.
        /// </summary>
        private void SaveRuleProperties()
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show(Resources.error1);
            }
            else
            {
                _ruleList[listBox1.SelectedIndex].Name = textBox1.Text;
                _ruleList[listBox1.SelectedIndex].Color = (int)numericUpDown1.Value;
                int[] pattern = new int[3];
                pattern[0] = (int)numericUpDown2.Value;
                pattern[1] = (int)numericUpDown3.Value;
                pattern[2] = (int)numericUpDown4.Value;
                _ruleList[listBox1.SelectedIndex].Pattern = pattern;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SaveRuleProperties();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            SaveRuleProperties();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            SaveRuleProperties();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SaveRuleProperties();
        }
    }
}
