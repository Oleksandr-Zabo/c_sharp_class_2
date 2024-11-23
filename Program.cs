namespace c_sharp_class_2
{
    internal class Program
    {//lab ex -3
        static void Main()
        {
            var creditCard = new Clases.CreditCard(cardNumber: "1234567890123456",
                name:"John",
                surname:"Doe",
                patronymic:"Bob",
                cvc:"123",
                expiryDate: new Clases.ExpiryDate(12, 2024)
            );
            Console.WriteLine(creditCard);
        }
    }
}
