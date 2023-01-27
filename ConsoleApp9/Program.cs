using System.Globalization;

namespace Program
{
    class Product 
    {  
        static void Main(string[] args)
        {

                int num, product = 1;

               
                Console.Write("Enter any number: ");
                num = Convert.ToInt32(Console.ReadLine());

            while (++num < 1)
            {
                Console.WriteLine("Current value of n is", num);

               

                   
                    num = num * 10;
            }

                Console.WriteLine("Product of digits = " + product);

                Console.ReadLine();

        }
            









    }










}
