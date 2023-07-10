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
            //act
            //assert
            Assert.True(false);
        }
        [Fact]
        public void If_A_Number_Is_Divisible_By_3_And_5_Output_Should_Be_FizzBuzz()
        {
            //arrange
            //act
            //assert
            Assert.True(false);
        }
    }
}