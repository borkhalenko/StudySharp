using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//https://habr.com/post/271483/
namespace DtKppEndpoint {
    class Program {
        static void Main(string[] args) {
            Settings settings = Settings.GetInstance();
            Console.WriteLine(settings.GetStorageType());
            //Endpoint e = new Endpoint();
            //e.start();
        }
    }
}
