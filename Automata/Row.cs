using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata
{
    public class Row
    {
        private int[] _rowData;

        public Row(int iteration)
        {
            _rowData = new int[GetRowSize(iteration)];
        }

        public static int GetRowSize(int iteration)
        {
            return (iteration * 2) - 1;
        }

        public void FillRow(int value = 0)
        {
            for (int i = 0; i < _rowData.Length; i++)
            {
                _rowData[i] = value;
            }
        }

        public void FillRow(Row previousRow, List<Rule> ruleList)
        {
            for (int i = 0; i < _rowData.Length; i++)
            {
                int upLeft = previousRow[i - 2];
                int upUp = previousRow[i - 1];
                int upRight = previousRow[i];
                foreach (Rule rule in ruleList)
                {
                    if (rule.Test(upLeft, upUp, upRight))
                    {
                        _rowData[i] = rule.Color;
                        break;
                    }
                }
            }
        }

        public int this[int index]
        {
            get { return index < 0 || index >= _rowData.Length ? 0 : _rowData[index]; }
            set { _rowData[index] = value; }
        }
    }
}
