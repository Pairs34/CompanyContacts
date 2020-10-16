using System.ComponentModel.DataAnnotations;

namespace Rehber.Models
{
    public class Course
    {
        public string courseName { get; set; }
        public string courseDescription { get; set; }
        public bool? ispublished { get; set; }
    }
}