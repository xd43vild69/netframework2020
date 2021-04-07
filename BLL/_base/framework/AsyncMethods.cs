using System;
using System.Threading.Tasks;

namespace BLL
{
    public class AsyncMethods
    {
        public async Task RunAsyncMethod()
        {
            _ = longTask1();
            _ = longTask2();
            _ = longTask3();
            await Task.Delay(2000);
        }

        private async Task longTask1()
        {
            await Task.Delay(2000);
            Console.WriteLine("long task 1");
        }

        private async Task longTask2()
        {
            await Task.Delay(4000);
            Console.WriteLine("long task 2");
        }

        private async Task longTask3()
        {
            await Task.Delay(1000);
            Console.WriteLine("long task 3");
        }
    }
}