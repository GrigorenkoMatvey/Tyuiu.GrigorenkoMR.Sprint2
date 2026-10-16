using Tyuiu.GrigorenkoMR.Sprint2.Task5.V10.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint2.Task5.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondicion1()
        {
            DataService ds = new DataService();
            // 15 марта 2024 → 14 марта 2024
            var res = ds.FindDateOfPreviousDay(2024, 3, 15);
            Assert.AreEqual("14.03.2024", res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            // 1 марта 2024 → 28 февраля 2024 (не високосный)
            var res = ds.FindDateOfPreviousDay(2024, 3, 1);
            Assert.AreEqual("28.02.2024", res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            // 1 января 2024 → 31 декабря 2023
            var res = ds.FindDateOfPreviousDay(2024, 1, 1);
            Assert.AreEqual("31.12.2023", res);
        }
    }
}
