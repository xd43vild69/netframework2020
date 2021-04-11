using BLL._base._class._modifier._access;

namespace BLL._base.Manager
{
    public class ModifierManager
    {
        public void CallPublicClass()
        {
            _Public publicClass = new _Public();
            publicClass.PublicMethodIntoPublicClass();
        }

        public void CallPublicSonClass()
        {
            _PublicSon publicSonClass = new _PublicSon();
            publicSonClass.PublicSonMethodCallingInternalMethod();
            System.Console.WriteLine("exec public method parent since son");
            publicSonClass.PublicMethodIntoPublicClass();
        }
    }
}
