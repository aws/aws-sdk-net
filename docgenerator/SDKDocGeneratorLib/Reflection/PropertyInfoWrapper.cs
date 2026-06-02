using System;
using System.Reflection;

namespace SDKDocGenerator
{
    public class PropertyInfoWrapper : MemberInfoWrapper
    {
        readonly PropertyInfo _info;

        public PropertyInfoWrapper(PropertyInfo info, string docId)
            : base(info, docId)
        {
            this._info = info;
        }

        public bool IsPublic
        {
            get
            {
                if (this._info.GetGetMethod() == null)
                    return false;

                var underlyingType = Nullable.GetUnderlyingType(this._info.GetGetMethod().GetType());
                if (underlyingType != null)
                    return underlyingType.IsPublic;

                return this._info.GetGetMethod().IsPublic;
            }
        }

        public bool IsStatic
        {
            get
            {
                // need to watch out for properties with only a single accessor, CanRead/CanWrite
                // don't seem too reliable with public/protected/private modifiers
                if (_info.CanRead)
                {
                    var mi = _info.GetGetMethod();
                    if (mi != null)
                        return mi.IsStatic;
                }

                if (_info.CanWrite)
                {
                    var mi = _info.GetSetMethod();
                    if (mi != null)
                        return mi.IsStatic;
                }

                return false;
           }
        }

        public TypeWrapper PropertyType
        {
            get { return new TypeWrapper(this._info.PropertyType, DocId); }
        }

        public MethodInfoWrapper GetGetMethod()
        {
            var method = this._info.GetGetMethod();
            if (method == null)
                return null;

            return new MethodInfoWrapper(method, DocId);
        }

        public MethodInfoWrapper GetSetMethod()
        {
            var method = this._info.GetSetMethod();
            if (method == null)
                return null;

            return new MethodInfoWrapper(method, DocId);
        }
    }
}
