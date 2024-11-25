using System;
namespace c_sharp_class_2
{
    class Program
    {//hw ex.1
        static void Main()
        {
            try
            {
                Console.WriteLine("Select conversion direction:");
                Console.WriteLine("1. Decimal to Binary");
                Console.WriteLine("2. Binary to Decimal");
                Console.WriteLine("3. Decimal to Hexadecimal");
                Console.WriteLine("4. Hexadecimal to Decimal");
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input) || input.Length != 1)
                {
                    throw new ArgumentException("Input is null or empty.");
                }
                int choice = Convert.ToInt32(input);

                Console.WriteLine("Enter the number:");
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentException("Input is null or empty.");
                }

                switch (choice)
                {
                    case 1:
                        int decimalNumber = int.Parse(input);
                        string binaryResult = ConvertDecimalToBinary(decimalNumber);
                        Console.WriteLine($"Binary: {binaryResult}");
                        break;
                    case 2:
                        int binaryNumber = ConvertBinaryToDecimal(input);
                        Console.WriteLine($"Decimal: {binaryNumber}");
                        break;
                    case 3:
                        decimalNumber = int.Parse(input);
                        string hexResult = ConvertDecimalToHexadecimal(decimalNumber);
                        Console.WriteLine($"Hexadecimal: {hexResult}");
                        break;
                    case 4:
                        int hexNumber = ConvertHexadecimalToDecimal(input);
                        Console.WriteLine($"Decimal: {hexNumber}");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static string ConvertDecimalToBinary(int decimalNumber)
        {
            if (decimalNumber < 0)
            {
                throw new ArgumentException("Number must be non-negative.");
            }
            return Convert.ToString(decimalNumber, 2);
        }

        static int ConvertBinaryToDecimal(string binaryString)
        {
            if (string.IsNullOrWhiteSpace(binaryString))
            {
                throw new ArgumentException("Input is null or empty.");
            }

            long result = 0;
            for (int i = 0; i < binaryString.Length; i++)
            {
                if (binaryString[i] != '0' && binaryString[i] != '1')
                {
                    throw new ArgumentException("String contains non-binary characters.");
                }
                result = result * 2 + (binaryString[i] - '0');
                if (result > int.MaxValue)
                {
                    throw new OverflowException("Result exceeds int.MaxValue.");
                }
            }

            return (int)result;
        }

        static string ConvertDecimalToHexadecimal(int decimalNumber)
        {
            if (decimalNumber < 0)
            {
                throw new ArgumentException("Number must be non-negative.");
            }
            return decimalNumber.ToString("X");
        }

        static int ConvertHexadecimalToDecimal(string hexString)
        {
            if (string.IsNullOrWhiteSpace(hexString))
            {
                throw new ArgumentException("Input is null or empty.");
            }

            try
            {
                int result = 0;
                for (int i = 0; i < hexString.Length; i++)
                {
                    char hexChar = hexString[i];
                    int hexValue;

                    if (hexChar >= '0' && hexChar <= '9')
                    {
                        hexValue = hexChar - '0';
                    }
                    else if (hexChar >= 'A' && hexChar <= 'F')
                    {
                        hexValue = 10 + (hexChar - 'A');
                    }
                    else if (hexChar >= 'a' && hexChar <= 'f')
                    {
                        hexValue = 10 + (hexChar - 'a');
                    }
                    else
                    {
                        throw new ArgumentException("String contains non-hexadecimal characters.");
                    }

                    result = result * 16 + hexValue;
                    if (result > int.MaxValue)
                    {
                        throw new OverflowException("Result exceeds int.MaxValue.");
                    }
                }
                return result;
            }
            catch (FormatException)
            {
                throw new ArgumentException("String contains non-hexadecimal characters.");
            }
            catch (OverflowException)
            {
                throw new OverflowException("Result exceeds int.MaxValue.");
            }
        }
    }

}
