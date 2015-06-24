using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Util.Internal.PlatformServices
{
    public class NetworkReachability : INetworkReachability
    {
        public NetworkStatus NetworkStatus
        {
            get { throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage); }
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
