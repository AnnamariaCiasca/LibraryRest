using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Library.WcfSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Library.Wcf.LibraryService)))
            {
                host.Open();

                Console.WriteLine("Premi un tasto per fermare il servizio");
                Console.ReadKey();
            }
        }
    }
}
