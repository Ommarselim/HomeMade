using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMade.Domain.Entities.Setting
{

    [Table("Tokens", Schema = "Setting")]
    public class Tokens
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TokenId { get; set; }
        public string TokenVal { get; set; }
        public int DeviceType { get; set; } //DeviceTypeEnum
        public int UserType { get; set; }  // UserTypeEnum
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int UserID { get; set; }
    }
}
