using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace InterviewProj.Models
{
    [Keyless]
    [Table("PartyClaimRole")]
    public partial class PartyClaimRole
    {
        public int Id { get; set; }
        [Required]
        [StringLength(4)]
        public string PartyTypeCode { get; set; }
        [Required]
        [StringLength(50)]
        public string ClaimReference { get; set; }
        [Required]
        [StringLength(1)]
        public string AdhocOrPartyInd { get; set; }
        public int? PartyId { get; set; }
        public int? AdhocPartyId { get; set; }
        [StringLength(20)]
        public string PartyReference { get; set; }
        [StringLength(40)]
        public string ContactName { get; set; }
        [StringLength(35)]
        public string Telephone { get; set; }
        [StringLength(255)]
        public string EmailAddress { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int LastUpdatedId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedId { get; set; }
    }
}
