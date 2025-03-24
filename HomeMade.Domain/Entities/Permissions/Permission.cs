using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMade.Domain.Entities.Permissions
{
    [Table("Permission", Schema = "Permission")]
    public partial class Permission
    {

        public Permission()
        {
            PermissionGuid = Guid.NewGuid();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PermissionID { get; set; }
        public Guid PermissionGuid { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public int PermissionControllerActionID { get; set; }
        public virtual PermissionControllerAction PermissionControllerActions { get; set; }
        public virtual CustomRole Role { get; set; }
        public virtual User User { get; set; }
    }
}
