using RuleInterfaces;

namespace FizzBuzzApp.CustomRules
{
    internal class FizzBuzzRule : IRule
    {
        public Int32 Priority => 2;

        public String GetResult()
        {
            return "FizzBuzz";
        }

        public Boolean IsMatch(Int32 number)
        {
            return number % 3 == 0 && number % 5 == 0;
        }
    }
}
