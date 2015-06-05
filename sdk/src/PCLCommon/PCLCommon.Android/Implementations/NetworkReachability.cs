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

namespace Amazon.Common
{
    public class NetworkReachability : INetworkReachability
    {
        public NetworkStatus NetworkStatus
        {
            get { throw new NotImplementedException(); }
        }

        public event EventHandler<NetworkStatus> NetworkReachabilityChanged;
    }
}