using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public abstract float ComputeGradeAverage();

        public virtual string SendMessage (string message)
        {
            var sb = new StringBuilder();
            var timestamp = string.Format("Sent on {0:D} at {0:t}", DateTime.Now);
            sb.AppendLine(timestamp);
            sb.AppendLine("Dear" + FirstName + ",");
            sb.AppendLine(message);
            return sb.ToString();
        }
    }
}
