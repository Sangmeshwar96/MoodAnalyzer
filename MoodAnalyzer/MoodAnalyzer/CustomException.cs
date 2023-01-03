using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            Null,
            EMPTY,
            EMPTY_MESSAGE,
            NULL_MESSAGE,
            NO_SUCH_CLASS,
            NO_SUCH_CONSTRUCTOR,
            NO_SUCH_METHOD,
            NO_SUCH_FIELD,
            NO_NULL_TYPE
        }
        public ExceptionType type;
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }

}
