using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ObjectiveC;

namespace ConsoleApp10
{
    public class percentage
    {
        public static void percent(int phy,int che,int maths)
        {
            int obt;
            char ch;
            do
            {
                Console.Write("enter  the marks of Physics : ");
                phy = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter  the marks of  Chemistry : ");
                che = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter  the marks of maths : ");
                maths = Convert.ToInt32(Console.ReadLine());
                obt = phy + che + maths;

                Console.WriteLine("do you want to insert other num");
                ch = Convert.ToChar(Console.ReadLine());

            } while (ch == 'y' || ch == 'Y');

            float per = obt / 300 * 100;

            Console.WriteLine("percentage:=" + per);



        }
    }
    public class Program
    {
        static void Main(string[] args)
        {

            {
                int phy, che, maths;
                float obt;


                Console.WriteLine(" percentage  of three subjects:");
                Char ch;
                do
                {
                    Console.Write("enter  the marks of Physics : ");
                    phy = Convert.ToInt32(Console.ReadLine());
                    Console.Write("enter  the marks of  Chemistry : ");
                    che = Convert.ToInt32(Console.ReadLine());
                    Console.Write("enter  the marks of maths : ");
                    maths = Convert.ToInt32(Console.ReadLine());
                    obt = phy + che + maths;

                    Console.WriteLine("do you want to insert other num");
                    ch = Convert.ToChar(Console.ReadLine());

                } while (ch == 'y' || ch == 'Y');

                float per = obt / 300 * 100;

                Console.WriteLine("percentage:=" + per);


            }

        }
    }

}

      