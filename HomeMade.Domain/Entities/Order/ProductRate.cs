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
    [Table("ProductRate", Schema = "Order")]
    public class ProductRate : BaseEntity
    {
        public ProductRate()
        {
            ProductRateGuid = Guid.NewGuid();
            Notification = new HashSet<Notification>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductRateID { get; set; }
        public Guid ProductRateGuid { get; set; }
        public int ProductID { get; set; }
        public string CommentProduct { get; set; }
        public decimal Rate { get; set; }
        public int OrderVendorID { get; set; }
        public int OrderID { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual OrderVendor OrderVendor { get; set; }
        public virtual ICollection<Notification> Notification { get; set; }
    }
}
