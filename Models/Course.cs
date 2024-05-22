using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LMS.Models
{
    public class Course
    {
        [Required(ErrorMessage = "Course ID is required")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Course Name is required")]
        [StringLength(100, ErrorMessage = "Course Name cannot be longer than 100 characters")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Module Count is required")]
        [Range(1, 100, ErrorMessage = "Module Count must be between 1 and 100")]
        public int ModuleCount { get; set; }

        [Required(ErrorMessage = "Start Date is required")]
        [DataType(DataType.Date)]
        public DateTime FromDate { get; set; }

        [Required(ErrorMessage = "End Date is required")]
        [DataType(DataType.Date)]
        public DateTime ToDate { get; set; }

        [Required(ErrorMessage = "Lecture Mode is required")]
        [StringLength(50, ErrorMessage = "Lecture Mode cannot be longer than 50 characters")]
        public string LectureMode { get; set; }

        [Required(ErrorMessage = "Lecturer is required")]
        [StringLength(100, ErrorMessage = "Lecturer cannot be longer than 100 characters")]
        public string Lecturer { get; set; }

        public ICollection<Student> Students { get; set; }
    }

 
}
