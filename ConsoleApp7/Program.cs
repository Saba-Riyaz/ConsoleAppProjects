
namespace contact
{
    class outarr
    {
       
        public static void Contact()
        {
            var arrNUM = new int[11];

            for (int i = 0; i < 11; i++)
            {

                Console.Write("Please enter value for index " + i + " = ");
                arrNUM[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 11; i++)
            {
                Console.Write(arrNUM[i]);
            }

           

        }

}

class Program
{

    static void Main(string[] args)
    {
           


        
        outarr.Contact();

        

    }
}
    
}

