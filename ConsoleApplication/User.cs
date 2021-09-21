using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class User : Entity
    {
        public User(int id , string username) : base(id)
        { 
            Username = username;
        }

        public string Username { get; }

        public override string SayHello(string contact)
        { 
            string output;
            /* 
             # PreConditions :
                    * $contact must not be smaller than 5 character
             */ 
            if (contact.Length < 5)
                throw new InputParameterIsOutOfRange();
          
            output = "Hello " + contact;

            /*
             # Post-Conditions :
                * output must not contain the word "bye" or "good"
             */
            if ((output.Contains("bye") || output.Contains("@")))
            {
                throw new OutputContainsInvalidWord();
            }



            return output;
        }
    }
}
