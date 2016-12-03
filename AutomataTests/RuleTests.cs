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
    public class RuleTests
    {
        [TestMethod()]
        public void RuleTest()
        {
            Rule r = new Rule();
        }

        [TestMethod()]
        public void RuleTest1()
        {
            Rule r = new Rule(new[] {0, 0, 0}, 0);
        }

        [TestMethod()]
        public void RuleTest2()
        {
            Rule r = new Rule(new []{0, 0, 0}, 0, "Rule 1");
        }

        [TestMethod()]
        public void TestTest()
        {
            Rule r = new Rule(new[] { 0, 0, 0 }, 0);
            Assert.IsTrue(r.Test(0, 0, 0));
            Assert.IsFalse(r.Test(0, 1, 0));
        }
    }
}