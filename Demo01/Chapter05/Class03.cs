using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Class03
    {
        static int Main(string[] args)
        {
            //此代码有问题
            int result;
            string targetFileName;
            string url;
            switch (args.Length)
            {
                default:
                    Console.WriteLine("ERROR:you must specify the"+"URL and the file name");
                    targetFileName = null;
                    url = null;
                    break;
                case 2:
                    url = args[0];
                    targetFileName = args[1];
                    break;
            }
            if (targetFileName!=null && url!=null)
            {
                WebClient webclient = new WebClient();
                webclient.DownloadFile(url, targetFileName);
                result = 0;
            }
            else
            {
                Console.WriteLine("Usage:Downloader.exe <url><TargetFileName>");
                result = 1;
            }
            return result;
        }
    }
}
