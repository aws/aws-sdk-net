/*
* Copyright 2010-2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License").
* You may not use this file except in compliance with the License.
* A copy of the License is located at
*
*  http://aws.amazon.com/apache2.0
*
* or in the "license" file accompanying this file. This file is distributed
* on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
* express or implied. See the License for the specific language governing
* permissions and limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// This class is responsible for keeping track of Retry capacity across different ServiceURLs.
    /// </summary>
    public class CapacityManager:IDisposable
    {
        //Dispose Method
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                _rwlock.Dispose();
                _disposed = true;
            }
        }

        public CapacityManager(int throttleRetryCount, int throttleRetryCost, int throttleCost)
        {
            THROTTLE_RETRY_REQUEST_COST = throttleRetryCost;
            THROTTLED_RETRIES = throttleRetryCount;
            THROTTLE_REQUEST_COST = throttleCost;
        }

        /// <summary>
        /// This method acquires a said retry capacity if the container has the capacity.
        /// </summary>
        /// <param name="retryCapacity">Contains the RetryCapacity object for the said ServiceURL.</param>
        public bool TryAcquireCapacity(RetryCapacity retryCapacity)
        {
            if (THROTTLE_RETRY_REQUEST_COST < 0)
            {
                return false;
            }
            lock (retryCapacity)
            {
                if (retryCapacity.AvailableCapacity - THROTTLE_RETRY_REQUEST_COST >= 0)
                {
                    retryCapacity.AvailableCapacity -= THROTTLE_RETRY_REQUEST_COST;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// This method calls a method to release capacity back 
        /// based on whether it was a successful response or a successful retry response. This is invoked by a retry request response.
        /// </summary>
        /// <param name="isRetryRequest">if this request is a retry, use a different capacity cost</param>
        /// <param name="retryCapacity">Contains the RetryCapacity object for the said ServiceURL.</param>
        public void TryReleaseCapacity(bool isRetryRequest,RetryCapacity retryCapacity) 
        {
            if(isRetryRequest)
            {
                ReleaseCapacity(THROTTLE_RETRY_REQUEST_COST,retryCapacity);
            }
            else
            {
                ReleaseCapacity(THROTTLE_REQUEST_COST,retryCapacity);
            }
        }

        /// <summary>
        /// Ths method fetches the RetryCapacity for the given ServiceURL from CapacityManager.CapacityContainer
        /// </summary>
        public RetryCapacity GetRetryCapacity(string serviceURL)
        {
            RetryCapacity retryCapacity;
            if (!(TryGetRetryCapacity(serviceURL, out retryCapacity)))
            {
                retryCapacity = AddNewRetryCapacity(serviceURL);
            }
            return retryCapacity;
        }

        private bool _disposed;
        //Dictionary that keeps track of the available capacity by ServiceURLs
        private static Dictionary<string, RetryCapacity> _serviceUrlToCapacityMap = new Dictionary<string, RetryCapacity>();
        //Read write slim lock for performing said operations on CapacityManager._serviceUrlToCapacityMap.
        private ReaderWriterLockSlim _rwlock = new ReaderWriterLockSlim();
        // This parameter sets the cost of making a retry call on a request.The default value is set at 5.
        private readonly int THROTTLE_RETRY_REQUEST_COST;
        //maximum capacity in a bucket set to 100.
        private readonly int THROTTLED_RETRIES;
        // For every successful request, lesser value capacity would be released. This
        // is done to ensure that the bucket has a strategy for filling up if an explosion of bad retry requests 
        // were to deplete the entire capacity.The default value is set at 1.
        private readonly int THROTTLE_REQUEST_COST;

        private bool TryGetRetryCapacity(string key, out RetryCapacity value)
        {
            _rwlock.EnterReadLock();
            try
            {
                if (_serviceUrlToCapacityMap.TryGetValue(key, out value))
                {
                    return true;
                }
                return false;
            }
            finally
            {
                _rwlock.ExitReadLock();
            }
        }

        private RetryCapacity AddNewRetryCapacity(string serviceURL)
        {
            RetryCapacity retryCapacity;
            _rwlock.EnterUpgradeableReadLock();
            try
            {
                if (!(_serviceUrlToCapacityMap.TryGetValue(serviceURL, out retryCapacity)))
                {
                    _rwlock.EnterWriteLock();
                    try
                    {
                        retryCapacity = new RetryCapacity(THROTTLE_RETRY_REQUEST_COST * THROTTLED_RETRIES);
                        _serviceUrlToCapacityMap.Add(serviceURL, retryCapacity);
                        return retryCapacity;
                    }
                    finally
                    {
                        _rwlock.ExitWriteLock();
                    }
                }
                else
                {
                    return retryCapacity;
                }
            }
            finally
            {
                _rwlock.ExitUpgradeableReadLock();
            }
        }

        /// <summary>
        /// This method releases capacity back. This is invoked by the TryReleaseCapacity method.
        /// </summary>
        /// <param name="retryCapacity">Contains the RetryCapacity object for the said ServiceURL.</param>
        /// <param name="capacity">The capacity that needs to be released based on whether it was a successful response or a successful retry response.</param>
        private static void ReleaseCapacity(int capacity, RetryCapacity retryCapacity)
        {
            if (retryCapacity.AvailableCapacity >= 0 && retryCapacity.AvailableCapacity < retryCapacity.MaxCapacity)
            {
                lock (retryCapacity)
                {
                    retryCapacity.AvailableCapacity = Math.Min((retryCapacity.AvailableCapacity + capacity), retryCapacity.MaxCapacity);
                }
            }
        }
    }
    /// <summary>
    /// This class is the RetryCapacity class for a given ServiceURL.
    /// </summary>
    public class RetryCapacity
    {
        //maximum capacity in a bucket.
        private readonly int _maxCapacity;
        //available ncapacity in a bucket for a given ServiceURL.
        public int AvailableCapacity { get; set; }
        //maximum capacity in a bucket.
        public int MaxCapacity
        {
            get
            {
                return _maxCapacity;
            }
        }

        public RetryCapacity(int maxCapacity)
        {
            _maxCapacity = maxCapacity;
            this.AvailableCapacity = maxCapacity;
        }
    }
}
