using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2ChallengeConsoleApp
{
    public class Greeter
    {
        public void GetName(string name)
        {
            string nameVar = Console.ReadLine();
        }
        public void Hello (string nameVar)
        {
            Console.WriteLine("Hello " + nameVar);
        }

        public void TimeofDay(string nameVar)
        {
            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
            {
                Console.WriteLine("Good Morning " + nameVar);
            }
            else if (DateTime.Now.Hour >=12 && DateTime.Now.Hour < 18)
            {
                Console.WriteLine("Good Afternoon " + nameVar);
            }
            else if (DateTime.Now.Hour >= 16 && DateTime.Now.Hour < 20)
            {
                Console.WriteLine("Good Evening " + nameVar);
            }
            else if (DateTime.Now.Hour >= 20)
            {
                Console.WriteLine("Good Night " + nameVar);
            }
        }
        public void Goodbye (string nameVar)
        {
            Console.WriteLine("Goodbye " + nameVar);
        }
    }
}
