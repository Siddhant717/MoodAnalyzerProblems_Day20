using System;

namespace MoodAnalyzerProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory();

            MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyse", "MoodAnalyze");

        }
    }
}
