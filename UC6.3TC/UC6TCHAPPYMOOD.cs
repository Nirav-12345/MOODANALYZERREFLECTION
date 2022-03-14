using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC6TCRETURNHAPPYMOOD
{
    public class UC6TCHAPPYMOOD
    {
        
        public UC6TCHAPPYMOOD() { }
        public string message;

        public UC6TCHAPPYMOOD(string message)
        {
            this.message = message;
        }


        public string AnalyzeMood()
        {

            try
            {


                if (this.message.Equals(string.Empty))
                {

                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.Empty_Message, "Moodshoud not be empty");
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
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }




    }
}


   
