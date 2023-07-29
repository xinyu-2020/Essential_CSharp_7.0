using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Class09
    {
        public static void Main(string[] args)
        {
            int totalLineCount = 0;
            string directory;
            if (args.Length > 0)
            {
                directory = args[0];
            }
            else
            {
               //当前目录
                directory=Directory.GetCurrentDirectory();
            }
            //统计行数，并输出
            totalLineCount = DirectoryCountLines(directory);
            Console.WriteLine(totalLineCount);
            Console.ReadLine();
        }

        static int DirectoryCountLines(string directory)
        {
            int lineCount = 0;
            //返回文件数组
            foreach(string file in Directory.GetFiles(directory,"*.cs"))
            {
                lineCount += CountLines(file);
            }
            //返回目录的子目录完整名称的数组
            foreach (string subdirectory in Directory.GetDirectories(directory))
            {
                lineCount += DirectoryCountLines(subdirectory);
            }
            return lineCount;
        }
        static int CountLines(string file)
        {
            string line;
            int lineCount = 0;
            FileStream stream=new FileStream(file, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            //读取一行，返回下一行，末尾处为null
            line = reader.ReadLine();
            while (line != null)
            {
                //移除前后的空白字符
                if (line.Trim() != "")
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
