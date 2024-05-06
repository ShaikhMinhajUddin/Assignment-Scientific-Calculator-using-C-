using System;

class Calculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose calculator type:");
            Console.WriteLine("1. Normal Calculator");
            Console.WriteLine("2. Scientific Calculator");
            Console.WriteLine("3. Exit");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    RunNormalCalculator();
                    break;
                case 2:
                    RunScientificCalculator();
                    break;
                case 3:
                    Console.WriteLine("Exiting calculator. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                    break;
            }
        }
    }

    static void RunNormalCalculator()
    {
        double num1, num2;
        char op;

        Console.WriteLine("Enter first number:");
        if (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        Console.WriteLine("Enter second number:");
        if (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        Console.WriteLine("Enter operator (+, -, *, /):");
        op = Console.ReadKey().KeyChar;

        double result = 0;
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return;
                }
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operator.");
                return;
        }

        Console.WriteLine($"\nResult: {result}");
    }

    static void RunScientificCalculator()
    {
        double num;

        Console.WriteLine("Enter a number:");
        if (!double.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        Console.WriteLine("Choose operation:");
        Console.WriteLine("1. Exponentiation");
        Console.WriteLine("2. Square Root");
        Console.WriteLine("3. Logarithm (base 10)");
        Console.WriteLine("4. Sine");
        Console.WriteLine("5. Cosine");
        Console.WriteLine("6. Tangent");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return;
        }

        double result = 0;
        switch (choice)
        {
            case 1:
                double exponent;
                Console.WriteLine("Enter exponent:");
                if (!double.TryParse(Console.ReadLine(), out exponent))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }
                result = Math.Pow(num, exponent);
                break;
            case 2:
                result = Math.Sqrt(num);
                break;
            case 3:
                if (num <= 0)
                {
                    Console.WriteLine("Invalid input. Logarithm is defined for positive numbers only.");
                    return;
                }
                result = Math.Log10(num);
                break;
            case 4:
                result = Math.Sin(num);
                break;
            case 5:
                result = Math.Cos(num);
                break;
            case 6:
                result = Math.Tan(num);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }
}
