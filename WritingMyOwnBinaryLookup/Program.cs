using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingMyOwnBinaryLookup
{
    class Program
    {
       public static DataFinder finder = new DataFinder();
        private static Stopwatch sw = new Stopwatch();

        static void Main(string[] args)
        {
            var theArray = finder.GenerateArray(10000000);

            sw.Start();
            finder.FindInt(255, theArray);
            sw.Stop();
            Console.WriteLine($"Elapsed Ticks: {sw.ElapsedTicks}");

            sw.Reset();
            sw.Start();
            finder.FindIntBuiltIn(255, theArray);
            sw.Stop();
            Console.WriteLine($"Elapsed Ticks: {sw.ElapsedTicks}");

        }
    }
}
