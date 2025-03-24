using HomeMade.Domain.Entities.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMade.Domain.Entities.Setting
{

    [Table("CaptainZone", Schema = "Setting")]
    public class CaptainZone : BaseEntity
    {
        public CaptainZone()
        {
            CaptainZoneGuid = Guid.NewGuid();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CaptainZoneID { get; set; }
        public Guid CaptainZoneGuid { get; set; }
        public int BlockID { get; set; }
        public int DriversID { get; set; }

        public virtual Drivers Drivers { get; set; }
        public virtual User User { get; set; }
        public virtual Block Block { get; set; }

    }
}
