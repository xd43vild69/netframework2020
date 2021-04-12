using BLL._base._class.methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL._base.Manager
{
    public class OverloadManager
    {
        public void CallOverLoadManager()
        {
            _Overload o = new _Overload();
            o.CallOverload();
            o.CallOverload("with string value.");
        }
    }
}
