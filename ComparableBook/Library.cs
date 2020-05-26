﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ComparableBook
{
   public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);

        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        { return this.GetEnumerator(); }

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);

            }
            public void Dispose() { }
            public bool MoveNext() => ++this.currentIndex < this.books.Count;
            public void Reset() => this.currentIndex = -1;
            public Book Current => this.books[this.currentIndex];
            object IEnumerator.Current => this.Current;
        }
    }
}
