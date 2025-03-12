using Ganss.Xss;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace SecureCoding.Models
{
    public class Customer
    {
        private string address;
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "First Name Must Be Start With a Capital Letter!")]
        [Display(Name = "First Name")]
        [StringLength(25, MinimumLength = 3)]
        public string FirstName { get; set; } = string.Empty;
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Last Name Must Be Start With a Capital Letter!")]
        [Display(Name = "Last Name")]
        [StringLength(25, MinimumLength = 3)]
        public string LastName { get; set; } = string.Empty;
        [AllowedValues("Male", "Female", ErrorMessage = "Only Male or Female Allowed!")]
        public string Gender {  get; set; } = string.Empty;

        [StringLength(250)]
        public string Address
        {
            get => address;
            // set => address = Regex.Replace(value, @"[\!\@\#\$\%\^\&\<\>\?\|\;\[\]\{\}\~]", string.Empty); // This will remove any tag < >
            set => address = new HtmlSanitizer().Sanitize(value);
        }
    }
}
