using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT
{
    [TestClass]
    public class Generic_Should
    {
        [TestMethod]
        public void GenericTest_Should()
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
