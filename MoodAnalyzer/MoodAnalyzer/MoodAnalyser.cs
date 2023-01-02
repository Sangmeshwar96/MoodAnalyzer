using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodAnalyzer;

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
            if (this.message.ToLower().Contains("Sad"))
                return "Sad";
            return "Happy";
        }
    }
}
