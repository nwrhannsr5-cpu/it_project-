public double Calculate(double num1, double num2, char op)
{
    switch (op)
    {
        case '+':
            return num1 + num2;

        case '-':
            return num1 - num2;

        case '*':
            return num1 * num2;

        case '/':
            if (num2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return 0;
            }
            return num1 / num2;

        default:
            Console.WriteLine("Error: Unknown operator.");
            return 0;
    }
}