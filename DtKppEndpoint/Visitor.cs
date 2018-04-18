using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtKppEndpoint {
    public class Visitor {
        private int id;
        private string name;
        private List<string> codes = new List<string>();

        public Visitor(int p_id) {
            Id = p_id;
        }

        public Visitor(int p_id, string p_name) {
            Id = p_id;
            Name = p_name;
        }

        public void AddCode(string code) {
            if (!codes.Contains(code)) {
                codes.Add(code);
            }
        }

        public void DeleteCode(string code) {
            if (codes.Contains(code)) {
                codes.Remove(code);
            }
        }

        public int Id {
            get {
                return id;
            }

            private set {
                id = value;
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
