using Library.Core.Interfaces;
using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.EF.Repositories
{
    public class EFPrestitoRepository : IPrestitoRepository
    {
        private readonly LibraryContext ctx;

        public EFPrestitoRepository()
        {
            ctx = new LibraryContext();
        }
        public bool Add(Prestito newPrestito)
        {
            if (newPrestito == null)
                return false;

            try
            {
                ctx.Prestiti.Add(newPrestito);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Prestito> Fetch()
        {
            throw new NotImplementedException();
        }

        public Prestito GetByDate(DateTime dataPrestito)
        {
            throw new NotImplementedException();
        }

        public Prestito GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Prestito GetByTitle(string titolo)
        {
            throw new NotImplementedException();
        }

        public bool Update(Prestito item)
        {
            throw new NotImplementedException();
        }
    }
}
