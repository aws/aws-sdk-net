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
        private enum CredentialsLoadState
        {
            NotLoading,
            Loading
        }

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