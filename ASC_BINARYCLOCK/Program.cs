using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace BinaryClock
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer ceas = new System.Timers.Timer(1000.0); // interval de o secunda
            ceas.Elapsed += new ElapsedEventHandler(ceas_merge);
            Console.CursorVisible = false; // fara cursor
            ceas.Start(); // incepem timer-ul
            Console.ReadLine();
        }

        private static void ceas_merge(object source, ElapsedEventArgs e)
        {
            DateTime dt_now = DateTime.Now; // ora curenta pt sistem
            // facem conversia binara pt ore, minute si secunde
            string h = Convert.ToString(dt_now.Hour, 2).PadLeft(6, '0'); 
            String m = Convert.ToString(dt_now.Minute, 2).PadLeft(6, '0');
            String s = Convert.ToString(dt_now.Second, 2).PadLeft(6, '0');
            Console.SetCursorPosition(2, 1);
            Console.WriteLine($"H  * {h} *");
            Console.SetCursorPosition(2, 2);
            Console.WriteLine($"M  * {m} *");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine($"S  * {s} *");
        }
    }
}