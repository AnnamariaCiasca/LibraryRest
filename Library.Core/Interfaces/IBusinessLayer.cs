using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Core.Interfaces
{
    public interface IBusinessLayer
    {
        bool AddBook(Book newBook);
        bool DeleteBook(int idBook);
        bool UpdateBook(Book book);
        List<Book> FetchBooks();

        bool PrestitoLibro(Prestito prestito);
        bool ResoLibro(Prestito reso);
    }
}
