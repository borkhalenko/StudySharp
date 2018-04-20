using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;

namespace DtKppEndpoint {
    class Settings {
        //Singleton
        private Settings() { }
        private static Settings instance = null;
        public static Settings GetInstance() {
            if (instance == null) {
                instance = new Settings();
            }
            return instance;
        }

        public bool ResetToDefault() {
            return true;
        }

        public string GetStorageType() {
            string sAttr = ConfigurationManager.AppSettings.Get("OutStorageType");
            return sAttr;
        }
    }
}
