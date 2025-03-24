using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMade.Domain.Entities.Setting
{
    [Table("Slider", Schema = "Setting")]
    public class Slider : BaseEntity
    {
        public Slider()
        {
            SliderGuid = Guid.NewGuid();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SliderID { get; set; }
        public Guid SliderGuid { get; set; }
        [StringLength(75)]
        public string NameAR { get; set; }
        [StringLength(75)]
        public string NameEN { get; set; }
        public string DescAr { get; set; }
        public string DescEN { get; set; }
        public string Image { get; set; }
        public int DisplayIn { get; set; }
        public int SliderTypeId { get; set; } //SliderTypeEnum
        public virtual User User { get; set; }
    }
}
