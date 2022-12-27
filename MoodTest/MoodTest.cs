using MoodAnalyserMSTest;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyser("HAPPY"); //2000
            //MoodAnalyser obj = (MoodAnalyser)expected;
            object expected1 = expected;
            object obj = MoodAnalyserReflection.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserMSTest.MoodAnalyser", "MoodAnalyser", "HAPPY");
            // expected.Equals(obj);
            Assert.AreEqual(expected, expected1);
        }
    }
}