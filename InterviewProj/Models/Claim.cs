using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace InterviewProj.Models
{
    [Keyless]
    public partial class Claim
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Reference { get; set; }
        public int LossAdjusterId { get; set; }
        [StringLength(100)]
        public string Policy { get; set; }
        public DateTime LossDate { get; set; }
        public int LossTypeId { get; set; }
        [StringLength(200)]
        public string LossLoc { get; set; }
        public bool Closed { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int LastUpdatedId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedId { get; set; }

        [ForeignKey(nameof(CreatedId))]
        public virtual User Created { get; set; }
        [ForeignKey(nameof(LastUpdatedId))]
        public virtual User LastUpdated { get; set; }
        [ForeignKey(nameof(LossAdjusterId))]
        public virtual User LossAdjuster { get; set; }
        [ForeignKey(nameof(LossTypeId))]
        public virtual LossType LossType { get; set; }
    }
}
