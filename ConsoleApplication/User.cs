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

            if (contact.Length < 5)
                throw new InputParameterIsOutOfRange();
          
            output = "Hello " + contact;

            if ((output.Contains("bye") || output.Contains("@")))
            {
                throw new OutputContainsInvalidWord();
            }

            return output;
        }
    }
}
