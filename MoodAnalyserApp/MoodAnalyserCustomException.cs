using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserApp
{
    public class MoodAnalyserCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
            NO_SUCH_FILES, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }
        private readonly ExceptionType type;
        public MoodAnalyserCustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
