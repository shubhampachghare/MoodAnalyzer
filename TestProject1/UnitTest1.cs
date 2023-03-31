using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace TestMood
{
    [TestClass]
    public class UnitTest1
    {
        //TC 1.1  
        [TestMethod]
        public void SadMood()
        {
            
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);

            
            string mood = moodAnalyse.AnalyseMood();

            
            Assert.AreEqual(expected, mood);
        }

        //TC 1.2
        [TestMethod]
        public void HappyMood()
        {
            
            string expected = "HAPPY";
            string message = "I am in HAPPY Mood";
            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);

            
            string mood = moodAnalyse.AnalyseMood();

            
            Assert.AreEqual(expected, mood);
        }
    }
}