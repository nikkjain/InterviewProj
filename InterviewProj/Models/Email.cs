using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace InterviewProj.Models
{
    [Keyless]
    [Table("Email")]
    public partial class Email
    {
        public int Id { get; set; }
        public int LegacyActivityId { get; set; }
        [StringLength(500)]
        public string RecipientTo { get; set; }
        [StringLength(500)]
        public string Subject { get; set; }
        [Column(TypeName = "ntext")]
        public string BodyText { get; set; }
        [Required]
        [StringLength(100)]
        public string SentBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SentTime { get; set; }
        [StringLength(4)]
        public string PartyTypeCode { get; set; }
    }
}
