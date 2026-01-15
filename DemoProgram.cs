ZohidbeksCoolCalculator calculator = new(
    "Welcome to Zohidbek's Cool Calculator!");
calculator.Start();


public sealed class ZohidbeksCoolCalculator
{
    private string _greeting;
    public ZohidbeksCoolCalculator(string greeting)
    {
        _greeting = greeting;
    }

    public void Start()
    {
        Console.WriteLine(_greeting);

        Dictionary<string, string> supportedOperators = new()
        {
            //{ "+", "Add" },
            //{ "-", "Subtract" },
            //{ "*", "Multiply" },
            //{ "/", "Divide" },
            ["+"] = "Add",
            ["-"] = "Subtract",
            ["*"] = "Multiply",
            ["/"] = "Divide"
        };

        while (true)
        {
            Console.WriteLine("Operator choices are as follows:");
            foreach (var op in supportedOperators)
            {
                Console.WriteLine($"{op.Value}: {op.Key}");
            }

            Console.WriteLine("Enter an operator (or 'q' to quit):");
            string operatorChoice = Console.ReadLine();

            if (string.Equals(operatorChoice, "q", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(operatorChoice, "exit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Goodbye! :)");
                break;
            }

            if (!supportedOperators.TryGetValue(
                 operatorChoice,
                 out var selectedOperatorDescription))
            {
                Console.WriteLine("Invalid operator choice.");
                continue;
            }

            Console.WriteLine($"You selected: {selectedOperatorDescription}");
            Console.WriteLine();

            Console.WriteLine(
                $"Recall the integers are on the range " + 
                $"{int.MinValue} to {int.MaxValue}!");
            Console.WriteLine();

            Console.WriteLine("Enter the first integer:");
            string firstNumberInput = Console.ReadLine();
            if (!int.TryParse(firstNumberInput, out int firstNumber))
            {
                Console.WriteLine(
                    $"{firstNumber} could not be parsed as an integer!");
                continue;
            }

            Console.WriteLine("Enter the second integer:");
            string secondNumberInput = Console.ReadLine();
            if (!int.TryParse(secondNumberInput, out int secondNumber))
            {
                Console.WriteLine(
                    $"{secondNumber} could not be parsed as an integer!");
                continue;
            }

            int result;
            try
            {
                result = operatorChoice switch
                {
                    "+" => firstNumber + secondNumber,
                    "-" => firstNumber - secondNumber,
                    "*" => firstNumber * secondNumber,
                    "/" => firstNumber / secondNumber,
                    _ => throw new NotSupportedException(
                        $"Arithmetic is not currently supported " +
                        $"for operator {operatorChoice}.    ")
                };
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by zero.");
                continue;
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"There was an unhandled exception: {ex.Message}");
                continue;
            }

            Console.WriteLine($"The result is {result}");
        }
    }
}