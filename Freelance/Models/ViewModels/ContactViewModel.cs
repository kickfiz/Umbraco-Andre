using System.ComponentModel.DataAnnotations;

using Freelance.Validation;

namespace Freelance.Models.ViewModels;

public class ContactViewModel
{
    [Display(Name= "Full name")]
    [Required(ErrorMessage = "You must enter your name")]
    public string? Name { get; set; }

    [Display(Name = "Email address")]
    [EmailAddress(ErrorMessage = "You must enter a valid email address")]
    [Required(ErrorMessage = "You must enter your email address")]
    public string? Email { get; set; }

    [Display(Name = "Phone")]
    public string? Phone { get; set; }

    [Display(Name = "Message")]
    [Required(ErrorMessage = "You must enter a message")]
    public string? Message { get; set; }

    [Display(Name = "Yes, I give permission to store and process my data")]
    [Required(ErrorMessage = "You must give consent to store and process your data")]
    [MustBeTrue(ErrorMessage = "You must give consents to store and process your data")]
    public bool Consent { get; set; }
}
