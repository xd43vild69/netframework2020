using BLL._base.Manager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT
{

    [TestClass]
    public class OverrideOverload_Should
    {

        [TestMethod]
        public void OverrideTest_Should()
        {
            //Arrage
            OverrideManager om = new OverrideManager();

            //Act
            om.CallOverrideExample();

            //Assert
            // No assert yet
        }

        [TestMethod]
        public void OverloadTest_Should()
        {
            //Arrage
            OverloadManager om = new OverloadManager();

            //Act
            om.CallOverLoadManager();

            //Assert
            // No assert yet
        }

    }
}
