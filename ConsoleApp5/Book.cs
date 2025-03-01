using System;

namespace ConsoleApp5
{
    class BookList
    {
        private string[] books;
        private int bookCount;

        public int Count
        {
            get { return bookCount; }
        }

        public BookList(int capacity)
        {
            books = new string[capacity];
            bookCount = 0;
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < bookCount)
                    return books[index];
                throw new IndexOutOfRangeException("Invalid index.");
            }
            set
            {
                if (index >= 0 && index < bookCount)
                    books[index] = value;
                else
                    throw new IndexOutOfRangeException("Invalid index.");
            }
        }

        public static BookList operator +(BookList bookList, string book)
        {
            if (bookList.bookCount >= bookList.books.Length)
                throw new InvalidOperationException("No more space to add books.");
            bookList.books[bookList.bookCount++] = book;
            return bookList;
        }

        public static BookList operator -(BookList bookList, string book)
        {
            for (int i = 0; i < bookList.bookCount; i++)
            {
                if (bookList.books[i] == book)
                {
                    for (int j = i; j < bookList.bookCount - 1; j++)
                    {
                        bookList.books[j] = bookList.books[j + 1];
                    }
                    bookList.books[--bookList.bookCount] = null;
                    return bookList;
                }
            }
            throw new InvalidOperationException("Book not found.");
        }

        public void PrintBooks()
        {
            Console.WriteLine("Books in the list:");
            if (bookCount == 0)
                Console.WriteLine("No books in the list.");
            else
            {
                for (int i = 0; i < bookCount; i++)
                    Console.WriteLine($"{i + 1}. {books[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BookList myBookList = new BookList(5);

            myBookList = myBookList + "The Catcher in the Rye";
            myBookList = myBookList + "1984 by George Orwell";
            myBookList = myBookList + "To Kill a Mockingbird";
            myBookList = myBookList + "Moby Dick";

            myBookList.PrintBooks();

            myBookList = myBookList - "1984 by George Orwell";
            myBookList.PrintBooks();
        }
    }
}
