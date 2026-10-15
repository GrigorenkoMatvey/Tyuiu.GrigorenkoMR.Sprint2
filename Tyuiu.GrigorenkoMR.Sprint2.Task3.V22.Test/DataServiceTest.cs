using Tyuiu.GrigorenkoMR.Sprint2.Task3.V22.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint2.Task3.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition()
        {
            DataService ds = new DataService();
            double x = 5.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(37.0, res);
        }
    }
}
