
namespace four
{
    internal class Program
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







        }
    }
}





