
using System.ComponentModel.DataAnnotations;

namespace Course.WebUI.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Adını girmelisin")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email girmelisin")]
        [EmailAddress(ErrorMessage ="Doğru formatta girilmelidie")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone girmelisin")]
        public string Phone { get; set; }
        public bool? Confirm { get; set; }
    }
}
