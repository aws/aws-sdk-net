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
    public class DefaultAWSCredentialsIdentityResolver : IIdentityResolver<AWSCredentials>
    {
        private const string AWS_PROFILE_ENVIRONMENT_VARIABLE = "AWS_PROFILE";
        private const string DEFAULT_PROFILE_NAME = "default";

        /// <summary>
        /// A method that should either return valid <see cref="AWSCredentials"/> or throw an exception (so
        /// that the SDK can move on and attempt the next generator in the credential chain).
        /// </summary>
        public delegate AWSCredentials CredentialsGenerator();

        private static readonly ReaderWriterLockSlim _cachedCredentialsLock = new();
        private AWSCredentials _cachedCredentials;
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
            var profile = clientConfig?.Profile;
            if (profile != null)
            {
                var source = new CredentialProfileStoreChain(profile.Location);
                if (source.TryGetProfile(profile.Name, out CredentialProfile storedProfile))
                {
                    return storedProfile.GetAWSCredentials(source, true);
                }

                throw new AmazonClientException($"Unable to find the \"{profile.Name}\" profile specified in the client configuration.");
            }

            return InternalGetCredentials();
        }

        Task<BaseIdentity> IIdentityResolver.ResolveIdentityAsync(IClientConfig clientConfig, CancellationToken cancellationToken) =>
            Task.FromResult<BaseIdentity>(ResolveIdentity(clientConfig));

        public Task<AWSCredentials> ResolveIdentityAsync(IClientConfig clientConfig, CancellationToken cancellationToken = default) =>
            Task.FromResult(ResolveIdentity(clientConfig));

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "We need to catch all exceptions to be able to move the the next generator.")]
        private AWSCredentials InternalGetCredentials()
        {
            var hasEnvironmentChanged = false;

            try
            {
                _cachedCredentialsLock.EnterReadLock();
                if (_cachedCredentials != null)
                {
                    hasEnvironmentChanged = _lastKnownEnvironmentState.HasEnvironmentChanged();
                    if (!hasEnvironmentChanged)
                    {
                        return _cachedCredentials;
                    }
                }
            }
            finally
            {
                _cachedCredentialsLock.ExitReadLock();
            }

            try
            {
                _cachedCredentialsLock.EnterWriteLock();
                if (_cachedCredentials != null && !hasEnvironmentChanged)
                {
                    return _cachedCredentials;
                }

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

                List<Exception> errors = new List<Exception>();
                foreach (CredentialsGenerator generator in providersToUse)
                {
                    try
                    {
                        _cachedCredentials = generator();
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
                        _cachedCredentials = null;
                        errors.Add(e);
                    }

                    if (_cachedCredentials != null)
                    {
                        break;
                    }
                }

                if (_cachedCredentials != null)
                {
                    _lastKnownEnvironmentState.UpdateEnvironment();
                    return _cachedCredentials;
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
            finally
            {
                _cachedCredentialsLock.ExitWriteLock();
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

        internal static string GetProfileName()
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
