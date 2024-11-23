using System;

namespace c_sharp_class_2.Classes
{
    public class BinaryToInt
    {
        public string? Input_string { get; set; }
        public int Output_int { get; set; }

        public int CovertStringBinaryToInt()
        {
            try
            {
                if (Input_string == null)
                {
                    throw new Exception("Input is null");
                }

                long result = 0;
                for (int i = 0; i < Input_string.Length; i++)
                {
                    if (Input_string[i] != '0' && Input_string[i] != '1')
                    {
                        throw new Exception("String contains non-binary characters");
                    }
                    else
                    {
                        result = result * 2 + (Input_string[i] - '0');
                        if (result > int.MaxValue)
                        {
                            throw new Exception("Result exceeds int.MaxValue");
                        }
                        if (result < int.MinValue)
                        {
                            throw new Exception("Result is less than int.MinValue");
                        }
                    }
                }

                return (int)result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex}");
                return 0;
            }
        }

        public BinaryToInt()
        {
            Input_string = Console.ReadLine();
            Output_int = CovertStringBinaryToInt();
        }

        public BinaryToInt(string input)
        {
            Input_string = input;
            Output_int = CovertStringBinaryToInt();
        }
    }
}
