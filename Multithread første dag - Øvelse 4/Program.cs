using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithread_første_dag___Øvelse_4
{
    internal class Program
    {
        public static char ch { get; set; }
        public static char chWait { get; set; }


        static void Main(string[] args)
        {
            ch = '*';

            Thread printer = new Thread(Printer);
            printer.Start();

            Thread reader = new Thread(Reader);
            reader.SetApartmentState(ApartmentState.STA);
            reader.Start();

        }

        static void Printer()
        {
            for (; ; )
            {
                Console.Write(ch);
                Thread.Sleep(100);
            }
        }

        static void Reader()
        {
            for (; ; )
            {
                chWait = Console.ReadKey().KeyChar;

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    ch = chWait;
                    Console.WriteLine();

                }
            }
        }
    }
}
