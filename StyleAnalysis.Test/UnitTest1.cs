using Logic;

namespace StyleAnalysis.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var math = new MyMath();
            var a = math.Divid(1, 1);

            Assert.AreEqual(1, a);
        }
    }
}