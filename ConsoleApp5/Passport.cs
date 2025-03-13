//using System;

//namespace ConsoleApp5
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                Passport passport = new Passport("123456789", "Ivanov Ivan Ivanovich", new DateTime(2020, 5, 10), new DateTime(2030, 5, 10), "Ukraine");
//                Console.WriteLine(passport.ToString());
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Error: {ex.Message}");
//            }
//        }
//    }

//    internal class Passport
//    {
//        public string PassportNumber { get; private set; }
//        public string FullName { get; private set; }
//        public DateTime IssueDate { get; private set; }
//        public DateTime ExpiryDate { get; private set; }
//        public string Nationality { get; private set; }

//        public Passport(string passportNumber, string fullName, DateTime issueDate, DateTime expiryDate, string nationality)
//        {
//            if (string.IsNullOrWhiteSpace(passportNumber) || passportNumber.Length != 9)
//                throw new ArgumentException("Invalid passport number (must contain 9 characters).");

//            if (string.IsNullOrWhiteSpace(fullName))
//                throw new ArgumentException("Full name cannot be empty.");

//            if (issueDate >= expiryDate)
//                throw new ArgumentException("Issue date must be earlier than the expiry date.");

//            if (string.IsNullOrWhiteSpace(nationality))
//                throw new ArgumentException("Nationality cannot be empty.");

//            PassportNumber = passportNumber;
//            FullName = fullName;
//            IssueDate = issueDate;
//            ExpiryDate = expiryDate;
//            Nationality = nationality;
//        }

//        public override string ToString()
//        {
//            return $"Passport Number: {PassportNumber}\nFull Name: {FullName}\nIssue Date: {IssueDate:dd.MM.yyyy}\nExpiry Date: {ExpiryDate:dd.MM.yyyy}\nNationality: {Nationality}";
//        }
//    }
//}
