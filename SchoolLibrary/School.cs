using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        private string _twitterAddress;
        public string TwitterAddress
        {
            //make sure the twitter addres starts with @
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("Twitter address must begin with @");
                }
            }
                   
        
        }
        //Make constructor
        public School() 
        {
            Name = "Untitled School";
            PhoneNumber = "555-1234";
        }

        //Overloaded Constructor
        public School (string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }




        //METHODS
        public float AverageThreeScores1(float a, float b, float c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        //Function Bodied Expression
        public float AverageThreeScores2(float a, float b, float c) => (a + b + c) / 3;

        //Overloaded METHOD
        public int AverageThreeScores3 (int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }




        //MAKE STATIC METHOD
        public static float AverageThreeScores4(float a, float b, float c) => (a + b + c) / 3;

        //Overloaded STATIC-METHOD
        public static int AverageThreeScores5(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }




        //overriding ToString
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.Append(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append(" ");
            sb.Append(Zip);

            return sb.ToString();
        }


    }
}
