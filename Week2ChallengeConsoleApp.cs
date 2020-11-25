using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2ChallengeConsoleApp;

namespace Week2ChallengeConsoleApp
{
    public class Week2ChallengeConsoleApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            var instance = new Greeter();
            string userInput = Console.ReadLine();
            instance.Hello(userInput);
            instance.TimeofDay(userInput);
            instance.Goodbye(userInput);
            Console.WriteLine("Enter any key to exit");
            Console.ReadLine();
        }
    }
}
