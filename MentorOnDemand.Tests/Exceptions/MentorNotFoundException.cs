using System;
using System.Collections.Generic;
using System.Text;

namespace MentorOnDemand.Tests.Exceptions
{
  public  class MentorNotFoundException :Exception
    {
        public string messages = ("Mentor Not Found ");

        public MentorNotFoundException()
        {
        }
        public MentorNotFoundException(string _message)
        {
            this.messages = _message;
        }
    }
}
