//using System;

//namespace ConsoleApp5
//{
//    class Employee
//    {
//        private string Name;
//        private string Birthday;
//        private int Phone;
//        private string Email;
//        private string Job_title;
//        private string Job;
//        private string Birtday;
//        private int Money;  

//        public string Country { get; private set; }

//        public Employee(string name, string birthday, int phone, string email, string job_title, string job, int money)
//        {
//            Name = name;
//            Birthday = birthday;
//            Phone = phone;
//            Email = email;
//            Job_title = job_title;
//            Job = job;
//            Money = money;
//        }

//        public Employee(string name) : this(name, "N/A", 0, "N/A", "N/A", "N/A", 0)
//        {
//        }

//        public Employee(string name, string birthday) : this(name, birthday, 0, "N/A", "N/A", "N/A", 0)
//        {
//        }

//        public Employee(string name, string birthday, int phone) : this(name, birthday, phone, "N/A", "N/A", "N/A", 0)
//        {
//        }

//        #region Setters
//        public void SetName(string name) { Name = name; }
//        public void SetBirthday(string birtday) { Birtday = birtday; }
//        public void SetPhone(int phone) { Phone = phone; }
//        public void SetEmail(string email) { Email = email; }
//        public void SetJob_title(string job_title) { Job_title = job_title; }
//        public void SetJob(string job) { Job = job; }
//        public void SetMoney(int money) { Money = money; } 
//        #endregion

//        #region Getters
//        public string GetName() { return Name; }
//        public string GetBirthday() { return Birthday; }
//        public int GetPhone() { return Phone; }
//        public string GetJob_title() { return Job_title; }
//        public string GetJob() { return Job; }
//        public int GetMoney() { return Money; } 
//        #endregion

//        public void PrintEmployeeInfo()
//        {
//            Console.WriteLine($"Name: {Name}\nBirthday: {Birthday}\nPhone: {Phone}\nEmail: {Email}\nJob Title: {Job_title}\nJob: {Job}\nMoney: {Money}");
//        }

//        public static Employee operator -(Employee emp, int amount)
//        {
//            emp.Money -= amount;
//            return emp;
//        }

//        public static Employee operator +(Employee emp, int amount)
//        {
//            emp.Money += amount;
//            return emp;
//        }

//        public static bool operator ==(Employee emp1, Employee emp2)
//        {
//            return emp1.Money == emp2.Money;
//        }

//        public static bool operator !=(Employee emp1, Employee emp2)
//        {
//            return emp1.Money != emp2.Money;
//        }

//        public static bool operator <(Employee emp1, Employee emp2)
//        {
//            return emp1.Money < emp2.Money;
//        }

//        public static bool operator >(Employee emp1, Employee emp2)
//        {
//            return emp1.Money > emp2.Money;
//        }

//        public override bool Equals(object obj)
//        {
//            if (obj is Employee emp)
//            {
//                return this.Money == emp.Money;
//            }
//            return false;
//        }

//        public override int GetHashCode()
//        {
//            return Money.GetHashCode();
//        }

//        internal class Program
//        {
//            static void Main(string[] args)
//            {
//                Employee emp1 = new Employee("Agh Agh Gah", "21.21.1999", 1233433121, "12121@gmail.com", "Cleaner", "Wash the floors", 23000);
//                Employee emp2 = new Employee("John Doe", "15.07.1990", 987654321, "john.doe@example.com", "Developer", "Write code", 25000);

//                emp1.PrintEmployeeInfo();
//                Console.WriteLine();
//                emp2.PrintEmployeeInfo();

//                Console.WriteLine("\nIncreasing salary of emp1 by 5000");
//                emp1 = emp1 + 5000;
//                emp1.PrintEmployeeInfo();

//                Console.WriteLine("\nDecreasing salary of emp2 by 2000");
//                emp2 = emp2 - 2000;
//                emp2.PrintEmployeeInfo();

//                Console.WriteLine($"\nAre salaries of emp1 and emp2 equal? {emp1 == emp2}");
//                Console.WriteLine($"Is salary of emp1 greater than emp2? {emp1 > emp2}");
//                Console.WriteLine($"Is salary of emp1 less than emp2? {emp1 < emp2}");
//                Console.WriteLine($"Are salaries of emp1 and emp2 not equal? {emp1 != emp2}");
//            }
//        }
//    }
//}
