using FizzBuzzApp;

class Program
{
    static void Main(string[] args)
    {
        var fizzBuzz = new FizzBuzz();

        for (int i = 1; 1 < 100; i++)
        {
            Console.WriteLine(fizzBuzz.GenerateOutput(i));
        }
    }
}