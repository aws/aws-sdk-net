using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using UnityEngine;

namespace Amazon.Util.Storage.Internal
{
    public class NetworkInfo
    {
        public static NetworkReachability GetReachability()
        {
            //if the thread is main thread. Then return the rechability status directly
            if (UnityInitializer.IsMainThread())
            {
                return Application.internetReachability;
            }
            else
            {
                NetworkReachability _networkReachability = NetworkReachability.NotReachable;
                AutoResetEvent asyncEvent = new AutoResetEvent(false);
                UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
                {
                    _networkReachability = Application.internetReachability;
                    asyncEvent.Set();
                });
                asyncEvent.WaitOne();

                return _networkReachability;
            }
        }
    }
}
