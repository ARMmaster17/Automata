using Microsoft.VisualStudio.TestTools.UnitTesting;
using Automata;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata.Tests
{
    [TestClass()]
    public class BuilderTests
    {
        [TestMethod()]
        public void BuildSmallWorldImageTest()
        {
            Image i = Builder.BuildWorldImage(5, GetDefaultRules());
            Assert.IsNotNull(i);
        }
        [TestMethod()]
        public void BuildFixedWorldImageTest()
        {
            Image i = Builder.BuildWorldImage(10, 30, 12, GetDefaultRules());
            Assert.IsNotNull(i);
        }
        [TestMethod()]
        public void BuildLargeWorldImageTest()
        {
            Image i = Builder.BuildWorldImage(1000, GetDefaultRules());
            Assert.IsNotNull(i);
        }

        private static List<Rule> GetDefaultRules()
        {
            List<Rule> ruleList = new List<Rule>
            {
                new Rule(new[] {1, 1, 1}, 0, "Rule A"),
                new Rule(new[] {1, 1, 0}, 0, "Rule B"),
                new Rule(new[] {1, 0, 1}, 0, "Rule C"),
                new Rule(new[] {1, 0, 0}, 1, "Rule D"),
                new Rule(new[] {0, 1, 1}, 1, "Rule E"),
                new Rule(new[] {0, 1, 0}, 1, "Rule F"),
                new Rule(new[] {0, 0, 1}, 1, "Rule G"),
                new Rule(new[] {0, 0, 0}, 0, "Rule H")
            };
            return ruleList;
        }
    }
}