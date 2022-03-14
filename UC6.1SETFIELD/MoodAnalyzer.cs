using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;

namespace UC7SETFIELD
{
    public class MoodAnalyzer
    {
        public static object CreateMoodParameterConstructor(string className, string construcorName, string message)
        {
            Type type = typeof(MoodAnalyzer);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(construcorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { "HAPPY" });
                    return instance;
                }

                else
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
                }

            }

            else
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_CLASS, "class not found");
            }



        }



















        public static string InvokeAnalyseMood(string message, string MethodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyzerApp.MoodAnalyse");
                object mmodanalyseobject = MoodAnalyzer.CreateMoodParameterConstructor("MoodAnalyzerApp.MoodAnalyse", "MoodAnlalyse", message);

                MethodInfo analyseMoodinfo = type.GetMethod(MethodName);
                object mood = analyseMoodinfo.Invoke(mmodanalyseobject, null);
                return mood.ToString();

            }

            catch (NullReferenceException)
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_METHOD, "Method not found");
            }
        }


        //uc7field

        public static string setfield(string message, string fieldname)
        {
            try
            {
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
                Type type = typeof(MoodAnalyzer);
                FieldInfo field = type.GetField(fieldname, BindingFlags.Public | BindingFlags.Instance);
                if (message == null)
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_FIELD, "Message should not be null");
                }

                field.SetValue(moodAnalyzer, message);
                return moodAnalyzer.ToString();
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_FIELD, "no such filed is present");
            }
                
        }






    }
}
