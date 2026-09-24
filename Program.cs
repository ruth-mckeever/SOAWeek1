namespace SOAWeek1;

class Program
{
    static void Main(string[] args)
    {
        //Question1();
        //Question2();
        //Question3();
        //Question4();
        //Question5();
        Question6();
    }

    static void Question1() //1. Guessing Game
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
    
    private static void Question2()
    {
        //2.	Check if a number is prime.
        Console.WriteLine("Enter a number to check if it is prime:");
        int possiblePrime = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The number {possiblePrime} is prime: {CheckPrimeNumber(possiblePrime)}");
    }
    
    private static void Question3()
    {
        //3. Accept an integer as input and calculate the factorial of that number. If the
        // number is 4, then the output should be 24 (i.e. 4x3x2x1).
        Console.WriteLine("Enter an integer to calculate its factorial");
        int highNumber = Convert.ToInt32(Console.ReadLine());
        int factorial = 1;
        for (int i = highNumber; i > 0; i--)
        {
            factorial *= i;
        }
        Console.WriteLine($"Factorial of {highNumber} is {factorial}");
    }
    
    private static void Question4()
    {
        //4. Write a program that displays the sum of the even numbers and the product
        // of the odd numbers between 1 and 10. Use two loops. Can you solve the
        // problem with one loop?
        int sumEven = 0;
        int productOdd = 1;
        
        //One Loop
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                sumEven += i;
            }
            else
            {
                productOdd *= i;
            }
        }
        
        Console.WriteLine($"The sum of the even numbers between 1 and 10 is: {sumEven}");
        Console.WriteLine($"The product of the odd numbers between 1 and 10 is: {productOdd}");
        
    }
    
    
    private static void Question5()
    {
        //13.	A number can also be a palindrome. For example, each of the following five-digit integers is a palindrome: 12321, 55555, 45554 and 11611.
        //Write a program that reads in a five-digit integer and determines whether it is a palindrome.
        //(Hint: Use the division and modulus operators to separate the number into its individual numbers).
        //Note - yes it would be easier to treat this as a string but that's not the point...
        Console.WriteLine("Enter a 5 digit integer");
        int possiblePalindrome = Convert.ToInt32(Console.ReadLine());
        int lastNum = possiblePalindrome % 10;
        Console.WriteLine($"Last number: {lastNum}");
        int secondLastNum = (possiblePalindrome/10) % 10;
        Console.WriteLine($"Second last number: {secondLastNum}");
        int secondNum = (possiblePalindrome/1000) % 10;
        Console.WriteLine($"Second number: {secondNum}");
        int firstNum = (possiblePalindrome/10000) % 10;
        Console.WriteLine($"First number: {firstNum}");

        if (firstNum == lastNum && secondNum == secondLastNum)
        {
            Console.WriteLine("This number is a palindrome.");
        }
        else
        {
            Console.WriteLine("This number is NOT a palindrome.");
        }
        
        //TODO: how would you handle this if you didn't know how long the number was? i.e. not 5 digits...

    }
    
    private static void Question6()
    {
        //6.	Write a program that reads 5 sets of three nonzero integers and determines and prints if they could be the sides of a right triangle.
        int a = 5;
        int b = 12;
        int c = 13;
        Console.WriteLine($"{a}, {b}, {c} could make a right angled triangle: {CheckIfRightAngledTriangle(a, b, c)}");
    }
    
    //Helper methods/reusable functions - should ideally go in a separate class
    public static bool CheckPrimeNumber(int number)
    {
        int divisor = 2;
        Console.WriteLine($"Dividing {number} by {divisor}");
        while (number % divisor != 0)
        {
            divisor++;
            if (divisor == number)
            {
                return true;
            }
        }
        return false;
    }
    
    public static bool CheckIfRightAngledTriangle(int x, int y, int z)
    {
        if (x > y && x > z)
        {
            //x is largest side
            return (x * x == ((y * y) + (z * z)));
        }
        else if(y > x && y > z)
        {
            //y must be the largest side
            return (y * y == ((x * x) + (z * z)));
        }
        else
        {
            //z must be the largest side or two sides are equal
            return (z * z == ((x * x) + (y * y)));
        }
    }
}