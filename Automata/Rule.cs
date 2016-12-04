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

        /// <summary>
        /// Takes an nearest neighbors and checks against initialized rule pattern.
        /// </summary>
        /// <param name="blockLeft">Block up and to the left.</param>
        /// <param name="blockMid">Block directly above test square.</param>
        /// <param name="blockRight">Block up and to the right.</param>
        /// <returns>Result of test.</returns>
        public bool Test(int blockLeft, int blockMid, int blockRight)
        {
            return _testCase[0] == blockLeft && _testCase[1] == blockMid && _testCase[2] == blockRight;
        }

        /// <summary>
        /// Result color that should be set when rule returns true.
        /// </summary>
        public int Color { get; set; }

        /// <summary>
        /// Name of rule in GUI tool.
        /// </summary>
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

        /// <summary>
        /// Test pattern for check function.
        /// </summary>
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
