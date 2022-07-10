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
        public void CheckObjWithDefaultConstructor()
        {


            object expected = new MoodAnalyse("Happy");

            MoodAnalyserFactory moodanalyser = new MoodAnalyserFactory();
            var ans = moodanalyser.CreateMoodAnalyserUsingParametrisedConstructor("MoodAnalyse", "MoodAnalyse", "Happy");


            expected.Equals(ans);
            
        }
    }
}