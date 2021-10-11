using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace InterviewProj.Models
{
    [Keyless]
    public partial class LegacyActivityType
    {
        [Required]
        [StringLength(4)]
        public string Code { get; set; }
        [Required]
        [StringLength(4)]
        public string CategoryCode { get; set; }
        [Required]
        [StringLength(45)]
        public string Description { get; set; }
        [Required]
        [StringLength(1)]
        public string Active { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int LastUpdatedId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedId { get; set; }
    }
}
