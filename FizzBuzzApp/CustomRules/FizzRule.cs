using RuleInterfaces;

namespace FizzBuzzApp.CustomRules
{
    internal class FizzRule : IRule
    {
        public String GetResult()
        {
            return "Fizz";
        }

        public Boolean IsMatch(Int32 number)
        {
            return number % 3 == 0;
        }
    }
}
