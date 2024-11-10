using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace task_2
{
    public class Library
    {
        public Book[] Books = new Book[0];

        
        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[^1] = book;
        }

        
        public Book GetBookById(int id)
        {
            foreach (var book in Books)
            {
                if (book.Id == id)
                    return book;
            }
            return null;
        }

       
        public Book GetBookByName(string name)
        {
            foreach (var book in Books)
            {
                if (book.Name == name)
                {
                    return book;
                }
                    
            }
            return null;
        }
        public Book[] GetBooksByName(string name)
        {
            Book[] wantedBookName = new Book[0];

            foreach (Book book in Books)
            {
                if (book.Name.ToLower().Contains(name.ToLower()))
                {
                    Array.Resize(ref wantedBookName, wantedBookName.Length + 1);
                    wantedBookName[^1] = book;
                }
            }
            return wantedBookName;
        }

        public Book[] GetFilteredBook(string genre)
        {
            Book[] wantedGenre = new Book[0];

            foreach (Book book in Books)
            {
                if (book.Genre.ToLower().Contains(genre.ToLower()))
                {
                    Array.Resize(ref wantedGenre, wantedGenre.Length + 1);
                    wantedGenre[^1] = book;
                }
            }
            return wantedGenre;
        }

        public Book[] GetFiltredBooks(double minPrice, double maxPrice)
        {
            Book[] wantedbooks = new Book[0];
            foreach (var book in Books)
            {
                if (book.Price >= minPrice && book.Price <= maxPrice)
                {
                    Array.Resize(ref wantedbooks, wantedbooks.Length + 1);
                    wantedbooks[^1] = book;
                }
            }
            return wantedbooks;
        }
    }

}

