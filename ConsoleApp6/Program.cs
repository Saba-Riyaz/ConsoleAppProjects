using System;

namespace CSharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, f = 0;
            Console.Write("Enter a Number: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    f++;
                }
            }
            if (f == 2)
            {
                Console.WriteLine("Number is Prime.");
            }
            else
            {
                Console.WriteLine("Number is Not Prime.");
            }

            Console.ReadLine();
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            int num , f=0;
            Console.WriteLine("Num is prime =");
            Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num is not prime=");
            Convert.ToInt32(Console.ReadLine());

                    
           
        }
    }
}