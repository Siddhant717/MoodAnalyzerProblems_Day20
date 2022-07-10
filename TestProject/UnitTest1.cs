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
        public void TestMoodAnalyse()
        {


            string message = null;

            object expected = new MoodAnalyse(message);


            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyse", "MoodAnalyse");
            expected.Equals(obj);



        }
    }
}