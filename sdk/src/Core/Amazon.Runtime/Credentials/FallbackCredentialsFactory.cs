/*
 * Copyright 2011-2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
#if BCL || CORECLR
using Amazon.Runtime.CredentialManagement;
#endif
using Amazon.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security;

namespace Amazon.Runtime
{
    // Credentials fallback mechanism
    public static class FallbackCredentialsFactory
    {
#if BCL || CORECLR
        internal const string AWS_PROFILE_ENVIRONMENT_VARIABLE = "AWS_PROFILE";
        internal const string DefaultProfileName = "default";

        private static CredentialProfileStoreChain credentialProfileChain = new CredentialProfileStoreChain();
#endif

        static FallbackCredentialsFactory()
        {
            Reset();
        }

        public delegate AWSCredentials CredentialsGenerator();
        public static List<CredentialsGenerator> CredentialsGenerators { get; set; }
        public static void Reset()
        {
            cachedCredentials = null;
            CredentialsGenerators = new List<CredentialsGenerator>
            {
#if BCL
                () => new AppConfigAWSCredentials(),            // Test explicit keys/profile name first.
#endif
#if BCL || CORECLR
                // Attempt to load the default profile.  It could be Basic, Session, AssumeRole, or SAML.
                () => GetAWSCredentials(credentialProfileChain),
                () => new EnvironmentVariablesAWSCredentials(), // Look for credentials set in environment vars.
                ECSEC2CredentialsWrapper,                       // either get ECS credentials or instance profile credentials
#endif
            };
        }

#if BCL || CORECLR
        private static AWSCredentials GetAWSCredentials(ICredentialProfileSource source)
        {
            var profileName = Environment.GetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE);
            if (profileName == null)
                profileName = DefaultProfileName;

            CredentialProfile profile;
            if (source.TryGetProfile(profileName, out profile))
                return profile.GetAWSCredentials(source, true);
            else
                throw new AmazonClientException("Unable to find the '" + profileName + "' profile in CredentialProfileStoreChain.");
        }

        /// If AWS_CONTAINER_CREDENTIALS_RELATIVE_URI environment variable is set, we want to attempt to retrieve credentials
        /// using ECS endpoint instead of referring to instance profile credentials.
        private static AWSCredentials ECSEC2CredentialsWrapper()
        {
            try
            {
                string uri = System.Environment.GetEnvironmentVariable(ECSTaskCredentials.ContainerCredentialsURIEnvVariable);
                if (!string.IsNullOrEmpty(uri))
                {
                    return new ECSTaskCredentials();
                }
            }
            catch (SecurityException e)
            {
                Logger.GetLogger(typeof(ECSTaskCredentials)).Error(e, "Failed to access environment variable {0}", ECSTaskCredentials.ContainerCredentialsURIEnvVariable);
            }
            return new InstanceProfileAWSCredentials();
        }
#endif

        private static AWSCredentials cachedCredentials;
        public static AWSCredentials GetCredentials()
        {
            return GetCredentials(false);
        }

        public static AWSCredentials GetCredentials(bool fallbackToAnonymous)
        {
            if (cachedCredentials != null)
                return cachedCredentials;

            List<Exception> errors = new List<Exception>();

            foreach (CredentialsGenerator generator in CredentialsGenerators)
            {
                try
                {
                    cachedCredentials = generator();
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
    }
}
