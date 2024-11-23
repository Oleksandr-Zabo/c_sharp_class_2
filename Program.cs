namespace c_sharp_class_2
{
    internal class Program
    {//lab ex.4
        static int EvaluateExpression(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
            {
                throw new ArgumentException("Expression cannot be empty.");
            }

            if (expression.Contains(' '))
            {
                throw new ArgumentException("Expression cannot contain spaces.");
            }

            string[] parts = expression.Split('*');
            int result = 1;

            foreach (string part in parts)
            {
                if (!int.TryParse(part, out int number))
                {
                    throw new ArgumentException($"Invalid input: {part}");
                }
                result *= number;
            }

            return result;
        }

        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a mathematical expression (e.g., 3*2*1*4):");
                string? input = Console.ReadLine();
                if (input == null)
                {
                    throw new ArgumentException("Expression cannot be empty.");
                }
                int result = EvaluateExpression(input);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        
    }
}
