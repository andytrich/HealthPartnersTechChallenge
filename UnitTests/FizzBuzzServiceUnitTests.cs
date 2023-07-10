using FluentAssertions;
using HealthPartnersTechChallenge.Enum;
using HealthPartnersTechChallenge.Services;

namespace UnitTests
{
    public class FizzBuzzServiceUnitTests
    {

        [Fact]
        public void If_A_Number_Is_Divisible_By_3_Output_Should_Be_Fizz()
        {
            //arrange
            var service = new FizzBuzzService();
            //act
            var result = service.GenerateFizzBuzz(3);
            //assert
            result.Should().Be(FizzBuzz.Fizz);
        }
        [Fact]
        public void If_A_Number_Is_Divisible_By_5_Output_Should_Be_Buzz()
        {
            //arrange
            var service = new FizzBuzzService();
            //act
            var result = service.GenerateFizzBuzz(5);
            //assert
            result.Should().Be(FizzBuzz.Buzz);
        }
        [Fact]
        public void If_A_Number_Is_Divisible_By_3_And_5_Output_Should_Be_FizzBuzz()
        {
            //arrange
            var service = new FizzBuzzService();
            //act
            var result = service.GenerateFizzBuzz(15);
            //assert
            result.Should().Be(FizzBuzz.FizzBuzzz);
        }
    }
}