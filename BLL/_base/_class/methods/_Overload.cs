using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL._base._class.methods
{
    public class _Overload
    {
        public void CallOverload()
        {
            Console.WriteLine("OverLoadBasic");
        }

        public void CallOverload(string message)
        {
            Console.WriteLine($"OverLoadBasic {message}");
        }
    }
}
