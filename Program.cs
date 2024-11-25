using c_sharp_class_2.Classes;
namespace c_sharp_class_2
{
    
    internal class Program
    {//hw ex-3
        static void Main()
        {
            var passport = new ForeignPassport(passportNumber: "AB1234567", name: "John", surname:"Doe",
                patronymic: "Smith", issueDate: new DateTime(2020, 1, 1));
            Console.WriteLine(passport);

            passport.Name = "Jane";
            passport.IssueDate = new DateTime(2025, 1, 1);
            Console.WriteLine(passport);
        }
    }
}
