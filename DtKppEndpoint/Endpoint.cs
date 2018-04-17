using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtKppEndpoint {
    class Endpoint {
        private Guid uid;
        private string name;
        private IReader reader;

        public int start() {
            reader = new SimpleReader();
            while (true) {
                Console.WriteLine( reader.getBarCode()) ;
                System.Threading.Thread.Sleep(1000);
            }
            return 0;
        }

        public Guid Uid {
            get {
                return uid;
            }

            set {
                uid = value;
            }
        }

        public string Name {
            get {
                return name;
            }

            set {
                name = value;
            }
        }
    }
}
