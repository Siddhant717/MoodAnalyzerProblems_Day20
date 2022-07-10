﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyse
    {
        public string message;
        public MoodAnalyse()
        {

        }
            
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        //Creating method for Analysing the mood
        public string AnalyseMood()
        {
            try
            {
                if (message == null)
                {
                    throw new CustomMoodAnalyzerException(CustomMoodAnalyzerException.ExceptionType.Null_Message, "Mood should not be null");
                }
                if(this.message.Contains(string.Empty))
                {
                    throw new CustomMoodAnalyzerException(CustomMoodAnalyzerException.ExceptionType.Empty_Message, "Mood should not be empty");

                }

                if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (CustomMoodAnalyzerException e)
            {
                Console.WriteLine(e.Message);
               
            }
            return message;


        }
    }
}