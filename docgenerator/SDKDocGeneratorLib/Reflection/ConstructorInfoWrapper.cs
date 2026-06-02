using System.Reflection;

namespace SDKDocGenerator
{
    public class ConstructorInfoWrapper : MethodBaseWrapper
    {
        readonly ConstructorInfo _info;

        public ConstructorInfoWrapper(ConstructorInfo info, string docId)
            : base(info, docId)
        {
            this._info = info;
        }

        public bool IsStatic
        {
            get
            {
                return _info.IsStatic;
            }
        }
    }
}
