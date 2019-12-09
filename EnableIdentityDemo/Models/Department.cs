using System.ComponentModel.DataAnnotations;

namespace EnableIdentityDemo.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter department name")]
        [Display(Name = "Department")]
        [StringLength(100)]
        public string DepartmentName { get; set; }
    }
}
