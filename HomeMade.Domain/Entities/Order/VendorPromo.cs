using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeMade.Domain.Entities.Customer;
using HomeMade.Domain.Entities.Driver;
using HomeMade.Domain.Entities.Emp;
using HomeMade.Domain.Entities.Order;
using HomeMade.Domain.Entities.Permissions;
using HomeMade.Domain.Entities.Setting;
using HomeMade.Domain.Entities.Vendor;

namespace HomeMade.Domain.Entities.Order
{
    [Table("VendorPromo", Schema = "Order")]
    public class VendorPromo : BaseEntity
    {
        public VendorPromo()
        {
            VendorPromoGuid = Guid.NewGuid();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VendorPromoID { get; set; }
        public Guid VendorPromoGuid { get; set; }
        public int VendorsID { get; set; }
        public int PromoCodeID { get; set; }
        public virtual User User { get; set; }
        public virtual PromoCode PromoCode { get; set; }
        public virtual Vendors Vendors { get; set; }

    }
}
