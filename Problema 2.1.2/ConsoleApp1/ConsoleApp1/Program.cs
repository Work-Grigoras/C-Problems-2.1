using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string read = Console.ReadLine();

            string[] list = read.Split(' ');

            foreach (string numb in list)
            {
                if (numb.Contains('.'))
                    Console.WriteLine(numb);
            }

            double[] doubleArray = Array.ConvertAll(list, s => double.Parse(s));
            double min = doubleArray[0];

            for (int i =1;i< doubleArray.Length;i++)
            {
                if (min > doubleArray[i])
                    min = doubleArray[i];
            }

            Console.WriteLine("Minimul este: " + min);

            Console.ReadLine();

        }

    }
}