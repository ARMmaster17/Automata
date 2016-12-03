using System;
using Automata.Properties;

namespace Automata
{
    public class Rule
    {
        private int[] _testCase = {0, 0, 0};
        private string _name = "Rule";

        /// <summary>
        /// Default constructor for Rule class.
        /// </summary>
        public Rule()
        {
            // Use default of all empty returns empty color.
        }

        /// <summary>
        /// Constructor for Rule class.
        /// </summary>
        /// <param name="testPattern">Color pattern that makes this rule return true.</param>
        /// <param name="trueColor">Color to return if rule pattern is matched.</param>
        public Rule(int[] testPattern, int trueColor)
        {
            if (testPattern.Length != 3)
            {
                throw new ArgumentException(Resources.error2 + testPattern.Length, nameof(testPattern));
            }
            _testCase = testPattern;
            Color = trueColor;
        }

        /// <summary>
        /// Constructor for Rule class.
        /// </summary>
        /// <param name="testPattern">Color pattern that makes this rule return true.</param>
        /// <param name="trueColor">Color to return if rule pattern is matched.</param>
        /// <param name="ruleName">Name of rule.</param>
        public Rule(int[] testPattern, int trueColor, string ruleName)
        {
            if (testPattern.Length != 3)
            {
                throw new ArgumentException(Resources.error2 + testPattern.Length, nameof(testPattern));
            }
            _testCase = testPattern;
            Color = trueColor;
            Name = ruleName;
        }

        public bool Test(int blockLeft, int blockMid, int blockRight)
        {
            return _testCase[0] == blockLeft && _testCase[1] == blockMid && _testCase[2] == blockRight;
        }

        public int Color { get; set; }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException(Resources.error3, nameof(value));
                }
                _name = value;
            }
        }

        public int[] Pattern
        {
            get { return _testCase; }
            set
            {
                if (value.Length != 3)
                {
                    throw new ArgumentException(Resources.error2 + value.Length, nameof(value));
                }
                _testCase = value;
            }
        }
    }
}
