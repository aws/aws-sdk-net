using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Common
{
    public enum NetworkStatus
    {
        NotReachable,
        ReachableViaCarrierDataNetwork,
        ReachableViaWiFiNetwork
    }

    public interface INetworkReachability
    {
        NetworkStatus NetworkStatus { get; }

        event EventHandler<NetworkStatus> NetworkReachabilityChanged;
    }
}
