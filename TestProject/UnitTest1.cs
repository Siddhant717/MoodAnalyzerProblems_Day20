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
            MoodAnalyse moodAnalyse = new MoodAnalyse("I am in Happy Mood");

            //Act
            string checkmood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual("HAPPY", checkmood);
        }
    }
}