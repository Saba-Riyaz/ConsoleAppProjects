using static System.Formats.Asn1.AsnWriter;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Initialize a variable "employee" to 1.
            //While "employee" is less than or equal to 10, do the following:
            //Prompt the user to enter the number of hours worked by the employee.
            //Store the number of hours worked in a variable called "hours".
            //If "hours" is greater than 40, calculate the overtime pay as follows:
            //Initialize a variable "overtime" to 0.
            //Set "overtime" to the number of hours worked above 40 hours,
            //multiplied by Rs. 200 per hour.
            //If "hours" is less than or equal to 40, set "overtime" to 0.
            //Print the overtime pay for the employee.
            //Increment "employee" by 1.

            int employe = 1;
            int hours;
            float over_time;
            float over_timepay;
           
            while (employe <= 10)
            {
                Console.WriteLine("Enter the working hours of employee no :" +  employe);

                hours = Convert.ToInt32(Console.ReadLine());


                if (hours > 40)

                {
                    over_time = hours - 40;
                    over_timepay = over_time * 200 ;
                    Console.WriteLine("Employee overtime pay of employe "  + employe + " is = "+ over_timepay);
                }
                else
                {
                    Console.WriteLine("no over time pay\n");


                }


                employe++;


    
    }   
    
}








