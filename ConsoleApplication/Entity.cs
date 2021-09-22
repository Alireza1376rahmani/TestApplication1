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

        public int Id { get; }

        public virtual string SayHello(string contact)
        {
            string output;

            if (contact.Length < 10)
                throw new InputParameterIsOutOfRange();
            output = "Hello " + contact;

            if(output.Contains("bye"))
                throw new OutputContainsInvalidWord();

            return output;
        }
    }
}
