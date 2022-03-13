using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;


namespace UC5Mood
{
    public class MoodAnalyzerCustomException : Exception

    {
        public enum ExceptionType
        {
            NULL_MESSAGE, Empty_Message,
            NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE,


        }

        private readonly ExceptionType type;

        public MoodAnalyzerCustomException(ExceptionType Type, string message) : base(message)

        {
            this.type = Type;


        }




    }
}
