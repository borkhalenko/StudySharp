using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DtHelpDesk.Models {
    public class Order {
        public int OrderId { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
    }
}
