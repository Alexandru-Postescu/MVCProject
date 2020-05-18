using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
/*
 * Used only for display
 * We are going to create another model for backend layer; placed in DataLibrary
 * For example: here we have ConfirmEmailAdress or ConfirmPassword that we not going to use in our database
 */
namespace ProjectMVC.Models
{
    public class UsersModel
    {
        [Display(Name = "CUI")]
        [Range(100000, 999999, ErrorMessage = "You need to enter a valid CUI")]
        public int UserId { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "You need to choose an username")]
        public string Username { get; set; }

        [Display(Name = "Firm Name")]
        [Required(ErrorMessage = "You need to give us your firm name")]
        public string FirmName { get; set; }

        [Display(Name = "Location")]
        [Required(ErrorMessage = "No empty field allowed.")]
        public string Location { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "No empty field allowed.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "You need to give us your email adress.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Confirm Email Adress")]
        [Compare(nameof(Email), ErrorMessage = "The email and confirm email must match.")]
        public string ConfirmUserEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "You need to choose a password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "The password and confirm password must match.")]
        public string ConfirmUserPassword { get; set; }
        /* To be updated
        [Display(Name = "Location")]
        public AdressModel UserAdress { get; set; }

        [Display(Name = "Shipping Option")]
        [Required(ErrorMessage = "You need to choose a shipping option.")]
        public ShippingOptionModel ShippingOptin { get; set; }
        */
    }
}