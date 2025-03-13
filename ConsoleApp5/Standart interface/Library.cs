//using System;
//using System.Collections;
//using System.Collections.Generic;


//class Library : IEnumerable<Book>
//{
//    private Book[] books;

//    public Library(Book[] books)
//    {
//        this.books = books;
//    }

//    public IEnumerator<Book> GetEnumerator()
//    {
//        foreach (var book in books)
//            yield return book;
//    }

//    IEnumerator IEnumerable.GetEnumerator()
//    {
//        return GetEnumerator();
//    }
//}

