using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtKppEndpoint {
    public class VisitorStorage {
        private Dictionary<int, Visitor> visitorStorage;
        private Dictionary<string, int> codeStorage;

        public IReader reader;

        public Visitor GetVisitorById(int id) {
            if (visitorStorage.ContainsKey(id)) {
                return visitorStorage[id];
            }
            else {
                return null;
            }
        }

        public bool ContainsCode(string code) {
            if (codeStorage.ContainsKey(code)) {
                return true;
            }
            else {
                return false;
            }
        }

        public bool UpdateStorage() {
            
            return true;
        }
    }
}
