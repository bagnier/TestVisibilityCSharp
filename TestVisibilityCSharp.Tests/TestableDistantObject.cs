namespace TestVisibilityCSharp.Tests
{
    public class TestableDistantObject : DistantObject
    {
        public new bool ProtectedMethod()
        {
            return base.ProtectedMethod();
        }

        public new bool ProtectedInternalMethod()
        {
            return base.ProtectedInternalMethod();
        }

        internal bool InternalMethod()
        {
            //return base.InternalMethod();
            return false;
        }

        private bool PrivateMethod()
        {
            //return base.PrivateMethod();
            return false;
        }
    }
}
