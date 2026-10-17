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
    }
}