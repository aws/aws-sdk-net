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
    /// A resolver that provides an AWSCredentials identity. 
    /// </summary>
    public class DefaultAWSCredentialsIdentityResolver : IIdentityResolver
    {
        private const string AWS_PROFILE_ENVIRONMENT_VARIABLE = "AWS_PROFILE";
        private const string DEFAULT_PROFILE_NAME = "default";

        private static ReaderWriterLockSlim _cachedCredentialsLock = new ReaderWriterLockSlim();
        private delegate AWSCredentials CredentialsGenerator();
        private AWSCredentials _cachedCredentials;
        private List<CredentialsGenerator> _credentialsGenerators { get; set; }
        private readonly CredentialProfileStoreChain _credentialProfileChain = new CredentialProfileStoreChain();

        public DefaultAWSCredentialsIdentityResolver()
        {
            try
            {
                _cachedCredentialsLock.EnterWriteLock();
                _cachedCredentials = null;
                _credentialsGenerators = new List<CredentialsGenerator>
                {
#if BCL
                    () => new AppConfigAWSCredentials(), // Test explicit keys/profile name first.
#endif
                    () => AssumeRoleWithWebIdentityCredentials.FromEnvironmentVariables(),
                    () => new EnvironmentVariablesAWSCredentials(), // Look for credentials set in environment vars.
                    () => GetAWSCredentials(_credentialProfileChain),
                    () => ContainerEC2CredentialsWrapper(), // either get ECS / EKS credentials or instance profile credentials
                };
            }
            finally
            {
                _cachedCredentialsLock.ExitWriteLock();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "We need to catch all exceptions to be able to move the the next generator.")]
        public BaseIdentity ResolveIdentity()
        {
            try
            {
                _cachedCredentialsLock.EnterReadLock();
                if (_cachedCredentials != null)
                {
                    return _cachedCredentials;
                }
            }
            finally
            {
                _cachedCredentialsLock.ExitReadLock();
            }

            try
            {
                _cachedCredentialsLock.EnterWriteLock();
                if (_cachedCredentials != null)
                {
                    return _cachedCredentials;
                }

                List<Exception> errors = new List<Exception>();
                foreach (CredentialsGenerator generator in _credentialsGenerators)
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
                    catch (Exception e)
                    {
                        _cachedCredentials = null;

                        errors.Add(e);
                    }

                    if (_cachedCredentials != null)
                        break;
                }

                if (_cachedCredentials != null)
                    return _cachedCredentials;

                using (StringWriter writer = new StringWriter(CultureInfo.InvariantCulture))
                {
                    writer.WriteLine("Unable to find credentials");
                    writer.WriteLine();
                    for (int i = 0; i < errors.Count; i++)
                    {
                        Exception e = errors[i];
                        writer.WriteLine("Exception {0} of {1}:", i + 1, errors.Count);
                        writer.WriteLine(e.ToString());
                        writer.WriteLine();
                    }

                    throw new AmazonClientException(writer.ToString());
                }
            }
            finally
            {
                _cachedCredentialsLock.ExitWriteLock();
            }
        }

        public async Task<BaseIdentity> ResolveIdentityAsync(CancellationToken cancellationToken = default)
        {
            return await Task.Run(() => ResolveIdentity(), cancellationToken).ConfigureAwait(false);
        }

        private static AWSCredentials GetAWSCredentials(ICredentialProfileSource source)
        {
            var profileName = GetProfileName();

            CredentialProfile profile;
            if (source.TryGetProfile(profileName, out profile))
                return profile.GetAWSCredentials(source, true);

            throw new AmazonClientException($"Unable to find the \"{profileName}\" profile in CredentialProfileStoreChain.");
        }

        internal static string GetProfileName()
        {
            var profileName = AWSConfigs.AWSProfileName;

            if (string.IsNullOrEmpty(profileName?.Trim()))
                profileName = Environment.GetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE);

            if (string.IsNullOrEmpty(profileName?.Trim()))
                profileName = DEFAULT_PROFILE_NAME;

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
            return DefaultInstanceProfileAWSCredentials.Instance;
        }
    }
}
