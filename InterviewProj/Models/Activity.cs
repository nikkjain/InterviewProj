using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace InterviewProj.Models
{
    [Keyless]
    public partial class Activity
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string ClaimReference { get; set; }
        [StringLength(50)]
        public string LegacyActivityId { get; set; }
        [Required]
        [StringLength(10)]
        public string ActivityTypeCode { get; set; }
        [Required]
        [StringLength(1000)]
        public string ActivityDetails { get; set; }
        public DateTime ActivityDateTime { get; set; }
        public int? PartyId { get; set; }
        [StringLength(4)]
        public string PartyType { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int LastUpdatedId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedId { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedId { get; set; }
    }
}
