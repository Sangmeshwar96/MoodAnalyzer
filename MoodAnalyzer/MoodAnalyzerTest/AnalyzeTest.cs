namespace MoodAnalyzerTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSadMood()
        {
            //Arrange
            string message = "I,m in Sad Mood";
            //Act
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual = analyser.AnalyzeMood();
            //Assert
            Assert.AreEqual(actual, "Sad");
        }
        [Test]
        public void GivenHappyMessage_WhenAnalyze_ShouldReturnHappyMood()
        {
            //Arrange
            string message = "I,m in Happy Mood";
            //Act
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual = analyser.AnalyzeMood();
            //Assert
            Assert.AreEqual(actual, "Happy");
        }
    }
}