using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DtHelpDesk.Models
{
    public class WorkOrderRepository
    {
        private static List<WorkOrderModel> orders = new List<WorkOrderModel>();
        public static IEnumerable<WorkOrderModel> Orders {
            get {
                return orders;
            }
        }

        public static void AddOrder(WorkOrderModel order) {
            orders.Add(order);
        }
    }
}
