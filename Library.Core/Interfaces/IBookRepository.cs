using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Core.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        Book GetByISBN(string isbn);
    }
}
