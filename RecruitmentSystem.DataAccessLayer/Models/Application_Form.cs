using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystem.DataAccessLayer.Models
{
    public class Application_Form
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Application_ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        [ForeignKey("Job_Position")]
        public int JobPosition_ID { get; set; }
        [StringLength(50)]
        public string Status { get; set; } = string.Empty;
        [ForeignKey("Rejection_Reason")]
        public int RejectionReason_id { get; set; }
        [ForeignKey("Candidant")]
        public int Candidant_ID { get; set; }
        public int Recruiter_Id { get; set; }
        public int Interviewer_Id { get; set; }
        [Range(0,99999)]
        public int ExpectedSalary { get; set; }
        [Range(0, 99999)]
        public int CurrentSalary { get; set; }
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
        public virtual Candidant? Candidant { get; set; }
        public virtual Rejection_Reason? Rejection_Reason { get; set; }
        public virtual Job_Position? Job_Position { get; set; }
        //===========
        public virtual ICollection<Interview>? Interviews { get; set; } = new HashSet<Interview>();
        public virtual ICollection<Exam>? Exams { get; set; } = new HashSet<Exam>();

    }
}
