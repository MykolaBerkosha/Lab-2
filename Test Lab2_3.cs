using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test1
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethod() //äîáóòîê åëåìåíò³â ìàñèâó, ðîçòàøîâàíèõ ì³æ ïåðøèì é îñòàíí³ì â³ä’ºìíèìè åëåìåíòàìè
        {
            int n = 5;
            int[] a = { 3, -1, -4, 5, 7 };
            float result = Lab2._2b.Program.Dob_el(a, n);
            Assert.AreEqual(2, result);
        }
    }
    
}

