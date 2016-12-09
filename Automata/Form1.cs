using System;
using System.Collections.Generic;
using System.Drawing;
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
            LoadDefaultRules();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ruleList.Add(new Rule(new[] { 0, 0, 0 }, 0, "Rule " + _ruleCounter));
            _ruleCounter++;
            RepopulateRuleList();
        }

        public void LoadDefaultRules()
        {
            _ruleList.Clear();
            _ruleList.Add(new Rule(new[] { 1, 1, 1 }, 0, "Rule A"));
            _ruleList.Add(new Rule(new[] { 1, 1, 0 }, 0, "Rule B"));
            _ruleList.Add(new Rule(new[] { 1, 0, 1 }, 0, "Rule C"));
            _ruleList.Add(new Rule(new[] { 1, 0, 0 }, 1, "Rule D"));
            _ruleList.Add(new Rule(new[] { 0, 1, 1 }, 1, "Rule E"));
            _ruleList.Add(new Rule(new[] { 0, 1, 0 }, 1, "Rule F"));
            _ruleList.Add(new Rule(new[] { 0, 0, 1 }, 1, "Rule G"));
            _ruleList.Add(new Rule(new[] { 0, 0, 0 }, 0, "Rule H"));
            RepopulateRuleList();
        }

        /// <summary>
        /// Repopulates listBox1 items to reflect the current Rule list.
        /// </summary>
        public void RepopulateRuleList()
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
                numericUpDown2.Value = (decimal)temp.Pattern[0];
                numericUpDown3.Value = (decimal)temp.Pattern[1];
                numericUpDown4.Value = (decimal)temp.Pattern[2];
            }
        }

        /// <summary>
        /// Copies data from properties pane into the source Rule object.
        /// </summary>
        public void SaveRuleProperties()
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
            //SaveRuleProperties();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //SaveRuleProperties();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            //SaveRuleProperties();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //SaveRuleProperties();
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDefaultRules();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveRuleProperties();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StartSimulation(5);
        }

        public void StartSimulation(int iterations)
        {
            pictureBox1.Image = Builder.BuildWorldImage(iterations, _ruleList);
        }

        public void ClearGraph()
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            StartSimulation(10);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            StartSimulation(100);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            StartSimulation(1000);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearGraph();
        }
    }
}
