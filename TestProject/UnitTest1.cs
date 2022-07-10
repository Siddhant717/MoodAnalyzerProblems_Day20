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
        public void GivenClassName_ThrowException()
        {


            string expected = "Class Not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyse", "MoodAnalyse");
            }
            catch (CustomMoodAnalyzerException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        
        }
    }
}