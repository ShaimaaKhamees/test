using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RecruitmentSystem.DataAccessLayer.Models;


namespace RecruitmentSystem.DataAccessLayer.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Employee_ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [StringLength(50)]
        public string PrivatePhone { get; set; } = string.Empty;
        [StringLength(50)]
        public string PrivateMobile { get; set; } = string.Empty;
        [StringLength(50)]
        public string Street { get; set; } = string.Empty;
        [ForeignKey("City")]
        public int City_ID { get; set; }
        public DateTime BirthDate { get; set; }
        [StringLength(50)]
        public string PlaceOfBirth { get; set; } = string.Empty;
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; } = string.Empty;
        [StringLength(50)]
        public string NationalID { get; set; } = string.Empty;
        public DateTime HiringDate { get; set; }
        public int Position_ID { get; set; }
        public int Manager_ID { get; set; }
        public int department_id { get; set; }
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
        public virtual City? City { get; set; }
        public virtual ICollection<Employee>? Employees { get; set; } = new HashSet<Employee>();
        public virtual ICollection<User>? Users { get; set; } = new HashSet<User>();
    }
}
