using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class UC2MoodAnalyzer
    {
        private string message;
        public UC2MoodAnalyzer()
        {

        }
        public UC2MoodAnalyzer(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch
            {
                return "Happy";
            }
        }
    }

}