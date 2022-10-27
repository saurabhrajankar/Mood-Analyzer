using Mood_Analyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyze_Test
{
    [TestClass]
    public class UnitTest3
    {
        public MAP3 map3;
        [TestMethod]
        public void EmptyMsg()
        {
            map3 = new MAP3();
            try
            {
                string msg = "";
                string value = map3.analysemood(msg);
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("Empty Value", e.Message);
            }
        }
        [TestMethod]
        public void NullMsg()
        {
            map3 = new MAP3();
            try
            {
                string msg = null;
                string value = map3.analysemood(msg);
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("Null Value", e.Message);
            }
        }
    }
}