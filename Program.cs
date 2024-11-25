namespace c_sharp_class_2
{
    using c_sharp_class_2.Classes;
    internal class Program
    {//hw ex. 4
        static void Main()
        {
            Console.WriteLine("Enter a logical expression:");
            string? expression = Console.ReadLine();
            try
            {
                if (expression == null)
                {
                    throw new ArgumentException("Expression cannot be empty.");
                }
                bool result = LogicalExpression.Evaluate(expression);
                Console.WriteLine($"The result is: {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
