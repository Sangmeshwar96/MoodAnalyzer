using System;

namespace MoodAnalyserMSTest
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("---Welcome to MoodAnalyser MSTesting---\n");

            object expected = new MoodAnalyser(null);
            object obj = MoodAnalyserReflection.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserMSTest.MoodAnalyser", "MoodAnalyser", "HAPPY");
            bool result = (expected.Equals(obj));
            Console.WriteLine(result);
        }
    }
}