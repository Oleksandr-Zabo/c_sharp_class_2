using c_sharp_class_2.Classes;

namespace c_sharp_class_2
{
    internal class Program
    {//lab ex.2
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter line to convert int:");
                string? input = Console.ReadLine();
                if (input == null)
                {
                    throw new Exception("Input is null");
                }
                int number = new BinaryToInt(input).Output_int;
                Console.WriteLine($"Output int: {number}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exeptinon {ex}");
            }

        }
    }
}
