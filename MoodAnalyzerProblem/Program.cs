﻿using System;

namespace MoodAnalyzerProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyse moodanalyse = new MoodAnalyse(" ");
            string checkmood= moodanalyse.AnalyseMood();
            Console.WriteLine(checkmood);
           
        }
    }
}
