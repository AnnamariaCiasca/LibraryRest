using Library.Core;
using Library.Core.BusinessLayer;
using Library.Core.Interfaces;
using Library.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Library.Wcf
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "Service1" nel codice e nel file di configurazione contemporaneamente.
    public class LibraryService : ILibraryService
    {
       private readonly IBusinessLayer bl;
       public LibraryService()
        {
            bl = new MainBusinessLayer(new EFBookRepository()); //TODO: Passare istanza di IBookRepository
        }

        public bool CreateBook(Book newBook)
        {
            if(newBook == null)
            {
                return false;
            }

            return bl.AddBook(newBook);
        }

        public bool DeleteBook(int idBook)
        {
            if(idBook > 0)
            {
                return bl.DeleteBook(idBook);
            }
            else
            {
                return false;
            }
        }


        public bool UpdateBook(Book book)
        {
            if(book == null)
            {
                return false;
            }
            else
            {
                return bl.UpdateBook(book);
            }
        }

        public List<Book> FetchBooks()
        {
            return bl.FetchBooks();
        }
    }
}
