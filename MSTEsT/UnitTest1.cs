using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC4MoodAnalyzerObject;

namespace UC4MoodAnalyzerObject
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


            UC2TC2 mood = new UC2TC2(message);

            string moo = mood.AnalyzeMood();


            Assert.AreEqual(expected, moo);


        }
        [TestMethod]
        public void GIVEN_EMPTY_MOOD_SHOULD_THROW_MOOD_ANALYZER_EXCEPTION()
        {
            try
            {
                string message = "";
                UC2TC2 mood = new UC2TC2(message);

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
                UC2TC2 mood = new UC2TC2(message);

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

            object expaected = new UC2TC2(message);


            object obj = Moodanalyzer.createMoodAnalyzer("Moodanalyzer app with core.Moodanalyzer", "Mood Analyzer");

            expaected.Equals(obj);
        }
    }
}