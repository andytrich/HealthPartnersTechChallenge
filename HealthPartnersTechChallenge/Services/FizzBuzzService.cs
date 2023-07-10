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
            if (inputNumber % 3 == 0) { return FizzBuzz.Fizz; }
            throw new NotImplementedException();
        }
    }
}
