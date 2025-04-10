using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RecruitmentSystem.DataAccessLayer.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Department_ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        public int Manager_ID { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; }
        [StringLength(50)]
        public string LastUpdatedBy { get; set; } = string.Empty;
        public DateTime LastUpdatedOn { get; set; }
        [StringLength(50)]
        public string DeletedBy { get; set; } = string.Empty;
        public DateTime DeletedOn { get; set; }
        public bool Active { get; set; }
        // Navigation property
        public virtual ICollection<Job_Position> Job_Positions { get; set; } = new List<Job_Position>();
    }
}
