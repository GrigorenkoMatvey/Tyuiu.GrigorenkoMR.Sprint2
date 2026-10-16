using Tyuiu.GrigorenkoMR.Sprint2.Task7.V15.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint2.Task7.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            // Точка (1.5, 0.5): x²+y² = 2.25+0.25 = 2.5 (между 1 и 4), y > 0 → внутри
            var res = ds.CheckDotInShadedArea(1.5, 0.5);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea1()
        {
            DataService ds = new DataService();
            // Точка (0.3, 0.3): x²+y² = 0.18 (< 1) → в «дырке»
            var res = ds.CheckDotInShadedArea(0.3, 0.3);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea2()
        {
            DataService ds = new DataService();
            // Точка (0, -1): y < 0 → вне области
            var res = ds.CheckDotInShadedArea(0, -1);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea3()
        {
            DataService ds = new DataService();
            // Точка (2.5, 0.5): x²+y² = 6.5 (> 4) → вне внешнего круга
            var res = ds.CheckDotInShadedArea(2.5, 0.5);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea4()
        {
            DataService ds = new DataService();
            // Точка (1, 0): x²+y² = 1, y = 0 → на границе внутреннего круга → внутри
            var res = ds.CheckDotInShadedArea(1, 0);
            Assert.AreEqual(true, res);
        }
    }
}
