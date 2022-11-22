using Microsoft.VisualStudio.TestTools.UnitTesting;
using Basic_of_.Net_Fremework;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void maxRepeatingtest()
        {
            string str = "aaaabbaaccde";
            
            Unit.maxRepeating(str);
            Assert.AreEqual(Unit.maxRepeating(str), 'a');
        }
        [TestMethod]
        public void maxnoRepeatingtest()
        {
            string str = "aaaabbaaccde";
            Assert.AreEqual(Unit.maxnoRepeating(str), 'b');
        }
        [TestMethod]
        public void maxRepeatinginttest()
        {
            int[] a = new int[10] { 1, 2, 3, 5, 5, 5, 3, 4, 5, 4 };
            Assert.AreEqual(Unit.maxRepeatingint(a), 3);
        }
    }
}
