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
        public void HandleException()
        {


            try
            {
                //Arrange
                MoodAnalyse moodAnalyse = new MoodAnalyse(null);

                //Act
                string checkmood = moodAnalyse.AnalyseMood();

                

            }
            catch (MoodNullException e)
            {
                //Assert
                Assert.AreEqual("Exception:" ,e.Message);
            }
        }
    }
}