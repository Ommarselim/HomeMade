﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMade.Domain.Entities.Setting
{

    [Table("ShippingCompanyBlocks", Schema = "Setting")]
    public class ShippingCompanyBlocks : BaseEntity
    {
        public ShippingCompanyBlocks()
        {
            ShippingCompanyBlocksGuid = Guid.NewGuid();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShippingCompanyBlocksID { get; set; }
        public Guid ShippingCompanyBlocksGuid { get; set; }
        public int BlockID { get; set; }
        public int ShippingCompanyID { get; set; }

        public virtual ShippingCompany ShippingCompany { get; set; }
        public virtual User User { get; set; }
        public virtual Block Block { get; set; }

    }
}
