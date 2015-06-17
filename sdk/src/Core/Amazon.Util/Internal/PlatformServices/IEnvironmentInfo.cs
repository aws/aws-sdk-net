using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Util.Internal.PlatformServices
{
    public interface IEnvironmentInfo
    {
        string Platform { get; }
        string Model { get; }
        string Make { get; }
        string PlatformVersion { get; }
        public string Locale { get; }
    }
}
