
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
                var networkReachability = NetworkInfo.Reachability;
                if (networkReachability == UnityEngine.NetworkReachability.ReachableViaCarrierDataNetwork)
                    return NetworkStatus.ReachableViaCarrierDataNetwork;
                else if (networkReachability == UnityEngine.NetworkReachability.ReachableViaLocalAreaNetwork)
                    return NetworkStatus.ReachableViaWiFiNetwork;
                else
                    return NetworkStatus.NotReachable;
            }
        }

        internal EventHandler<NetworkStatusEventArgs> mNetworkReachabilityChanged;

        internal static readonly object reachabilityChangedLock = new object();

        public event EventHandler<NetworkStatusEventArgs> NetworkReachabilityChanged
        {
            add
            {
                lock (reachabilityChangedLock)
                {
                    mNetworkReachabilityChanged += value;
                }
            }
            remove
            {
                lock (reachabilityChangedLock)
                {
                    mNetworkReachabilityChanged -= value;
                }
            }
        }

        internal void OnNetworkReachabilityChanged(NetworkStatus status)
        {
            EventHandler<NetworkStatusEventArgs> handler = mNetworkReachabilityChanged;
            if (handler != null)
            {
                handler(null, new NetworkStatusEventArgs(status));
            }
        }

    }
}
