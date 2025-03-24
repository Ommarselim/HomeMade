using HomeMade.Domain.Entities.Customer;
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
    [Table("Block", Schema = "Setting")]
    public class Block : BaseEntity
    {
        public Block()
        {
            BlockGuid = Guid.NewGuid();
            CustomerLocation = new HashSet<CustomerLocation>();
            Vendors = new HashSet<Vendors>();
            CaptainZone = new HashSet<CaptainZone>();
            ShippingCompanyBlocks = new HashSet<ShippingCompanyBlocks>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BlockID { get; set; }
        public Guid BlockGuid { get; set; }
        public string Code { get; set; }
        [StringLength(75)]
        public string NameAR { get; set; }
        [StringLength(75)]
        public string NameEN { get; set; }

        public int CityID { get; set; }
        public virtual User User { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<CustomerLocation> CustomerLocation { get; set; }
        public virtual ICollection<Vendors> Vendors { get; set; }
        public virtual ICollection<CaptainZone> CaptainZone { get; set; }
        public virtual ICollection<ShippingCompanyBlocks> ShippingCompanyBlocks { get; set; }


    }
}
