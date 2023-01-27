using System;
using System.Diagnostics.Metrics;

namespace first
{
    class Temperature
    {
        public float tempInFahr;

        public void getTemp()

        {
            Console.WriteLine("Please Enter the temperature in fahrenheit = ");
             tempInFahr= Convert.ToSingle(Console.ReadLine());


        }
    }






    class TempIn  : Temperature 
    {
        public float tempInCent;



        public void calculatetempInCent()
        {
             tempInCent = ((tempInFahr - 32) * (5 /9.0f));
            


        }
        public void displayTemp()
        {
            Console.WriteLine("Temperature In centigrade " + tempInCent);

        }

    }





    class Program
    {

        static void Main(string[] args)
        {
            var tempIn = new TempIn();
            tempIn.getTemp();
            tempIn.calculatetempInCent();
            tempIn.displayTemp();
            
           

        }
    
    } 
}

