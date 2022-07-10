using System;

namespace MoodAnalyzerProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyserFactory moodanalysefactory = new MoodAnalyserFactory();

            moodanalysefactory.CreateMoodAnalyserUsingParametrisedConstructor("MoodAnalyse", "MoodAnalyse", "Happy");

        }
    }
}
