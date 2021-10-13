using Library.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Library.Wcf
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IService1" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface ILibraryService
    {
        [OperationContract]
        List<Book> FetchBooks();

        [OperationContract]
        bool CreateBook(Book newBook);

        [OperationContract]
        bool DeleteBook(int idBook);

        [OperationContract]
        bool UpdateBook(Book book);
    }
}
