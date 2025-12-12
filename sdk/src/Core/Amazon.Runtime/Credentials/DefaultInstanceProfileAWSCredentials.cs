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
using Amazon.Runtime.Internal.UserAgent;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime
{
    /// <summary>
    /// InstanceProfileAWSCredentials allows configuring Roles and every instance hits IMDS individually.  
    /// This class has a singleton timer task that caches instance profile credentials every 2 minutes.
    /// </summary>
    internal class DefaultInstanceProfileAWSCredentials : AWSCredentials, IDisposable
    {
        private static readonly object _instanceLock = new object();

        // Semaphore used to ensure only one thread/task access IMDS at a time.
        // In the GetCredentials call once the lock is obtained, a second check is made
        // to see if the credentials have already been refreshed so only one access to IMDS
        // is required across multiple threads/tasks when credentials are expired.
        private readonly SemaphoreSlim _credentialsSemaphore = new SemaphoreSlim(initialCount: 1, maxCount: 1);

        private readonly Timer _credentialsRetrieverTimer;
        private volatile RefreshingAWSCredentials.CredentialsRefreshState _lastRetrievedCredentials;

        /// <summary>
        /// Control flag: in the event IMDS returns an expired credential, a refresh must be immediately
        /// retried, if it continues to fail, then retry every 5-10 minutes.
        /// </summary>
        private volatile bool _previousRefreshFailed = false;

        private readonly IIMDSAccessMethods _imdsAccessMethods;
        private readonly TimeSpan _refreshRate = TimeSpan.FromMinutes(2); // EC2 refreshes credentials 2 min before expiration

        private static readonly TimeSpan _neverTimespan = TimeSpan.FromMilliseconds(-1);
        private const string FailedToGetCredentialsMessage = "Failed to retrieve credentials from EC2 Instance Metadata Service.";
        private const string FailedToGetLockMessage = "Failed to obtain lock to refresh credentials from EC2 Instance Metadata Service.";
        private static readonly TimeSpan _credentialsLockTimeout = TimeSpan.FromMinutes(1);

        private const string _usingExpiredCredentialsFromIMDS =
            "Attempting credential expiration extension due to a credential service availability issue. " +
            "A refresh of these credentials will be attempted again in 5-10 minutes.";

        private static DefaultInstanceProfileAWSCredentials _instance;

        public static DefaultInstanceProfileAWSCredentials Instance
        {
            get
            {
                IMDSAccessMethods.DefaultInstance.CheckIsIMDSEnabled();

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
            _imdsAccessMethods = new IMDSAccessMethods();

            // if IMDS is turned off, no need to spin up the timer task
            if (!EC2InstanceMetadata.IsIMDSEnabled)
            {
                return;
            }

            _credentialsRetrieverTimer = new Timer(RenewCredentials, null, TimeSpan.Zero, _neverTimespan); // This invokes synchronous calls in seperate thread.
            FeatureIdSources.Add(UserAgentFeatureId.CREDENTIALS_IMDS);
        }

        internal static DefaultInstanceProfileAWSCredentials CreateTestDefaultInstanceProfileAWSCredentials(
            IIMDSAccessMethods imdsAccessMethods,
            TimeSpan refreshRate)
        {
            return new DefaultInstanceProfileAWSCredentials(
                imdsAccessMethods,
                refreshRate);
        }

        private DefaultInstanceProfileAWSCredentials(
            IIMDSAccessMethods imdsAccessMethods,
            TimeSpan refreshRate)
        {
            _imdsAccessMethods = imdsAccessMethods;
            _refreshRate = refreshRate;

            _credentialsRetrieverTimer = new Timer(RenewCredentials, null, TimeSpan.Zero, _neverTimespan); // This invokes synchronous calls in seperate thread.
            FeatureIdSources.Add(UserAgentFeatureId.CREDENTIALS_IMDS);
        }

        #region Overrides

        /// <summary>
        /// Returns a copy of the most recent instance profile credentials.
        /// </summary>
        public override ImmutableCredentials GetCredentials()
        {
            // The logger instance is not cached as member variable because the static constructor
            // can fire before the adaptor plug ins have been registered causing them to not
            // send the logs to the correct destination.
            var logger = Logger.GetLogger(typeof(DefaultInstanceProfileAWSCredentials));
            _imdsAccessMethods.CheckIsIMDSEnabled();
            ImmutableCredentials credentials;

            // Copy current assignment of _lastRetrievedCredentials into a local variable in case another thread updates it.
            var localLastRetrievedCredentials = _lastRetrievedCredentials;

            if (null != localLastRetrievedCredentials && !localLastRetrievedCredentials.IsExpiredWithin(TimeSpan.Zero))
            {
                credentials = localLastRetrievedCredentials.Credentials;
            }
            else
            {
                logger.DebugFormat("Waiting on lock to refresh ECS IMDS");
                if (_credentialsSemaphore.Wait(_credentialsLockTimeout))
                {
                    try
                    {
                        logger.DebugFormat("Obtained lock to refresh ECS IMDS");

                        // Check to see if another thread has already refreshed the credentials
                        localLastRetrievedCredentials = _lastRetrievedCredentials;
                        if (null != localLastRetrievedCredentials && !localLastRetrievedCredentials.IsExpiredWithin(TimeSpan.Zero))
                        {
                            logger.DebugFormat("Another thread has refreshed credentials and reusing those credentials");
                            credentials = localLastRetrievedCredentials.Credentials;
                        }
                        else
                        {
                            logger.DebugFormat("Fetching credentials from ECS IMDS");
                            _lastRetrievedCredentials = _imdsAccessMethods.FetchCredentials();
                            // if credentials are expired, we'll still return them, but log a message about
                            // them being expired.
                            if (_lastRetrievedCredentials.IsExpiredWithin(TimeSpan.Zero))
                            {
                                // If the previous refresh did not fail then this is the first failure and write the single
                                // expired warning log message for this specific incident.
                                if (!_previousRefreshFailed)
                                {
                                    logger.InfoFormat(_usingExpiredCredentialsFromIMDS);
                                }

                                _previousRefreshFailed = true;
                            }
                            else
                            {
                                _previousRefreshFailed = false;
                            }

                            credentials = _lastRetrievedCredentials.Credentials;
                        }
                    }
                    finally
                    {
                        logger.DebugFormat("Releasing lock after refreshing ECS IMDS");
                        SafeReleaseSemaphore();
                    }
                }
                else
                {
                    throw new AmazonServiceException(FailedToGetLockMessage);
                }
            }

            if (credentials == null)
            {
                throw new AmazonServiceException(FailedToGetCredentialsMessage);
            }

            return credentials;
        }

        /// <summary>
        /// Returns a copy of the most recent instance profile credentials.
        /// </summary>
        public override async Task<ImmutableCredentials> GetCredentialsAsync()
        {
            // The logger instance is not cached as member variable because the static constructor
            // can fire before the adaptor plug ins have been registered causing them to not
            // send the logs to the correct destination.
            var logger = Logger.GetLogger(typeof(DefaultInstanceProfileAWSCredentials));
            _imdsAccessMethods.CheckIsIMDSEnabled();
            ImmutableCredentials credentials;

            // Copy current assignment of _lastRetrievedCredentials into a local variable in case another thread updates it.
            var localLastRetrievedCredentials = _lastRetrievedCredentials;

            if (null != localLastRetrievedCredentials && !localLastRetrievedCredentials.IsExpiredWithin(TimeSpan.Zero))
            {
                credentials = localLastRetrievedCredentials.Credentials;
            }
            else
            {
                logger.DebugFormat("Waiting on lock to refresh ECS IMDS");
                if (await _credentialsSemaphore.WaitAsync(_credentialsLockTimeout).ConfigureAwait(false))
                {
                    try
                    {
                        logger.DebugFormat("Obtained lock to refresh ECS IMDS");

                        // Check to see if another thread has already refreshed the credentials
                        localLastRetrievedCredentials = _lastRetrievedCredentials;
                        if (null != localLastRetrievedCredentials && !localLastRetrievedCredentials.IsExpiredWithin(TimeSpan.Zero))
                        {
                            logger.DebugFormat("Another thread has refreshed credentials and reusing those credentials");
                            credentials = localLastRetrievedCredentials.Credentials;
                        }
                        else
                        {
                            logger.DebugFormat("Fetching credentials from ECS IMDS");
                            _lastRetrievedCredentials = await _imdsAccessMethods.FetchCredentialsAsync().ConfigureAwait(false);
                            // if credentials are expired, we'll still return them, but log a message about
                            // them being expired.
                            if (_lastRetrievedCredentials.IsExpiredWithin(TimeSpan.Zero))
                            {
                                // If the previous refresh did not fail then this is the first failure and write the single
                                // expired warning log message for this specific incident.
                                if (!_previousRefreshFailed)
                                {
                                    logger.InfoFormat(_usingExpiredCredentialsFromIMDS);
                                }

                                _previousRefreshFailed = true;                                
                            }
                            else
                            {
                                _previousRefreshFailed = false;
                            }

                            credentials = _lastRetrievedCredentials.Credentials;
                        }
                    }
                    finally
                    {
                        logger.DebugFormat("Releasing lock after refreshing ECS IMDS");
                        SafeReleaseSemaphore();
                    }
                }
                else
                {
                    throw new AmazonServiceException(FailedToGetLockMessage);
                }
            }

            if (credentials == null)
            {
                throw new AmazonServiceException(FailedToGetCredentialsMessage);
            }

            return credentials;
        }

        #endregion

        #region Private members
        private void RenewCredentials(object _)
        {
            var logger = Logger.GetLogger(typeof(DefaultInstanceProfileAWSCredentials));

            // This would only be true for unit tests that want to disable the timer-based refresh for
            // more predictable testing.
            if (_refreshRate <= TimeSpan.Zero)
                return;

            // By default, the refreshRate will continue to be 
            // _refreshRate, but if FetchCredentials() returns an expired credential,
            // the refresh rate will be adjusted
            var refreshRate = _refreshRate;
            var lockedObtained = false;
            try
            {
                logger.DebugFormat("[Background Timer] Waiting on lock to refresh ECS IMDS");
                if (!_isDisposed && _credentialsSemaphore.Wait(_credentialsLockTimeout))
                {
                    lockedObtained = true;
                    logger.DebugFormat("[Background Timer] Obtained lock to refresh ECS IMDS");

                    // if FetchCredentials() call were to fail, _lastRetrievedCredentials
                    // would remain unchanged and would continue to be returned in GetCredentials()
                    _lastRetrievedCredentials = _imdsAccessMethods.FetchCredentials();

                    // If the previous refresh do not fail but this refresh did fail retry immediately.
                    if (!_previousRefreshFailed && _lastRetrievedCredentials.IsExpiredWithin(TimeSpan.Zero))
                    {
                        logger.DebugFormat("[Background Timer] First refresh failed and trying an immediate retry fetching credentials");
                        _lastRetrievedCredentials = _imdsAccessMethods.FetchCredentials();
                    }

                    // if credentials are expired, we'll still return them, but log a message about them being expired.
                    if (_lastRetrievedCredentials.IsExpiredWithin(TimeSpan.Zero))
                    {
                        logger.DebugFormat("[Background Timer] Credential refresh failed");
                        // If the previous refresh did not fail then this is the first failure and write the single
                        // expired warning log message for this specific incident.
                        if (!_previousRefreshFailed)
                        {
                            logger.InfoFormat(_usingExpiredCredentialsFromIMDS);
                        }

                        _previousRefreshFailed = true;
                    }
                    else
                    {
                        logger.DebugFormat("[Background Timer] Credential refresh succeeded");
                        _previousRefreshFailed = false;
                    }


                    // first failure refresh failed OR subsequent refresh failed.
                    if (_lastRetrievedCredentials.IsExpiredWithin(TimeSpan.Zero))
                    {
                        // relax the refresh rate to at least 5 minutes
                        refreshRate = TimeSpan.FromMinutes(new Random().Next(5, 11));
                    }
                }
                else
                {
                    logger.InfoFormat("[Background Timer] {0}", FailedToGetLockMessage);
                }

            }
            catch (OperationCanceledException e)
            {
                logger.Error(e, "[Background Timer] RenewCredentials task canceled");
            }
            catch (Exception e)
            {
                // we want to suppress any exceptions from this timer task.
                logger.Error(e, FailedToGetCredentialsMessage);
            }
            finally
            {
                // re-invoke this task once after time specified by refreshRate set at beginning of this method
                _credentialsRetrieverTimer.Change(refreshRate, _neverTimespan);

                if (lockedObtained)
                    SafeReleaseSemaphore();
            }
        }

        // Helper to release the semaphore safely if Dispose() races with an in-flight caller/timer.
        private void SafeReleaseSemaphore()
        {
            try
            {
                _credentialsSemaphore.Release();
            }
            catch (ObjectDisposedException)
            {
                // Semaphore already disposed — safe to ignore.
                // This can happen during the Dispose of this method and race conditions disposing the timer.
            }
            catch (SemaphoreFullException)
            {
                // Defensive: ignore if Release would overflow the semaphore.
            }
        }

        internal interface IIMDSAccessMethods
        {
            RefreshingAWSCredentials.CredentialsRefreshState FetchCredentials();
            Task<RefreshingAWSCredentials.CredentialsRefreshState> FetchCredentialsAsync();
            void CheckIsIMDSEnabled();
        }


        private class IMDSAccessMethods : IIMDSAccessMethods
        {
            public static IMDSAccessMethods DefaultInstance = new IMDSAccessMethods();

            public RefreshingAWSCredentials.CredentialsRefreshState FetchCredentials()
            {
                var securityCredentials = EC2InstanceMetadata.IAMSecurityCredentials;
                if (securityCredentials == null)
                    throw new AmazonServiceException("Unable to get IAM security credentials from EC2 Instance Metadata Service.");

                IAMSecurityCredentialMetadata metadata = GetMetadataFromSecurityCredentials(securityCredentials);

                return new RefreshingAWSCredentials.CredentialsRefreshState(
                    new ImmutableCredentials(metadata.AccessKeyId, metadata.SecretAccessKey, metadata.Token),
                    metadata.Expiration);
            }

            public async Task<RefreshingAWSCredentials.CredentialsRefreshState> FetchCredentialsAsync()
            {
                var securityCredentials = await EC2InstanceMetadata.GetIAMSecurityCredentialsAsync().ConfigureAwait(false);
                if (securityCredentials == null)
                    throw new AmazonServiceException("Unable to get IAM security credentials from EC2 Instance Metadata Service.");

                IAMSecurityCredentialMetadata metadata = GetMetadataFromSecurityCredentials(securityCredentials);

                return new RefreshingAWSCredentials.CredentialsRefreshState(
                    new ImmutableCredentials(metadata.AccessKeyId, metadata.SecretAccessKey, metadata.Token),
                    metadata.Expiration);
            }

            private IAMSecurityCredentialMetadata GetMetadataFromSecurityCredentials(System.Collections.Generic.IDictionary<string, IAMSecurityCredentialMetadata> securityCredentials)
            {
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

                return metadata;
            }

            public void CheckIsIMDSEnabled()
            {
                // keep this behavior consistent with GetObjectFromResponse case.
                if (!EC2InstanceMetadata.IsIMDSEnabled) throw new AmazonServiceException("Unable to retrieve credentials.");
            }
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
                    // Mark disposed early to reduce race window with the timer.
                    _isDisposed = true;

                    // Stop and dispose timer while holding the instance lock to avoid
                    // concurrent RenewCredentials runs racing with disposal.
                    lock (_instanceLock)
                    {
                        try
                        {
                            _credentialsRetrieverTimer?.Change(Timeout.Infinite, Timeout.Infinite);
                        }
                        catch (ObjectDisposedException) { }

                        _credentialsRetrieverTimer?.Dispose();
                        _instance = null;
                    }

                    // Dispose the semaphore after timer is stopped/disposed.
                    _credentialsSemaphore.Dispose();
                }

                // keep the flag set
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
