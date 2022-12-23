using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyserMSTest
{
    public class MoodAnalyserReflection
    {
        public MoodAnalyserReflection()
        {
        }
        public static object CreateMoodAnalyser(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                Assembly executing = Assembly.GetExecutingAssembly();
                Type moodAnalyseType = executing.GetType(className);
                return Activator.CreateInstance(moodAnalyseType);
            }
            return null;
        }
    }
}