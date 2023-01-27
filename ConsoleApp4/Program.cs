using System.Data.SqlTypes;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, result;
                    
            Console.WriteLine("please enter the number /n");

            num = Convert.ToInt32(Console.ReadLine());
            result = num % 2;

            if (result == 0)
            {
                Console.WriteLine(" number is even ");
            }
            else
            {

                Console.WriteLine("number is odd");
            }
        }
    }


}
    






    



