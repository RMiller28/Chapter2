using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {

            String name, ssn, hpr, hw;
            double hourspay, hoursworked;



            double gross, fed, state, moneyperh;



            Console.Write("Enter your name:");
            name = Console.ReadLine();


            Console.Write("Social Security number:");
            ssn = Console.ReadLine();


            Console.Write("Hourly pay rate:");
            hpr = Console.ReadLine();
            hourspay = Convert.ToDouble(hpr);

            Console.Write("Hours worked:");
            hw = Console.ReadLine();
            hoursworked = Convert.ToDouble(hw);

            // Do the calculations!!!!!!
            gross = hourspay * hoursworked;
            moneyperh = gross / hoursworked;
            fed = gross * 0.15;
            state = gross * 0.05;


            Console.WriteLine("Payroll Summary for {0}:", name);

            Console.WriteLine("SSN {0}:", ssn);

            Console.WriteLine("You earned {0} at {1} per hour", gross, moneyperh);



            Console.WriteLine("Gross pay is: {0,10}", gross.ToString("C"));

            Console.WriteLine("Federal withholding is: {0,10}", fed.ToString("C"));

            Console.WriteLine("State withholding is {0,10}", state.ToString("C"));


        }
    }
}