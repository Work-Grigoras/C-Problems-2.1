using System;

namespace Proiect_1
{
    class Program
    {


        static void Main(string[] args)
        {
            int num = Read();

            int reverse = Mirror(num);

            Console.WriteLine("The mirrored number is: " + reverse);

            PerfSquare(reverse);

            Console.ReadLine();
            
        }



        static int Read()
        {

            int ver = 1;
            int x=0;

            while (ver == 1)
            {
                Console.WriteLine("Enter a number of min 3 digits: ");
                x = Convert.ToInt32(Console.ReadLine());
                if (Math.Ceiling(Math.Log10(x)) >= 3)
                    ver = 0;
                else
                    Console.WriteLine("The number has less then 3 digits!");
            }

            return x;

        }



        static int Mirror(int x)
        {

            int y=0;

            while (x > 0)
            {
                int remainder = x % 10;
                y = (y * 10) + remainder;
                x = x / 10;
            }

            return y;

        }

        static void PerfSquare(int x)
        {

            double sq = Math.Sqrt(x);

            if (sq % 1 == 0)

            {
                Console.WriteLine(x + " is perfect square");
                Console.WriteLine(x + " = " + sq + " * " + sq + " - ok");
            }

            else
                Console.WriteLine(x + " is not a perfect square");

        }


    }
}
