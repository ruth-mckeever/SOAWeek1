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
        //Question6();
        //Question7();
        //Question8();
        Question9();
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

    private static void Question7()
    {
        //15.	Write a program that calculates and prints the average of several integers. Assume the last value read is the sentinel 9999.
        //A typical input sequence might be 10 8 11 7 9 9999 indicating that the average of all the values preceding 9999 is to be calculated.
        int sentinel = 9999;
        Console.WriteLine("Please enter integers: (9999 to exit)");
        int input = Convert.ToInt32(Console.ReadLine());
        int count = 0, sum = 0;
        double average = 0;
        while (input != sentinel)
        {
            count++;
            sum += input;
            input = Convert.ToInt32(Console.ReadLine());
        }

        average = sum / count;
        Console.WriteLine($"Average of all numbers entered is: {average}");

    }
    private static void Question8()
    {
        //16.	One interesting application of computers is drawing graphs and bar charts (sometimes called “histograms”).
        //Write a program that reads five numbers (each between 1 and 30).
        //For each number read, your program should print a line containing that number of adjacent asterisks.
        //For example, if your program reads the number seven, it should print *******.
        int[] numArray =  new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter a number between 1 and 30");
            numArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (int num in numArray)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();        //Only move onto a new line after correct number of * have been printed
        }
    }
    
    private static void Question9()
    {
        //19.	Develop a C# program that will determine the gross pay for each of several employees.
        //  The company pays “straight-time” for the first 40 hours worked by each employee and pays “time-and-a-half” for all hours worked in excess of 40 hours.
        //  You are given a list of the employees of the company, the number of hours each employee worked last week and the hourly rate of each employee.
        //  Your program should input this information for each employee and should determine and display the employee's gross pay.
        Employee emp1 = new Employee("Ted", 28, 12.5);
        Employee emp2 = new Employee("Tom", 40, 13.5);
        Employee emp3 = new Employee("Tim", 45, 14.5);
        Employee emp4 = new Employee("Tod", 50, 15.5);

        Employee[] employeeList = { emp1, emp2, emp3, emp4 };

        foreach (Employee emp in employeeList)
        {
            //TODO: Finish this
        }

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

class Employee
{
    public string Name { get; set; }
    public double HoursWorked { get; set; }
    public double HourlyRate { get; set; }

    public Employee(string name, double hoursWorked, double hourlyRate)
    {
        Name = name;
        HoursWorked = hoursWorked;
        HourlyRate = hourlyRate;
    }
}