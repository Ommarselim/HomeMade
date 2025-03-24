using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeMade.Domain.Entities.Setting;

namespace HomeMade.Domain.Entities.Order
{
    [Table("ListTransfer", Schema = "Order")]
    public class ListTransfer : BaseEntity
    {
        public ListTransfer()
        {
            ListTransferGuid = Guid.NewGuid();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ListTransferID { get; set; }
        public int InvoiceMasterID { get; set; }
        public Guid ListTransferGuid { get; set; }
        [Display(Name = "Bank")]
        public int? BanksID { get; set; }
        public decimal Total { get; set; }
        public string ReferenceNo { get; set; }
        public string Attachment { get; set; }
        public DateTime TransferDate { get; set; }
        public virtual User User { get; set; }
        public virtual Banks Banks { get; set; }
        public virtual InvoiceMaster InvoiceMaster { get; set; }
    }
}
