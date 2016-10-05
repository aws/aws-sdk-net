/*
 * Copyright 2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Class to construct different types of AWSCredentials based on a profile.
    /// </summary>
    public class AWSCredentialsFactory
    {
        private const string RoleSessionNamePrefix = "aws-dotnet-sdk-session-";

        public ICredentialProfileSource ProfileSource { get; private set; }

        /// <summary>
        /// Construct an AWSCredentialsFactory.
        /// </summary>
        /// <param name="profileSource">The profile source to search for credentials.</param>
        public AWSCredentialsFactory(ICredentialProfileSource profileSource)
        {
            ProfileSource = profileSource;
        }

        /// <summary>
        /// Get credentials for the given profile.
        /// </summary>
        /// <param name="profileName">The name of profile to find credentials for.</param>
        /// <returns>True if the profile exists and has valid credentials, false otherwise.</returns>
        public AWSCredentials GetAWSCredentials(string profileName)
        {
            return GetAWSCredentials(profileName, true, false);
        }

        /// <summary>
        /// Return the credentials for the profile if valid credentials can be found.
        /// </summary>
        /// <param name="profileName">The name of profile to find credentials for.</param>
        /// <param name="credentials">The credentials for the profile.</param>
        /// <returns>True if the profile was found and it contained valid credentials, false otherwise.</returns>
        public bool TryGetAWSCredentials(string profileName, out AWSCredentials credentials)
        {
            credentials = GetAWSCredentials(profileName, false, false);
            return credentials != null;
        }

        private AWSCredentials GetAWSCredentials(string profileName, bool throwIfInvalid, bool isSourceProfile)
        {
            CredentialProfile profile = null;
            if (ProfileSource.TryGetProfile(profileName, out profile))
            {
                var options = profile.Options;
                if (profile.IsValid)
                {
                    // The isSourceProfile parameter is important to prevent possible stack overflow in recursive call.
                    if (isSourceProfile && profile.ProfileType != CredentialProfileType.Basic)
                    {
                        return ThrowOrReturnNull(string.Format(CultureInfo.InvariantCulture,
                            "Source profile [{0}] is not a basic profile.", profileName), null, throwIfInvalid);
                    }

                    switch (profile.ProfileType)
                    {
                        case CredentialProfileType.Basic:
                            return new BasicAWSCredentials(options.AccessKey, options.SecretKey);
                        case CredentialProfileType.Session:
                            return new SessionAWSCredentials(options.AccessKey, options.SecretKey, options.Token);
                        case CredentialProfileType.AssumeRole:
                        case CredentialProfileType.AssumeRoleExternal:
                        case CredentialProfileType.AssumeRoleMFA:
                        case CredentialProfileType.AssumeRoleExternalMFA:
                        case CredentialProfileType.FullAssumeRole:
                        case CredentialProfileType.FullAssumeRoleExternal:
                        case CredentialProfileType.FullAssumeRoleExternalMFA:
                        case CredentialProfileType.FullAssumeRoleMFA:
                            BasicAWSCredentials sourceCredentials = null;
                            if (options.SourceProfile == null)
                            {
                                // get basic credentials from this profile
                                sourceCredentials = new BasicAWSCredentials(options.AccessKey, options.SecretKey);
                            }
                            else
                            {
                                // get basic credentials from a separate source profile
                                try
                                {
                                    // Sending true for the isSourceProfile prevents possible stack overflow on recursive call.
                                    sourceCredentials = (BasicAWSCredentials)GetAWSCredentials(options.SourceProfile, throwIfInvalid, true);
                                }
                                catch (InvalidDataException e)
                                {
                                    return ThrowOrReturnNull(string.Format(CultureInfo.InvariantCulture,
                                        "Error reading source profile [{0}] for profile [{1}].", options.SourceProfile, profile.Name),
                                        e, throwIfInvalid);
                                }
                            }

                            var roleSessionName = RoleSessionNamePrefix + DateTime.UtcNow.Ticks;
                            var assumeRoleOptions = new AssumeRoleAWSCredentialsOptions()
                            {
                                ExternalId = options.ExternalID,
                                MfaSerialNumber = options.MfaSerial
                            };
                            return new AssumeRoleAWSCredentials(sourceCredentials, options.RoleArn, roleSessionName, assumeRoleOptions);
                        default:
                            return ThrowOrReturnNull(string.Format(CultureInfo.InvariantCulture,
                                "Invalid ProfileType {0} for credential profile [{1}].", profile.ProfileType, profileName),
                                null, throwIfInvalid);
                    }
                }
                else
                {
                    return ThrowOrReturnNull(string.Format(CultureInfo.InvariantCulture,
                        "Credential profile [{0}] is not valid.  Please ensure the profile contains a valid combination of properties.", profileName),
                        null, throwIfInvalid);
                }
            }
            else
            {
                return ThrowOrReturnNull(string.Format(CultureInfo.InvariantCulture,
                    "Credential profile [{0}] was not found.", profileName), null, throwIfInvalid);
            }
        }

        /// <summary>
        /// Helper to reduce clutter
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="doThrow"></param>
        /// <returns></returns>
        private static BasicAWSCredentials ThrowOrReturnNull(string message, Exception innerException, bool doThrow)
        {
            if (doThrow)
            {
                throw new InvalidDataException(message, innerException);
            }
            else
            {
                return null;
            }
        }
    }
}
