using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtItHelpDesk {
    class TradePoint {
        private string namePoint;
        private string address;

        public string NamePoint {
            get {
                return namePoint;
            }

            set {
                namePoint = value;
            }
        }

        public string Address {
            get {
                return address;
            }

            set {
                address = value;
            }
        }
    }
}
