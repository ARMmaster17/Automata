﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata
{
     public static class Builder
    {
        public static Image BuildWorldImage(int iterations, int width, int height, List<Rule> ruleList )
        {
            return BuildMap(iterations, width, height, BuildStructure(iterations, ruleList));
        }

        public static Image BuildWorldImage(int iterations, List<Rule> ruleList)
        {
            return BuildWorldImage(iterations, Row.GetRowSize(iterations), iterations, ruleList);
        }

        private static List<Row> BuildStructure(int iterations, List<Rule> ruleList)
        {
            List<Row> rows = new List<Row>();
            Row firstRow = new Row(1);
            firstRow.FillRow(1);
            rows.Add(firstRow);
            Row prevRow = firstRow;
            for (int i = 2; i <= iterations; i++)
            {
                Row newRow = new Row(i);
                newRow.FillRow(prevRow, ruleList);
                rows.Add(newRow);
                prevRow = newRow;
            }
            return rows;
        }

        private static Image BuildMap(int iterations, int width, int height, List<Row> structure)
        {
            Bitmap worldBitmap = new Bitmap(width, height);
            Graphics worldGraphics = Graphics.FromImage(worldBitmap);

            return worldBitmap;
        }
    }
}
