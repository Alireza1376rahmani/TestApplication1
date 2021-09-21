using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    [Serializable]
    public class InputParameterIsOutOfRange : Exception
    {
        public InputParameterIsOutOfRange()
        {
        }

        public InputParameterIsOutOfRange(string message) : base(message)
        {
        }

        public InputParameterIsOutOfRange(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InputParameterIsOutOfRange(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    public class OutputContainsInvalidWord : Exception
    {
        public OutputContainsInvalidWord()
        {
        }

        public OutputContainsInvalidWord(string message) : base(message)
        {
        }

        public OutputContainsInvalidWord(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OutputContainsInvalidWord(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }













}
