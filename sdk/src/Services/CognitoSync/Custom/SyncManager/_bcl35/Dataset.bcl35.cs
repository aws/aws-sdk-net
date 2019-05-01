//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// SPDX-License-Identifier: Apache-2.0
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
        /// <seealso href="http://docs.aws.amazon.com/cognito/latest/developerguide/synchronizing-data.html#synchronizing-local-data">Amazon Cognito Sync Dev. Guide - Synchronizing Local Data with the Sync Store</seealso>
        public virtual void Synchronize()
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                FireSyncFailureEvent(new NetworkException("Network connectivity unavailable."));
                return;
            }

            SynchronizeHelper();
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
                SynchronizeHelper();
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

        private void SynchronizeHelper()
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

                SynchornizeInternal();
            }
            catch (Exception e)
            {
                FireSyncFailureEvent(e);
                _logger.Error(e, "");
            }
        }

    }
}

