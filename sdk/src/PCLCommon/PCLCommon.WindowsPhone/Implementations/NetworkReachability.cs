using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
