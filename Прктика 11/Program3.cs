using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп___3
{
    internal class Book
    {
        private string title;
        private int pages;
        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Название не может быть пустым");
                else
                    title = value;
            }
        }
        public int Pages
        {
            get { return pages; }
            set
            {
                pages = value >= 1 ? value : 1;
            }
        }
        public bool IsLong
        {
            get { return Pages > 300; }
        }
        public Book(string title)
        {
            this.Title = title;
            Pages = 1;
        }
        public Book(string title, int pages) : this(title)
        {
            Pages = pages;
        }
        public void Info()
        {
            string Long = IsLong ? "да" : "нет";
            Console.WriteLine($"Книга: {Title}, страниц: {Pages}, длинная: {Long}");
        }
    }


internal class Program
    {
        static void Main(string[] args)
        {
Book book= new Book ("Война и мир", 1200);
            book.Info();
            Book book2 = new Book("");
            Book book3 = new Book("Краткая история", 1);
            book3.Info();
        }
    }

}
   
