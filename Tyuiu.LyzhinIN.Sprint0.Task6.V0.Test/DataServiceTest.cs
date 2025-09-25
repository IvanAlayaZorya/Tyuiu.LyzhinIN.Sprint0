using Tyuiu.LyzhinIN.Sprint0.Task6.V0.Lib;
namespace Tyuiu.LyzhinIN.Sprint0.Task6.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAddArrValid()
        {
            var num = new int[] { 1, 2, 3,4,5 };
            var res = DataService.AddArr(num);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckSubArrValid()
        {
            var num = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubArr(num);
            Assert.AreEqual(-15, res);
        }
        [TestMethod]
        public void CheckMultArrValid()
        {
            var num = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultArr(num);
            Assert.AreEqual(120, res);
        }
    }
}
