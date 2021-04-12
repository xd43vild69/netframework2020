using Microsoft.VisualStudio.TestTools.UnitTesting;
using d = BLL.Delegates;

namespace UT
{
    [TestClass]
    public class Deletegate_Should
    {
        [TestMethod]
        public void DelegateTest_Should()
        {
            //Arrage
            d.Delegate d = new d.Delegate();

            //Act
            d.RunBasicDelegate();
            d.RunFuncDelegate();
            d.RunActionDelegate();
            d.RunPredicateDelegate();

            //Assert
            // No assert yet
        }
    }
}
