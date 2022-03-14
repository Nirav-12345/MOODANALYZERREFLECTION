using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UC7_Happy7._1
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


            UC7 mood = new UC7(message);

            string moo = mood.AnalyzeMood();


            Assert.AreEqual(expected, moo);


        }
        [TestMethod]
        public void GIVEN_EMPTY_MOOD_SHOULD_THROW_MOOD_ANALYZER_EXCEPTION()
        {
            try
            {
                string message = "";
                UC7 mood = new UC7(message);

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
                UC7 mood = new UC7(message);

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

            object expaected = new UC7(message);


            object obj = MoodAnalyzer.InvokeAnalyseMood("MoodAnalyzer app with core.Moodanalyzer", "Mood Analyzer");

            expaected.Equals(obj);
        }


        [TestMethod]
        public void GIvenMoodshoudreturnHappy()
        {
            string expected = "Happy";
            string mood = MoodAnalyzer.InvokeAnalyseMood("Happy", "AnalyseMood");
            Assert.AreEqual(expected, mood);
        }


        //uc7
        [TestMethod]
       // public void GivenMoodanalyseclass_Nam_SetField()
        //{
            //string message = null;

            //object expaected = new UC7(message);


            //object obj = MoodAnalyzer.setfield("MoodAnalyzer app with core.Moodanalyzer", "Mood Analyzer");

            //expaected.Equals(obj);
        //}

        //uc7.1

        public void GivenHappyShouldReturnHappy()
        {
            string result = MoodAnalyzer.setfield("Happy", "message");
            Assert.AreEqual("happy", result);
        }






    }



}