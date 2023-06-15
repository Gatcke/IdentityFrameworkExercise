using System.ComponentModel.DataAnnotations;

namespace Learn_Identity_App.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
