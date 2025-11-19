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
using Amazon.Runtime.CredentialManagement;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Amazon.Runtime.CredentialManagement.Internal
{
    public enum CredentialProfileType
    {
        AssumeRole,
        AssumeRoleCredentialSource,
        AssumeRoleExternal,
        AssumeRoleExternalMFA,
        AssumeRoleMFA,
        Basic,
        SAMLRole,
        SAMLRoleUserIdentity,
        Session,
        CredentialProcess,
        AssumeRoleWithWebIdentity,
        AssumeRoleWithWebIdentitySessionName,
        AssumeRoleSessionName,
        AssumeRoleCredentialSourceSessionName,
        AssumeRoleExternalSessionName,
        AssumeRoleExternalMFASessionName,
        AssumeRoleMFASessionName,
#if !BCL35
        SSO,
#endif
        AssumeRoleWithServices,
        AssumeRoleWithGlobalEndpoint,
        AssumeRoleWithServicesAndGlobalEndpoint,
        AssumeRoleCredentialSourceWithGlobalEndpoint,
        AssumeRoleCredentialSourceWithServices,
        AssumeRoleCredentialSourceWithServicesAndGlobalEndpoint,
        AssumeRoleExternalWithServices,
        AssumeRoleExternalWithGlobalEndpoint,
        AssumeRoleExternalWithServicesAndGlobalEndpoint,
        AssumeRoleExternalMFAWithServices,
        AssumeRoleExternalMFAWithGlobalEndpoint,
        AssumeRoleExternalMFAWithServicesAndGlobalEndpoint,
        AssumeRoleMFAWithServices,
        AssumeRoleMFAWithGlobalEndpoint,
        AssumeRoleMFAWithServicesAndGlobalEndpoint,
        BasicWithServices,
        BasicWithGlobalEndpoint,
        BasicWithServicesAndGlobalEndpoint,
        AssumeRoleWithWebIdentityWithServices,
        AssumeRoleWithWebIdentityWithGlobalEndpoint,
        AssumeRoleWithWebIdentityWithServicesAndGlobalEndpoint,
        AssumeRoleWithWebIdentitySessionNameWithServices,
        AssumeRoleWithWebIdentitySessionNameWithGlobalEndpoint,
        AssumeRoleWithWebIdentitySessionNameWithServicesAndGlobalEndpoint,
        AssumeRoleSessionNameWithServices,
        AssumeRoleSessionNameWithGlobalEndpoint,
        AssumeRoleSessionNameWithServicesAndGlobalEndpoint,
        AssumeRoleCredentialSourceSessionNameWithServices,
        AssumeRoleCredentialSourceSessionNameWithGlobalEndpoint,
        AssumeRoleCredentialSourceSessionNameWithServicesAndGlobalEndpoint,
        AssumeRoleExternalSessionNameWithServices,
        AssumeRoleExternalSessionNameWithGlobalEndpoint,
        AssumeRoleExternalSessionNameWithServicesAndGlobalEndpoint,
        AssumeRoleExternalMFASessionNameWithServices,
        AssumeRoleExternalMFASessionNameWithGlobalEndpoint,
        AssumeRoleExternalMFASessionNameWithServicesAndGlobalEndpoint,
        AssumeRoleMFASessionNameWithServices,
        AssumeRoleMFASessionNameWithGlobalEndpoint,
        AssumeRoleMFASessionNameWithServicesAndGlobalEndpoint,
        SAMLRoleWithServices,
        SAMLRoleWithGlobalEndpoint,
        SAMLRoleWithServicesAndGlobalEndpoint,
        SAMLRoleUserIdentityWithServices,
        SAMLRoleUserIdentityWithGlobalEndpoint,
        SAMLRoleUserIdentityWithServicesAndGlobalEndpoint,
        SessionWithServices,
        SessionWithGlobalEndpoint,
        SessionWithServicesAndGlobalEndpoint,
#if !BCL
        Login,
#endif
    }

    public enum CredentialSourceType
    {
        Ec2InstanceMetadata,
        Environment,
        EcsContainer
    }

    public static class CredentialProfileTypeDetector
    {
        private const string BasicCredentials = "Basic";
        private const string SessionCredentials = "Session";
        private const string AssumeRoleCredentials = "Assume Role";
        private const string AssumeRoleWithWebIdentityCredentials = "Assume Role with OIDC Web Identity";
        private const string SAMLCredentials = "SAML";
        
        private const string Services = "Services";
        private const string AccessKey = "AccessKey";
        private const string CredentialSource = "CredentialSource";
        private const string EndpointName = "EndpointName";
        private const string ExternalID = "ExternalID";
        private const string MfaSerial = "MfaSerial";
        private const string RoleArn = "RoleArn";
        private const string RoleSessionName = "RoleSessionName";
        private const string SecretKey = "SecretKey";
        private const string SourceProfile = "SourceProfile";        
        private const string Token = "Token";
        private const string WebIdentityTokenFile = "WebIdentityTokenFile";
        private const string UserIdentity = "UserIdentity";
        private const string CredentialProcess = "CredentialProcess";
        private const string EndpointUrl = "EndpointUrl";

#if !BCL35
        private const string SsoAccountId = nameof(CredentialProfileOptions.SsoAccountId);
        private const string SsoRegion = nameof(CredentialProfileOptions.SsoRegion);
        private const string SsoRegistrationScopes = nameof(CredentialProfileOptions.SsoRegistrationScopes);
        private const string SsoRoleName = nameof(CredentialProfileOptions.SsoRoleName);
        private const string SsoStartUrl = nameof(CredentialProfileOptions.SsoStartUrl);
        private const string SsoSession = nameof(CredentialProfileOptions.SsoSession);

        private static HashSet<string> SsoProperties = new HashSet<string>(
            new string[] {SsoAccountId, SsoRegion, SsoRegistrationScopes, SsoRoleName, SsoStartUrl, SsoSession},
            StringComparer.OrdinalIgnoreCase);
#endif
#if !BCL
        private const string LoginSession = nameof(CredentialProfileOptions.LoginSession);
#endif

        private static Dictionary<CredentialProfileType, HashSet<string>> TypePropertyDictionary =
            new Dictionary<CredentialProfileType, HashSet<string>>()
            {
                {
                    CredentialProfileType.CredentialProcess, new HashSet<string>()
                    {
                        CredentialProcess
                    }
                },
                {
                    CredentialProfileType.AssumeRole, new HashSet<string>()
                    {
                        RoleArn,
                        SourceProfile,
                    }
                },
                {
                    CredentialProfileType.AssumeRoleWithServices, new HashSet<string>()
                    {
                        RoleArn,
                        SourceProfile,
                        Services
                    }
                },
                {
                    CredentialProfileType.AssumeRoleWithGlobalEndpoint, new HashSet<string>()
                    {
                        RoleArn,
                        SourceProfile,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.AssumeRoleWithServicesAndGlobalEndpoint, new HashSet<string>()
                    {
                        RoleArn,
                        SourceProfile,
                        Services,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.AssumeRoleCredentialSource, new HashSet<string>()
                    {
                        RoleArn,
                        CredentialSource,
                    }
                },
                {
                    CredentialProfileType.AssumeRoleCredentialSourceWithGlobalEndpoint, new HashSet<string>()
                    {
                        RoleArn,
                        CredentialSource,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.AssumeRoleCredentialSourceWithServices, new HashSet<string>()
                    {
                        RoleArn,
                        CredentialSource,
                        Services
                    }
                },
                {
                    CredentialProfileType.AssumeRoleCredentialSourceWithServicesAndGlobalEndpoint, new HashSet<string>()
                    {
                        RoleArn,
                        CredentialSource,
                        Services,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.AssumeRoleExternal, new HashSet<string>()
                    {
                        ExternalID,
                        RoleArn,
                        SourceProfile,
                    }
                },
                {
                    CredentialProfileType.AssumeRoleExternalWithServices, new HashSet<string>()
                    {
                        ExternalID,
                        RoleArn,
                        SourceProfile,
                        Services
                    }
                },
                {
                    CredentialProfileType.AssumeRoleExternalWithGlobalEndpoint, new HashSet<string>()
                    {
                        ExternalID,
                        RoleArn,
                        SourceProfile,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.AssumeRoleExternalWithServicesAndGlobalEndpoint, new HashSet<string>()
                    {
                        ExternalID,
                        RoleArn,
                        SourceProfile,
                        EndpointUrl,
                        Services
                    }
                },
                {
                    CredentialProfileType.AssumeRoleExternalMFA, new HashSet<string>()
                    {
                        ExternalID,
                        MfaSerial,
                        RoleArn,
                        SourceProfile,
                    }
                },
                {
                    CredentialProfileType.AssumeRoleExternalMFAWithServices, new HashSet<string>()
                    {
                        ExternalID,
                        MfaSerial,
                        RoleArn,
                        SourceProfile,
                        Services
                    }
                },
                {
                    CredentialProfileType.AssumeRoleExternalMFAWithGlobalEndpoint, new HashSet<string>()
                    {
                        ExternalID,
                        MfaSerial,
                        RoleArn,
                        SourceProfile,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.AssumeRoleExternalMFAWithServicesAndGlobalEndpoint, new HashSet<string>()
                    {
                        ExternalID,
                        MfaSerial,
                        RoleArn,
                        SourceProfile,
                        Services,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.AssumeRoleWithWebIdentity, new HashSet<string>()
                    {
                        RoleArn,
                        WebIdentityTokenFile,
                    }
                },
                {
                    CredentialProfileType.AssumeRoleWithWebIdentityWithServices, new HashSet<string>()
                    {
                        RoleArn,
                        WebIdentityTokenFile,
                        Services
                    }
                },
                {
                    CredentialProfileType.AssumeRoleWithWebIdentityWithGlobalEndpoint, new HashSet<string>()
                    {
                        RoleArn,
                        WebIdentityTokenFile,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.AssumeRoleWithWebIdentityWithServicesAndGlobalEndpoint, new HashSet<string>()
                    {
                        RoleArn,
                        WebIdentityTokenFile,
                        EndpointUrl,
                        Services
                    }
                },
                {
                    CredentialProfileType.AssumeRoleWithWebIdentitySessionName, new HashSet<string>()
                    {
                        RoleArn,
                        WebIdentityTokenFile,
                        RoleSessionName
                    }
                },
                {
                    CredentialProfileType.AssumeRoleWithWebIdentitySessionNameWithServices, new HashSet<string>()
                    {
                        RoleArn,
                        WebIdentityTokenFile,
                        RoleSessionName,
                        Services
                    }
                },
                {
                    CredentialProfileType.AssumeRoleWithWebIdentitySessionNameWithGlobalEndpoint, new HashSet<string>()
                    {
                        RoleArn,
                        WebIdentityTokenFile,
                        RoleSessionName,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.AssumeRoleWithWebIdentitySessionNameWithServicesAndGlobalEndpoint, new HashSet<string>()
                    {
                        RoleArn,
                        WebIdentityTokenFile,
                        RoleSessionName,
                        Services,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.AssumeRoleMFA, new HashSet<string>()
                    {
                        MfaSerial,
                        RoleArn,
                        SourceProfile,
                    }
                },
                {
                    CredentialProfileType.AssumeRoleMFAWithServices, new HashSet<string>()
                    {
                        MfaSerial,
                        RoleArn,
                        SourceProfile,
                        Services
                    }
                },
                {
                    CredentialProfileType.AssumeRoleMFAWithGlobalEndpoint, new HashSet<string>()
                    {
                        MfaSerial,
                        RoleArn,
                        SourceProfile,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.AssumeRoleMFAWithServicesAndGlobalEndpoint, new HashSet<string>()
                    {
                        MfaSerial,
                        RoleArn,
                        SourceProfile,
                        EndpointUrl,
                        Services
                    }
                },
                {
                    CredentialProfileType.Basic, new HashSet<string>()
                    {
                        AccessKey,
                        SecretKey,
                    }
                },
                {
                    CredentialProfileType.BasicWithServices, new HashSet<string>()
                    {
                        AccessKey,
                        SecretKey,
                        Services
                    }
                },
                {
                    CredentialProfileType.BasicWithGlobalEndpoint, new HashSet<string>()
                    {
                        AccessKey,
                        SecretKey,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.BasicWithServicesAndGlobalEndpoint, new HashSet<string>()
                    {
                        AccessKey,
                        SecretKey,
                        EndpointUrl,
                        Services
                    }
                },
                {
                    CredentialProfileType.SAMLRole, new HashSet<string>()
                    {
                        EndpointName,
                        RoleArn,
                    }
                },
                {
                    CredentialProfileType.SAMLRoleWithServices, new HashSet<string>()
                    {
                        EndpointName,
                        RoleArn,
                        Services
                    }
                },
                {
                    CredentialProfileType.SAMLRoleWithGlobalEndpoint, new HashSet<string>()
                    {
                        EndpointName,
                        RoleArn,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.SAMLRoleWithServicesAndGlobalEndpoint, new HashSet<string>()
                    {
                        EndpointName,
                        RoleArn,
                        Services,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.SAMLRoleUserIdentity, new HashSet<string>()
                    {
                        EndpointName,
                        RoleArn,
                        UserIdentity,
                    }
                },
                {
                    CredentialProfileType.SAMLRoleUserIdentityWithServices, new HashSet<string>()
                    {
                        EndpointName,
                        RoleArn,
                        UserIdentity,
                        Services
                    }
                },
                {
                    CredentialProfileType.SAMLRoleUserIdentityWithGlobalEndpoint, new HashSet<string>()
                    {
                        EndpointName,
                        RoleArn,
                        UserIdentity,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.SAMLRoleUserIdentityWithServicesAndGlobalEndpoint, new HashSet<string>()

                    {
                        EndpointName,
                        RoleArn,
                        UserIdentity,
                        EndpointUrl,
                        Services
                    }

                },
                {
                    CredentialProfileType.Session, new HashSet<string>()
                    {
                        AccessKey,
                        SecretKey,
                        Token,
                    }
                },
                {
                    CredentialProfileType.SessionWithServices, new HashSet<string>()
                    {
                        AccessKey,
                        SecretKey,
                        Token,
                        Services
                    }
                },
                {
                    CredentialProfileType.SessionWithGlobalEndpoint, new HashSet<string>()
                    {
                        AccessKey,
                        SecretKey,
                        Token,
                        EndpointUrl
                        
                    }
                },
                {
                    CredentialProfileType.SessionWithServicesAndGlobalEndpoint, new HashSet<string>()
                    {
                        AccessKey,
                        SecretKey,
                        Token,
                        EndpointUrl,
                        Services
                    }
                },
                {
                    CredentialProfileType.AssumeRoleSessionName, new HashSet<string>()
                    {
                        RoleArn,
                        SourceProfile,
                        RoleSessionName
                    }
                },
                {
                    CredentialProfileType.AssumeRoleSessionNameWithServices, new HashSet<string>()
                    {
                        RoleArn,
                        SourceProfile,
                        RoleSessionName,
                        Services
                    }
                },
                {
                    CredentialProfileType.AssumeRoleSessionNameWithGlobalEndpoint, new HashSet<string>()
                    {
                        RoleArn,
                        SourceProfile,
                        RoleSessionName,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.AssumeRoleSessionNameWithServicesAndGlobalEndpoint, new HashSet<string>()
                    {
                        RoleArn,
                        SourceProfile,
                        RoleSessionName,
                        EndpointUrl,
                        Services
                    }
                },
                {
                    CredentialProfileType.AssumeRoleCredentialSourceSessionName, new HashSet<string>()
                    {
                        RoleArn,
                        CredentialSource,
                        RoleSessionName
                    }
                },
                {
                    CredentialProfileType.AssumeRoleCredentialSourceSessionNameWithServices, new HashSet<string>()
                    {
                        RoleArn,
                        CredentialSource,
                        RoleSessionName,
                        Services
                    }
                },
                {
                    CredentialProfileType.AssumeRoleCredentialSourceSessionNameWithGlobalEndpoint, new HashSet<string>()
                    {
                        RoleArn,
                        CredentialSource,
                        RoleSessionName,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.AssumeRoleCredentialSourceSessionNameWithServicesAndGlobalEndpoint, new HashSet<string>()
                    {
                        RoleArn,
                        CredentialSource,
                        RoleSessionName,
                        EndpointUrl,
                        Services
                    }
                },
                {
                    CredentialProfileType.AssumeRoleExternalSessionName, new HashSet<string>()
                    {
                        ExternalID,
                        RoleArn,
                        SourceProfile,
                        RoleSessionName
                    }
                },
                {
                    CredentialProfileType.AssumeRoleExternalSessionNameWithServices, new HashSet<string>()
                    {
                        ExternalID,
                        RoleArn,
                        SourceProfile,
                        RoleSessionName,
                        Services
                    }
                },
                {
                    CredentialProfileType.AssumeRoleExternalSessionNameWithGlobalEndpoint, new HashSet<string>()
                    {
                        ExternalID,
                        RoleArn,
                        SourceProfile,
                        RoleSessionName,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.AssumeRoleExternalSessionNameWithServicesAndGlobalEndpoint, new HashSet<string>()
                    {
                        ExternalID,
                        RoleArn,
                        SourceProfile,
                        RoleSessionName,
                        Services,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.AssumeRoleExternalMFASessionName, new HashSet<string>()
                    {
                        ExternalID,
                        MfaSerial,
                        RoleArn,
                        SourceProfile,
                        RoleSessionName
                    }
                },
                {
                    CredentialProfileType.AssumeRoleExternalMFASessionNameWithServices, new HashSet<string>()
                    {
                        ExternalID,
                        MfaSerial,
                        RoleArn,
                        SourceProfile,
                        RoleSessionName,
                        Services
                    }
                },
                {
                    CredentialProfileType.AssumeRoleExternalMFASessionNameWithGlobalEndpoint, new HashSet<string>()
                    {
                        ExternalID,
                        MfaSerial,
                        RoleArn,
                        SourceProfile,
                        RoleSessionName,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.AssumeRoleExternalMFASessionNameWithServicesAndGlobalEndpoint, new HashSet<string>()
                    {
                        ExternalID,
                        MfaSerial,
                        RoleArn,
                        SourceProfile,
                        RoleSessionName,
                        Services,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.AssumeRoleMFASessionName, new HashSet<string>()
                    {
                        MfaSerial,
                        RoleArn,
                        SourceProfile,
                        RoleSessionName
                    }
                },
                {
                    CredentialProfileType.AssumeRoleMFASessionNameWithServices, new HashSet<string>()
                    {
                        MfaSerial,
                        RoleArn,
                        SourceProfile,
                        RoleSessionName,
                        Services
                    }
                },
                {
                    CredentialProfileType.AssumeRoleMFASessionNameWithGlobalEndpoint, new HashSet<string>()
                    {
                        MfaSerial,
                        RoleArn,
                        SourceProfile,
                        RoleSessionName,
                        EndpointUrl
                    }
                },
                {
                    CredentialProfileType.AssumeRoleMFASessionNameWithServicesAndGlobalEndpoint, new HashSet<string>()
                    {
                        MfaSerial,
                        RoleArn,
                        SourceProfile,
                        RoleSessionName,
                        Services,
                        EndpointUrl
                    }
                },
#if !BCL35
                {
                    CredentialProfileType.SSO, new HashSet<string>()
                    {
                        SsoAccountId,
                        SsoRegion,
                        SsoRegistrationScopes,
                        SsoRoleName,
                        SsoStartUrl,
                        SsoSession
                    }
                },
#endif
#if !BCL
                {
                    CredentialProfileType.Login, new HashSet<string>()
                    {
                        LoginSession
                    }
                },
#endif
            };

        private static Dictionary<CredentialProfileType, string> CredentialTypeDictionary =
            new Dictionary<CredentialProfileType, string>()
            {
                { CredentialProfileType.AssumeRole, AssumeRoleCredentials },
                { CredentialProfileType.AssumeRoleWithServices, AssumeRoleCredentials },
                { CredentialProfileType.AssumeRoleExternal, AssumeRoleCredentials },
                { CredentialProfileType.AssumeRoleExternalMFA, AssumeRoleCredentials },
                { CredentialProfileType.AssumeRoleMFA, AssumeRoleCredentials },
                { CredentialProfileType.AssumeRoleWithWebIdentity, AssumeRoleWithWebIdentityCredentials },
                { CredentialProfileType.AssumeRoleWithWebIdentitySessionName, AssumeRoleWithWebIdentityCredentials },
                { CredentialProfileType.AssumeRoleSessionName, AssumeRoleCredentials },
                { CredentialProfileType.AssumeRoleExternalSessionName, AssumeRoleCredentials },
                { CredentialProfileType.AssumeRoleExternalMFASessionName, AssumeRoleCredentials },
                { CredentialProfileType.AssumeRoleMFASessionName, AssumeRoleCredentials },
                { CredentialProfileType.Basic, BasicCredentials },
                { CredentialProfileType.SAMLRole, SAMLCredentials },
                { CredentialProfileType.SAMLRoleUserIdentity, SAMLCredentials },
                { CredentialProfileType.Session, SessionCredentials },
                { CredentialProfileType.CredentialProcess, CredentialProcess },
                { CredentialProfileType.BasicWithServices, BasicCredentials },
                { CredentialProfileType.BasicWithGlobalEndpoint, BasicCredentials },
                {CredentialProfileType.BasicWithServicesAndGlobalEndpoint, BasicCredentials },

            };

        public static string GetUserFriendlyCredentialType(CredentialProfileType? profileType)
        {
            if (profileType.HasValue)
            {
                return CredentialTypeDictionary[profileType.Value];
            }
            else
            {
                return null;
            }
        }

        public static CredentialProfileType? DetectProfileType(CredentialProfileOptions profileOptions)
        {
            CredentialProfileType? profileType = null;

            HashSet<string> propertyNames = GetPropertyNames(profileOptions);

#if !BCL35
            // Spec: If one or more of the SSO properties is present, the profile MUST be resolved by the SSO credential provider.
            if (propertyNames.Any(propertyName => SsoProperties.Contains(propertyName)))
            {
                return CredentialProfileType.SSO;
            }
#endif

            // brute force algorithm - but it's a very small set
            foreach (var pair in TypePropertyDictionary)
            {
                if (pair.Value.SetEquals(propertyNames))
                {
                    // exact match
                    profileType = pair.Key;
                }
            }

#if !BCL
            // If profile type was not detected due to presence of LoginSession property, then try to match without LoginSession
            if (profileType == null && propertyNames.Contains(LoginSession))
            {
                HashSet<string> propertyNamesWithoutLoginSession = new HashSet<string>(propertyNames.Where(p => p != LoginSession));

                foreach (var pair in TypePropertyDictionary)
                {
                    // If we have reached the Login profile type, it's of higher precedence than subsequent profiles.
                    if (pair.Key == CredentialProfileType.Login)
                    {
                        profileType = CredentialProfileType.Login;
                        break;
                    }

                    if (pair.Value.SetEquals(propertyNamesWithoutLoginSession))
                    {
                        profileType = pair.Key;
                        break;
                    }
                }
            }
#endif
            return profileType;
        }

        public static HashSet<string> GetPropertiesForProfileType(CredentialProfileType profileType)
        {
            return new HashSet<string>(TypePropertyDictionary[profileType]);
        }

        private static HashSet<string> GetPropertyNames(CredentialProfileOptions profileOptions)
        {
            HashSet<string> propertyNames = new HashSet<string>();
            foreach (var property in typeof(CredentialProfileOptions).GetProperties())
            {
                var value = (string)property.GetValue(profileOptions, null);
                if (!string.IsNullOrEmpty(value))
                {
                    propertyNames.Add(property.Name);
                }
            }
            return propertyNames;
        }
    }
}
