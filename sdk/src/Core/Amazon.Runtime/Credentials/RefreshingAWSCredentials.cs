/*
 * Copyright 2011-2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.Runtime
{
    /// <summary>
    /// Abstract class for automatically refreshing AWS credentials
    /// </summary>
    public abstract class RefreshingAWSCredentials : AWSCredentials
    {
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
            { }
            public CredentialsRefreshState(ImmutableCredentials credentials, DateTime expiration)
            {
                Credentials = credentials;
                Expiration = expiration;
            }
        }


        protected CredentialsRefreshState currentState = null;
        private object _refreshLock = new object();

        #endregion

        #region Private members

        private TimeSpan _preemptExpiryTime = TimeSpan.FromMinutes(0);

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
                if (value < TimeSpan.Zero) throw new ArgumentOutOfRangeException("value", "PreemptExpiryTime cannot be negative");
                _preemptExpiryTime = value;
            }
        }

        #endregion

        #region Override methods

        /// <summary>
        /// Returns an instance of ImmutableCredentials for this instance
        /// </summary>
        /// <returns></returns>
        public override ImmutableCredentials GetCredentials()
        {
            lock (this._refreshLock)
            {
                // If credentials are expired, update
                if (ShouldUpdate)
                {
                    currentState = GenerateNewCredentials();
                    UpdateToGeneratedCredentials(currentState);
                }

                return currentState.Credentials.Copy();
            }
        }

#if AWS_ASYNC_API
        public async override System.Threading.Tasks.Task<ImmutableCredentials> GetCredentialsAsync()
        {
            // If credentials are expired, update
            if (ShouldUpdate)
            {
                var state = await GenerateNewCredentialsAsync().ConfigureAwait(false);
                lock (this._refreshLock)
                {
                    currentState = state;
                    UpdateToGeneratedCredentials(currentState);
                }
            }

            return currentState.Credentials.Copy();
        }
#endif

        #endregion


        #region Private/protected credential update methods

#if UNITY
        protected
#else
        private
#endif
        void UpdateToGeneratedCredentials(CredentialsRefreshState state)
        {
            // Check if the new credentials are already expired
            if (ShouldUpdate)
            {
                string errorMessage;
                if (state == null)
                    errorMessage = "Unable to generate temporary credentials";
                else
                    errorMessage = string.Format(CultureInfo.InvariantCulture,
                        "The retrieved credentials have already expired: Now = {0}, Credentials expiration = {1}",
#pragma warning disable CS0612 // Type or member is obsolete
                        AWSSDKUtils.CorrectedUtcNow.ToLocalTime(), state.Expiration);
#pragma warning restore CS0612 // Type or member is obsolete
                throw new AmazonClientException(errorMessage);
            }

            // Offset the Expiration by PreemptExpiryTime
            state.Expiration -= PreemptExpiryTime;

            if (ShouldUpdate)
            {
                // This could happen if the default value of PreemptExpiryTime is
                // overriden and set too high such that ShouldUpdate returns true.
                var logger = Logger.GetLogger(typeof(RefreshingAWSCredentials));
                logger.InfoFormat(
                    "The preempt expiry time is set too high: Current time = {0}, Credentials expiry time = {1}, Preempt expiry time = {2}.",
#pragma warning disable CS0612 // Type or member is obsolete
                    AWSSDKUtils.CorrectedUtcNow.ToLocalTime(),
#pragma warning restore CS0612 // Type or member is obsolete
                    currentState.Expiration,
                    PreemptExpiryTime);
            }
        }

        // Test credentials existence and expiration time
#if UNITY
        protected
#else
        private
#endif
        bool ShouldUpdate
        {
            get
            {
                // should update if:

                //  credentials have not been loaded yet
                if (currentState == null)
                    return true;

                //  it's past the expiration time
#pragma warning disable CS0612 // Type or member is obsolete
                var now = AWSSDKUtils.CorrectedUtcNow;
#pragma warning restore CS0612 // Type or member is obsolete
                var exp = currentState.Expiration.ToUniversalTime();
                return (now > exp);
            }
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

#if AWS_ASYNC_API
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
#endif

        /// <summary>
        /// Clears currently-stored credentials, forcing the next GetCredentials call to generate new credentials.
        /// </summary>
        public virtual void ClearCredentials()
        {
            currentState = null;
        }

        #endregion
    }
}
