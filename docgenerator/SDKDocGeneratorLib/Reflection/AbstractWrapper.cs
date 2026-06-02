using System;
using System.Collections.Generic;

namespace SDKDocGenerator
{
    public abstract class AbstractWrapper : MarshalByRefObject
    {
        public string DocId
        {
            private set;
            get;
        }

        protected AbstractWrapper(string docId)
        {
            DocId = docId;
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public abstract class AbstractTypeProvider : AbstractWrapper
    {
        protected AbstractTypeProvider(string docId)
            : base(docId)
        {
        }

        public virtual TypeWrapper GetType(string name) { return null; }
        public virtual IEnumerable<TypeWrapper> GetTypes() { return null; }
        public virtual IEnumerable<string> GetNamespaces() { return null; }
        public virtual IEnumerable<TypeWrapper> GetTypesForNamespace(string namespaceName) { return null; }
    }
}
