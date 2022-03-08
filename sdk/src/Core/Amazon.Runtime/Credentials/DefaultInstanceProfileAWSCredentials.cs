/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Globalization;
using System.Threading;
#if AWS_ASYNC_API
using System.Threading.Tasks;
#endif

namespace Amazon.Runtime
{
    /// <summary>
    /// InstanceProfileAWSCredentials allows configuring Roles and every instance hits IMDS individually.  
    /// This class has a singleton timer task that caches instance profile credentials every 2 minutes.
    /// </summary>
    internal class DefaultInstanceProfileAWSCredentials : AWSCredentials, IDisposable
    {
        private static readonly object _instanceLock = new object();
        private readonly ReaderWriterLockSlim _credentialsLock = new ReaderWriterLockSlim(); // Lock to control getting credentials across multiple threads.

        private readonly Timer _credentialsRetrieverTimer;
        private RefreshingAWSCredentials.CredentialsRefreshState _lastRetrievedCredentials;
        private Logger _logger;

        private static readonly TimeSpan _neverTimespan = TimeSpan.FromMilliseconds(-1);
        private static readonly TimeSpan _refreshRate = TimeSpan.FromMinutes(2); // EC2 refreshes credentials 5 min before expiration
        private const string FailedToGetCredentialsMessage = "Failed to retrieve credentials from EC2 Instance Metadata Service.";
        private static readonly TimeSpan _credentialsLockTimeout = TimeSpan.FromSeconds(5);

        private const string _usingExpiredCredentialsFromIMDS =
            "Attempting credential expiration extension due to a credential service availability issue. " +
            "A refresh of these credentials will be attempted again in 5-15 minutes.";

        private static DefaultInstanceProfileAWSCredentials _instance;

        public static DefaultInstanceProfileAWSCredentials Instance
        {
            get
            {
                CheckIsIMDSEnabled();

                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DefaultInstanceProfileAWSCredentials();
                        }
                    }
                }

                return _instance;
            }
        }

        private DefaultInstanceProfileAWSCredentials()
        {
            // if IMDS is turned off, no need to spin up the timer task
            if (!EC2InstanceMetadata.IsIMDSEnabled) return;

            _logger = Logger.GetLogger(typeof(DefaultInstanceProfileAWSCredentials));
            
            _credentialsRetrieverTimer = new Timer(RenewCredentials, null, TimeSpan.Zero, _neverTimespan);
        }

        #region Overrides
        /// <summary>
        /// Returns a copy of the most recent instance profile credentials.
        /// </summary>
        public override ImmutableCredentials GetCredentials()
        {
            CheckIsIMDSEnabled();
            ImmutableCredentials credentials = null;

            // Try to acquire read lock. The thread would be blocked if another thread has write lock.
            if (_credentialsLock.TryEnterReadLock(_credentialsLockTimeout))
            {
                try
                {
                    if (null != _lastRetrievedCredentials)
                    {
                        // if credentials are expired, we'll still return them, but log a message about
                        // them being expired.
                        if (_lastRetrievedCredentials.IsExpiredWithin(TimeSpan.Zero))
                        {
                            _logger.InfoFormat(_usingExpiredCredentialsFromIMDS);
                        }

                        return _lastRetrievedCredentials?.Credentials.Copy();
                    }
                }
                finally
                {
                    _credentialsLock.ExitReadLock();
                }
            }

            // If there's no credentials cached, hit IMDS directly. Try to acquire write lock.
            if (_credentialsLock.TryEnterWriteLock(_credentialsLockTimeout))
            {
                try
                {
                    // Check for last retrieved credentials again in case other thread might have already fetched it.
                    if (null == _lastRetrievedCredentials)
                    {
                        _lastRetrievedCredentials = FetchCredentials();
                    }

                    // if credentials are expired, we'll still return them, but log a message about
                    // them being expired.
                    if (_lastRetrievedCredentials.IsExpiredWithin(TimeSpan.Zero))
                    {
                        _logger.InfoFormat(_usingExpiredCredentialsFromIMDS);
                    }

                    credentials = _lastRetrievedCredentials.Credentials?.Copy();
                }
                finally
                {
                    _credentialsLock.ExitWriteLock();
                }
            }

            if (credentials == null)
            {
                throw new AmazonServiceException(FailedToGetCredentialsMessage);
            }

            return credentials;
        }

#if AWS_ASYNC_API
        /// <summary>
        /// Returns a copy of the most recent instance profile credentials.
        /// </summary>
        public override Task<ImmutableCredentials> GetCredentialsAsync()
        {
            return Task.FromResult<ImmutableCredentials>(GetCredentials());
        }
#endif
#endregion

        #region Private members
        private void RenewCredentials(object unused)
        {
            // By default, the refreshRate will continue to be 
            // _refreshRate, but if FetchCredentials() returns an expired credential,
            // the refresh rate will be adjusted
            var refreshRate = _refreshRate;

            try
            {
                // if FetchCredentials() call were to fail, _lastRetrievedCredentials
                // would remain unchanged and would continue to be returned in GetCredentials()
                _lastRetrievedCredentials = FetchCredentials();

                if (_lastRetrievedCredentials.IsExpiredWithin(TimeSpan.Zero))
                {
                    // relax the refresh rate to at least 5 minutes
                    refreshRate = TimeSpan.FromMinutes(new Random().Next(5, 16));
                }
            }
            catch (OperationCanceledException e)
            {
                _logger.Error(e, "RenewCredentials task canceled");
            }
            catch (Exception e)
            {
                // we want to suppress any exceptions from this timer task.
                _logger.Error(e, FailedToGetCredentialsMessage);
            }
            finally
            {
                // re-invoke this task once after time specified by refreshRate set at beginning of this method
                _credentialsRetrieverTimer.Change(refreshRate, _neverTimespan);
            }
        }

        private static RefreshingAWSCredentials.CredentialsRefreshState FetchCredentials()
        {
            var securityCredentials = EC2InstanceMetadata.IAMSecurityCredentials;
            if (securityCredentials == null)
                throw new AmazonServiceException("Unable to get IAM security credentials from EC2 Instance Metadata Service.");

            string firstRole = null;
            foreach (var role in securityCredentials.Keys)
            {
                firstRole = role;
                break;
            }

            if (string.IsNullOrEmpty(firstRole))
                throw new AmazonServiceException("Unable to get EC2 instance role from EC2 Instance Metadata Service.");

            var metadata = securityCredentials[firstRole];
            if (metadata == null)
                throw new AmazonServiceException("Unable to get credentials for role \"" + firstRole + "\" from EC2 Instance Metadata Service.");

            return new RefreshingAWSCredentials.CredentialsRefreshState(
                new ImmutableCredentials(metadata.AccessKeyId, metadata.SecretAccessKey, metadata.Token),
                metadata.Expiration);
        }

        private static void CheckIsIMDSEnabled()
        {
            // keep this behavior consistent with GetObjectFromResponse case.
            if (!EC2InstanceMetadata.IsIMDSEnabled) throw new AmazonServiceException("Unable to retrieve credentials.");
        }
#endregion

#region IDisposable Support
        private bool _isDisposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    lock (_instanceLock)
                    {
                        _credentialsRetrieverTimer.Dispose();
                        _logger = null;
                        _instance = null;
                    }
                }

                _isDisposed = true;
            }
        }

        /// <summary>
        /// Dispose this object and all related resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
#endregion
    }
}
