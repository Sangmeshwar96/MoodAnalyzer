using MoodAnalyzer;

namespace MoodAnalyzerTest
{
    public class Tests
    {
        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSadMood()
        {
            //Arrange
            string message = "I,m in Sad Mood";
            //Act
            MoodAnalyser analyser = new MoodAnalyser();
            string actual = analyser.AnalyzeMood(message);
            //Assert
            Assert.AreEqual(actual, "Sad");
        }
    }
}