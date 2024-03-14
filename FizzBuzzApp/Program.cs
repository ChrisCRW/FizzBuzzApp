using FizzBuzzApp;

class Program
{
    static void Main(string[] args)
    {
        var fizzBuzz = new FizzBuzz();

        for (Int32 i = 1; i <= 100; i++)
        {
            Console.WriteLine(fizzBuzz.GenerateOutput(i));
        }
    }
}