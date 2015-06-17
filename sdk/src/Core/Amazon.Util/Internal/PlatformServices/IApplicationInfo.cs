using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Util.Internal.PlatformServices
{
    public interface IApplicationInfo
    {
        string AppTitle { get; }
        string AppVersionName { get; }
        string AppVersionCode { get; }
        string PackageName { get; }
    }
}
