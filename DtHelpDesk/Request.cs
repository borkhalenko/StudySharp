using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtItHelpDesk {
    class Request {
        private TradePoint point;
        private DateTime date;
        private String description;

        internal TradePoint Point {
            get {
                return point;
            }

            set {
                point = value;
            }
        }

        public DateTime Date {
            get {
                return date;
            }

            set {
                date = value;
            }
        }

        public string Description {
            get {
                return description;
            }

            set {
                description = value;
            }
        }
    }
}
