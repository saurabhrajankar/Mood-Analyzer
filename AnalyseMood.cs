using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyzer
{
    public class AnalyseMood
    {
        public string AnalyseMoodMethod(string message)
        {
            // checking if msg passed contains given value or not
            if (message.ToUpper().Contains("SAD"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
    
    
}