using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            try
            {
                if (this.message.ToLower().Contains("Sad"))
                    return "Sad";
                else
                    if (message.Equals(" "))
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                else if (message.Equals(null))
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Mood should not be Null");
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Mood should not be Null");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

            }
        }
    }
}