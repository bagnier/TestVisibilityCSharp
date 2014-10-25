using System;
using System.Reflection;
using NUnit.Framework;

namespace TestVisibilityCSharp.Tests
{
    [TestFixture]
    internal class ReflexiveDistantObjectTests
    {
        [Test]
        public void DistantObject_InternalMethod_IsTestable()
        {
            DistantObject instance = new DistantObject();
            Object returnedValue = RunInstanceMethod(typeof(DistantObject), "InternalMethod", instance, null);
            bool result = (bool)returnedValue;
            Assert.That(result, Is.True);
        }

        [Test]
        public void DistantObject_PrivateMethod_IsTestable()
        {
            DistantObject instance = new DistantObject();
            Object returnedValue = RunInstanceMethod(typeof(DistantObject), "PrivateMethod", instance, null);
            bool result = (bool)returnedValue;
            Assert.That(result, Is.True);

        }

        public static object RunInstanceMethod(System.Type t, string strMethod, object objInstance,
                                               object[] aobjParams)
        {
            BindingFlags eFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            return RunMethod(t, strMethod, objInstance, aobjParams, eFlags);
        }

        private static object RunMethod(System.Type t, string strMethod, object objInstance, object[] aobjParams, BindingFlags eFlags)
        {
            MethodInfo m;
            try
            {
                m = t.GetMethod(strMethod, eFlags);
                if (m == null)
                {
                    throw new ArgumentException("There is no method '" + strMethod + "' for type '" + t.ToString() + "'.");
                }
                return m.Invoke(objInstance, aobjParams);
            }
            catch
            {
                throw;
            }
        }
    }
}