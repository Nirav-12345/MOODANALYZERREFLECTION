using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;

namespace UC6TCRETURNHAPPYMOOD
{
    public class MOODANALYZERFACTORY
    {
        public static object CreateMoodParameterConstructor(string className, string construcorName, string message)
        {
            Type type = typeof(MOODANALYZERFACTORY);
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
                object mmodanalyseobject = MOODANALYZERFACTORY.CreateMoodParameterConstructor("MoodAnalyzerApp.MoodAnalyse", "MoodAnlalyse", message);

                MethodInfo analyseMoodinfo = type.GetMethod(MethodName);
                object mood = analyseMoodinfo.Invoke(mmodanalyseobject, null);
                return mood.ToString();

            }

            catch (NullReferenceException)
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_METHOD, "Method not found");
            }
        }




    }
}
