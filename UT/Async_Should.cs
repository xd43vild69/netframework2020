using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace UT
{
    [TestClass]
    public class Async_Should
    {
        [TestMethod]
        public async Task DelegateTest_Should()
        {
            //Arrage
            AsyncMethods a = new AsyncMethods();

            //Act
            await a.RunAsyncMethod();

            System.Console.WriteLine("In C# 7.1, To use async method");
            System.Console.WriteLine($"Main Method execution started at {System.DateTime.Now}");

            await Task.Delay(2000);
            System.Console.WriteLine($"Main Method execution ended at {System.DateTime.Now}");

            //Assert
            // No assert yet
        }
    }
}