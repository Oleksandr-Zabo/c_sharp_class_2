using System;

namespace c_sharp_class_2.Classes
{
    public class StringIntCovert
    {
        public string? Input_string { get; set; }
        public int Output_int { get; set; }

        public int CovertStringToInt()
        {
            try
            {
                if (Input_string == null)
                {
                    throw new Exception("Input is null");
                }

                bool negative = false;
                if (Input_string[0] == '-')
                {
                    negative = true;
                    Input_string = Input_string.Substring(1);
                }

                if (Input_string.Length > 10 || (Input_string.Length == 10 &&
                    ((negative && Input_string.CompareTo("2147483648") > 0) ||
                    (!negative && Input_string.CompareTo("2147483647") > 0))))
                {
                    throw new Exception("String represents a number larger than int.MaxValue or smaller than int.MinValue");
                }

                int result = 0;
                for (int i = 0; i < Input_string.Length; i++)
                {
                    if (Input_string[i] < '0' || Input_string[i] > '9')
                    {
                        throw new Exception("String contains non-numeric characters");
                    }
                    else
                    {
                        result = result * 10 + (Input_string[i] - '0');
                    }
                }

                if (negative == true)
                {
                    result *= -1;
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex}");
                return 0;
            }
        }

        public StringIntCovert()
        {
            Input_string = Console.ReadLine();
            Output_int = CovertStringToInt();
        }

        public StringIntCovert(string input)
        {
            Input_string = input;
            Output_int = CovertStringToInt();
        }
    }
}
