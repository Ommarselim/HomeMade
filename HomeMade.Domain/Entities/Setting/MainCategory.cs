﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMade.Domain.Entities.Setting
{
    [Table("MainCategory", Schema = "Setting")]
    public class MainCategory : BaseEntity
    {
        public MainCategory()
        {
            MainCategoryGuid = Guid.NewGuid();
            Departments = new HashSet<Departments>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int MainCategoryID { get; set; }
        public Guid MainCategoryGuid { get; set; }
        [StringLength(75)]
        public string NameAR { get; set; }
        [StringLength(75)]
        public string NameEN { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Departments> Departments { get; set; }

    }
}
