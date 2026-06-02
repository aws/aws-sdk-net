using System;
using System.Reflection;
using System.Threading;

namespace SDKDocGenerator
{
    public class FieldInfoWrapper : MemberInfoWrapper
    {
        readonly FieldInfo _info;
        // Lazy + thread-safe so a shared wrapper can be read concurrently during parallel generation.
        private readonly Lazy<TypeWrapper> _fieldType;

        public FieldInfoWrapper(FieldInfo info, string docId)
            : base(info, docId)
        {
            this._info = info;
            this._fieldType = new Lazy<TypeWrapper>(
                () => new TypeWrapper(this._info.FieldType, DocId),
                LazyThreadSafetyMode.ExecutionAndPublication);
        }

        public bool IsPublic
        {
            get { return this._info.IsPublic; }
        }

        public bool IsStatic
        {
            get { return this._info.IsStatic; }
        }

        public bool IsInitOnly
        {
            get { return this._info.IsInitOnly; }
        }

        public bool IsLiteral
        {
            get { return this._info.IsLiteral; }
        }

        public TypeWrapper FieldType
        {
            get { return this._fieldType.Value; }
        }
    }
}
