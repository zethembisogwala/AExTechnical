using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AExTechnical
{
    public static class VirtualFile
    {
        public static string GetFilePath(string fileName)
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"data\" + fileName + ".txt");
        }

        public static List<string> ReadFile(string filePath)
        {
            return new List<string>(File.ReadAllLines(filePath));
        }

        public static DataFile Create(string fileName)
        {
            string filePath = GetFilePath(fileName);
            List<string> file =  ReadFile(filePath);

            return new DataFile(file);
        }
    }
}
