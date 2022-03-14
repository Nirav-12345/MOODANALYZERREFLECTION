using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using System.Reflection;

namespace UC6InvokeAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
         
            [DataRow("I am in Happy mood")]
            //[DataRow(null)]


            public void GivenSadShouldReturnSad(string message)
            {
                string expected = "HAPPY";


                UC6 mood = new UC6(message);

                string moo = mood.AnalyzeMood();


                Assert.AreEqual(expected, moo);


            }
            [TestMethod]
            public void GIVEN_EMPTY_MOOD_SHOULD_THROW_MOOD_ANALYZER_EXCEPTION()
            {
                try
                {
                    string message = "";
                    UC6 mood = new UC6(message);

                    string moo = mood.AnalyzeMood();
                }
                catch (MoodAnalyzerCustomException e)
                {
                    Assert.AreEqual("Mood should not be empty", e.Message);
                }
            }
            [TestMethod]
            public void GIVEN_NULL_MOOD_SHOULD_THROW_MOOD_ANALYZER_EXCEPTION()
            {
                try
                {
                    string message = null;
                    UC6 mood = new UC6(message);

                    string moo = mood.AnalyzeMood();
                }
                catch (MoodAnalyzerCustomException e)
                {
                    Assert.AreEqual("Mood should not be null", e.Message);
                }


            }

            [TestMethod]

            public void GivenMoodanalyseclass_Name()
            {
                string message = null;

                object expaected = new UC6(message);


                object obj = MoodAnalyzer.InvokeAnalyseMood("MoodAnalyzer app with core.Moodanalyzer", "Mood Analyzer");

                expaected.Equals(obj);
            }
        }

    }
    
