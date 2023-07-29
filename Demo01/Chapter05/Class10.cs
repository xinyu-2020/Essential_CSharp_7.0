using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Class10
    {
        static void Main(string[] args)
        {
            int totalLineCount;
            if (args.Length > 1 )
            {
                totalLineCount = DirectoryCountLines(args[0], args[1]);
            }
            if (args.Length > 0)
            {
                totalLineCount = DirectoryCountLines(args[0]);
            }
            else
            {
                totalLineCount = DirectoryCountLines();
            }
            Console.WriteLine(totalLineCount);
        }

        private static int DirectoryCountLines(string directory, string extension)
        {
            int lineCount = 0;
            foreach (string file in Directory.GetFiles(directory, extension))
            {
                lineCount += DirectoryCountLines(file);
            }
            foreach (string subdirectory in Directory.GetFiles(directory, extension))
            {
                lineCount += CountLines(subdirectory);
            }
            return lineCount;
        }

        static int DirectoryCountLines()
        {
            return DirectoryCountLines(Directory.GetCurrentDirectory());
        }

        static int DirectoryCountLines(string directory)
        {
            return DirectoryCountLines(directory, "*.cs");
        }
        static int CountLines(string file)
        {
            int lineCount = 0;
            string line;
            FileStream stream=new FileStream(file,FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            line = reader.ReadLine();
            while (line != null)
            {
                if(line.Trim()!="")
                {
                    lineCount++;
                }
                line = reader.ReadLine();
            }
            reader.Close();
            return lineCount;
        }
        
    }
}
