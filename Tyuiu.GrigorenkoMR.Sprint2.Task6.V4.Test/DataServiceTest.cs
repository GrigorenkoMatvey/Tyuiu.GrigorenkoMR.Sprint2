using Tyuiu.GrigorenkoMR.Sprint2.Task6.V4.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint2.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            var res = ds.FindCardSuit(1);
            Assert.AreEqual("пики", res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            var res = ds.FindCardSuit(2);
            Assert.AreEqual("трефы", res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            var res = ds.FindCardSuit(3);
            Assert.AreEqual("бубны", res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            var res = ds.FindCardSuit(4);
            Assert.AreEqual("червы", res);
        }
    }
}