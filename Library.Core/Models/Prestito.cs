using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Library.Core.Models
{
    [DataContract]
    public class Prestito
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Utente { get; set; }
        [DataMember]
        public DateTime DataPrestito { get; set; }

        public DateTime? DataReso { get; set; }


        public int IdBook { get; set; }
        public Book Book { get; set; }
    }
}
