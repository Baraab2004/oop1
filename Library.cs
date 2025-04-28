using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Library
    {

        List<Book> Books { get; set; }
        List<AbstractPerson> Members { get; set; }
        public Library()
        {
            Books = new List<Book>();
            Members = new List<AbstractPerson>();
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void AddMember(AbstractPerson member)
        {
            Members.Add(member);
        }
        public Book FindBookById(int id)
        {
            foreach (Book book in Books)
            {
                if(book.Id == id)
                {
                    return book;
                }
            }
            return null;
        }
        public AbstractPerson FindMemberById(int id)
        {
            foreach (AbstractPerson member in Members)
            {
                if (member.Id == id)
                {
                    return member;
                }
            }
            return null;
        }
        public void DisplayAllBooks()
        {
            foreach(Book book in Books)
            {
                book.DisplayInfo();
            }
        }
        public void DisplayAllMembers()
        {
            foreach (AbstractPerson member in Members)
            {
                member.DisplayInfo();
            }
        }
    }
}
