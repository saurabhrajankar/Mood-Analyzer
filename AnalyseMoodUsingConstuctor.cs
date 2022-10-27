using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyzer
{
    public class AnalyzeMoodUsingConstructor
    {
        public string msg1= "i am sad";
        public AnalyzeMoodUsingConstructor(string message)
        {
            this.msg1 = message;
        }
        public AnalyzeMoodUsingConstructor()
        {
        }
        public string AnalyseMoodMethod1()
        {
            //if msg passed in constructor contains given value
            if (msg1.ToUpper().Contains("SAD"))
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
