using static System.Formats.Asn1.AsnWriter;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Transactions;
using System.Reflection.Metadata;
using System.Diagnostics.Metrics;
using System.Reflection;
using System;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            char m_status, gender;
            int age;
          
            Console.WriteLine("please use U for unmarried ");
            Console.WriteLine("plaese use m for married");
            Console.WriteLine("please enter the Maritial Status");
            m_status=Convert.ToChar(Console.ReadLine());


            Console.WriteLine("please use F for female ");
            Console.WriteLine("plaese use M for male");
            Console.WriteLine("please enter gender");
            gender =Convert.ToChar(Console.ReadLine());


            Console.WriteLine("please enter age");
            age =Convert.ToInt32(Console.ReadLine());
            if (m_status == 'M')
            {

                Console.WriteLine("Driver is insured");

            }   
            else
            {
                if (gender == 'M')
                {
                    if (age >= 30)
                    {
                        Console.WriteLine("Driver is insured");
                    }

                    else
                    { 
                        Console.WriteLine("Driver is not insured");

                    }
                       
                }
                else
                {
                    if (age >= 25)
                    {
                        Console.WriteLine("Driver is insured");
                    }
                    else
                    { 
                        Console.WriteLine("Driver is not  insured");

                    }
                    
                }
            }
       

        }
    }
}

    




