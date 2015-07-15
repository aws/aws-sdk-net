using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Net;

namespace Amazon.Util.Internal.PlatformServices
{
    public class NetworkReachability : INetworkReachability, IDisposable
    {
        private NetworkStatusChangeBroadcastReceiver _networkBroadcastReceiver;

        private NetworkStatus _networkStatus;

        public NetworkReachability()
        {
            //TODO: need a better way to implement this
            if(_networkBroadcastReceiver == null)
            {
                var context = Application.Context;
                _networkBroadcastReceiver = new NetworkStatusChangeBroadcastReceiver();
                _networkBroadcastReceiver.ConnectionStatusChanged += NetworkStatusChanged;
                Application.Context.RegisterReceiver(_networkBroadcastReceiver, new IntentFilter(ConnectivityManager.ConnectivityAction));

                //update the network status for the first time
                var connectivityManager = (ConnectivityManager)context.GetSystemService(Context.ConnectivityService);
                var activeConnection = connectivityManager.ActiveNetworkInfo;
                var connectionStatus = NetworkStatus.NotReachable;

                if ((activeConnection != null) && activeConnection.IsConnected)
                {
                    if (activeConnection.Type == ConnectivityType.Wifi)
                    {
                        connectionStatus = NetworkStatus.ReachableViaWiFiNetwork;
                    }
                    else
                    {
                        connectionStatus = NetworkStatus.ReachableViaCarrierDataNetwork;
                    }
                }

                this._networkStatus = connectionStatus;
            }
        }

        private void NetworkStatusChanged(object sender, NetworkStatus e)
        {
            this._networkStatus = e;
            if (NetworkReachabilityChanged != null)
                NetworkReachabilityChanged(this, new NetworkStatusEventArgs(e));
        }

        public NetworkStatus NetworkStatus
        {
            get
            {
                return _networkStatus;
            }
        }

        public event EventHandler<NetworkStatusEventArgs> NetworkReachabilityChanged;

        [BroadcastReceiver()]
        public class NetworkStatusChangeBroadcastReceiver : BroadcastReceiver
        {
            public event EventHandler<NetworkStatus> ConnectionStatusChanged;

            public override void OnReceive(Context context, Intent intent)
            {
                var connectivityManager = (ConnectivityManager)context.GetSystemService(Context.ConnectivityService);
                var activeConnection = connectivityManager.ActiveNetworkInfo;
                var connectionStatus = NetworkStatus.NotReachable;

                if ((activeConnection != null) && activeConnection.IsConnected)
                {
                    if (activeConnection.Type == ConnectivityType.Wifi)
                    {
                        connectionStatus =  NetworkStatus.ReachableViaWiFiNetwork;
                    }
                    else
                    {
                        connectionStatus =  NetworkStatus.ReachableViaCarrierDataNetwork;
                    }
                }

                if (ConnectionStatusChanged != null)
                    ConnectionStatusChanged(this, connectionStatus);
            }
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}