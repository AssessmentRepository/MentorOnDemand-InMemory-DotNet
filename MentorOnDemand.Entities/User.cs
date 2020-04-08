using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MentorOnDemand.Entities
{
  public class User
    {
        
        public  int Id { get; set; }
        //Username should be Email
        public  string UserName { get; set; }
        public  string Password { get; set; }
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public  long ContactNumber { get; set; }
        public  string Role { get; set; }
        public  string LinkedinURL { get; set; }
        public  int Experience { get; set; }
        public  bool Active { get; set; }
        public  bool ConfirmedSignUp { get; set; }
        public  bool ResetPassword { get; set; }
        public  DateTime ResetPasswordDate { get; set; }
    }

}
