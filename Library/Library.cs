using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Library
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library (params Book[] books)
        {
            this.books = new List<Book>(books);

        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var book in books)
            {
                yield return book; // Return type that is an IEnumerable; "yield return" to return a value to set in the loop body.
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
