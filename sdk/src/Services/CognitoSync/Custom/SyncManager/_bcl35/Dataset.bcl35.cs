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
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading;


namespace Amazon.CognitoSync.SyncManager
{
    public partial class Dataset : IDisposable
    {
        private void DatasetSetupInternal()
        {
            NetworkChange.NetworkAvailabilityChanged += HandleNetworkChange;
        }

        #region Dispose Methods
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
                NetworkChange.NetworkAvailabilityChanged -= HandleNetworkChange;
                _disposed = true;
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Synchronize <see cref="Dataset"/> between local storage and remote storage.
        /// </summary>
        public virtual void Synchronize()
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                FireSyncFailureEvent(new NetworkException("Network connectivity unavailable."));
                return;
            }

            SynchronizeHelperAsync();
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
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                SynchronizeHelperAsync();
            }
            else
            {
                waitingForConnectivity = true;
            }
        }
        #endregion

        #region Private Methods
        private void HandleNetworkChange(object sender, NetworkAvailabilityEventArgs e)
        {
            if (!waitingForConnectivity)
            {
                return;
            }

            if (e.IsAvailable)
            {
                Synchronize();
            }
        }
        #endregion
    }
}

