using System.ComponentModel.DataAnnotations;

namespace Rehber.Models
{
    public class Student
    {
        [Required(ErrorMessage = "İsim Alanı Zorunludur")]
        public string name { get; set; }
        [Required(ErrorMessage = "Mail Alanı Zorunludur")]
        [EmailAddress(ErrorMessage = "Mail formatı doğru değil")]
        public string mail { get; set; }
        [Required(ErrorMessage = "Telefon Alanı Zorunludur")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Katılma Alanı Zorunludur")]
        public bool? confirm { get; set; }
    }
}