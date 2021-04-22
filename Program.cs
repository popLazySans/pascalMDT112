using System;

namespace pasCal
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    while (count <= num)
                    {
                        for(int k = 0; k < count+1; k++)
                        {
                            Console.Write(pasCalculator(count,k));
                            Console.Write(" ");
                        }
                        count += 1;
                        Console.WriteLine("");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Pascal’s triangle row number.");
                }
            }
        }

       
        static int pasCalculator(int r, int c)
        {

            int p = Factorial(r)/(Factorial(c)*Factorial(r-c));
            return p;
        }
        static int Factorial(int num)
        {
            if (num>0) {
                int newNum = num;
                for (int i = 1; i < newNum; i++)
                {
                    num = num * i;
                }
            }
            else
            {
                num = 1;
            }
            return num;
        }
    }
}
