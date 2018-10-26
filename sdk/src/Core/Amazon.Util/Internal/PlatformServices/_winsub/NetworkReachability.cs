using System;
using System.Net;
//using Windows.Networking.Connectivity;

namespace Amazon.Util.Internal.PlatformServices
{
    public class NetworkReachability : INetworkReachability
    {
        //TODO: should implement idisposable
        public NetworkReachability()
        {
             
        }

        private NetworkStatus _networkStatus;

        public NetworkStatus NetworkStatus
        {
            get
            {
                return NetworkStatus.ReachableViaWiFiNetwork;
            }
        }

        public event EventHandler<NetworkStatusEventArgs> NetworkReachabilityChanged;

        private void CheckInternetConnectivity()
        {
            
        }

        private void NetworkStatusChanged(object sender)
        {
            
        }
    }
}
