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
using Amazon.CognitoIdentity;
using Amazon.CognitoSync.SyncManager.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Util.Storage.Internal;

using System;
using System.Collections.Generic;
using System.Threading;

using UnityEngine;

namespace Amazon.CognitoSync.SyncManager
{

    public partial class Dataset : IDisposable
    {
        
        /// <summary>
        /// Synchronize <see cref="Dataset"/> between local storage and remote storage.
        /// </summary>
        public virtual void Synchronize()
        {
            if (NetworkInfo.GetReachability() == NetworkReachability.NotReachable)
            {
                FireSyncFailureEvent(new NetworkException("Network connectivity unavailable."));
                return;
            }

            // if the thread is in background thread, then start synchronizing, 
            // else queue the synchronization in a threadpool thread
            if (!UnityInitializer.IsMainThread())
            {
                SynchronizeInternalAsync();
            }
            else
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    SynchronizeInternalAsync();
                }));
            }
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
            if (NetworkInfo.GetReachability() != NetworkReachability.NotReachable)
            {
                Synchronize();
            }
            else
            {
                waitingForConnectivity = true;
            }
        }

        private void HandleConnectivityRefresh(object sender, UnityMainThreadDispatcher.NetworkStatusRefreshed result)
        {
            if (!waitingForConnectivity)
            {
                return;
            }

            if (result.NetworkReachability != NetworkReachability.NotReachable)
            {
                Synchronize();
            }
        }

        #endregion
    }

}

