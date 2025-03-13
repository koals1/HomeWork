//using System;
//using System.Collections;
//using System.Collections.Generic;

//class Book : IComparable<Book>, ICloneable
//{
//    public string Title { get; set; }
//    public string Author { get; set; }
//    public int Year { get; set; }
//    public double Price { get; set; }

//    public Book(string title, string author, int year, double price)
//    {
//        Title = title;
//        Author = author;
//        Year = year;
//        Price = price;
//    }

  
//    public int CompareTo(Book other)
//    {
//        return this.Year.CompareTo(other.Year);
//    }

  
//    public object Clone()
//    {
//        return new Book(this.Title, this.Author, this.Year, this.Price);
//    }

//    public override string ToString()
//    {
//        return $"Книга: {Title}, Автор: {Author}, Рік: {Year}, Ціна: {Price} грн";
//    }
//}

//class PriceComparer : IComparer<Book>
//{
//    public int Compare(Book x, Book y)
//    {
//        return x.Price.CompareTo(y.Price);
//    }
//}

//class Program
//{
//    static void Main()
//    {
       
//        Book[] books = {
//            new Book("Гаррі Поттер", "Дж. К. Роулінг", 1997, 350),
//            new Book("Війна і мир", "Лев Толстой", 1869, 500),
//            new Book("1984", "Джордж Орвелл", 1949, 280),
//            new Book("Майстер і Маргарита", "Михайло Булгаков", 1967, 300)
//        };

//        Console.WriteLine("Список книг до сортування:");
//        foreach (var book in books)
//        {
//            Console.WriteLine(book);
//        }

        
//        Array.Sort(books);
//        Console.WriteLine("\nСписок книг після сортування за роком:");
//        foreach (var book in books)
//        {
//            Console.WriteLine(book);
//        }

//        Array.Sort(books, new PriceComparer());
//        Console.WriteLine("\nСписок книг після сортування за ціною:");
//        foreach (var book in books)
//        {
//            Console.WriteLine(book);
//        }

      
//        Book originalBook = books[0];
//        Book clonedBook = (Book)originalBook.Clone();

        
//        Console.WriteLine("\nОригінальна книга:");
//        Console.WriteLine(originalBook);

//        Console.WriteLine("\nКлонована книга:");
//        Console.WriteLine(clonedBook);
//    }
//}
