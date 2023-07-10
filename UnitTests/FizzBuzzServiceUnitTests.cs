using FluentAssertions;
using HealthPartnersTechChallenge.Enum;
using HealthPartnersTechChallenge.Services;
using System.Collections;

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
            result.Should().Be(FizzBuzz.FizzBuzz);
        }
        [Fact]
        public void If_A_Number_Is_Not_Divisible_By_3_Or_5_Output_Should_Be_NoChange()
        {
            //arrange
            var service = new FizzBuzzService();
            //act
            var result = service.GenerateFizzBuzz(1);
            //assert
            result.Should().Be(FizzBuzz.NoChange);
        }

        [Theory]
        [MemberData(nameof(SetOfDivideByThree))]
        public void If_A_Number_Is_Divisible_By_3_Output_Should_Be_Fizz_For_A_Range_From_1_To_100(int testNumber)
        {
            //arrange
            var service = new FizzBuzzService();
            //act
            var result = service.GenerateFizzBuzz(testNumber);
            //assert
            result.Should().Be(FizzBuzz.Fizz);
        }
        public static IEnumerable<object[]> SetOfDivideByThree()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 15 != 0) { yield return new object[] { i }; }
            }            
        }
        [Theory]
        [MemberData(nameof(SetOfDivideByFive))]
        public void If_A_Number_Is_Divisible_By_5_Output_Should_Be_Buzz_For_A_Range_From_1_To_100(int testNumber)
        {
            //arrange
            var service = new FizzBuzzService();
            //act
            var result = service.GenerateFizzBuzz(testNumber);
            //assert
            result.Should().Be(FizzBuzz.Buzz);
        }
        public static IEnumerable<object[]> SetOfDivideByFive()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 5 == 0 && i % 15 != 0) { yield return new object[] { i }; }
            }
        }
        [Theory]
        [MemberData(nameof(SetOfDivideByFifteen))]
        public void If_A_Number_Is_Divisible_By_15_Output_Should_Be_FizzBuzz_For_A_Range_From_1_To_100(int testNumber)
        {
            //arrange
            var service = new FizzBuzzService();
            //act
            var result = service.GenerateFizzBuzz(testNumber);
            //assert
            result.Should().Be(FizzBuzz.FizzBuzz);
        }
        public static IEnumerable<object[]> SetOfDivideByFifteen()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 15 == 0) { yield return new object[] { i }; }
            }
        }
        [Theory]
        [MemberData(nameof(SetOfAllOthers))]
        public void If_A_Number_Is_Not_Divisible_By_3_Or_5_Output_Should_Be_NoChange_For_A_Range_From_1_To_100(int testNumber)
        {
            //arrange
            var service = new FizzBuzzService();
            //act
            var result = service.GenerateFizzBuzz(testNumber);
            //assert
            result.Should().Be(FizzBuzz.NoChange);
        }
        public static IEnumerable<object[]> SetOfAllOthers()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 != 0 && i % 5 != 0) { yield return new object[] { i }; }
            }
        }
    }
}