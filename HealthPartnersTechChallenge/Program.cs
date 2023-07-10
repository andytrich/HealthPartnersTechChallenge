using HealthPartnersTechChallenge.Enum;
using HealthPartnersTechChallenge.Services;
using System;
using System.IO;

namespace HealthPartnersTechChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = 0;
            if (args.Length != 1)
            { 
                Console.WriteLine("This app takes only one integer parameter, see read me for details");
                return;
            }
            if (!int.TryParse(args[0], out inputNumber))
            {
                Console.WriteLine("This app takes only one integer parameter, see read me for details");
                return;
            }

            var service = new FizzBuzzService();
            var result = service.GenerateFizzBuzz(inputNumber);
            if(result == FizzBuzz.NoChange)
            {
                Console.WriteLine($"You're number was {inputNumber}. There no fizz or buzz!");
                return;
            }
            Console.WriteLine($"You're number was {inputNumber}. It's {result.ToString()}");


        }
    }
}
