using System.Reflection;

namespace SDKDocGenerator
{
    public class MethodInfoWrapper : MethodBaseWrapper
    {
        readonly MethodInfo _info;

        public MethodInfoWrapper(MethodInfo info, string docId)
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

        public bool IsAbstract
        {
            get { return this._info.IsAbstract; }
        }

        public bool IsVirtual
        {
            get { return this._info.IsVirtual && !this._info.IsAbstract; }
        }

        public TypeWrapper ReturnType
        {
            get { return new TypeWrapper(this._info.ReturnType, DocId); }
        }

        public bool IsGenericMethod
        {
            get { return this._info.IsGenericMethod; }
        }

        public TypeWrapper[] GetGenericArguments()
        {
            if (!this.IsGenericMethod)
                return null;

            var types = this._info.GetGenericArguments();
            var wrappers = new TypeWrapper[types.Length];
            for(int i = 0; i < types.Length; i++)
            {
                wrappers[i] = new TypeWrapper(types[i], DocId);
            }

            return wrappers;
        }

        public string FullName
        {
            get
            {
                return this._info.ToString();
            }
        }
    }
}
