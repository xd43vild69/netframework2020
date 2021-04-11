using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL._base._class.methods
{
    public class _Override : OverrideAbstract
    {
        public override void ExecOverrideMethod()
        {
            base.ExecOverrideMethod();
            Console.WriteLine("Exec override method from OverrideAbstract class.");
        }
    }
}
