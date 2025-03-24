using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMade.Domain.Entities.Setting
{

    [Table("InqueriesReply", Schema = "Setting")]
    public class InqueriesReply : BaseEntity
    {
        public InqueriesReply()
        {
            InqueriesReplyGuid = Guid.NewGuid();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InqueriesReplyID { get; set; }
        public Guid InqueriesReplyGuid { get; set; }
        public int InqueriesID { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        public string EmailContent { get; set; }
        public bool IsSMS { get; set; }
        public bool IsEmail { get; set; }
        public virtual User User { get; set; }
        public virtual Inqueries Inqueries { get; set; }
    }
}
