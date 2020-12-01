using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AExTechnical
{
    public class FileRow
    {
        public string IP { get; set; }
        public RowValues Values { get; set; } = new RowValues();
        public FileRow() { }
        public FileRow(FileRow fileRow)
        {
            IP = fileRow.IP;
            Values = new RowValues() { Values = new List<string>(fileRow.Values.Values) };
        }

        public static FileRow operator +(FileRow fileRow1, FileRow fileRow2)
        {
            FileRow resultFileRow = new FileRow() { IP = fileRow1.IP, Values = fileRow1.Values + fileRow2.Values };

            resultFileRow.Values.Values = resultFileRow.Values.Values.Distinct().OrderBy(val => Convert.ToInt32(val)).ToList();

            return resultFileRow;
        }

        public bool AddValues(List<string> values)
        {
            if (values != null)
            {
                for (int i = 0; i < values.Count; i++)
                {
                    Values.Values.Add(values[i]);
                }

                Values.Values = Values.Values.Distinct().OrderBy(value => Convert.ToInt32(value)).ToList();

                return true;
            }

            return false;
        }
        public override string ToString()
        {
            List<string> values = new List<string>();

            foreach(string value in Values.Values)
            {
                values.Add(value);
            }

            string result = string.Join(",", values);

            return $"{IP}: {result}";
        }

        public override bool Equals(object obj)
        {
            FileRow fileRow = (FileRow)obj;
            bool IPEqual = fileRow.IP.Equals(IP);

            int valuesEqual = 0;

            foreach(string value in fileRow.Values.Values)
            {
                if(Values.Values.Any(val => val.Equals(value)))
                {
                    valuesEqual++;
                }
            }

            if(IPEqual && valuesEqual == fileRow.Values.Values.Count && valuesEqual == Values.Values.Count)
            {
                return true;
            }

            return false;
        }
    }
}
