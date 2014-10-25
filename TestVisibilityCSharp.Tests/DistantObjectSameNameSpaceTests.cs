using NUnit.Framework;
using TestVisibilityCSharp.Tests;

namespace TestVisibilityCSharp
{
    [TestFixture]
    public class DistantObjectSameNameSpaceTests
    {
        [Test]
        public void DistantObject_PublicMethod_IsVisible()
        {
            DistantObject instance = new DistantObject();
            bool result = instance.PublicMethod();
        }

        [Test]
        public void DistantObject_ProtectedMethod_IsTestable()
        {
            TestableDistantObject instance = new TestableDistantObject();
            bool result = instance.ProtectedMethod();
        }

        [Test]
        public void DistantObject_ProtectedInternalMethod_IsTestable()
        {
            TestableDistantObject instance = new TestableDistantObject();
            bool result = instance.ProtectedInternalMethod();
        }

        [Test]
        public void DistantObject_InternalMethod_IsNotTestable()
        {
            DistantObject instance = new DistantObject();
            //Wont compile !
            //bool result = instance.InternalMethod();
        }

        [Test]
        public void DistantObject_PrivateMethod_IsNotTestable()
        {
            DistantObject instance = new DistantObject();
            //Wont compile !
            //bool result = instance.PrivateMethod();
        }
    }
}