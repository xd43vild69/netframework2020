using System;

namespace BLL._base._class._modifier._access
{
    internal class _Internal
    {
        private class _Private
        {
            protected void _ProtectedMethod()
            {
                Console.WriteLine("ProtectedMethod into a private class");
            }
        }

        protected class _Protected
        {
            private void _PrivateMethod()
            {
                Console.WriteLine("PrivateMethod into a protected class");
            }
        }

        public class _Public
        {
            private void _PrivateMethod()
            {
                Console.WriteLine("PrivateMethod into a public class");
            }

            protected void _ProtectedMethod()
            {
                Console.WriteLine("ProtectedMethod into a public class");
            }
        }
    }
}