using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace TestMood
{
    [TestClass]
    public class UnitTest1
    {
       
        public UnitTest1()
        {

        }
        //TC 1.1  
        [TestMethod]
        public void SadMood()
        {
            
            string expected = "SAD";
            string message = "I am in Sad Mood";
            UC2MoodAnalyzer moodAnalyse = new UC2MoodAnalyzer(message);

            
            string mood = moodAnalyse.AnalyseMood();

            
            Assert.AreEqual(expected, mood);
        }

        //TC 1.2
        [TestMethod]
        public void HappyMood()
        {
            
            string expected = "HAPPY";
            string message = "I am in HAPPY Mood";
            UC2MoodAnalyzer moodAnalyse = new UC2MoodAnalyzer(message);

            
            string mood = moodAnalyse.AnalyseMood();

            
            Assert.AreEqual(expected, mood);
        }
        // UC2 null message return happy
        [TestMethod]
        public void givenMood_WhenNull_ShouldReturnHappyMood()
        {
            
            string expected = "Happy";
            UC2MoodAnalyzer moodAnalyzer = new UC2MoodAnalyzer(null);
            
            string mood = moodAnalyzer.AnalyseMood();
            
            Assert.AreEqual(expected, mood);
        }
    }
}