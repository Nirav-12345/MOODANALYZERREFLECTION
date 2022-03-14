using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UC6TCRETURNHAPPYMOOD
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


           UC6TCHAPPYMOOD mood = new UC6TCHAPPYMOOD(message);

            string moo = mood.AnalyzeMood();


            Assert.AreEqual(expected, moo);


        }
        [TestMethod]
        public void GIVEN_EMPTY_MOOD_SHOULD_THROW_MOOD_ANALYZER_EXCEPTION()
        {
            try
            {
                string message = "";
                UC6TCHAPPYMOOD mood = new UC6TCHAPPYMOOD(message);

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
                UC6TCHAPPYMOOD mood = new UC6TCHAPPYMOOD(message);

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

            object expaected = new UC6TCHAPPYMOOD(message);


            object obj = MOODANALYZERFACTORY.InvokeAnalyseMood("MoodAnalyzer app with core.Moodanalyzer", "Mood Analyzer");

            expaected.Equals(obj);
        }


        [TestMethod]
        public void GIvenMoodshoudreturnHappy()
        {
            string expected = "Happy";
            string mood = MOODANALYZERFACTORY.InvokeAnalyseMood("Happy", "AnalyseMood");
            Assert.AreEqual(expected, mood);
        }
    }


}