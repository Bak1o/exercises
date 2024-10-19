using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public int Year { get; set; }
        public Book(string title, int pages, int year)
        {
            Title = title;
            Pages = pages;
            Year = year;
        }

        public void PrintTitle()
        {
            Console.WriteLine(Title);
        }

        public override string ToString()
        {
            return Title + " pages = " + Pages + " year = " + Year;
        }
    }
}
