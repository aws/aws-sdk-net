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

        //refer this http://stackoverflow.com/questions/16523447/how-to-detect-if-windows-8-device-is-on-wifi-lan-or-3g-internet-connection
        private void CheckInternetConnectivity()
        {
            
        }

        private void NetworkStatusChanged(object sender)
        {
            
        }
    }
}
