using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeMade.Domain.Entities.Setting;

namespace HomeMade.Domain.Entities.Emp
{
    [Table("Employees", Schema = "Emp")]
    public class Employees : BaseEmp
    {
        public Employees()
        {
            EntityEmpGuid = Guid.NewGuid();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int EntityEmpID { get; set; }
        public Guid EntityEmpGuid { get; set; }
        public int JobsID { get; set; }
        public virtual Nationality Nationality { get; set; }
        public virtual City City { get; set; }
        public virtual User User { get; set; }
        public virtual Jobs Jobs { get; set; }

    }
}
