using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeMade.Domain.Entities.Vendor;

namespace HomeMade.Domain.Entities.Order
{

    [Table("QuantitiesRequest", Schema = "Order")]
    public class QuantitiesRequest : BaseEntity
    {
        public QuantitiesRequest()
        {
            QuantitiesRequestGuid = Guid.NewGuid();
            QuantitiesRequestProduct = new HashSet<QuantitiesRequestProduct>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuantitiesRequestID { get; set; }
        public Guid QuantitiesRequestGuid { get; set; }
        public int VendorsID { get; set; } // fk
        public virtual User User { get; set; }
        public virtual Vendors Vendors { get; set; }
        public virtual ICollection<QuantitiesRequestProduct> QuantitiesRequestProduct { get; set; }
    }
}
