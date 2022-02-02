using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            //Act
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, mood);
        }
        [TestMethod]
        public void GivenHAPPYMoodShouldReturnHappy()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in HAPPY Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indication_EmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood Should Not Be Empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_Null_Mood_Should_Throw_MoodanalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood Should Not Be Null", e.Message);
            }
        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserApp.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
            Assert.AreNotEqual(expected, obj);

        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyser("HAPPY"); //2000
            object expected1 = expected;
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserApp.MoodAnalyser", "MoodAnalyser", "HAPPY");
            expected.Equals(obj);
            Assert.AreEqual(expected, expected1);
        }
    }
}