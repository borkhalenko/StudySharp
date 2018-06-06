using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DtHelpDesk.Models {
    public class WorkOrderModel {
        [Required(ErrorMessage = "Please enter department name")]
        public string Department { get; set; }

        [Required(ErrorMessage ="Please enter description")]
        public string Description { get; set; }
    }
}
