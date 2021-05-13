using System;

namespace BLL._base.framework.GenericBase
{
    public class GenericClassBase<T>
    {
        private T _value;

        public GenericClassBase(T t)
        {
            // The field has the same type as the parameter.
            this._value = t;
        }

        public void Write()
        {
            Console.WriteLine(this._value);
        }
    }
}