using System;
using System.Collections.Generic;

namespace OOPtest
{
    abstract class Book
    {
        private protected string author;
        public Book(string author)
        {
            this.author = author;
        }
        public abstract Book getBook();
        public abstract string getTitle();
    }

    class MarkTwenBook : Book
    {
        private string title;
        public MarkTwenBook(string title) : base("Mark Twen")
        {
            this.title = title;
        }
        public void toString()
        {
            Console.WriteLine(title+" "+author );
        }
        public override string getTitle()
        {
            Console.WriteLine(title);
            return title;
        }
        public override Book getBook()
        {
            return this;
        }
    }

    class AgataCristiBook : Book
    {
        private string title;
        public AgataCristiBook(string title) : base("Agata Cristi")
        {
            this.title = title;
        }
        public void toString()
        {
            Console.WriteLine(title + " " + author);
        }
        public override string getTitle()
        {
            Console.WriteLine(title);
            return title;
        }
        public override Book getBook()
        {
            return this;
        }
    }



    

        
        class Program
        {
            static void Main(string[] args)
            {
            AgataCristiBook DeathOnNill = new AgataCristiBook("Death on the Nile read");
            MarkTwenBook TomSawyer = new MarkTwenBook("The Adventures of Tom Sawyer");
            DeathOnNill.toString();
            TomSawyer.toString();
            }
        }
}   
