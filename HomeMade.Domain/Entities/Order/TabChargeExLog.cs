using HomeMade.Domain.Entities.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMade.Domain.Entities.Order
{
    [Table("TabChargeExLog", Schema = "Order")]
    public class TabChargeExLog
    {
        [Key]
        public int TabChargeExLogID { get; set; }
        public int TabChargeExLogGuid { get; set; }
        public int? OrdersID { get; set; }
        public int? CustomersID { get; set; }
        public string Status { get; set; }
        public string ResponseRedirect { get; set; }
        public DateTime RequestDate { get; set; }
        public int ErrorFrom { get; set; }
        public int TabChargeEnum { get; set; }

        public virtual Orders Orders { get; set; }
        public virtual Customers Customers { get; set; }

    }
}
