﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    class MoodAnalyser
    {
        public string AnalyzeMood(string message)
        {
            if (message.ToLower().Contains("Sad"))
                return "Sad";
            return "Happy";
        }
    }
}