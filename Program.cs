using System;

namespace MoodAnalyserMSTest
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("---Welcome to MoodAnalyser MSTesting---\n");
            object expected = new MoodAnalyser(null);
            object obj = MoodAnalyserReflection.CreateMoodAnalyser("MoodAnalyserMSTest.MoodAnalyser", "MoodAnalyser");
            bool result = (expected.Equals(obj));
            Console.WriteLine(result);

        }
    }
}