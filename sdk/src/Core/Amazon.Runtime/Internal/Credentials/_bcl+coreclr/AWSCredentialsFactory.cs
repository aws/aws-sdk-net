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
using Amazon.Util;
using System;
using System.Globalization;
using System.IO;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Factory to construct different types of AWSCredentials based on a profile.
    /// </summary>
    public static class AWSCredentialsFactory
    {
        private const string RoleSessionNamePrefix = "aws-dotnet-sdk-session-";

#if BCL
        private static readonly SAMLEndpointManager EndpointManager = new SAMLEndpointManager();
#endif

        /// <summary>
        /// Get credentials for the given profile, or throws InvalidDataException.
        /// </summary>
        /// <param name="profile">The profile to create credentials with.</param>
        /// <returns>Valid credentials if they can be created.</returns>
        public static AWSCredentials GetAWSCredentials(CredentialProfile profile)
        {
            return GetAWSCredentials(profile, true, false);
        }

        /// <summary>
        /// Return the credentials for the profile if valid credentials can created.
        /// </summary>
        /// <param name="profile">The profile to create credentials with.</param>
        /// <param name="credentials">The credentials for the profile.</param>
        /// <returns>True if credentials can be created from the profile, false otherwise.</returns>
        public static bool TryGetAWSCredentials(CredentialProfile profile, out AWSCredentials credentials)
        {
            credentials = GetAWSCredentials(profile, false, false);
            return credentials != null;
        }

        private static AWSCredentials GetAWSCredentials(CredentialProfile profile, bool throwIfInvalid, bool isSourceProfile)
        {
            var options = profile.Options;
            if (profile.CanCreateAWSCredentials)
            {
                // The isSourceProfile parameter is important to prevent possible stack overflow in recursive call.
                if (isSourceProfile && profile.ProfileType != CredentialProfileType.Basic)
                {
                    return ThrowOrReturnNull(string.Format(CultureInfo.InvariantCulture,
                        "Source profile [{0}] is not a basic profile.", profile.Name), null, throwIfInvalid);
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
                        BasicAWSCredentials sourceCredentials;
                        // get basic credentials from another profile in the same store
                        try
                        {
                            CredentialProfile sourceProfile = null;
                            if (profile.ProfileStore.TryGetProfile(options.SourceProfile, out sourceProfile))
                            {
                                // Sending true for the isSourceProfile prevents possible stack overflow on recursive call.
                                sourceCredentials = (BasicAWSCredentials)GetAWSCredentials(sourceProfile, throwIfInvalid, true);
                            }
                            else
                            {
                                return ThrowOrReturnNull(string.Format(CultureInfo.InvariantCulture,
                                    "Source profile [{0}] was not found.", options.SourceProfile), null, throwIfInvalid);
                            }
                        }
                        catch (InvalidDataException e)
                        {
                            return ThrowOrReturnNull(string.Format(CultureInfo.InvariantCulture,
                                "Error reading source profile [{0}] for profile [{1}].", options.SourceProfile, profile.Name),
                                e, throwIfInvalid);
                        }

                        var roleSessionName = RoleSessionNamePrefix + DateTime.UtcNow.Ticks;
                        var assumeRoleOptions = new AssumeRoleAWSCredentialsOptions()
                        {
                            ExternalId = options.ExternalID,
                            MfaSerialNumber = options.MfaSerial
                        };
                        return new AssumeRoleAWSCredentials(sourceCredentials, options.RoleArn, roleSessionName, assumeRoleOptions);
#if BCL
                    case CredentialProfileType.SAMLRole:
                    case CredentialProfileType.SAMLRoleUserIdentity:
                        var federatedOptions = new FederatedAWSCredentialsOptions()
                        {
                            UserIdentity = profile.Options.UserIdentity,
                            ProfileName = profile.Name
                        };
                        return new FederatedAWSCredentials(EndpointManager.GetEndpoint(profile.Options.EndpointName),
                            profile.Options.RoleArn, federatedOptions);
#endif
                    default:
                        return ThrowOrReturnNull(string.Format(CultureInfo.InvariantCulture,
                            "Invalid ProfileType {0} for credential profile [{1}].", profile.ProfileType, profile.Name),
                            null, throwIfInvalid);
                }
            }
            else
            {
                return ThrowOrReturnNull(string.Format(CultureInfo.InvariantCulture,
                    "Credential profile [{0}] is not valid.  Please ensure the profile contains a valid combination of properties.", profile.Name),
                    null, throwIfInvalid);
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
