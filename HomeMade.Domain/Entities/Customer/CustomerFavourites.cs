using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeMade.Domain.Entities.Vendor;

namespace HomeMade.Domain.Entities.Customer
{
    [Table("CustomerFavourites", Schema = "Setting")]
    public class CustomerFavourites : BaseEntity
    {
        public CustomerFavourites()
        {
            CustomerFavouritesGuid = Guid.NewGuid();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerFavouritesID { get; set; }
        public Guid CustomerFavouritesGuid { get; set; }
        public int CustomersID { get; set; }
        public int ProductID { get; set; }
        public virtual User User { get; set; }
        public virtual Customers Customers { get; set; }
        public virtual Product Product { get; set; }
    }
}
