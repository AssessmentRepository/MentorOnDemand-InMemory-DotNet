using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MentorOnDemand.Entities
{
   public class MentorDetails
    {
        public  int Id { get; set; }
        public  string Email { get; set; }
        [Required(ErrorMessage = "Required")]
        public  string UserName { get; set; }
        public  string Technology { get; set; }
        public  string Role { get; set; }
        public  float Exprience { get; set; }
        public  string Facilities { get; set; }
        public  float Fees { get; set; }
        public  float WorkHours { get; set; }
        public  int Rating { get; set; }
        public  string Password { get; set; }
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile")]
        public  int ContactNumber { get; set; }
    }
}
