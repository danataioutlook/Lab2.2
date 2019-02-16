using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //created txt for check
            string s = @"TextFile4.txt";
            //created file
            var c = File.Create(@"C:\Users\user\source\repos\ConsoleApp4\ConsoleApp4\Create\" + s);
            c.Close();
            //copied first file and deleted first file
            File.Copy(@"C:\Users\user\source\repos\ConsoleApp4\ConsoleApp4\Create\" + s, @"C:\Users\user\source\repos\ConsoleApp4\ConsoleApp4\Create1\" + s);
            File.Delete(@"C:\Users\user\source\repos\ConsoleApp4\ConsoleApp4\Create\" + s);

        }
    }
}
