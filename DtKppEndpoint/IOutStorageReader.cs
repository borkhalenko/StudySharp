using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtKppEndpoint {
    interface IOutStorageReader {
        ICollection<Visitor> GetVisitors();
        IDictionary<string, int> getBarcodes();
    }
}
