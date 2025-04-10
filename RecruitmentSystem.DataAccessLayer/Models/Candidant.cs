using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystem.DataAccessLayer.Models
{
    public class Candidant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Candidant_ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [StringLength(50)]
        public string Mobile { get; set; } = string.Empty;
        [StringLength(50)]
        public string Phone { get; set; } = string.Empty;
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; } = string.Empty;
        [StringLength(50)]
        public string Street { get; set; } = string.Empty;
        public int City_ID { get; set; }
        [StringLength(50)]
        public string Country_id { get; set; } = string.Empty;
        [StringLength(50)]
        public string Source { get; set; } = string.Empty;
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
        public virtual ICollection<Application_Form>? Application_Forms { get; set; } = new HashSet<Application_Form>();

    }
}
