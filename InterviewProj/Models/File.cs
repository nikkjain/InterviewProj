using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace InterviewProj.Models
{
    [Keyless]
    public partial class File
    {
        public int Id { get; set; }
        public Guid PublicId { get; set; }
        [Required]
        [StringLength(100)]
        public string FileName { get; set; }
        [Required]
        [StringLength(100)]
        public string BlobName { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int LastUpdatedId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedId { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedId { get; set; }
    }
}
