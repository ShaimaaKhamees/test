using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystem.DataAccessLayer.Models
{
    public class Interview
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Interview_id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [ForeignKey("Interviewer")]
        public int interviewer_id { get; set; }
        public DateTime Date { get; set; }
        [StringLength(50)]
        public string Result { get; set; } = string.Empty;
        [ForeignKey("Application_Form")]
        public int Application_id { get; set; }
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
        public string Interview_Type { get; set; } = string.Empty;
        //navigation properties
        public virtual Interviewer? Interviewer { get; set; }
        public virtual Application_Form? Application_Form { get; set; }
    }
}
