using Microsoft.VisualStudio.TestTools.UnitTesting;

// ReSharper disable once CheckNamespace
namespace Automata.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            var f = new Form1();
            f.Show();
        }

        [TestMethod()]
        public void Form1RuleMod()
        {
            var f = new Form1();
            f.Show();
            f.RepopulateRuleList();
            f.LoadDefaultRules();
            //f.SaveRuleProperties();
        }
    }
}