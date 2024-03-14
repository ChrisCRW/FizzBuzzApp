using RuleInterfaces;

namespace FizzBuzzApp.CustomRules
{
    internal class BuzzRule : IRule
    {
        public String GetResult()
        {
            return "Buzz";
        }

        public Boolean IsMatch(Int32 number)
        {
            return number % 5 == 0;
        }
    }
}
