using Tyuiu.GrigorenkoMR.Sprint2.Task0.V29.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint2.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 105;
            int y = 735;
            var res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[]
           {
                false, false, true, true, false, false
           };
            CollectionAssert.AreEqual(wait, res);


        }
    }
}
