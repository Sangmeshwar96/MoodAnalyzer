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
                if (this.message == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
                }
//<<<<<<< Updated upstream
                if (this.message.Equals(string.Empty))
//=======
                if(this.message.Equals(String.Empty)) //>>>>>>> Stashed changes
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                else if (this.message.ToUpper().Contains("SAD"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (CustomException obj)
            {
                Console.WriteLine(obj.Message);
            }
            return null;
        }
    }
}