using System.Reflection;

namespace SDKDocGenerator
{
    public class EventInfoWrapper : MemberInfoWrapper
    {
        readonly EventInfo _info;

        public EventInfoWrapper(EventInfo info, string docId)
            : base(info, docId)
        {
            this._info = info;
        }

        public bool IsStatic
        {
            get
            {
                // need to watch out for properties with only a single accessor, CanRead/CanWrite
                // don't seem too reliable with public/protected/private modifiers
                if (_info.AddMethod != null)
                {
                    return _info.AddMethod.IsStatic;
                }

                if (_info.RemoveMethod != null)
                {
                    return _info.RemoveMethod.IsStatic;
                }

                return false;
            }
        }
    }
}
