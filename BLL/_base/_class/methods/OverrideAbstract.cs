using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL._base._class.methods
{
    public abstract class OverrideAbstract
    {
        public virtual void ExecOverrideMethod()
        {
            Console.WriteLine("Call abstract method not override.");
        }
    }
}
