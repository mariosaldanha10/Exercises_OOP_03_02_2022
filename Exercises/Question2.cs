using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP_03_02_2022.Exercises
{
    

    public class Question2
    {
        public Question2()
        {

        }
        public void sumInt()
        {
            int i = 1;
            int sum = 0;
            while (i <= 50)
            {
                sum = sum + i;
            }
            Console.WriteLine("Final value: {0}", sum);
        }
    }

}
