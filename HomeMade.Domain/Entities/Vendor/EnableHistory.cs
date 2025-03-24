using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMade.Domain.Entities.Vendor
{
    [Table("EnableHistory", Schema = "Vendor")]
    public class EnableHistory : BaseEntity
    {
        public EnableHistory()
        {
            EnableHistoryGuid = Guid.NewGuid();
        }
        public int EnableHistoryID { get; set; }
        public Guid EnableHistoryGuid { get; set; }
        public bool Status { get; set; }
        public int VendorsID { get; set; }
        public virtual User User { get; set; }
        public virtual Vendors Vendors { get; set; }

    }
}
