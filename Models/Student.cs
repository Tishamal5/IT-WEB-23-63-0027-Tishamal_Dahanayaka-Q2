using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, ErrorMessage = "First Name cannot be longer than 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, ErrorMessage = "Last Name cannot be longer than 50 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "NIC is required")]
        [RegularExpression(@"^\d{9}[VvXx]|\d{12}$", ErrorMessage = "Invalid NIC number")]
        public string NIC { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telephone is required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Course is required")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}