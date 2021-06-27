using JqueryFormValidator.Models;
using System;
using System.ComponentModel.DataAnnotations;
using Foolproof;

namespace JqueryFormValidator.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z ]*", ErrorMessage = "Use letters and spaces only please")]
        public string FirstName
        {
            get;
            set;
        }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z ]*", ErrorMessage = "Use letters and spaces only please")]
        public string LastName
        {
            get;
            set;
        }

        [Display(Name = "Middle Name")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z ]*", ErrorMessage = "Use letters and spaces only please")]
        public string MiddleName
        {
            get;
            set;
        }

        
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telephone Number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        [RequiredIfEmpty("EmailAddress", ErrorMessage = "Either telephone number or Email is required.")]
        public string TelephoneNumber
        {
            get;
            set;
        }

        
        [EmailAddress]
        [RequiredIfEmpty("TelephoneNumber", ErrorMessage = "Either telephone number or Email is required.")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        public bool CheckEmailandTele
        {
            get
            {
                return string.IsNullOrEmpty(TelephoneNumber);

            }
        }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9 ]*", ErrorMessage = "Use alphanumerica and spaces only please")]
        [Display(Name = "Identification Number")]
        public string IdentificationNumber
        {
            get;
            set;
        }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth
        {
            get;
            set;
        }

        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress
        {
            get;
            set;
        }

        [Display(Name = "Secondary Address")]
        public string SecondaryAddress
        {
            get;
            set;
        }

        [Required]
        [RegularExpression(@"^[a-zA-Z ]*", ErrorMessage = "Use letters and spaces only please")]
        [Display(Name = "City")]
        public string City
        {
            get;
            set;
        }

        [Required]
        [Display(Name = "State")]
        [RegularExpression(@"^[a-zA-Z ]*", ErrorMessage = "Use letters and spaces only please")]
        public string State
        {
            get;
            set;
        }

        [Required]
        [Display(Name = "Zip Code")]
        [RegularExpression(@"^([0-9]{5}|[0-9]{9})$", ErrorMessage = "Invalid Zip Code")]
        public string Zip
        {
            get;
            set;
        }

        

        //[Required]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        //[DataType(DataType.Password)]
        //[Display(Name = "Password")]
        //public string Password { get; set; }

        //[DataType(DataType.Password)]
        //[Display(Name = "Confirm password")]
        //[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        //public string ConfirmPassword { get; set; }
    }

    
}

