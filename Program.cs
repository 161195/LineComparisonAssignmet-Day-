using System;

namespace lineComparison_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to line comparision computation program");
            //varibles declaration
            double x1, x2, y1, y2;    //taking user inputs of cartessian coordinates of line 1
            double len, length;
            double point1, point2;

            double x11, x22, y11, y22;    //taking user inputs of cartessian coordinates of line 2
            double len1, length1;
            double point3, point4;

            Console.WriteLine("Enter the coordinates for line number 1");
            Console.WriteLine();

            Console.WriteLine("Enter x1 of line1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1 of line1");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 of line1");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2 of line1");
            y2 = Convert.ToDouble(Console.ReadLine());

            //following inputs are for line number2
            Console.WriteLine();
            Console.WriteLine("Enter the coordinates for line number 2");
            Console.WriteLine();

            Console.WriteLine("Enter x1 of line2");
            x11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1 of line2");
            y11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 of line2");
            x22 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2 of line2");
            y22 = Convert.ToDouble(Console.ReadLine());

            //using the math class methods pow and sqrt to calculate the sqaures and square root as per the formula
            // formula is length = sqrt[(x2 -x1)^2 + (y2-y1)^2]
            point1 = Math.Pow((x2 - x1), 2);
            point2 = Math.Pow((y2 - y1), 2);
            len = point1 + point2;
            length = Math.Sqrt(len);

            point3 = Math.Pow((x22 - x11), 2);
            point4 = Math.Pow((y22 - y11), 2);
            len1 = point3 + point4;
            length1 = Math.Sqrt(len1);

            Console.WriteLine("The length of line 1 is: " + length);
            Console.WriteLine("The length of line 2 is: " + length1);
            Console.WriteLine();

            if (length == length1)                    // if statement for comparision
            {
                Console.WriteLine("Both the lines are equal");
            }
            else
            {
                Console.WriteLine("The lines aren't equal");
            }

        }
    }
}
