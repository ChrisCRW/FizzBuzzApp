namespace RuleInterfaces
{
    public interface IRule
    {
        Int32 Priority { get; }

        Boolean IsMatch(Int32 number);

        String GetResult();
    }
}
