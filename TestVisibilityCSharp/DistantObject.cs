namespace TestVisibilityCSharp
{
    public class DistantObject
    {
        public bool PublicMethod()
        {
            return true;
        }

        protected bool ProtectedMethod()
        {
            return true;
        }

        protected internal bool ProtectedInternalMethod()
        {
            return true;
        }

        internal bool InternalMethod()
        {
            return true;
        }

        private bool PrivateMethod()
        {
            return true;
        }
    }
}
