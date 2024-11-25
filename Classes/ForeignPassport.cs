using System;
using System.Text.RegularExpressions;

namespace c_sharp_class_2.Classes
{
    internal class ForeignPassport
    {
        private string passportNumber;
        private string name;
        private string surname;
        private string patronymic;
        private DateTime issueDate;

        public string PassportNumber
        {
            get => passportNumber;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 9 || !Regex.IsMatch(value, @"^[A-Z0-9]+$"))
                {
                    throw new ArgumentException("Passport number must be 9 characters long and contain only uppercase letters and digits.");
                }
                passportNumber = value;
            }
        }

        public string Name
        {
            get => name;
            set
            {
                if (!IsValidName(value))
                {
                    throw new ArgumentException("Name contains invalid characters.");
                }
                name = value;
            }
        }

        public string Surname
        {
            get => surname;
            set
            {
                if (!IsValidName(value))
                {
                    throw new ArgumentException("Surname contains invalid characters.");
                }
                surname = value;
            }
        }

        public string Patronymic
        {
            get => patronymic;
            set
            {
                if (!IsValidName(value))
                {
                    throw new ArgumentException("Patronymic contains invalid characters.");
                }
                patronymic = value;
            }
        }

        public DateTime IssueDate
        {
            get => issueDate;
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Issue date cannot be in the future.");
                }
                issueDate = value;
            }
        }

        public ForeignPassport()
        {
            PassportNumber = "AB1234567";
            Name = "";
            Surname = "";
            Patronymic = "";
            IssueDate = new DateTime();
        }

        public ForeignPassport(string passportNumber, string name, string surname, string patronymic, DateTime issueDate)
        {
            PassportNumber = passportNumber ?? throw new ArgumentNullException(nameof(passportNumber));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            Patronymic = patronymic ?? throw new ArgumentNullException(nameof(patronymic));
            IssueDate = issueDate;
        }

        private bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z]+$") && !string.IsNullOrWhiteSpace(name);
        }

        public override string ToString()
        {
            return $"Passport: {PassportNumber}, Name: {Name}, Surname: {Surname}, Patronymic: {Patronymic}, Issue Date: {IssueDate:dd/MM/yyyy}";
        }
    }
}
