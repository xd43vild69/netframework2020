using BLL._base.Manager;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UT
{
    [TestClass]
    public class ModifierAccess_Should
    {
        [TestMethod]
        public void ModifierAccess_PublicClass_Should()
        {
            //Arrage
            ModifierManager mm = new ModifierManager();

            //Act
            mm.CallPublicClass();

            //Assert
            // No assert yet
        }

        [TestMethod]
        public void ModifierAccess_PublicSonClass_Should()
        {
            //Arrage
            ModifierManager mm = new ModifierManager();

            //Act
            mm.CallPublicSonClass();

            //Assert
            // No assert yet
        }
    }
}