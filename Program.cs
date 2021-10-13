using System;

namespace lineComparison_Day3
{
    class Program
    {        
            static double distance(int x1, int y1, int x2, int y2)
            {
                // Calculating distance
                return Math.Sqrt(Math.Pow(x2 - x1, 2) +
                              Math.Pow(y2 - y1, 2) * 1.0);
            }

            //Driver code
            public static void Main(string[] args)
            {
                Console.WriteLine(Math.Round(distance(7, 3, 3, 7)
                                           * 100000.0) / 100000.0);
                Console.ReadLine();
            }       
    }
}
