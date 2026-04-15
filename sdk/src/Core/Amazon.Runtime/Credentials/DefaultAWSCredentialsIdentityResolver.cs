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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Identity;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Credentials
{
    /// <summary>
    /// A resolver that provides an <see cref="AWSCredentials"/> identity.
    /// <para />
    /// The default search order used is described in the <a href="https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/creds-assign.html">
    /// developer guide</a>, but it can be overwritten by setting the <see cref="AWSConfigs.AWSCredentialsGenerators"/> property.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA1001:Types that own disposable fields should be disposable",
        Justification = "This resolver is designed to be long-lived (singleton via DefaultIdentityResolverConfiguration). Disposing the semaphore would break concurrent callers.")]
    public class DefaultAWSCredentialsIdentityResolver : IIdentityResolver<AWSCredentials>
    {
        private const string AWS_PROFILE_ENVIRONMENT_VARIABLE = "AWS_PROFILE";
        private const string DEFAULT_PROFILE_NAME = "default";

        /// <summary>
        /// A method that should either return valid <see cref="AWSCredentials"/> or throw an exception (so
        /// that the SDK can move on and attempt the next generator in the credential chain).
        /// </summary>
        public delegate AWSCredentials CredentialsGenerator();

        /// <summary>
        /// SemaphoreSlim supports both synchronous Wait() and asynchronous WaitAsync(), preventing
        /// thread pool starvation when many concurrent async requests need to resolve credentials
        /// simultaneously. Only one caller walks the credential chain; all others wait and reuse
        /// the cached result.
        /// </summary>
        private readonly SemaphoreSlim _credentialResolutionLock = new SemaphoreSlim(1, 1);
        private volatile AWSCredentials _cachedCredentials;
        private readonly List<CredentialsGenerator> _credentialsGenerators;
        private readonly CredentialProfileStoreChain _credentialProfileChain = new();
        private readonly EnvironmentState _lastKnownEnvironmentState = new();
        private static readonly Lazy<DefaultAWSCredentialsIdentityResolver> _defaultInstance = new();

        public DefaultAWSCredentialsIdentityResolver()
        {
            _cachedCredentials = null;
            _credentialsGenerators = new List<CredentialsGenerator>
            {
#if NETFRAMEWORK
                () => new AppConfigAWSCredentials(), // Test explicit keys/profile name first.
#endif
                () => new EnvironmentVariablesAWSCredentials(), // Look for credentials set in environment vars.
                () => AssumeRoleWithWebIdentityCredentials.FromEnvironmentVariables(),
                () => GetProfileCredentials(_credentialProfileChain),
                () => ContainerEC2CredentialsWrapper(), // either get ECS / EKS credentials or instance profile credentials
            };
        }

        #region Helper methods for migration from FallbackCredentialsFactory

        /// <summary>
        /// Search the environment for configured AWS credentials. The search includes
        /// environment variables, "default" AWS credentials profiles and EC2 instance metadata.
        /// </summary>
        /// <param name="clientConfig">
        /// Optional config object that can be used to specify a different profile programatically (via the <see cref="Profile"/> property).
        /// </param>
        /// <returns>AWSCredentials that can be used when creating AWS service clients.</returns>
        public static AWSCredentials GetCredentials(IClientConfig clientConfig = null)
        {
            return _defaultInstance.Value.ResolveIdentity(clientConfig);
        }

        /// <summary>
        /// Search the environment for configured AWS credentials. The search includes
        /// environment variables, "default" AWS credentials profiles and EC2 instance metadata.
        /// </summary>
        /// <param name="clientConfig">
        /// Optional config object that can be used to specify a different profile programatically (via the <see cref="Profile"/> property).
        /// </param>
        /// <returns>AWSCredentials that can be used when creating AWS service clients.</returns>
        public static Task<AWSCredentials> GetCredentialsAsync(IClientConfig clientConfig = null)
        {
            return _defaultInstance.Value.ResolveIdentityAsync(clientConfig);
        }

        #endregion

        BaseIdentity IIdentityResolver.ResolveIdentity(IClientConfig clientConfig) 
            => ResolveIdentity(clientConfig);

        public AWSCredentials ResolveIdentity(IClientConfig clientConfig)
        {
            var profileCredentials = TryGetProfileCredentials(clientConfig);
            if (profileCredentials != null) return profileCredentials;

            return InternalGetCredentials();
        }

        async Task<BaseIdentity> IIdentityResolver.ResolveIdentityAsync(IClientConfig clientConfig, CancellationToken cancellationToken) =>
            await ResolveIdentityAsync(clientConfig, cancellationToken).ConfigureAwait(false);

        public async Task<AWSCredentials> ResolveIdentityAsync(IClientConfig clientConfig, CancellationToken cancellationToken = default)
        {
            var profileCredentials = TryGetProfileCredentials(clientConfig);
            if (profileCredentials != null) return profileCredentials;

            return await InternalGetCredentialsAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Resolves credentials from the profile specified in <paramref name="clientConfig"/>, if any.
        /// Returns null if no profile name is configured, allowing the caller to fall back to the credential chain.
        /// </summary>
        private static AWSCredentials TryGetProfileCredentials(IClientConfig clientConfig)
        {
            var profile = clientConfig?.Profile;
            if (string.IsNullOrEmpty(profile?.Name)) return null;

            var source = new CredentialProfileStoreChain(profile.Location);
            if (source.TryGetProfile(profile.Name, out CredentialProfile storedProfile))
            {
                return storedProfile.GetAWSCredentials(source, true);
            }

            throw new AmazonClientException($"Unable to find the \"{profile.Name}\" profile specified in the client configuration.");
        }

        /// <summary>
        /// Checks whether valid cached credentials are available without acquiring the lock.
        /// Returns the cached credentials if they exist and the environment hasn't changed,
        /// otherwise returns null to indicate that credentials need to be resolved.
        /// </summary>
        private AWSCredentials TryGetCachedCredentials()
        {
            var cached = _cachedCredentials;
            if (cached != null)
            {
                if (!_lastKnownEnvironmentState.HasEnvironmentChanged())
                {
                    return cached;
                }
            }
            return null;
        }

        /// <summary>
        /// Walks the credential chain and resolves credentials. This method must only be
        /// called while holding the <see cref="_credentialResolutionLock"/>.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "We need to catch all exceptions to be able to move to the next generator.")]
        private AWSCredentials ResolveCredentialChain()
        {
            List<CredentialsGenerator> providersToUse;
            if (AWSConfigs.AWSCredentialsGenerators != null)
            {
                Logger.GetLogger(typeof(DefaultAWSCredentialsIdentityResolver)).DebugFormat("Using custom credential search order defined in {0}", nameof(AWSConfigs));
                providersToUse = AWSConfigs.AWSCredentialsGenerators;
            }
            else
            {
                providersToUse = _credentialsGenerators;
            }

            AWSCredentials resolvedCredentials = null;
            List<Exception> errors = new List<Exception>();
            foreach (CredentialsGenerator generator in providersToUse)
            {
                try
                {
                    resolvedCredentials = generator();
                }
                // Breaking the chain in case a ProcessAWSCredentialException exception 
                // is encountered. ProcessAWSCredentialException is thrown by the ProcessAWSCredential provider
                // when an exception is encountered when running a user provided process to obtain Basic/Session 
                // credentials. The motivation behind this is that, if the user has provided a process to be run
                // he expects to use the credentials obtained by running the process. Therefore the exception is
                // surfaced to the user.
                catch (ProcessAWSCredentialException)
                {
                    throw;
                }
                // Also breaking the chain in case a custom profile name was specified and the profile does not exist.
                // This differs from the FallbackCredentialsFactory, which would default to the IMDS provider (and throw
                // an error that may not be applicable when running outside of an EC2 environment).
                catch (ProfileNotFoundException)
                {
                    throw;
                }
                catch (Exception e)
                {
                    resolvedCredentials = null;
                    errors.Add(e);
                }

                if (resolvedCredentials != null)
                {
                    break;
                }
            }

            if (resolvedCredentials != null)
            {
                // Update the environment snapshot before publishing the credentials via the
                // volatile write. This avoids a race where a concurrent reader in
                // TryGetCachedCredentials sees non-null _cachedCredentials but stale
                // environment state, causing a false "environment changed" detection and
                // an unnecessary re-resolution attempt.
                _lastKnownEnvironmentState.UpdateEnvironment();
                _cachedCredentials = resolvedCredentials;
                return resolvedCredentials;
            }

            using var writer = new StringWriter(CultureInfo.InvariantCulture);
            writer.WriteLine("Failed to resolve AWS credentials. The credential providers used to search for credentials returned the following errors:");
            writer.WriteLine();
            for (int i = 0; i < errors.Count; i++)
            {
                Exception e = errors[i];
                writer.WriteLine("Exception {0} of {1}: {2}", i + 1, errors.Count, e.Message);
            }

            throw new AmazonClientException(writer.ToString());
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "We need to catch all exceptions to be able to move to the next generator.")]
        private AWSCredentials InternalGetCredentials()
        {
            // Fast path: return cached credentials without acquiring the lock.
            var cached = TryGetCachedCredentials();
            if (cached != null)
            {
                return cached;
            }

            // Slow path: acquire the lock synchronously so only one thread walks the credential chain.
            _credentialResolutionLock.Wait();
            try
            {
                // Re-check with fresh environment state after acquiring the lock.
                cached = TryGetCachedCredentials();
                if (cached != null)
                {
                    return cached;
                }

                return ResolveCredentialChain();
            }
            finally
            {
                _credentialResolutionLock.Release();
            }
        }

        /// <summary>
        /// Asynchronously resolves credentials using a single-flight pattern.
        /// Only one task walks the credential chain; all other concurrent tasks
        /// asynchronously wait on the semaphore (yielding their thread back to
        /// the thread pool) and then reuse the cached result.  This prevents
        /// thread pool starvation under high concurrency.
        /// </summary>
        private async Task<AWSCredentials> InternalGetCredentialsAsync(CancellationToken cancellationToken)
        {
            // Fast path: return cached credentials without acquiring the lock.
            var cached = TryGetCachedCredentials();
            if (cached != null)
            {
                return cached;
            }

            // Slow path: asynchronously wait for the lock so we don't block thread pool threads.
            await _credentialResolutionLock.WaitAsync(cancellationToken).ConfigureAwait(false);
            try
            {
                // Re-check with fresh environment state after acquiring the lock.
                cached = TryGetCachedCredentials();
                if (cached != null)
                {
                    return cached;
                }

                return ResolveCredentialChain();
            }
            finally
            {
                _credentialResolutionLock.Release();
            }
        }

        private static AWSCredentials GetProfileCredentials(ICredentialProfileSource source)
        {
            var profileName = GetProfileName();
            if (source.TryGetProfile(profileName, out CredentialProfile profile))
            {
                return profile.GetAWSCredentials(source, true);
            }

            if (!profileName.Equals(DEFAULT_PROFILE_NAME, StringComparison.OrdinalIgnoreCase))
            {
                throw new ProfileNotFoundException($"Unable to find the \"{profileName}\" profile.");
            }

            throw new AmazonClientException($"Unable to find the \"{DEFAULT_PROFILE_NAME}\" profile.");
        }

        public static string GetProfileName()
        {
            var profileName = AWSConfigs.AWSProfileName;

            if (string.IsNullOrEmpty(profileName?.Trim()))
            {
                profileName = Environment.GetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE);
            }

            if (string.IsNullOrEmpty(profileName?.Trim()))
            {
                profileName = DEFAULT_PROFILE_NAME;
            }

            return profileName;
        }

        private static AWSCredentials ContainerEC2CredentialsWrapper()
        {
            try
            {
                var relativeUri = Environment.GetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable);
                if (!string.IsNullOrEmpty(relativeUri))
                {
                    return new GenericContainerCredentials();
                }

                var fullUri = Environment.GetEnvironmentVariable(GenericContainerCredentials.FullURIEnvVariable);
                if (!string.IsNullOrEmpty(fullUri))
                {
                    return new GenericContainerCredentials();
                }
            }
            catch (SecurityException e)
            {
                Logger.GetLogger(typeof(GenericContainerCredentials)).Error(e, $"Failed to access environment variables {GenericContainerCredentials.RelativeURIEnvVariable} and {GenericContainerCredentials.FullURIEnvVariable}." +
                    $" Either {GenericContainerCredentials.RelativeURIEnvVariable} or {GenericContainerCredentials.FullURIEnvVariable} environment variables must be set.");
            }

            try
            {
                var credentials = DefaultInstanceProfileAWSCredentials.Instance;

                // Test that credentials can be resolved using EC2 instance metadata. Assuming the
                // credentials are successfully resolved the credentials will be cached so the
                // later use of getting credentials for making the request will not have to redo
                // the network calls to EC2 instance metadata to get credentials.
                credentials.GetCredentials();

                return credentials;
            }
            catch (AmazonServiceException e)
            {
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "Failed to connect to EC2 instance metadata to retrieve credentials: {0}.",
                    e.Message), e);
            }
        }

        /// <summary>
        /// This helper class keeps track of the environment state at the time credentials were last resolved.
        /// <para>
        /// The <see cref="FallbackCredentialsFactory"/> was written with the assumption the environment wouldn't change between calls, so it returns
        /// cached values if available. However, in some scenarios (such as a PowerShell interactive session), customers may set a different profile or
        /// temporary access and secret keys (and we want to pick up that change to match the behavior of the AWS CLI).
        /// </para>
        /// </summary>
        /// <remarks>
        /// This class intentionally doesn't check for variables related to the <see cref="GenericContainerCredentials"/> provider, as those are expected to 
        /// be set once when the container starts and not to change for its lifecycle.
        /// </remarks>
        private class EnvironmentState
        {
            public string AccessKey { get; private set; }
            public string SecretKey { get; private set; }
            public string SessionToken { get; private set; }
            public string ProfileName { get; private set; }

            public bool HasEnvironmentChanged()
            {
                var secretKey = 
                    Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY) ?? 
                    Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.LEGACY_ENVIRONMENT_VARIABLE_SECRETKEY);

                return 
                    AccessKey != Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY) ||
                    SecretKey != secretKey ||
                    SessionToken != Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SESSION_TOKEN) ||
                    ProfileName != Environment.GetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE);
            }

            public void UpdateEnvironment()
            {
                AccessKey = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY);
                SecretKey = 
                    Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY) ??
                    Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.LEGACY_ENVIRONMENT_VARIABLE_SECRETKEY);
                SessionToken = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SESSION_TOKEN);
                ProfileName = Environment.GetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE);
            }
        }
    }
}
