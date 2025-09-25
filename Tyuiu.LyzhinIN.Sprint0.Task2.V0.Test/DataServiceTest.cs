
using Tyuiu.LyzhinIN.Sprint0.Task2.V0.Lib;

namespace Tyuiu.LyzhinIN.Sprint0.Task2.V0.Test


{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckMessageValid()
        {
            var name = "Иван";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Иван", res);
        }
    }
}
