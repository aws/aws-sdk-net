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

namespace Amazon.Runtime
{
    /// <summary>
    /// Abstract class for automatically refreshing AWS credentials
    /// </summary>
    public abstract class RefreshingAWSCredentials : AWSCredentials, IDisposable
    {
        private Logger _logger = Logger.GetLogger(typeof(RefreshingAWSCredentials));

        /// <inheritdoc />
        public override DateTime? Expiration
        {
            get
            {
                if (currentState == null)
                {
                    return null;
                }
                return currentState.Expiration.ToUniversalTime();
            }
        }

        #region Refresh data

        /// <summary>
        /// Refresh state container consisting of credentials
        /// and the date of the their expiration
        /// </summary>
        public class CredentialsRefreshState
        {
            public ImmutableCredentials Credentials { get; set; }
            public DateTime Expiration { get; set; }

            public CredentialsRefreshState()
            {
            }

            public CredentialsRefreshState(ImmutableCredentials credentials, DateTime expiration)
            {
                Credentials = credentials;
                Expiration = expiration;
            }

            internal bool IsExpiredWithin(TimeSpan preemptExpiryTime)
            {
                var now = AWSSDKUtils.CorrectedUtcNow;
                var exp = Expiration.ToUniversalTime();
                return now > exp - preemptExpiryTime;
            }

            internal TimeSpan GetTimeToLive(TimeSpan preemptExpiryTime)
            {
                var now = AWSSDKUtils.CorrectedUtcNow;
                var exp = Expiration.ToUniversalTime();

                return exp - now + preemptExpiryTime;
            }
        }

        /// <summary>
        /// Represents the current state of the Credentials.
        /// </summary>
        /// <remarks>This can be cleared without synchronization.</remarks>
        protected CredentialsRefreshState currentState;

        #region Private members

        private TimeSpan _preemptExpiryTime = TimeSpan.FromMinutes(0);
        private bool _disposed;

        /// <summary>
        /// Semaphore to control thread access to GetCredentialsAsync method.
        /// The semaphore will allow only one thread to generate new credentials and
        /// update the current state.
        /// </summary>
        private readonly SemaphoreSlim _updateGeneratedCredentialsSemaphore = new SemaphoreSlim(1, 1);

        #endregion

        #endregion

        #region Properties

        /// <summary>
        /// The time before actual expiration to expire the credentials.
        /// Property cannot be set to a negative TimeSpan.
        /// </summary>
        public TimeSpan PreemptExpiryTime
        {
            get { return _preemptExpiryTime; }
            set
            {
                if (value < TimeSpan.Zero)
                    throw new ArgumentOutOfRangeException("value", "PreemptExpiryTime cannot be negative");
                _preemptExpiryTime = value;
            }
        }

        #endregion

        #region Override methods

        /// <summary>
        /// Returns an instance of ImmutableCredentials for this instance
        /// </summary>
        /// <returns></returns>
        public override sealed ImmutableCredentials GetCredentials()
        {
            // We save the currentState as it might be modified or cleared.
            var tempState = currentState;

            var ttl = tempState?.GetTimeToLive(PreemptExpiryTime);

            if (ttl > TimeSpan.Zero)
            {
                if (ttl < PreemptExpiryTime)
                {
                    // background refresh (fire & forget)
                    if (_updateGeneratedCredentialsSemaphore.Wait(0))
                    {
                        _ = System.Threading.Tasks.Task.Run(GenerateCredentialsAndUpdateState);
                    }
                }
            }
            else
            {
                // If credentials are expired, update
                _updateGeneratedCredentialsSemaphore.Wait();
                tempState = GenerateCredentialsAndUpdateState();
            }

            return tempState.Credentials;

            CredentialsRefreshState GenerateCredentialsAndUpdateState()
            {
                System.Diagnostics.Debug.Assert(_updateGeneratedCredentialsSemaphore.CurrentCount == 0);

                try
                {
                    var tempState = currentState;
                    // double-check that the credentials still need updating
                    // as it's possible that multiple requests were queued acquiring the semaphore
                    if (ShouldUpdateState(tempState))
                    {
                        tempState = GenerateNewCredentials();
                        UpdateToGeneratedCredentials(tempState);
                        currentState = tempState;
                    }

                    return tempState;
                }
                finally
                {
                    _updateGeneratedCredentialsSemaphore.Release();
                }
            }
        }

