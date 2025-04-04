﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMade.Domain.Entities.Setting
{
    [Table("KeyWords", Schema = "Setting")]
    public class KeyWords : BaseEntity
    {
        public KeyWords()
        {
            KeyWordsGuid = Guid.NewGuid();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KeyWordsID { get; set; }
        public Guid KeyWordsGuid { get; set; }
        [StringLength(75)]
        public string NameAR { get; set; }
        [StringLength(75)]
        public string NameEN { get; set; }

        public int? DepartmentsID { get; set; }
        public virtual User User { get; set; }
        public virtual Departments Departments { get; set; }
    }
}
