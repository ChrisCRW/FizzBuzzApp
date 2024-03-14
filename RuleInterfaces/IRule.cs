namespace RuleInterfaces
{
    public interface IRule
    {
        Boolean IsMatch(Int32 number);

        String GetResult();
    }
}
