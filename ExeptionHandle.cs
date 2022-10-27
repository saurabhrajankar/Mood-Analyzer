using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyzer
{
    public class MoodAnalyzerException
    {
        public string MoodAnalyzerExceptionMethod(string message)
        {
            //exception handled using try catch
            try
            {
                //checking if msg passed contains given value
                string message1 = "SAD";
                string message2 = "HAPPY";
                if (message.ToUpper().Contains(message1.ToUpper()))
                {
                    return message1;
                }
                else if (message.ToUpper().Contains(message2.ToUpper()))
                {
                    return message2;
                }
            }
            catch (Exception ex)
            {
                return "HAPPY";
            }
            return null;
        }
    }
}
