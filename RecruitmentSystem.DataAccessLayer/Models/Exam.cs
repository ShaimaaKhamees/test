using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystem.DataAccessLayer.Models
{
    public class Exam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Exam_ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [StringLength(50)]
        public string Type { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        [StringLength(50)]
        public string Result { get; set; } = string.Empty;
        [ForeignKey("Application_Form")]
        public int Application_ID { get; set; }
        public int Candidant_ID { get; set; }
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
        public virtual Application_Form? Application_Form { get; set; }

    }
}
