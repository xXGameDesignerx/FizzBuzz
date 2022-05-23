// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to a game called fizz buzz.");
Console.WriteLine("An interactive game where you can say 'Fizz' for every multiple of 3.");
Console.WriteLine("And 'Buzz' for every multiple of 5. ");
Console.WriteLine("If that number is multiple by both we say 'FizzBuzz'.");

for (int i = 0; i <= 100; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}
