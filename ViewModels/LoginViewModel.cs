using System.ComponentModel.DataAnnotations;

namespace Learn_Identity_App.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="Username")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        ErrorMessage = "Please enter a correct email address")]
        public string UserName{ get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Remember Me?")]
        public bool RememberMe { get; set; }
            
        public string? ReturnUrl { get; set; }
    }
}
