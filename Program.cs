namespace SOAWeek1;

class Program
{
    static void Main(string[] args)
    {
        Question1();
    }

    static void Question1()
    {
        bool found = false;
        int numGuesses = 0;
        Random generator = new Random();
        int secretNumber = generator.Next(1, 11);
        Console.WriteLine("Enter a guess between 1 and 10");

        while (!found)
        {
            int guess = Convert.ToInt32(Console.ReadLine()); //Bad - should handle non-numerical input
            numGuesses++;
            if (guess == secretNumber)
            {
                found = true;
            }
        }
        Console.WriteLine($"Congratulations, you guessed the correct number in {numGuesses} attempt(s)");
    }
}