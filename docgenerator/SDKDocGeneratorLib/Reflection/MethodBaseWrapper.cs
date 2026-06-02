using System.Collections.Generic;
using System.Reflection;

namespace SDKDocGenerator
{
    public class MethodBaseWrapper : MemberInfoWrapper
    {
        readonly MethodBase _info;

        public MethodBaseWrapper(MethodBase info, string docId)
            : base(info, docId)
        {
            this._info = info;
        }

        public IList<ParameterInfoWrapper> GetParameters()
        {
            var wrappers = new List<ParameterInfoWrapper>();

            foreach (var info in this._info.GetParameters())
            {
                wrappers.Add(new ParameterInfoWrapper(info, DocId));
            }

            return wrappers;
        }

        public bool IsPublic
        {
            get { return this._info.IsPublic; }
        }
    }
}
