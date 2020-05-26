using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ComparableBook
{
    public class Book : IComparable<Book>
    {
        private List<string> authors;

       
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = new List<string>(authors);

        }

        public string Title { get; private set; }
        public int Year { get; private set; }
        public IReadOnlyList<string> Authors
        {
            get;
            private set;

        }

        public int CompareTo (Book Other)
        {
            int result = this.Year.CompareTo(Other.Year);
            if ( result == 0)
            {
                result = this.Title.CompareTo(Other.Title);
            }
            return result;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
