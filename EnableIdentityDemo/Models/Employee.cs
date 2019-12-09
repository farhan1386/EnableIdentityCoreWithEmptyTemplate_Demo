using System.ComponentModel.DataAnnotations;

namespace EnableIdentityDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter first name")]
        [Display(Name = "First name")]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter last name")]
        [Display(Name = "Last name")]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter position")]
        [StringLength(100)]
        public string Position { get; set; }

        [Required(ErrorMessage = "Please enter office")]
        [StringLength(100)]
        public string Office { get; set; }

        [Required(ErrorMessage = "Please enter salary")]
        public int Salary { get; set; }

        [Required(ErrorMessage = "Please choose department name")]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
