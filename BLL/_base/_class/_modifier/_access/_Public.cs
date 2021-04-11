using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL._base._class._modifier._access
{
    public class _Public
    {
        public _Public()
        {

        }

        internal void InternalMethodIntoPublicClass()
        {
            Console.WriteLine("exec InternalMethodIntoPublicClass");
        }

        public void PublicMethodIntoPublicClass()
        {
            Console.WriteLine("exec PublicMethodIntoPublicClass");
            PrivateMethodIntoPublicClass();
            ProtectedMethodIntoPublicClass();
        }

        protected void ProtectedMethodIntoPublicClass()
        {
            Console.WriteLine("exec ProtectedMethodIntoPublicClass");
        }

        protected void PrivateMethodIntoPublicClass()
        {
            Console.WriteLine("exec PrivateMethodIntoPublicClass");
        }

    }
}
