using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Book
    {
        

        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public bool IsAvailable { get; set; }
        public Book(int id, string title, string authorName)
        {
            Id = id;
            Title = title;
            AuthorName = authorName;
            IsAvailable = true;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"\n Book Id : {Id}\n Title : {Title}\n Author name : {AuthorName}\n");
            Console.WriteLine("===========================");
        }
    }
}
