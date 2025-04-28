using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    abstract class AbstractPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> BorrowedBooks { get; set; }
        public AbstractPerson(int id,string name)
        {
            Id = id;
            Name = name;
            BorrowedBooks = new List<Book>();
        }

        abstract public void DisplayInfo();

    }
}
