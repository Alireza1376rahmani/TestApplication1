using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public abstract class Entity
    {
        public Entity(int id)
        {
            Id = id;
        }

        //  #Data Invariant : *Username must be held
        public int Id { get; }

        public virtual string SayHello(string contact)
        {

            string output;

            /*
             # PreConditions :
                    * $contact must not be smaller than 10 character
             */
            if (contact.Length < 10)
                throw new InputParameterIsOutOfRange();
            output = "Hello " + contact;


            /*
             #Post-Conditions :
                * output must not contain the word "bye"
             */
            if(output.Contains("bye"))
                throw new OutputContainsInvalidWord();


            return output;
        }
    }
}
