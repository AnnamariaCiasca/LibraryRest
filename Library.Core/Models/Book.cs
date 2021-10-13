using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Library.Core
{
    [DataContract]
    public class Book
    {   
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ISBN { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Author { get; set; }

        public List<Prestito> Prestiti { get; set; }
    }
}
