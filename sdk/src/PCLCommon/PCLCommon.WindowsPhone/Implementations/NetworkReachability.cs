using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.Connectivity;

namespace Amazon.Common
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

        public event EventHandler<NetworkStatus> NetworkReachabilityChanged;

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
                        if (InternetConnectionProfile.IsWlanConnectionProfile)
                            _networkStatus = Common.NetworkStatus.ReachableViaWiFiNetwork;
                        else
                            _networkStatus = Common.NetworkStatus.ReachableViaCarrierDataNetwork;
                        break;
                }
            }
        }

        private void NetworkStatusChanged(object sender)
        {
            CheckInternetConnectivity();
            if (NetworkReachabilityChanged != null)
                NetworkReachabilityChanged(this, _networkStatus);
        }
    }
}
