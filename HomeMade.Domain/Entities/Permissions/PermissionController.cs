using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMade.Domain.Entities.Permissions
{

    [Table("PermissionController", Schema = "Permission")]
    public partial class PermissionController
    {
        public PermissionController()
        {
            PermissionControllerActions = new HashSet<PermissionControllerAction>();
            PermissionControllerGuid = Guid.NewGuid();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PermissionControllerID { get; set; }

        public Guid PermissionControllerGuid { get; set; }

        [StringLength(50)]
        public string PermissionControllerNameAr { get; set; }

        [StringLength(50)]
        public string PermissionControllerNameEn { get; set; }

        public virtual ICollection<PermissionControllerAction> PermissionControllerActions { get; set; }
    }
}
