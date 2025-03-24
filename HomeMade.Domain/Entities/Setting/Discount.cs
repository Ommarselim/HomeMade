using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMade.Domain.Entities.Setting
{
    [Table("Discount", Schema = "Setting")]
    public class Discount : BaseEntity
    {
        public Discount()
        {
            DiscountGuid = Guid.NewGuid();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DiscountID { get; set; }
        public Guid DiscountGuid { get; set; }
        public int DiscountTypeID { get; set; }  // DiscountSettingEnum
        public decimal DiscountValue { get; set; }
        public virtual User User { get; set; }
    }
}
