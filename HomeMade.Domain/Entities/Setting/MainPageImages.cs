using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMade.Domain.Entities.Setting
{

    [Table("MainPageImages", Schema = "Setting")]
    public class MainPageImages : BaseEntity
    {
        public MainPageImages()
        {
            MainPageImagesGuid = Guid.NewGuid();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MainPageImagesID { get; set; }
        public Guid MainPageImagesGuid { get; set; }
        public string Image { get; set; }
        public string VedioUrl { get; set; }

        public int MainPageDetailsID { get; set; }
        public virtual MainPageDetails MainPageDetails { get; set; }
        public virtual User User { get; set; }


    }
}
