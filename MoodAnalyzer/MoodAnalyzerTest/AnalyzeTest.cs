using MoodAnalyzer;
using MoodAnalyzerProblem;

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
        [Test]
        public void GivenNullMood_WhenAnalyse_ShouldThrowMoodAnalysisException()
        {
            try
            {
                MoodAnalyser mood = new MoodAnalyser(null);
                string actual = mood.AnalyzeMood();
                Assert.AreEqual("Happy", actual);
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Mood should not be Null");
            }
        }
        [Test]
        public void GivenEMPTYMood_WhenAnalyse_ShouldThrowMoodAnalysisException()
        {
            try
            {
                MoodAnalyser mood = new MoodAnalyser("");
                string actual = mood.AnalyzeMood();
                Assert.AreEqual("Happy", actual);
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
            }
        }
        [Test]
        public void GivenMoodAnalyzerClassName_ShouldReturnMoodAnalyseObject()
        {
            object expected = new MoodAnalyser();
            object actual = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(actual);
        }
        [Test]
        public void GivenMoodAnalyzerClassName_WhenImproper_ShouldThrowMoodAnalysisException()
        {
            try
            {
                object actual = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzerProblem.Mood", "Mood");
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "Class not found");
            }
        }
        [Test]
        public void GivenMoodAnalyzerConstructorName_WhenImproper_ShouldThrowMoodAnalysisException()
        {
            try
            {
                object actual = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyzer", "Mood");
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Constructor not found");
            }
        }
        [Test]
        public void GivenConstructorForParameterizedConstructorName_WhenImproper_ShouldReturnMoodAnalysisException()
        {
            try
            {
                object actual = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser", "Parameter Constructor");
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Constructor not found");
            }
        }
        [Test]
        public void GivenHappyMessageUsingReflection_WhenProper_ShouldReturnHappy()
        {
            string expected = "happy";
            string actual = MoodAnalyzerFactory.InvokeAnalyseMood("I am happy", "MoodAnalyzer");
            expected.Equals(actual);
        }
        [Test]
        public void GivenMethodname_WhenImproper_ShouldReturnMoodAnalysisException()
        {
            string expected = "Method not found";
            string actual = MoodAnalyzerFactory.InvokeAnalyseMood("I am happy", "Mood");
            Assert.AreEqual(expected, actual);
        }
    }
}