using Microsoft.VisualStudio.TestTools.UnitTesting;
using Automata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Form1 f = new Form1();
            f.Show();
        }

        [TestMethod()]
        public void Form1RuleMod()
        {
            Form1 f = new Form1();
            f.Show();
            f.RepopulateRuleList();
            f.LoadDefaultRules();
            //f.SaveRuleProperties();
        }
    }
}