using Mood_Analyzer;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyze_Test
{
    [TestClass]
    public class UnitTAnalyseMoodTest2
    {
        [TestMethod]
        public void AnalyseMoodMethodTest()
        {
            AnalyzeMoodUsingConstructor a = new AnalyzeMoodUsingConstructor("i m sad");
            string value = a.AnalyseMoodMethod1();
            Assert.AreEqual("SAD", value);

            AnalyzeMoodUsingConstructor b = new AnalyzeMoodUsingConstructor();
            string z = b.AnalyseMoodMethod1();
            Console.WriteLine("Using Default Constructor  " + z);
            Assert.AreEqual("SAD", value);
        }
        

    }
}