        public override sealed async System.Threading.Tasks.Task<ImmutableCredentials> GetCredentialsAsync()
        {
            // We save the currentState as it might be modified or cleared.
            var tempState = currentState;

            var ttl = tempState?.GetTimeToLive(PreemptExpiryTime);

            if (ttl > TimeSpan.Zero)
            {
                if (ttl < PreemptExpiryTime)
                {
                    // background refresh (fire & forget)
                    if (_updateGeneratedCredentialsSemaphore.Wait(0))
                    {
                        _ = GenerateCredentialsAndUpdateStateAsync();
                    }
                }
            }
            else
            {
                // If credentials are expired, update
                await _updateGeneratedCredentialsSemaphore.WaitAsync().ConfigureAwait(false);
                tempState = await GenerateCredentialsAndUpdateStateAsync().ConfigureAwait(false);
            }

            return tempState.Credentials;

            async System.Threading.Tasks.Task<CredentialsRefreshState> GenerateCredentialsAndUpdateStateAsync()
            {
                System.Diagnostics.Debug.Assert(_updateGeneratedCredentialsSemaphore.CurrentCount == 0);

                try
                {
                    var tempState = currentState;
                    // double-check that the credentials still need updating
                    // as it's possible that multiple requests were queued acquiring the semaphore
                    if (ShouldUpdateState(tempState))
                    {
                        tempState = await GenerateNewCredentialsAsync().ConfigureAwait(false);
                        UpdateToGeneratedCredentials(tempState);
                        currentState = tempState;
                    }

                    return tempState;
                }
                finally
                {
                    _updateGeneratedCredentialsSemaphore.Release();
                }
            }
        }

        #endregion

        #region Private/protected credential update methods

        private void UpdateToGeneratedCredentials(CredentialsRefreshState state)
        {
            // Check if the new credentials are already expired
            if (ShouldUpdateState(state))
            {
                string errorMessage;
                if (state == null)
                {
                    errorMessage = "Unable to generate temporary credentials";
                }
                else
                {
                    errorMessage = string.Format(CultureInfo.InvariantCulture,
                        "The retrieved credentials have already expired: Now = {0}, Credentials expiration = {1}",
                        AWSSDKUtils.CorrectedUtcNow, state.Expiration);
                }

                throw new AmazonClientException(errorMessage);
            }

            // Offset the Expiration by PreemptExpiryTime. This produces the expiration window 
            // where the credentials should be updated before they actually expire.
            state.Expiration -= PreemptExpiryTime;

            if (ShouldUpdateState(state))
            {
                // This could happen if the default value of PreemptExpiryTime is
                // overridden and set too high such that ShouldUpdate returns true.
                var logger = Logger.GetLogger(typeof(RefreshingAWSCredentials));
                logger.InfoFormat(
                    "The preempt expiry time is set too high: Current time = {0}, Credentials expiry time = {1}, Preempt expiry time = {2}.",
                    AWSSDKUtils.CorrectedUtcNow,
                    state.Expiration, PreemptExpiryTime);
            }
        }

        /// <summary>
        /// Test credentials existence and expiration time
        /// should update if:
        /// credentials have not been loaded yet
        /// it's past the expiration time. At this point currentState.Expiration may
        /// have the PreemptExpiryTime baked into to the expiration from a call to
        /// UpdateToGeneratedCredentials but it may not if this is new application load.
        /// </summary>
        protected bool ShouldUpdate
        {
            get
            {
                return ShouldUpdateState(currentState);
            }
        }

        // Test credentials existence and expiration time
        // should update if:
        //  credentials have not been loaded yet
        // it's past the expiration time. At this point currentState.Expiration may 
        // have the PreemptExpiryTime baked into to the expiration from a call to 
        // UpdateToGeneratedCredentials but it may not if this is new application 
        // load.
        private bool ShouldUpdateState(CredentialsRefreshState state)
        {
            // it's past the expiration time. At this point currentState.Expiration may 
            // have the PreemptExpiryTime baked into to the expiration from a call to 
            // UpdateToGeneratedCredentials but it may not if this is new application 
            // load.
            var isExpired = state?.IsExpiredWithin(TimeSpan.Zero);
            if (isExpired == true)
            {
                var logger = Logger.GetLogger(typeof(RefreshingAWSCredentials));
                logger.InfoFormat("Determined refreshing credentials should update. Expiration time: {0}, Current time: {1}",
                                state.Expiration.Add(PreemptExpiryTime).ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.f ffffffK", CultureInfo.InvariantCulture),
                                AWSSDKUtils.CorrectedUtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture));
            }

            return isExpired ?? true;
        }

        /// <summary>
        /// When overridden in a derived class, generates new credentials and new expiration date.
        /// 
        /// Called on first credentials request and when expiration date is in the past.
        /// </summary>
        /// <returns></returns>
        protected virtual CredentialsRefreshState GenerateNewCredentials()
        {
            throw new NotImplementedException();
        }

        /// <summary> 
        /// When overridden in a derived class, generates new credentials and new expiration date.
        /// 
        /// Called on first credentials request and when expiration date is in the past.
        /// </summary>
        /// <returns></returns>
        protected virtual System.Threading.Tasks.Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
        {
            return System.Threading.Tasks.Task.Run(() => this.GenerateNewCredentials());
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                _updateGeneratedCredentialsSemaphore.Dispose();
            }

            _disposed = true;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Clears currently-stored credentials, forcing the next GetCredentials call to generate new credentials.
        /// </summary>
        public virtual void ClearCredentials()
        {
            currentState = null;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}