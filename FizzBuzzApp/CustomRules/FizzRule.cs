using RuleInterfaces;

namespace FizzBuzzApp.CustomRules
{
    internal class FizzRule : IRule
    {
        public Int32 Priority => 0;

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
