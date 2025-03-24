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

namespace HomeMade.Domain.Entities.Setting
{
    [Table("Activity", Schema = "Setting")]
    public class Activity : BaseEntity
    {
        public Activity()
        {
            ActivityGuid = Guid.NewGuid();
            Vendors = new HashSet<Vendors>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ActivityID { get; set; }
        public Guid ActivityGuid { get; set; }
        [StringLength(75)]
        public string NameAR { get; set; }
        [StringLength(75)]
        public string NameEN { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Vendors> Vendors { get; set; }
    }
}
