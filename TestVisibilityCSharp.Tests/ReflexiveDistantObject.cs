using System;
using System.Reflection;

namespace TestVisibilityCSharp.Tests
{
    class ReflexiveDistantObject : DistantObject
    {
        public new bool ProtectedMethod()
        {
            return base.ProtectedMethod();
        }

        public new bool ProtectedInternalMethod()
        {
            return base.ProtectedInternalMethod();
        }

        public bool InternalMethod()
        {
            return (bool)RunInstanceMethod(typeof(DistantObject), "InternalMethod", this, null);
        }

        public bool PrivateMethod()
        {
            return (bool)RunInstanceMethod(typeof(DistantObject), "PrivateMethod", this, null);
        }

        public static object RunInstanceMethod(System.Type t, string strMethod, object objInstance,
                                       object[] aobjParams)
        {
            BindingFlags eFlags = BindingFlags.Instance | BindingFlags.Public |
                                  BindingFlags.NonPublic;
            return RunMethod(t, strMethod, objInstance, aobjParams, eFlags);
        }

        private static object RunMethod(System.Type t, string strMethod, object objInstance, object[] aobjParams,
                                        BindingFlags eFlags)
        {
            MethodInfo m;
            try
            {
                m = t.GetMethod(strMethod, eFlags);
                if (m == null)
                {
                    throw new ArgumentException("There is no method '" +
                                                strMethod + "' for type '" + t.ToString() + "'.");
                }

                object objRet = m.Invoke(objInstance, aobjParams);
                return objRet;
            }
            catch
            {
                throw;
            }
        }
    }
}