using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AExTechnical
{
    public class DataFile
    {
        public List<FileRow> FileRows { get; set; } = new List<FileRow>();

        public DataFile() { }

        public DataFile(DataFile dataFile)
        {
            FileRows = new List<FileRow>(dataFile.FileRows);
        }

        public DataFile(List<string> fileRead)
        {
            List<FileRow> fileRows = new List<FileRow>();
            for(int i = 0; i < fileRead.Count; i++)
            {
                FileRow fileRow = new FileRow
                {
                    IP = fileRead[i].Substring(0, 7)
                };

                fileRow.Values.Values = fileRead[i].Substring(9, fileRead[i].Length - 9).Split(',').Distinct().OrderBy(val => Convert.ToInt32(val)).ToList();

                fileRows.Add(fileRow);
            }

            FileRows = fileRows;

        }

        public static DataFile operator +(DataFile dataFile1, DataFile dataFile2)
        {
            List<FileRow> file1Rows = dataFile1.FileRows;
            List<FileRow> file2Rows = dataFile2.FileRows;

            List<FileRow> addedRows = new List<FileRow>();
            file1Rows.ForEach(row => addedRows.Add(new FileRow(row)));

            for (int i = 0; i < file2Rows.Count; i++)
            {
                string IPmatch = file2Rows[i].IP;

                if (addedRows.Any(row => row.IP.Equals(IPmatch)))
                {
                    FileRow rowMatch = addedRows.Find(row => row.IP.Equals(IPmatch));

                    addedRows[addedRows.IndexOf(rowMatch)].AddValues(file2Rows[i].Values.Values);
                }
                else
                {
                    addedRows.Add(file2Rows[i]);
                }
            }

            return new DataFile() { FileRows = addedRows.Distinct().OrderBy(row => row.IP).ToList() };
        }

        public override string ToString()
        {
            string rows = "";
            foreach(FileRow file in FileRows)
            {
                rows += file + " ";
            }
            return $"{rows}";
        }

        public override bool Equals(object obj)
        {
            DataFile file = (DataFile)obj;

            int matchesCount = 0;

            for(int i = 0; i < file.FileRows.Count; i++)
            {
                if(FileRows.Any(fileRow => fileRow.Equals(file.FileRows[i])))
                {
                    matchesCount++;
                }
            }

            if(matchesCount == FileRows.Count && matchesCount == file.FileRows.Count)
            {
                return true;
            }

            return false;
        }
    }
}
