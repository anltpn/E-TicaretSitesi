using System;

namespace core
{
    internal class Model
    {
        internal class Entity
        {
            internal class User
            {
                public static explicit operator User(object v)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}