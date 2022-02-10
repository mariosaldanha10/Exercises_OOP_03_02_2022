using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercises_OOP_03_02_2022.Exercises
{
 
    public class Question1
    {
        public Question1()
        {

        }
        public void hourlyPayRate()
        {

            double payRate;
            do
            {
                Console.WriteLine("Enter the value:");
                payRate = double.Parse(Console.ReadLine());
            } while (payRate < 5.65 || payRate > 49.99);

            Console.WriteLine("Payrate is: {0}", payRate);
            Console.ReadLine();
        }
    }

}
