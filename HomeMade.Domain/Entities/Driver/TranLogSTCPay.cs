﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeMade.Domain.Entities.Order;

namespace HomeMade.Domain.Entities.Driver
{

    [Table("TranLogSTCPay", Schema = "Driver")]
    public class TranLogSTCPay : BaseEntity
    {
        public TranLogSTCPay()
        {
            TranLogSTCPayGUID = Guid.NewGuid();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TranLogSTCPayID { get; set; }
        public Guid TranLogSTCPayGUID { get; set; }
        public int TransactionSTCPayID { get; set; }
        public int OrderVendorID { get; set; }
        public virtual User User { get; set; }
        public virtual OrderVendor OrderVendor { get; set; }
        public virtual TransactionSTCPay TransactionSTCPay { get; set; }
    }
}
