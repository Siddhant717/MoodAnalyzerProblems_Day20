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
        public void GivenNullShouldReturnNullException()
        {
            string expected = "Mood should not be null";
            MoodAnalyse moodAnalyser = new MoodAnalyse(null);
            try
            {
                //ACT
                string actual = moodAnalyser.AnalyseMood();
            }
            catch (CustomMoodAnalyzerException e)
            {
                //ASSERT
                Assert.AreEqual(expected, e.Message);
            }

        }
        
        
    }
}