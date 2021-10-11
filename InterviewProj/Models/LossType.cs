using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace InterviewProj.Models
{
    public partial class LossType
    {
        [Key]
        public int LossTypeId { get; set; }
        [Required]
        [StringLength(2)]
        public string LossTypeCode { get; set; }
        [Required]
        [StringLength(25)]
        public string LossTypeDescription { get; set; }
        [Required]
        public bool? Active { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int LastUpdatedId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedId { get; set; }
    }
}
