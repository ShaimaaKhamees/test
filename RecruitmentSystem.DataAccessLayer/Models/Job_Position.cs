using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystem.DataAccessLayer.Models
{
    public class Job_Position
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Position_ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [ForeignKey("Department")]
        public int Department_ID { get; set; }
        [StringLength(50)]
        public string Job_Description { get; set; } = string.Empty;
        [ForeignKey("Recruiter")]
        public int Recruiter_ID { get; set; }
        [StringLength(50)]
        public string Job_Type { get; set; } = string.Empty;
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
        //navigation properties
        public virtual ICollection<Employee>? Employees { get; set; } = new HashSet<Employee>();
        public virtual ICollection<Application_Form>? Application_Forms { get; set; } = new HashSet<Application_Form>();

    }
}
