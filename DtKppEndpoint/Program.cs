using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtKppEndpoint {
    class Program {
        static void Main(string[] args) {
            Settings settings = new Settings();
            Console.WriteLine(settings.GetStorageType());
            //Endpoint e = new Endpoint();
            //e.start();
        }
    }
}
