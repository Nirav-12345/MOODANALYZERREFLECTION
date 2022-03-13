using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UC5MoodTC
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


            UC5 mood = new UC5(message);

            string moo = mood.AnalyzeMood();


            Assert.AreEqual(expected, moo);


        }
        [TestMethod]
        public void GIVEN_EMPTY_MOOD_SHOULD_THROW_MOOD_ANALYZER_EXCEPTION()
        {
            try
            {
                string message = "";
                UC5 mood = new UC5(message);

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
                UC5 mood = new UC5(message);

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

            object expaected = new UC5(message);


            object obj = MoodAnalyzer.createMoodAnalyzer("MoodAnalyzer app with core.Moodanalyzer", "Mood Analyzer");

            expaected.Equals(obj);
        }


        [TestMethod]
        public void GivenMoodanalyseclass_Name_should_return()
        {
            object expaected = new UC5("HAPPY");
            object obj = MoodAnalyzer.CreateMoodParameterConstructor("MoodAnalyzer app with core.Moodanalyzer", "Mood Analyzer");
            expaected.Equals(obj);

        }







    }
}


  