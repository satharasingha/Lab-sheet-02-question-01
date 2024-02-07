using System;

namespace Lab_sheet_02_question_01
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();
            myBook.Title = "Harry Potter and the Philosopher's Stone";
            myBook.Author = "J.K. Rowling";

            Console.WriteLine("Title: " + myBook.Title);
            Console.WriteLine("Author: " + myBook.Author);
        }
    }
}