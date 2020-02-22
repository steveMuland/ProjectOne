using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroceryWarehouse.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Minimum 3, Maximum 60 characters")]
        [RegularExpression(@"^[a-zA-Z\s?]+$", ErrorMessage = "Please enter valid name")]
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage = "Minimum 3, Maximum 60 characters")]
        [RegularExpression(@"^[a-zA-Z\s?]+$", ErrorMessage = "Please enter valid last name")]
        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, Display(Name = "Identity Type")]
        public string IdType { get; set; }

        [Display(Name = "Identity Number")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "Please enter a valid identity number")]
        public string IdNo { get; set; }

        [Display(Name = "Passport Number")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "Please enter a valid passport number")]
        public string PassportNumber { get; set; }

        [Required, Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, Display(Name = "Phone Number")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Alt Phone Number")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Please enter a valid phone number")]
        public string AltPhoneNumber { get; set; }

        [Required, Display(Name = "Address line 1")]
        public string Address1 { get; set; }

        [Required, Display(Name = "Address line 2")]
        public string Address2 { get; set; }

        [Required, Display(Name = "City/Town")]
        public string CityTown { get; set; }

        [Required, Display(Name = "Postal Code")]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Please enter a valid postal code")]
        public string PostalCode { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
