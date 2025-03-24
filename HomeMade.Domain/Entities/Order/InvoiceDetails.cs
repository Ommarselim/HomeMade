using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMade.Domain.Entities.Order
{

    [Table("InvoiceDetails", Schema = "Order")]
    public class InvoiceDetails : BaseEntity
    {
        public InvoiceDetails()
        {
            InvoiceDetailsGuid = Guid.NewGuid();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceDetailsID { get; set; }
        public Guid InvoiceDetailsGuid { get; set; }
        public int InvoiceMasterID { get; set; }
        public int OrderVendorID { get; set; }
        public decimal Total { get; set; }
        public virtual User User { get; set; }
        public virtual OrderVendor OrderVendor { get; set; }
        public virtual InvoiceMaster InvoiceMaster { get; set; }
    }
}
