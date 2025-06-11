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
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Credentials;
using Amazon.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Security;
using System.Threading;

namespace Amazon.Runtime
{
    [Obsolete("This class is deprecated. Please use DefaultAWSCredentialsIdentityResolver instead to obtain AWSCredentials.")]
    public static class FallbackCredentialsFactory
    {
        // Lock to control caching credentials across multiple threads.
        private static ReaderWriterLockSlim cachedCredentialsLock = new ReaderWriterLockSlim();
    
        internal const string AWS_PROFILE_ENVIRONMENT_VARIABLE = "AWS_PROFILE";
        internal const string DefaultProfileName = "default";

        private static readonly CredentialProfileStoreChain credentialProfileChain = new CredentialProfileStoreChain();
        static FallbackCredentialsFactory()
        {
            Reset();
        }

        public delegate AWSCredentials CredentialsGenerator();

        /// <summary>
        /// When migrating to version 4 of the SDK the <see cref="DefaultAWSCredentialsIdentityResolver"/> will be the default identity resolver.
        /// Changing this property will not affect global override for the default credential provider chain. 
        /// <para />
        /// To change the default credential provider chain use the the <see cref="AWSConfigs.AWSCredentialsGenerators"/> property.
        /// </summary>
        public static List<CredentialsGenerator> CredentialsGenerators { get; set; }

        public static void Reset()
        {
            Reset(null);
        }

        public static void Reset(IWebProxy proxy)
        {
            try
            {
                cachedCredentialsLock.EnterWriteLock();
                cachedCredentials = null;
                CredentialsGenerators = new List<CredentialsGenerator>
                {
#if BCL
                () => new AppConfigAWSCredentials(),            // Test explicit keys/profile name first.
#endif
                    () => AssumeRoleWithWebIdentityCredentials.FromEnvironmentVariables(),
                    // Attempt to load the default profile.  It could be Basic, Session, AssumeRole, or SAML.
                    () => GetAWSCredentials(credentialProfileChain),
                    () => new EnvironmentVariablesAWSCredentials(), // Look for credentials set in environment vars.
                    () => ContainerEC2CredentialsWrapper(), // either get ECS / EKS credentials or instance profile credentials
                };
            }
            finally
            {
                cachedCredentialsLock.ExitWriteLock();
            }
        }

        internal static string GetProfileName()
        {
            var profileName = AWSConfigs.AWSProfileName;

            if (string.IsNullOrEmpty(profileName?.Trim()))
                profileName = Environment.GetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE);

            if (string.IsNullOrEmpty(profileName?.Trim()))
                profileName = DefaultProfileName;

            return profileName;
        }

        private static AWSCredentials GetAWSCredentials(ICredentialProfileSource source)
        {
            var profileName = GetProfileName();

            CredentialProfile profile;
            if (source.TryGetProfile(profileName, out profile))
                return profile.GetAWSCredentials(source, true);

            throw new AmazonClientException($"Unable to find the \"{ profileName }\" profile in CredentialProfileStoreChain.");
        }

        /// <summary>
        /// If either AWS_CONTAINER_CREDENTIALS_RELATIVE_URI or AWS_CONTAINER_CREDENTIALS_FULL_URI environment variables are set, we want to attempt to retrieve credentials
        /// using the generic container provider.
        /// 
        /// If they're not set, we will default to instance profile credentials.
        /// </summary>
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

        private static AWSCredentials cachedCredentials;
        public static AWSCredentials GetCredentials()
        {
            return GetCredentials(false);
        }
        /// <summary>
        /// This overloaded method accepts a config parameter and looks to see if Profile is set on the config.
        /// If this value is set, then the SDK tries to return the appropriate credentials for Profile.Name
        /// in Profile.Location if it is set. If config.Profile is not set then it fallsback to the regular logic.
        /// If config.Profile is set but that profile doesn't exist then an exception is thrown.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="fallbackToAnonymous"></param>
        /// <returns></returns>
        /// <exception cref="AmazonClientException"></exception>
        public static AWSCredentials GetCredentials(IClientConfig config, bool fallbackToAnonymous = false)
        {
            CredentialProfile storedProfile;
            Profile profile = config.Profile;
            if (profile != null)
            {
                CredentialProfileStoreChain source = new CredentialProfileStoreChain(profile.Location);
                if (source.TryGetProfile(profile.Name, out storedProfile))
                    return storedProfile.GetAWSCredentials(source, true);
                else
                {
                    throw new AmazonClientException($"Unable to find the \"{ profile.Name }\" profile in CredentialProfileStoreChain.");
                }
            }
            else
            {
                return GetCredentials(fallbackToAnonymous);
            }
        }

        public static AWSCredentials GetCredentials(bool fallbackToAnonymous)
        {
            try
            {
                cachedCredentialsLock.EnterReadLock();
                if (cachedCredentials != null)
                {
                    return cachedCredentials;
                }
            }
            finally
            {
                cachedCredentialsLock.ExitReadLock();
            }
            
            try
            {
                cachedCredentialsLock.EnterWriteLock();
                if (cachedCredentials != null)
                {
                    return cachedCredentials;
                }
                
                List<Exception> errors = new List<Exception>();
                foreach (CredentialsGenerator generator in CredentialsGenerators)
                {
                    try
                    {
                        cachedCredentials = generator();
                    }
                    // Breaking the FallbackCredentialFactory chain in case a ProcessAWSCredentialException exception 
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
                        cachedCredentials = null;

                        errors.Add(e);
                    }

                    if (cachedCredentials != null)
                        break;
                }

                if (cachedCredentials == null)
                {
                    if (fallbackToAnonymous)
                    {
                        return new AnonymousAWSCredentials();
                    }

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

                        throw new AmazonServiceException(writer.ToString());
                    }
                }

                return cachedCredentials;
            }
            finally
            {
                cachedCredentialsLock.ExitWriteLock();
            }
        }
    }
}
