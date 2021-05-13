using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UT
{
    [TestClass]
    public class ExtensionMethod
    {
        [TestMethod]
        public void DelegateTest_Should()
        {
            //Arrage
            string name = "name";

            //Act
            int result = name.WordCount();
            //System.Console.WriteLine($"Total words on string extension method {totalWords}");

            //Assert
            Assert.AreEqual(result, 4);
        }
    }
}