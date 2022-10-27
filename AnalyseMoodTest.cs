using Mood_Analyzer;

namespace Mood_Analyze_Test
{
    [TestClass]
    public class UnitTAnalyseMoodTest
    {
        [TestMethod]
        public void AnalyseMoodMethodTest()
        {
            AnalyseMood a1 = new AnalyseMood();
            string value = a1.AnalyseMoodMethod("I M SAD");
            Assert.AreEqual("SAD", value);
        }
        [TestMethod()]
        public void AnalyseMoodMethodTest1()
        {
            AnalyseMood a1 = new();
            Assert.AreEqual("HAPPY", a1.AnalyseMoodMethod("I am in any mood"));
        }

    }
}