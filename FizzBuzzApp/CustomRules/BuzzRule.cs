﻿using RuleInterfaces;

namespace FizzBuzzApp.CustomRules
{
    internal class BuzzRule : IRule
    {
        public Int32 Priority => 1;

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
