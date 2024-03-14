using FizzBuzzApp;

namespace FizzBuzzAppTests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void TestFizz()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal("Fizz", fizzBuzz.GenerateOutput(3));
        }

        [Fact]
        public void TestBuzz()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal("Buzz", fizzBuzz.GenerateOutput(5));
        }

        [Fact]
        public void TestFizzBuzz()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal("FizzBuzz", fizzBuzz.GenerateOutput(15));
        }

        [Fact]
        public void TestNumber()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal("4", fizzBuzz.GenerateOutput(4));
        }
    }
}