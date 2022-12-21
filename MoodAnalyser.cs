using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserMSTest
{
    public class MoodAnalyser
    {
        public string analyseMood(string message)
        {
            if (message.ToUpper().Contains("SAD"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}
