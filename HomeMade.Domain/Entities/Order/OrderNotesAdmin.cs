using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMade.Domain.Entities.Order
{
    [Table("OrderNotesAdmin", Schema = "Order")]
    public class OrderNotesAdmin : BaseEntity
    {
        public OrderNotesAdmin()
        {
            OrderNotesAdminGuid = Guid.NewGuid();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderNotesAdminID { get; set; }
        public Guid OrderNotesAdminGuid { get; set; }
        public string Notes { get; set; }
        #region Relations
        public int OrderVendorID { get; set; }
        public virtual OrderVendor OrderVendor { get; set; }
        public virtual User User { get; set; }
        #endregion
    }
}
