using NUnit.Framework;

namespace TestVisibilityCSharp.Tests
{
    [TestFixture]
    class SimplifiedReflexiveDistantObjectTests
    {
        [Test]
        public void DistantObject_InternalMethod_IsTestable()
        {
            ReflexiveDistantObject instance = new ReflexiveDistantObject();
            bool result = instance.InternalMethod();
            Assert.That(result, Is.True);
        }

        [Test]
        public void DistantObject_PrivateMethod_IsTestable()
        {
            ReflexiveDistantObject instance = new ReflexiveDistantObject();
            bool result = instance.PrivateMethod();
            Assert.That(result, Is.True);
        }
    }
}