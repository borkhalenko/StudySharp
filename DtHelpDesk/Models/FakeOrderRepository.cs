using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DtHelpDesk.Models {
    public class FakeOrderRepository : IOrderRepository {
        public IEnumerable<Order> Orders => new List<Order> {
            new Order {Department = "001 Aaaaaa", Description="queaeua" },
            new Order {Department = "002 Ooooo  oooo", Description="testaeuoes oetuaste"}
        };
    }
}
