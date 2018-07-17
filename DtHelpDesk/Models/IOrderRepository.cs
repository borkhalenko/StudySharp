using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DtHelpDesk.Models {
    public interface IOrderRepository {
        IEnumerable<Order> Orders { get; }
    }
}
