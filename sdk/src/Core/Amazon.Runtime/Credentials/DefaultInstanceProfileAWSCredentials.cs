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
using Amazon.Util.Internal;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime
{
    /// <summary>
    /// Credentials retrieved from the EC2 Instance Metadata Service (IMDS), used as the last link of the
    /// <see cref="Amazon.Runtime.Credentials.DefaultAWSCredentialsIdentityResolver"/> and
    /// <see cref="FallbackCredentialsFactory"/> chains.
    /// <para />
    /// This provider derives from <see cref="RefreshingAWSCredentials"/>, so the shared refresh lifecycle --
    /// advisory (background) refresh, mandatory blocking refresh, jittered refresh backoff, serving cached
    /// credentials when a refresh fails, and <see cref="RefreshingAWSCredentials.Invalidate(ImmutableCredentials)"/>
    /// -- owns caching and retry timing. The provider itself only resolves credentials from IMDS in
    /// <see cref="GenerateNewCredentials"/>.
    /// <para />
    /// As in earlier versions of the SDK, it also looks for newer credentials every 2 minutes, through a background
    /// refresh that never blocks callers and follows the refresh backoff. <see cref="InstanceProfileAWSCredentials"/>
    /// does the same. IMDS rotates in new credentials well before
    /// the current ones expire, and the instance's IAM role can be replaced, so this keeps the cached credentials recent
    /// instead of holding them until their refresh window, which for 6-hour credentials opens after about 5 hours.
    /// <para />
    /// There is no process-wide instance. Each <see cref="Amazon.Runtime.Credentials.DefaultAWSCredentialsIdentityResolver"/>
    /// instance and <see cref="FallbackCredentialsFactory"/> own one, and a credential_source=Ec2InstanceMetadata
    /// profile creates one per resolution. Each instance caches and refreshes independently.
    /// </summary>
    internal class DefaultInstanceProfileAWSCredentials : RefreshingAWSCredentials
    {
        // How often the IMDS providers look for newer credentials, as in earlier versions of the SDK.
        internal static readonly TimeSpan ScheduledRefreshInterval = TimeSpan.FromMinutes(2);

        private readonly IIMDSAccessMethods _imdsAccessMethods;

        internal DefaultInstanceProfileAWSCredentials()
            : this(new IMDSAccessMethods(), null, ScheduledRefreshInterval)
        {
        }

        /// <summary>
        /// For tests. The scheduled refresh is off unless <paramref name="scheduledRefreshInterval"/> is given.
        /// </summary>
        internal static DefaultInstanceProfileAWSCredentials CreateTestDefaultInstanceProfileAWSCredentials(
            IIMDSAccessMethods imdsAccessMethods,
            ITimeProvider timeProvider,
            TimeSpan? scheduledRefreshInterval = null)
        {
            return new DefaultInstanceProfileAWSCredentials(imdsAccessMethods, timeProvider, scheduledRefreshInterval);
        }

        private DefaultInstanceProfileAWSCredentials(
            IIMDSAccessMethods imdsAccessMethods,
            ITimeProvider timeProvider,
            TimeSpan? scheduledRefreshInterval)
            : base(timeProvider)
        {
            _imdsAccessMethods = imdsAccessMethods;

            // As in earlier versions of the SDK, the IMDS feature id is only advertised when IMDS is enabled.
            if (EC2InstanceMetadata.IsIMDSEnabled)
            {
                FeatureIdSources.Add(UserAgentFeatureId.CREDENTIALS_IMDS);

                if (scheduledRefreshInterval is TimeSpan interval && interval > TimeSpan.Zero)
                {
                    StartScheduledRefresh(interval);
                }
            }
        }

        #region Overrides

        /// <inheritdoc/>
        protected sealed override bool UsesManagedRefreshLifecycle => true;


        /// <summary>
        /// IMDS returns the same credentials until it rotates them, so it cannot supply longer-lived credentials on
        /// request: <see cref="RefreshingAWSCredentials.GetCredentials(TimeSpan)"/> behaves as
        /// <see cref="RefreshingAWSCredentials.GetCredentials()"/>.
        /// </summary>
        internal override bool SupportsMinimumLifetimeRefresh => false;

        /// <summary>
        /// Resolves credentials from IMDS. Throws on failure, so the base <see cref="RefreshingAWSCredentials"/>
        /// lifecycle owns the background refresh window, the refresh backoff, serving cached credentials when a refresh
        /// fails, and invalidation. An IMDS response whose credentials are already expired is treated as a failed
        /// refresh when credentials are already cached: the cached credentials are kept. With nothing cached yet, the
        /// expired credentials are used.
        /// <para />
        /// <see cref="IIMDSAccessMethods.CheckIsIMDSEnabled"/> is called here, rather than in a GetCredentials
        /// override, because the base <c>GetCredentials</c> is sealed. As in earlier versions of the SDK, a disabled
        /// IMDS throws <see cref="AmazonServiceException"/>.
        /// </summary>
        protected override CredentialsRefreshState GenerateNewCredentials()
        {
            _imdsAccessMethods.CheckIsIMDSEnabled();
            return _imdsAccessMethods.FetchCredentials();
        }

        /// <summary>
        /// Asynchronous mirror of <see cref="GenerateNewCredentials"/>.
        /// </summary>
        protected override async Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
        {
            _imdsAccessMethods.CheckIsIMDSEnabled();
            return await _imdsAccessMethods.FetchCredentialsAsync().ConfigureAwait(false);
        }

        #endregion

        #region IMDS access

        /// <summary>
        /// Throws <see cref="AmazonServiceException"/> when IMDS is disabled (AWS_EC2_METADATA_DISABLED is "true").
        /// Credential chains call this before creating or returning a provider, so resolution fails over to the
        /// next credential source, or reports the failure, instead of returning credentials that fail on first use.
        /// </summary>
        internal static void ThrowIfIMDSDisabled()
        {
            // keep this behavior consistent with GetObjectFromResponse case.
            if (!EC2InstanceMetadata.IsIMDSEnabled) throw new AmazonServiceException("Unable to retrieve credentials.");
        }

        internal interface IIMDSAccessMethods
        {
            RefreshingAWSCredentials.CredentialsRefreshState FetchCredentials();
            Task<RefreshingAWSCredentials.CredentialsRefreshState> FetchCredentialsAsync();
            void CheckIsIMDSEnabled();
        }


        private class IMDSAccessMethods : IIMDSAccessMethods
        {
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
                ThrowIfIMDSDisabled();
            }
        }

        #endregion
    }
}
