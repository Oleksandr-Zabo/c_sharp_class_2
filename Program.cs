namespace c_sharp_class_2
{
    internal class Program
    {//hw ex. 2
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a number word (e.g., zero, one, two, ... nine):");
                string? input = Console.ReadLine();
                if (input == null)
                {
                    throw new ArgumentNullException("Input is null.");
                }
                input.ToLower();
                int number = ConvertWordToNumber(input);
                Console.WriteLine($"The digit is: {number}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static int ConvertWordToNumber(string word)
        {
            if (word == "zero") {
                return 0;
            }
            else if (word == "one")
            {
                return 1;
            }
            else if (word == "two")
            {
                return 2;
            }
            else if (word == "three")
            {
                return 3;
            }
            else if (word == "four")
            {
                return 4;
            }
            else if (word == "five")
            {
                return 5;
            }
            else if (word == "six")
            {
                return 6;
            }
            else if (word == "seven")
            {
                return 7;
            }
            else if (word == "eight")
            {
                return 8;
            }
            else if (word == "nine")
            {
                return 9;
            }
            else
            {
                throw new ArgumentException("Invalid number word.");
            }
        }
    }
}
