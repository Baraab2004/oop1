using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Member : AbstractPerson
    {
        public List<Book> BorrowedBooks;

        public Member(int id, string name) : base(id, name)
        {
            BorrowedBooks = new List<Book>();
        }
        public void BorrowBook(Book book)
        {
            if (book.IsAvailable)
            {
                BorrowedBooks.Add(book);
                book.IsAvailable = false;
                Console.WriteLine("\nThe book has been borrowed successfully !!\n");
            }
            else
            {
                Console.WriteLine("\nThe book is not available !!\n");
            }
        }
        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                book.IsAvailable = true;
                Console.WriteLine("\nThe book has been returned successfully !!\n");
            }
            else
            {
                Console.WriteLine("\nThe book is not available !!\n");
            }
        }
        public void DisplayBorrowedBooks()
        {
            if (BorrowedBooks.Count == 0)
            {
                Console.WriteLine("No books borrowed.");
            }
            else
            {
                Console.WriteLine("\nYour borrowed books : \n");
                foreach (Book book in BorrowedBooks)
                {
                    book.DisplayInfo();
                }
            }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"\n Member ID: {Id}\n Name: {Name}\n Have: {BorrowedBooks.Count} Books\n");
            Console.WriteLine("=====================");
        }
    }
}
