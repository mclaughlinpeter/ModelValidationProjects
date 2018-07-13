using System;
using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Models
{
    public class Appointment
    {
        [Required]
        [Display(Name = "name")]
        public string ClientName { get; set; }

        [UIHint("Date")]
        [Required(ErrorMessage = "Please enter a date")]
        public DateTime Date { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "You must accept the terms")]
        public bool TermsAccepted { get; set; }
    }
}