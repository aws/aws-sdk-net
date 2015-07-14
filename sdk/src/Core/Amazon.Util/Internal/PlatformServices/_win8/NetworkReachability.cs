using System;
using System.Net;
using Windows.Networking.Connectivity;

namespace Amazon.Util.Internal.PlatformServices
{
    public class NetworkReachability : INetworkReachability
    {
        //TODO: should implement idisposable
        public NetworkReachability()
        {
            CheckInternetConnectivity();
            NetworkInformation.NetworkStatusChanged += NetworkStatusChanged;
        }

        private NetworkStatus _networkStatus;

        public NetworkStatus NetworkStatus
        {
            get
            {
                return _networkStatus;
            }
        }

        public event EventHandler<NetworkStatusEventArgs> NetworkReachabilityChanged;

        //refer this http://stackoverflow.com/questions/16523447/how-to-detect-if-windows-8-device-is-on-wifi-lan-or-3g-internet-connection
        private void CheckInternetConnectivity()
        {
            ConnectionProfile InternetConnectionProfile = NetworkInformation.GetInternetConnectionProfile();
            if (InternetConnectionProfile == null)
                _networkStatus = NetworkStatus.NotReachable;
            else
            {
                switch (InternetConnectionProfile.GetNetworkConnectivityLevel())
                {
                    case NetworkConnectivityLevel.None:
                    case NetworkConnectivityLevel.ConstrainedInternetAccess:
                    case NetworkConnectivityLevel.LocalAccess:
                        _networkStatus = NetworkStatus.NotReachable;
                        break;
                    case NetworkConnectivityLevel.InternetAccess:
                        {
                            var interfaceType = InternetConnectionProfile.NetworkAdapter.IanaInterfaceType;
                            
                            // 71 is WiFi & 6 is Ethernet(LAN)
                            if (interfaceType == 71 || interfaceType == 6)
                            {
                                _networkStatus = NetworkStatus.ReachableViaWiFiNetwork;
                            }
                            // 243 & 244 is 3G/Mobile
                            else if (interfaceType == 243 || interfaceType == 244)
                            {
                                _networkStatus = NetworkStatus.ReachableViaCarrierDataNetwork;
                            }
                        }
                        break;
                }
            }
        }

        private void NetworkStatusChanged(object sender)
        {
            CheckInternetConnectivity();
            if (NetworkReachabilityChanged != null)
                NetworkReachabilityChanged(this, new NetworkStatusEventArgs(_networkStatus));
        }
    }
}
