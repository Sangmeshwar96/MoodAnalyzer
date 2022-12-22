using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MoodAnalyserMSTest
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser() //default constructor
        {
        }
        public MoodAnalyser(string message) //parameterized constructor
        {
            this.message = message;
        }
        public string analyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new Exception("The string is empty, you must enter something");
                }
                else if (this.message.ToUpper().Contains("SAD"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (Exception obj)
            {
                Console.WriteLine(obj.Message);
            }
            return "null";
        }
    }
}
