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
using Amazon.Runtime.Internal;
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

        private AsyncOptions OnConnectivityOptions = null;

        /// <summary>
        /// Synchronize <see cref="Dataset"/> between local storage and remote storage.
        /// </summary>
        /// <seealso href="http://docs.aws.amazon.com/cognito/latest/developerguide/synchronizing-data.html#synchronizing-local-data">Amazon Cognito Sync Dev. Guide - Synchronizing Local Data with the Sync Store</seealso>
        public virtual void SynchronizeAsync(AsyncOptions options = null)
        {
            options = options == null ? new AsyncOptions() : options;
            if (_netReachability.NetworkStatus == NetworkStatus.NotReachable)
            {
                FireSyncFailureEvent(new NetworkException("Network connectivity unavailable."), options);
                return;
            }

            SynchronizeHelperAsync(options);
        }

        private void DatasetSetupInternal()
        {
            _netReachability = ServiceFactory.Instance.GetService<INetworkReachability>();
            _netReachability.NetworkReachabilityChanged += OnNetworkReachabilityChanged;
        }

        /// <summary>
        /// Attempt to synchronize <see cref="Dataset"/> when connectivity is available. If
        /// the connectivity is available right away, it behaves the same as
        /// <see cref="Dataset.SynchronizeAsync(AsyncOptions)"/>. Otherwise it listens to connectivity
        /// changes, and will do a sync once the connectivity is back. Note that if
        /// this method is called multiple times, only the last synchronize request
        /// is kept. If either the dataset or the callback is garbage collected
        /// , this method will not perform a sync and the callback won't fire.
        /// </summary>
        public virtual void SynchronizeOnConnectivity(AsyncOptions options = null)
        {
            if (_netReachability.NetworkStatus != NetworkStatus.NotReachable)
            {
                SynchronizeAsync(options);
            }
            else
            {
                waitingForConnectivity = true;
                OnConnectivityOptions = options;
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
                var options = OnConnectivityOptions;
                OnConnectivityOptions = null;
                SynchronizeAsync(options);
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

        private void SynchronizeHelperAsync(AsyncOptions options)
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
                    SynchornizeInternal(options);
                }, new AsyncOptions() { ExecuteCallbackOnMainThread = false });
            }
            catch (Exception e)
            {
                FireSyncFailureEvent(e, options);
                _logger.Error(e, "");
            }
        }


        /// <summary>
        /// Fires a Sync Success Event
        /// </summary>
        /// <param name="records">List of records after successful sync</param>
        /// <param name="options">AsyncOptions object that controls whether</param>
        protected void FireSyncSuccessEvent(List<Record> records, AsyncOptions options)
        {
            if (options.ExecuteCallbackOnMainThread)
            {
                // Enqueue the callback so that the Unity main thread dispatcher 
                // can invoke the callback on the main thread.
                UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
                {
                    FireSyncSuccessEvent(records);
                });
            }
            else
            {
                FireSyncSuccessEvent(records);
            }
        }

        /// <summary>
        /// Fires a Sync Failure event.
        /// </summary>
        /// <param name="exception">Exception object which caused the sync Failure</param>
        /// <param name="options">AsyncOptions object that controls whether</param>
        protected void FireSyncFailureEvent(Exception exception, AsyncOptions options)
        {
            if (options.ExecuteCallbackOnMainThread)
            {
                // Enqueue the callback so that the Unity main thread dispatcher 
                // can invoke the callback on the main thread.
                UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
                {
                    FireSyncFailureEvent(exception);
                });
            }
            else
            {
                FireSyncFailureEvent(exception);
            }
        }
    }
}
