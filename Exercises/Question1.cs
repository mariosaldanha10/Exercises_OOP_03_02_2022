using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP_03_02_2022.Exercises
{
    
    /*
     * 
     *  Write a console-based application that prompts a user for an
        hourly pay rate. While the user enters values less than $5.65
        or greater than $49.99, continue to prompt the user. Before
        the program ends, display the valid pay rate
     * 
     * */
    public class Question1
    {
        public Question1()
        {

        }
        public static void hourlyPayRate()
        {

            double payRate;
            do
            {
                Console.WriteLine("Enter the value:");
                payRate = double.Parse(Console.ReadLine());
            } while (payRate < 5.65 || payRate > 49.99);

            Console.WriteLine("Payrate is: {0}", payRate);
        }
    }

}
