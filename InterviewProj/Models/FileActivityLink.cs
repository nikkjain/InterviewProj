using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace InterviewProj.Models
{
    [Keyless]
    public partial class FileActivityLink
    {
        public int Id { get; set; }
        public int FileId { get; set; }
        public int? ActivityId { get; set; }
        [StringLength(50)]
        public string LegacyActivityId { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int LastUpdatedId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedId { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedId { get; set; }
    }
}
