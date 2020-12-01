using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AExTechnical
{
    public class RowValues
    {
        public List<string> Values { get; set; } = new List<string>();

        public RowValues() { }
        public RowValues(RowValues rowValues)
        {
            Values = new List<string>(rowValues.Values).ToList();
        }

        public static RowValues operator +(RowValues rowValues1, RowValues rowValues2)
        {
            RowValues rowValues = new RowValues() { Values = new List<string>(rowValues1.Values) };
            foreach(string rowValue in rowValues2.Values)
            {
                rowValues.Values.Add(rowValue);
            }
            rowValues.Values = rowValues.Values.Distinct().OrderBy(val => Convert.ToInt32(val)).ToList();
            return rowValues;
        }

        public override string ToString()
        {
            string rep = "";
            foreach(string value in Values)
            {
                rep += value + ", ";
            }
            return rep;
        }

        public override bool Equals(object obj)
        {
            RowValues rowValues = (RowValues)obj;
            int valueMatches = 0;
            for(int i = 0; i < rowValues.Values.Count; i++)
            {
                if(Values.Any(value => value.Equals(rowValues.Values[i])))
                {
                    valueMatches++;
                }
            }

            if(valueMatches == rowValues.Values.Count && valueMatches == Values.Count)
            {
                return true;
            }

            return false;
        }
    }
}
