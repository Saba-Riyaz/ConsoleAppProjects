using System.Net;
using System.Transactions;

namespace practise
{
    class program
    {
        static void Main(string[] args)
        {

            long year;
            Console.WriteLine("please enter a year");
            year = Convert.ToInt16(Console.ReadLine());
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine("year is leap");
                }
                else
                {
                    Console.WriteLine("year is not leap");
                }


            else
                {
                    if (year % 4 == 0)
                    {
                        Console.WriteLine("year is leap");
                    }
                    else
                    {
                        Console.WriteLine("year is not leap");
                    }
                }
            }
        }
    }


}
    }
}





















        
    


