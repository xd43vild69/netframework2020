using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL._base._class._modifier._access
{
    public class _PublicSon: _Public
    {
         public void PublicSonMethodCallingInternalMethod()
        {
            Console.WriteLine("exec PublicSonMethod");
            InternalMethodIntoPublicClass();
            ProtectedMethodIntoPublicClass();
            Console.WriteLine("end PublicSonMethod");
        }

    }
}
