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
            Shop shop1 = new Shop("Rozetka", "Kiev", "descpription", "+38097...", "shop@gmail.com");
            shop1.Name = "Rozetka";
            shop1.Adress = "Odesa";
            shop1.Description = "short descpription";
            shop1.Phone = "phone number";
            shop1.Email = "email.com";
            Console.WriteLine(shop1);


        }
    }
}