using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] persoane = new string[3];

            for (int i = 0; i<3;i++)
            {

                persoane[i] = Console.ReadLine().ToLower();


                List<char> letter = new List<char>();
                foreach(char a in persoane[i])
                {
                    letter.Add(a);
                }

                
                for (int j=0; j<letter.Count; j++)
                {
                    int contor = 1;
                    for (int k=j+1; k<letter.Count; k++)
                    {
                        if (letter[j] == letter[k])
                        {
                            contor++;
                            letter.RemoveAt(k);
                            k--;
                        }
                    }
                    Console.WriteLine(letter[j] + " appeared " + contor + " times");
                }


            }

            Console.WriteLine();
        }
    }
}
