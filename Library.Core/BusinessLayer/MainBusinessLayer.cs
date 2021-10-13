using Library.Core.Interfaces;
using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IBookRepository bookRep;
        public MainBusinessLayer(IBookRepository bookRepository)
        {
            this.bookRep = bookRepository;
        }
        public bool AddBook(Book newBook)
        {
           if(newBook == null)
            {
                return false;
            }
           else
            {
                return bookRep.Add(newBook);
            }
        }

        public bool DeleteBook(int idBook)
        {
            if(idBook <= 0)
            {
                return false;
            }
            else
            {
                Book bookToDelete = bookRep.GetById(idBook);

                if(bookToDelete != null)
                {
                    return bookRep.Delete(bookToDelete.Id);
                }
                else
                {
                    return false;
                }
            }
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateBook(Book book)
        {
            if(book == null)
            {
                return false;
            }
            else
            {
                return bookRep.Update(book);
            }
        }

        //TODO: Implementare
        public List<Book> FetchBooks()
        {
            throw new NotImplementedException();
        }

        public bool PrestitoLibro(Prestito prestito)
        {
            throw new NotImplementedException();
        }

        public bool ResoLibro(Prestito reso)
        {
            throw new NotImplementedException();
        }
    }
}
