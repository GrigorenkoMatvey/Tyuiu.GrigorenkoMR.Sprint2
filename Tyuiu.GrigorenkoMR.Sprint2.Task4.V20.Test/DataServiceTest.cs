using Tyuiu.GrigorenkoMR.Sprint2.Task4.V20.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint2.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondision1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(5, 2);
            Assert.AreEqual(1.187, res);
        }
        [TestMethod]
        public void ValidCondision2()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(-10, 5);
            Assert.AreEqual(99.8, res);
        }
    }
}
