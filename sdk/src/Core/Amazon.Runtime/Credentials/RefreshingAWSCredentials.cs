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
using Amazon.Util.Internal;
using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime
{
    /// <summary>
    /// Abstract class for automatically refreshing AWS credentials
    /// </summary>
    public abstract class RefreshingAWSCredentials : AWSCredentials, IDisposable
    {
        private readonly Logger _logger = Logger.GetLogger(typeof(RefreshingAWSCredentials));
        protected readonly ITimeProvider _timeProvider;

        protected RefreshingAWSCredentials() : this(DefaultTimeProvider.Instance) { }

        protected RefreshingAWSCredentials(ITimeProvider timeProvider) 
            => _timeProvider = timeProvider ?? DefaultTimeProvider.Instance;

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
            private readonly ITimeProvider _timeProvider;

            public ImmutableCredentials Credentials { get; set; }
            public DateTime Expiration { get; set; }

            public CredentialsRefreshState() : this(null, default) { }

            public CredentialsRefreshState(ImmutableCredentials credentials, DateTime expiration) 
                : this (credentials, expiration, DefaultTimeProvider.Instance) { }

            public CredentialsRefreshState(ImmutableCredentials credentials, DateTime expiration, ITimeProvider timeProvider)
            {
                Credentials = credentials;
                Expiration = expiration;
                _timeProvider = timeProvider ?? DefaultTimeProvider.Instance;
            }

            internal bool IsExpiredWithin(TimeSpan preemptExpiryTime)
            {
                var now = _timeProvider.CorrectedUtcNow;
                var exp = Expiration.ToUniversalTime();
                return now > exp - preemptExpiryTime;
            }
        }

        /// <summary>
        /// Represents the current state of the Credentials.
        /// </summary>
        /// <remarks>This can be cleared without synchronization.</remarks>
        protected volatile CredentialsRefreshState currentState;

        #region Private members

        private TimeSpan _preemptExpiryTime = TimeSpan.FromMinutes(0);
        private TimeSpan _expirationBuffer = TimeSpan.FromMinutes(1);

        private bool _disposed;

        private readonly SemaphoreSlim _updateGeneratedCredentialsSemaphore = new SemaphoreSlim(1, 1);
        
        /// <summary>
        /// Tracks the current state of background credentials refresh.
        /// </summary>
        private enum CredentialsLoadState
        {
            /// <summary>
            /// No background refresh is currently in progress.
            /// This is the default state, where credentials are either valid or expired.
            /// </summary>
            NotLoading,

            /// <summary>
            /// A background refresh is currently in progress.
            /// This means we're within the preempt expiry window, and credentials are still valid.
            /// </summary>
            Loading,
        }

        // Note this is purposefuly marked as volatile since it is modified by multiple threads. Read the comments
        // in the GetCredentials method for more information on the locking flow and how this is used.
        private volatile CredentialsLoadState currentLoadState;

        #endregion

        #endregion

        #region Properties

        /// <summary>
        /// If credentials are still valid but the expiration is within the Expiration minus PreemptExpiryTime a
        /// background refresh of the credentials will be triggered.
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

        /// <summary>
        /// The time subtracted from the expiration provided by the credentials provider and then used for determining 
        /// if the credentials are expired. This provides a buffer to avoid corner case issues of processing time
        /// on the client side before the credentials are actually used for signing and validation on the server side.
        /// </summary>
        public TimeSpan ExpirationBuffer
        {
            get { return _expirationBuffer; }
            set
            {
                if (value < TimeSpan.Zero)
                    throw new ArgumentOutOfRangeException("value", "ExpirationBuffer cannot be negative");
                _expirationBuffer = value;
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

            // Before acquiring the lock, check if we need to refresh credentials. This is essentially the read only section
            // and going into the if block is the costly write section. Majority of threads going through this path will stay
            // in the read section avoiding blocking on the semaphore. Execution only goes into the write section when credentials
            // are nearing expiration or already expired.
            //
            // There are two phases of credentials needing to be refreshed:
            // 
            // Credentials are expired. In that case the lock will be acquired and credential refresh will be blocking further 
            // execution until new credentials are retrieved. Once credentials are retrieved and the lock is released any other
            // threads that were blocked due to expired credentials will one by one acquire the lock and see that 
            // new credentials are present and use those refreshed credentials. 
            //
            // Credential epiration in preempt window. This is the case credentials are still valid but to avoid a later
            // blocking expiration refresh a background refresh is triggered. Only one background refresh will be triggered
            // which is controlled by setting currentLoadState to Loading while the lock is held.
            // Any other threads that come through in either the read or write section in the prempt window will see the 
            // currentLoadState is Loading and not trigger another background refresh. The current credentials will be returned
            // instead of waiting for the background refresh to complete since they are still valid.
            //
            // The background refresh task is in charge of reseting the currentLoadState to NotLoading once the background refresh is complete
            // or an exception happened. In the case of an exception during the background refresh resettting the currentLoadState to NotLoading
            // is not done within the scope of the lock. This is safe because the only other place currentLoadState is modified to a different value
            // is within the block of code that initiates the background refresh. The execution will never go into that block while a background
            // refresh is in progress because the currentLoadState was set to Loading which prevents starting a background refresh. Since 
            // currentLoadState is potentially modified by multiple threads it has been marked as volatile to ensure the latest value is always read.
            if (IsExpired(tempState) || (currentLoadState != CredentialsLoadState.Loading && IsPreemptExpiryWindow(tempState)))
            {
                _updateGeneratedCredentialsSemaphore.Wait();
                try
                {
                    // Update the local variable for credentials after acquiring the lock in case another thread got the lock first and updated the current state.
                    tempState = currentState;

                    // If credentials are expired block for credential refresh.
                    if (IsExpired(tempState))
                    {
                        LogCredentialsExpired(tempState);

                        tempState = GenerateNewCredentials();
                        ValidateGeneratedCredentials(tempState);
                        currentState = tempState;
                        currentLoadState = CredentialsLoadState.NotLoading;
                    }
                    else if (currentLoadState != CredentialsLoadState.Loading && IsPreemptExpiryWindow(tempState))
                    {
                        LogCredentialsPreemptExpiry(tempState);

                        currentLoadState = CredentialsLoadState.Loading;
                        _ = BackgroundCredentialsRefreshAsync();
                    }
                }
                finally
                {
                    _updateGeneratedCredentialsSemaphore.Release();
                }
            }

            return tempState.Credentials;
        }

        public override sealed async Task<ImmutableCredentials> GetCredentialsAsync()
        {
            // NOTICE: Before modifying any of the logic read the comments in the synchronous GetCredentials method to 
            // understand the locking flow. If any changes are required be sure the comments in that method are also updated.

            // We save the currentState as it might be modified or cleared.
            var tempState = currentState;

            if (IsExpired(tempState) || (currentLoadState != CredentialsLoadState.Loading && IsPreemptExpiryWindow(tempState)))
            {
                await _updateGeneratedCredentialsSemaphore.WaitAsync().ConfigureAwait(false);
                try
                {
                    // Update the local variable for credentials after acquiring the lock in case another thread got the lock first and updated the current state.
                    tempState = currentState;

                    // If credentials are expired block for credential refresh.
                    if (IsExpired(tempState))
                    {
                        LogCredentialsExpired(tempState);

                        tempState = await GenerateNewCredentialsAsync().ConfigureAwait(false);
                        ValidateGeneratedCredentials(tempState);
                        currentState = tempState;
                        currentLoadState = CredentialsLoadState.NotLoading;
                    }
                    else if (currentLoadState != CredentialsLoadState.Loading && IsPreemptExpiryWindow(tempState))
                    {
                        LogCredentialsPreemptExpiry(tempState);

                        currentLoadState = CredentialsLoadState.Loading;
                        _ = BackgroundCredentialsRefreshAsync();
                    }
                }
                finally
                {
                    _updateGeneratedCredentialsSemaphore.Release();
                }
            }

            return tempState.Credentials;
        }

        private async Task BackgroundCredentialsRefreshAsync()
        {
            // NOTICE: Before modifying any of the logic read the comments in the synchronous GetCredentials method to 
            // understand the locking flow. If any changes are required be sure the comments in that method are also updated.

            try
            {
                var newState = await GenerateNewCredentialsAsync().ConfigureAwait(false);
                ValidateGeneratedCredentials(newState);

                // Acquire the lock to atomically update both currentState and currentLoadState
                await _updateGeneratedCredentialsSemaphore.WaitAsync().ConfigureAwait(false);
                try
                {
                    currentState = newState;
                    currentLoadState = CredentialsLoadState.NotLoading;
                }
                finally
                {
                    _updateGeneratedCredentialsSemaphore.Release();
                }
            }
            catch (Exception e)
            {
                _logger.Error(e, "Exception occurred performing background credentials refresh.");

                // If any exceptions occur during background refresh, reset the state to NotLoading
                // so that future GetCredentials calls can attempt to refresh again.
                //
                // This is safe to modify outside of the lock because the only other place currentLoadState is modified
                // to a different value is within the block of code that initiates the background refresh. The block
                // can never be entered while this background refresh is in progress because currentLoadState was set to Loading.
                currentLoadState = CredentialsLoadState.NotLoading;
                throw;
            }
        }

        #endregion

        #region Private/protected credential update methods

        private void ValidateGeneratedCredentials(CredentialsRefreshState state)
        {
            // Check if the new credentials are already expired
            if (IsExpired(state))
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
                        _timeProvider.CorrectedUtcNow, state.Expiration);
                }

                throw new AmazonClientException(errorMessage);
            }

            state.Expiration -= ExpirationBuffer;
        }

        /// <summary>
        /// This property has been marked as Obsolete because it is no longer used for determining
        /// if credentials should be updated. The boolean ShouldUpdate property did not provide 
        /// enough information on whether credentials are expired or in the preempt expiry window.
        /// </summary>
        [Obsolete("Property is no longer used for determining if credentials should be updated.")]
        protected bool ShouldUpdate
        {
            get
            {
                return IsExpired(currentState);
            }
        }

        /// <summary>
        /// Test if the credentials are currently expired.
        /// </summary>
        private static bool IsExpired(CredentialsRefreshState state)
        {
            var isExpired = state?.IsExpiredWithin(TimeSpan.Zero);
            return isExpired ?? true;
        }

        private void LogCredentialsExpired(CredentialsRefreshState state)
        {
            if (state == null)
            {
                return;
            }

            _logger.InfoFormat(
                "Determined refreshing credentials should update. Expiration time: {0}, Current time: {1}",
                state.Expiration.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture),
                _timeProvider.CorrectedUtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture)
            );
        }

        /// <summary>
        /// Test if the credentials are in the preempt expiry window.
        /// <para />
        /// That means the instance currently has credentials and they are not expired but that will expire 
        /// within the window of expiration minus PreemptExpiryTime.
        /// </summary>
        private bool IsPreemptExpiryWindow(CredentialsRefreshState state)
        {
            if (state == null || IsExpired(state))
            {
                return false;
            }

            var isPreemptWindow = state.IsExpiredWithin(PreemptExpiryTime);
            return isPreemptWindow;
        }

        private void LogCredentialsPreemptExpiry(CredentialsRefreshState state)
        {
            if (state == null)
            {
                return;
            }

            _logger.InfoFormat(
                "Determined refreshing credentials are in window for preempt expiration. Preempt time: {0}, Current time: {1}",
                state.Expiration.Subtract(PreemptExpiryTime).ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture),
                _timeProvider.CorrectedUtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture)
            );
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
        protected virtual Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
        {
            return Task.Run(() => this.GenerateNewCredentials());
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