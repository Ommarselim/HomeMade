﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMade.Domain.Entities.Setting
{

    [Table("PaymentStatus", Schema = "Setting")]
    public class PaymentStatus : BaseEntity
    {
        public PaymentStatus()
        {
            PaymentStatusGuid = Guid.NewGuid();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentStatusID { get; set; }
        public Guid PaymentStatusGuid { get; set; }
        [StringLength(75)]
        public string NameAR { get; set; }
        [StringLength(75)]
        public string NameEN { get; set; }
        public virtual User User { get; set; }
    }
}
