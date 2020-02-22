using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GroceryWarehouse.Models
{
    public class Customer
    {
        [Key]
        [Display(Name ="Customer Id")]
        public string CustomerID { get; set; }

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

        [Required, Display(Name ="Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, Display(Name = "Phone Number")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Alt Phone Number")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Please enter a valid phone number")]
        public string AltPhoneNumber { get; set; }

        [Required, Display(Name ="Address line 1")]
        public string Address1 { get; set; }

        [Required, Display(Name ="Address line 2")]
        public string Address2 { get; set; }

        [Required, Display(Name ="City/Town")]
        public string CityTown { get; set; }

        [Required, Display(Name ="Postal Code")]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Please enter a valid postal code")]
        public string PostalCode { get; set; }

        [Display(Name = "Date Registered")]
        public DateTime DateReg { get; set; }

        [Display(Name = "Date Updated")]
        public Nullable<DateTime> DateUpdated { get; set; }

        [Display(Name = "Active?")]
        public bool IsActive { get; set; }
    }
}