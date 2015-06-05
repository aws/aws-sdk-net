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
            get { throw new NotImplementedException(Resources.NotImplementedErrorMessage); }
        }

        public event EventHandler<NetworkStatus> NetworkReachabilityChanged
        {
            add
            {
                throw new NotImplementedException(Resources.NotImplementedErrorMessage);
            }
            remove
            {
                throw new NotImplementedException(Resources.NotImplementedErrorMessage);
            }
        }
    }
}
