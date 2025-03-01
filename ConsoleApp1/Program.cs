using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Введите число от 1 до 100: ");
        int number;

       
        i
         
            if (number < 1 || number > 100)
            {
                Console.WriteLine("Ошибка! Число должно быть в диапазоне от 1 до 100.");
            }
            else
            {
               
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    
                    Console.WriteLine(number);
                }
            }
        
       
    }
}
