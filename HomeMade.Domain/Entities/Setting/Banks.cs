using HomeMade.Domain.Entities.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeMade.Domain.Entities.Vendor;

namespace HomeMade.Domain.Entities.Setting
{

    [Table("Banks", Schema = "Setting")]
    public class Banks : BaseEntity
    {
        public Banks()
        {
            BankGuid = Guid.NewGuid();
            PaymentConfiguration = new HashSet<PaymentConfiguration>();
            Vendors = new HashSet<Vendors>();
            ListTransfer = new HashSet<ListTransfer>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BanksID { get; set; }
        public Guid BankGuid { get; set; }
        [StringLength(75)]
        public string NameAR { get; set; }
        [StringLength(75)]
        public string NameEN { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<PaymentConfiguration> PaymentConfiguration { get; set; }
        public virtual ICollection<Vendors> Vendors { get; set; }
        public virtual ICollection<ListTransfer> ListTransfer { get; set; }


    }
}
