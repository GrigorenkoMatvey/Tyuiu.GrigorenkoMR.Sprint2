using Tyuiu.GrigorenkoMR.Sprint2.Task2.V14.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint2.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            var res = ds.CheckDotInShadedArea(4, 5);
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void OutsidePoint_ReturnsFalse()
        {
            DataService ds = new DataService();
            var res = ds.CheckDotInShadedArea(1, 1);
            Assert.AreEqual(false, res);
        }
    }
}
