using System.Reflection;

namespace SDKDocGenerator
{
    public class MemberInfoWrapper : AbstractWrapper
    {
        readonly MemberInfo _info;

        public MemberInfoWrapper(MemberInfo info, string docId)
            : base(docId)
        {
            this._info = info;
        }

        public string Name
        {
            get { return this._info.Name; }
        }

        public TypeWrapper DeclaringType
        {
            get { return new TypeWrapper(this._info.DeclaringType, DocId); }
        }

        public override string ToString()
        {
            return $"{this._info.DeclaringType.FullName}.{this._info.Name}";
        }
    }
}
