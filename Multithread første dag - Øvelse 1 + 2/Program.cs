using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithread_første_dag___Øvelse_1___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(SaySomething);
            Thread t2 = new Thread(SaySomething2);
            t.Start();
            t2.Start();
            Console.ReadKey();
        }

        static void SaySomething()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("C#-trådning er nemt!");

            }
        }

        static void SaySomething2()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Også med flere tråde...");

            }
        }
    }
}
