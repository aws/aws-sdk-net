
using Amazon.Util.Storage.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Util.Internal.PlatformServices
{
    public class NetworkReachability : INetworkReachability
    {
        public NetworkStatus NetworkStatus
        {
            get
            {
                var networkReachability = NetworkInfo.GetReachability();
                if (networkReachability == UnityEngine.NetworkReachability.ReachableViaCarrierDataNetwork)
                    return NetworkStatus.ReachableViaCarrierDataNetwork;
                else if (networkReachability == UnityEngine.NetworkReachability.ReachableViaLocalAreaNetwork)
                    return NetworkStatus.ReachableViaWiFiNetwork;
                else
                    return NetworkStatus.NotReachable;
            }
        }

        public event EventHandler<NetworkStatusEventArgs> NetworkReachabilityChanged
        {
            add
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
            remove
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }
    }
}
