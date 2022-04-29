using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithread_første_dag___Øvelse_3
{
    static class Program
    {
        static int alarmCheck { get; set; }

        static void Main(string[] args)
        {
            Thread t = new Thread(GenerateNumber);
            t.Start();

            t.Join();

            for (; ; )
            {
                if (!t.IsAlive)
                {
                    Console.WriteLine("Alarm-tråd termineret!");
                    break;
                }
            }
        }

        static void GenerateNumber()
        {
            int alarmCheck = 0;
            Random r = new Random();
            for (; ; )
            {
                int temperatur = r.Next(-20, 121);
                Console.WriteLine(temperatur);

                if (temperatur < 0 || temperatur > 100)
                {
                    alarmCheck++;
                    Console.WriteLine("Alarm, temperatur is out of scope. Current alarms = " + alarmCheck);

                    if (alarmCheck == 3)
                    {
                        break;
                    }
                }
                Thread.Sleep(2000);
            }
        }
    }
}
