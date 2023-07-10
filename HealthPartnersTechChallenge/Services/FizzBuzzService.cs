using HealthPartnersTechChallenge.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPartnersTechChallenge.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public FizzBuzz GenerateFizzBuzz(int inputNumber)
        {
            if (inputNumber % 15 == 0) { return FizzBuzz.FizzBuzz; }
            if (inputNumber % 3 == 0) { return FizzBuzz.Fizz; }
            if (inputNumber % 5 == 0) { return FizzBuzz.Buzz; }
            throw new NotImplementedException();
        }
    }
}
