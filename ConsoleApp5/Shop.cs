using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Shop
    {

        public string Name { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Shop(string name, string adress, string descpription, string phone, string email)
        {
            Name = name;
            Adress = adress;
            Email = email;
            Description = descpription;
            Phone = phone;
            Email = email;
        }
        public override string ToString()
        {
            return $"Name:{Name}\nAdress:{Adress}\nDescription: {Description}\nPhone: {Phone} \nEmail:{Email} ";
        }
    }
}