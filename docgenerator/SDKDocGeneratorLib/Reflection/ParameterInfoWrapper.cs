using System.Reflection;

namespace SDKDocGenerator
{
    public class ParameterInfoWrapper : AbstractWrapper
    {
        readonly ParameterInfo _info;

        public ParameterInfoWrapper(ParameterInfo info, string docId)
            : base(docId)
        {
            this._info = info;
        }

        public string Name
        {
            get { return this._info.Name; }
        }

        public TypeWrapper ParameterType
        {
            get
            {
                if (this._info.ParameterType.IsByRef)
                    return new TypeWrapper(this._info.ParameterType.GetElementType(), DocId);

                return new TypeWrapper(this._info.ParameterType, DocId);
            }
        }

        public bool IsOut
        {
            get { return this._info.IsOut; }
        }

        public override string ToString()
        {
            return $"Parameter {this._info.Name}";
        }
    }
}
