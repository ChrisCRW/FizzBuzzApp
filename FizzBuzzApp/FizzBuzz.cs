using RuleInterfaces;
using System.Reflection;

namespace FizzBuzzApp
{
    public class FizzBuzz
    {
        private List<IRule> _rules;

        public FizzBuzz()
        {
            _rules = new List<IRule>();
            this.LoadRules();
        }

        private void LoadRules()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();

            foreach (var type in types )
            {
                if (type.GetInterface("IRule") is not null)
                {
                    _rules.Add(Activator.CreateInstance(type) as IRule);
                }
            }
        }

        public String GenerateOutput(Int32 number)
        {
            foreach (var rule in _rules)
            {
                if (rule.IsMatch(number))
                {
                    return rule.GetResult();
                }
            }

            return number.ToString();
        }
    }
}
