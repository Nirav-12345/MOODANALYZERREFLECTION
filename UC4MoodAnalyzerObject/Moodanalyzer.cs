using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;

namespace UC4MoodAnalyzerObject
{
    public class Moodanalyzer
    {
        public static object createMoodAnalyzer(string className, string construcorName)
        {
            string p = @"." + construcorName + "$";
            Match result = Regex.Match(className, p);


            if(result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnatype = executing.GetType(className);
                    return Activator.CreateInstance(moodAnatype);
                }

                catch (ArgumentNullException)
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_CLASS, "class not found");
                }
            }

            else
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor not found");
            }
        }











    }
}
