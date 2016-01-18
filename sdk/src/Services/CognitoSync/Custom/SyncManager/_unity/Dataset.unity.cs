//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.Util.Internal;
using Amazon.Util.Internal.PlatformServices;
using System;
using System.Collections.Generic;
using System.Threading;


namespace Amazon.CognitoSync.SyncManager
{
    public partial class Dataset : IDisposable
    {

        INetworkReachability _netReachability;

        /// <summary>
        /// Synchronize <see cref="Dataset"/> between local storage and remote storage.
        /// </summary>
        public virtual void Synchronize()
        {
            if (_netReachability.NetworkStatus == NetworkStatus.NotReachable)
            {
                FireSyncFailureEvent(new NetworkException("Network connectivity unavailable."));
                return;
            }

            SynchronizeHelperAsync();
        }

        private void DatasetSetupInternal()
        {
            _netReachability = ServiceFactory.Instance.GetService<INetworkReachability>();
            _netReachability.NetworkReachabilityChanged += OnNetworkReachabilityChanged;
        }

        /// <summary>
        /// Attempt to synchronize <see cref="Dataset"/> when connectivity is available. If
        /// the connectivity is available right away, it behaves the same as
        /// <see cref="Dataset.Synchronize()"/>. Otherwise it listens to connectivity
        /// changes, and will do a sync once the connectivity is back. Note that if
        /// this method is called multiple times, only the last synchronize request
        /// is kept. If either the dataset or the callback is garbage collected
        /// , this method will not perform a sync and the callback won't fire.
        /// </summary>
        public virtual void SynchronizeOnConnectivity()
        {
            if (_netReachability.NetworkStatus != NetworkStatus.NotReachable)
            {
                Synchronize();
            }
            else
            {
                waitingForConnectivity = true;
            }
        }

        private void OnNetworkReachabilityChanged(object sender, NetworkStatusEventArgs e)
        {
            if (!waitingForConnectivity)
            {
                return;
            }

            if (e.Status != NetworkStatus.NotReachable)
            {
                Synchronize();
            }
        }

        /// <summary>
        /// Releases the resources consumed by this object if disposing is true. 
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                ClearAllDelegates();
                _netReachability.NetworkReachabilityChanged -= OnNetworkReachabilityChanged;
                _disposed = true;
            }
        }

        private void SynchronizeHelperAsync()
        {
            try
            {
                if (locked)
                {
                    _logger.InfoFormat("Already in a Synchronize. Queueing new request.", DatasetName);
                    queuedSync = true;
                    return;
                }
                else
                {
                    locked = true;
                }

                waitingForConnectivity = false;

                InternalSDKUtils.AsyncExecutor(() =>
                {
                    //make sure we have the updated credentials;
                    SynchornizeInternal();
                }, new AsyncOptions() { ExecuteCallbackOnMainThread = false });
            }
            catch (Exception e)
            {
                FireSyncFailureEvent(e);
                _logger.Error(e, "");
            }
        }
    }
}
