using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleProgressBar;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var progressBar = new ProgressBar())
            {
                Console.WriteLine("A test...");
                int count = 100;
                for (int i = 0; i <= count; i++)
                {
                    Thread.Sleep(100);
                    progressBar.Report((double)i / count);
                }
            }
            Console.WriteLine("Finished Test");
            Console.Read();
        }
    }
}
