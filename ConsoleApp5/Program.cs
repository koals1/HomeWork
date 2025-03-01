using ClassWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            //Task 1
            Shop shop1 = new Shop("Rozetka", "Kiev", "descpription", "+38097...", "shop@gmail.com");
            shop1.Name = "Rozetka";
            shop1.Adress = "Odesa";
            shop1.Description = "short descpription";
            shop1.Phone = "phone number";
            shop1.Email = "email.com";
            Console.WriteLine(shop1);
            //Task 2
            Console.WriteLine();
            Journal journal1 = new Journal("Forbs", 2010, "descpription", "+38097....", "forbs@gmail.com");
            Console.WriteLine(journal1);
            //Task 3
            Console.WriteLine();
            Web web1 = new Web("Site", "htps://www.site", "description", "100.200.300");
            Console.WriteLine(web1);
        }

    }
}