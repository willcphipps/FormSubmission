using System.ComponentModel.DataAnnotations;
using System;
namespace FormSubmission.Models {
    public class User {
        [Required (ErrorMessage = "Name Must be more than 4 characters")]
        [MinLength (4)]
        public string FirstName { get; set; }

        [Required (ErrorMessage = "Last name must be more then 4 characters")]
        [MinLength (4)]
        public string LastName { get; set; }
        
        [FutureDate]
        public DateTime Birthday { get; set; }



        [Required(ErrorMessage="Only Humans!")]
        [Range(0,120)]
        public int Age { get; set; }

        [Required (ErrorMessage = "You must submit an email!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required (ErrorMessage = "Password must be 8 characters!")]
        [MinLength (8)]
        [DataType (DataType.Password)]
        public string Password { get; set; }
    }
}