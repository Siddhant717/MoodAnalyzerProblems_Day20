using NUnit.Framework;
using MoodAnalyzerProblem;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckMood_returnHappy()
        {

            //Arrange
            MoodAnalyse moodAnalyse = new MoodAnalyse("I am in Any Mood");

            //Act
            string checksadmood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual("HAPPY", checksadmood);
        }
    }
}