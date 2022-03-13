using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC5Mood
{
    public class UC5
    {
        public UC5() { }
        public string message;

        public UC5(string message)
        {
            this.message = message;
        }


        public string AnalyzeMood()
        {

            try
            {


                if (this.message.Equals(string.Empty))
                {

                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.Empty_Message, "Moodshoud not be empty");
                }


                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }

                else
                {
                    return "HAPPY";
                }
            }

            catch (NullReferenceException)
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }





    }
}
