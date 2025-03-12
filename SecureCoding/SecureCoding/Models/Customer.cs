using System.ComponentModel.DataAnnotations;

namespace SecureCoding.Models
{
    public class Customer
    {
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "First Name Must Be Start With a Capital Letter!")]
        [Display(Name = "First Name")]
        [StringLength(25, MinimumLength = 3)]
        public string FirstName { get; set; } = string.Empty;
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Last Name Must Be Start With a Capital Letter!")]
        [Display(Name = "Last Name")]
        [Length(3, 25)]
        public string LastName { get; set; } = string.Empty;
        [AllowedValues("Male", "Female", ErrorMessage = "Only Male or Female Allowed!")]
        public string Gender {  get; set; } = string.Empty;
    }
}
