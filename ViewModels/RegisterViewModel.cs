using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Learn_Identity_App.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100,ErrorMessage ="The {0} must be at least {2} characters long.",MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm password")]
        [Compare("Password",ErrorMessage = "The password and the confirmation password do not match.")]

        public string ConfirmPassword { get; set;}

        public string ReturnUrl { get; set; }
    }
}
