using BLL;
using BLL.Delegates;
using Console.IO;
using System;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
         static async Task Main(string[] args)
        {
            //Extension Methods
            //OperateExtensionMethods();

            // Delegates
            //OperateDelegates();

            //EF Test
            //OperateEF();

            //ReadFile
            //OperateIOMemorize();

            //Async
            //await OperateAsyncMethod();

            //System.Console.WriteLine("Succesful finished. Press any key to exist.");
            //System.Console.Read();
        }

        public static void OperateIOMemorize()
        {
            IOMemorize ioM = new IOMemorize();
            ioM.ExecuteFormat();
        }

        public async static Task OperateAsyncMethod()
        {
            AsyncMethods asyncM1 = new AsyncMethods();
            await asyncM1.RunAsyncMethod();

            System.Console.WriteLine("In C# 7.1, To use async method");
            System.Console.WriteLine($"Main Method execution started at {System.DateTime.Now}");

            await Task.Delay(2000);
            System.Console.WriteLine($"Main Method execution ended at {System.DateTime.Now}");
        }

        public static void OperateExtensionMethods()
        {
            string name = "This is a new-add name";
            int totalWords = name.WordCount();
            System.Console.WriteLine($"Total words on string extension method {totalWords}");
        }

        public static void OperateDelegates()
        {
            BLL.Delegates.Delegate d = new BLL.Delegates.Delegate();
            d.RunBasicDelegate();
            d.RunFuncDelegate();
            d.RunActionDelegate();
            d.RunPredicateDelegate();
        }

        public static void OperateEF()
        {

            var newName = "D13 " + new Random().Next().ToString();
            int newId = 9;

            OperationsEF operationEF = new OperationsEF();


            operationEF.insertMtoM();

            operationEF.InsertEF(newName);

            var person = operationEF.GetEF(newId);
            System.Console.WriteLine($"Person name is {person.Name}");

            person = operationEF.GetById(newId);
            System.Console.WriteLine($"Person name is {person.Name}");

            newName = "D13 " + new Random().Next().ToString();
            person.Name = newName;

            operationEF.UpdateEF(person);
            person = operationEF.GetById(newId);
            System.Console.WriteLine($"Person name is {person.Name}");

            // operationEF.delete(person);
        }


    }
}
