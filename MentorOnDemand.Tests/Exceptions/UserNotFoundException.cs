using System;
using System.Collections.Generic;
using System.Text;

namespace MentorOnDemand.Tests.Exceptions
{
   public class UserNotFoundException: Exception
    {
        public string messages = ("User Not Found ");

        public UserNotFoundException()
        {
        }
        public UserNotFoundException(string _message)
        {
            this.messages = _message;
        }
    }
    
    
}
