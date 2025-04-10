using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystem.DataAccessLayer.Models
{
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Country_id { get; set; }
        [Required]
        [StringLength(50)]

        public string Name { get; set; } = string.Empty;
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
        public virtual ICollection<City>? Cities { get; set; } = new HashSet<City>();
    }
}
