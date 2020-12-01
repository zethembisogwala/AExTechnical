using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AExTechnical
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of first file: ");
            string fileName1 = Console.ReadLine();

            Console.WriteLine("Enter name of second file: ");
            string fileName2 = Console.ReadLine();

            string printString;

            try
            {
                DataFile dataFile1 = VirtualFile.Create(fileName1);
                DataFile dataFile2 = VirtualFile.Create(fileName2);

                DataFile combinedFile = dataFile1 + dataFile2;

                printString = $"file1 (sorted, no duplicates): {dataFile1}"
                + $"\nfile2 (sorted, no duplicates): {dataFile2}"
                + $"\ncombined: {combinedFile}";
            }
            catch (Exception)
            {
                printString = "Please double-check your file names in the \\bin\\Debug\\data folder and try again. Do not type the file extension.";
            }

            Console.WriteLine(printString);


            Console.Read();
        }
    }
}
