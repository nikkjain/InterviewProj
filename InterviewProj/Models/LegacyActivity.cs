using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace InterviewProj.Models
{
    [Keyless]
    public partial class LegacyActivity
    {
        [Required]
        [StringLength(50)]
        public string ClaimReference { get; set; }
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActivityDate { get; set; }
        [StringLength(1)]
        public string CategoryInd { get; set; }
        public int CompletedBy { get; set; }
        [StringLength(1)]
        public string AdhocOrPartyInd { get; set; }
        public int? PartyId { get; set; }
        public int? AdhocPartyId { get; set; }
        [Required]
        [StringLength(4)]
        public string TypeCode { get; set; }
        [StringLength(1000)]
        public string Detail { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastUpdatedDate { get; set; }
        public int LastUpdatedId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeletedDate { get; set; }
        public int? DeletedId { get; set; }
    }
}
