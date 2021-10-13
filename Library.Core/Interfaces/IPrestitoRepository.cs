using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Core.Interfaces
{
  public interface IPrestitoRepository : IRepository<Prestito>
    {
        Prestito GetByTitle(string titolo);

        Prestito GetByDate(DateTime dataPrestito);
    }
}
