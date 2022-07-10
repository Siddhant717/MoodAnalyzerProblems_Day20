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
        public void GivenEmptyShouldReturnEmptyException()
        {
            string expected = "Message should not be empty";
            MoodAnalyse moodAnalyser = new MoodAnalyse(null);
            try
            {
                //ACT
                string actual = moodAnalyser.AnalyseMood();
            }
            catch (CustomMoodAnalyzerException ex)
            {
                //ASSERT
                Assert.AreEqual(expected, ex.Message);
            }
        
        }
        
        
    }
}