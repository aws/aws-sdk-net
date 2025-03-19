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
        SSO,
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
        private const string AwsAccountId = "AwsAccountId";

        private const string SsoAccountId = nameof(CredentialProfileOptions.SsoAccountId);
        private const string SsoRegion = nameof(CredentialProfileOptions.SsoRegion);
        private const string SsoRegistrationScopes = nameof(CredentialProfileOptions.SsoRegistrationScopes);
        private const string SsoRoleName = nameof(CredentialProfileOptions.SsoRoleName);
        private const string SsoStartUrl = nameof(CredentialProfileOptions.SsoStartUrl);
        private const string SsoSession = nameof(CredentialProfileOptions.SsoSession);

        private static HashSet<string> SsoProperties = new HashSet<string>(
            new string[] { SsoAccountId, SsoRegion, SsoRegistrationScopes, SsoRoleName, SsoStartUrl, SsoSession },
            StringComparer.OrdinalIgnoreCase);
        private static Dictionary<CredentialProfileType, List<HashSet<string>>> TypePropertyDictionary =
            new Dictionary<CredentialProfileType, List<HashSet<string>>>()
            {
                { 
                    CredentialProfileType.CredentialProcess, new List<HashSet<string>>() 
                    { 
                        new HashSet<string> { CredentialProcess } ,
                        new HashSet<string> { CredentialProcess, AwsAccountId }
                    } 
                },

                { 
                    CredentialProfileType.AssumeRole, new List<HashSet<string>>() 
                    {
                        new HashSet<string> { RoleArn, SourceProfile },
                        new HashSet<string> { RoleArn, SourceProfile, AwsAccountId },
                        new HashSet<string> { RoleArn, SourceProfile, AwsAccountId, Services },
                        new HashSet<string> { RoleArn, SourceProfile, AwsAccountId, EndpointUrl },
                        new HashSet<string> { RoleArn, SourceProfile, AwsAccountId, Services, EndpointUrl },
                    } 
                },
                { 
                    CredentialProfileType.AssumeRoleCredentialSource, new List<HashSet<string>>() 
                    { 
                        new HashSet<string> { RoleArn, CredentialSource },
                        new HashSet<string> { RoleArn, CredentialSource, AwsAccountId }
                    } 
                },
                {
                    CredentialProfileType.AssumeRoleExternal, new List<HashSet<string>>() 
                    { 
                        new HashSet<string> { ExternalID, RoleArn, SourceProfile },
                        new HashSet<string> { ExternalID, RoleArn, SourceProfile, AwsAccountId },
                        new HashSet<string> { ExternalID, RoleArn, SourceProfile, AwsAccountId, Services },
                        new HashSet<string> { ExternalID, RoleArn, SourceProfile, AwsAccountId, EndpointUrl },
                        new HashSet<string> { ExternalID, RoleArn, SourceProfile, AwsAccountId, EndpointUrl, Services }
                    } 
                },
                { CredentialProfileType.AssumeRoleExternalMFA, new List<HashSet<string>>() { new HashSet<string> { ExternalID, RoleArn, SourceProfile, MfaSerial } } },
                { 
                    CredentialProfileType.AssumeRoleWithWebIdentity, new List<HashSet<string>>() 
                    {
                        new HashSet<string> { RoleArn, WebIdentityTokenFile },
                        new HashSet<string> { RoleArn, WebIdentityTokenFile, CredentialSource },
                        new HashSet<string> { RoleArn, WebIdentityTokenFile, CredentialSource, AwsAccountId },
                        new HashSet<string> { RoleArn, WebIdentityTokenFile, AwsAccountId, Services },
                        new HashSet<string> { RoleArn, WebIdentityTokenFile, AwsAccountId, EndpointUrl },
                        new HashSet<string> { RoleArn, WebIdentityTokenFile, AwsAccountId, EndpointUrl, Services },
                    } 
                },
                { 
                    CredentialProfileType.AssumeRoleWithWebIdentitySessionName, new List<HashSet<string>>() 
                    { 
                        new HashSet<string> { RoleArn, WebIdentityTokenFile, RoleSessionName },
                        new HashSet<string> { RoleArn, WebIdentityTokenFile, RoleSessionName, AwsAccountId } ,
                        new HashSet<string> { RoleArn, WebIdentityTokenFile, RoleSessionName, AwsAccountId, Services } ,
                        new HashSet<string> { RoleArn, WebIdentityTokenFile, RoleSessionName, AwsAccountId, EndpointUrl } ,
                        new HashSet<string> { RoleArn, WebIdentityTokenFile, RoleSessionName, AwsAccountId, Services, EndpointUrl } ,

                    } 
                },
                { 
                    CredentialProfileType.AssumeRoleMFA, new List<HashSet<string>>() 
                    { 
                        new HashSet<string> { MfaSerial, RoleArn, SourceProfile },
                        new HashSet<string> { MfaSerial, RoleArn, SourceProfile, AwsAccountId },
                        new HashSet<string> { MfaSerial, RoleArn, SourceProfile, AwsAccountId, Services },
                        new HashSet<string> { MfaSerial, RoleArn, SourceProfile, AwsAccountId, Services, EndpointUrl},
                        new HashSet<string> { MfaSerial, RoleArn, SourceProfile, AwsAccountId, EndpointUrl }
                    } 
                },
                { CredentialProfileType.Basic, new List<HashSet<string>>() 
                    {
                        new HashSet<string> { AccessKey, SecretKey },
                        new HashSet<string> { AccessKey, SecretKey, AwsAccountId },
                        new HashSet<string> { AccessKey, SecretKey, AwsAccountId, EndpointUrl },
                        new HashSet<string> { AccessKey, SecretKey, AwsAccountId, Services, EndpointUrl },
                        new HashSet<string> { AccessKey, SecretKey, AwsAccountId, Services }
                    } 
                },
                { 
                    CredentialProfileType.SAMLRole, new List<HashSet<string>>() 
                    { 
                        new HashSet<string> { EndpointName, RoleArn },
                        new HashSet<string> { EndpointName, RoleArn, AwsAccountId },
                        new HashSet<string> { EndpointName, RoleArn, AwsAccountId, Services },
                        new HashSet<string> { EndpointName, RoleArn, AwsAccountId, Services, EndpointUrl }
                    } 
                },
                { CredentialProfileType.SAMLRoleUserIdentity, new List<HashSet<string>>() { new HashSet<string> { EndpointName, RoleArn, UserIdentity } } },
                { 
                    CredentialProfileType.Session, new List<HashSet<string>>() 
                    { 
                        new HashSet<string> { AccessKey, SecretKey, Token },
                        new HashSet<string> { AccessKey, SecretKey, Token, AwsAccountId },
                        new HashSet<string> { AccessKey, SecretKey, Token, AwsAccountId, EndpointUrl },
                        new HashSet<string> { AccessKey, SecretKey, Token, AwsAccountId, Services, EndpointUrl }
                    } 
                },
                { 
                    CredentialProfileType.AssumeRoleSessionName, new List<HashSet<string>>() 
                    { 
                        new HashSet<string> { RoleArn, SourceProfile, RoleSessionName },
                        new HashSet<string> { RoleArn, SourceProfile, RoleSessionName, AwsAccountId },
                        new HashSet<string> { RoleArn, SourceProfile, RoleSessionName, AwsAccountId, Services },
                        new HashSet<string> { RoleArn, SourceProfile, RoleSessionName, AwsAccountId, Services, EndpointUrl }
                    } 
                },
                { 
                    CredentialProfileType.AssumeRoleCredentialSourceSessionName, new List<HashSet<string>>() 
                    {
                        new HashSet<string> { RoleArn, CredentialSource, RoleSessionName },
                        new HashSet<string> { RoleArn, CredentialSource, RoleSessionName, AwsAccountId},
                        new HashSet<string> { RoleArn, CredentialSource, RoleSessionName, AwsAccountId, Services},
                        new HashSet<string> { RoleArn, CredentialSource, RoleSessionName, AwsAccountId, Services, EndpointUrl},
                    } 
                },
                { 
                    CredentialProfileType.AssumeRoleExternalSessionName, new List<HashSet<string>>() 
                    { 
                        new HashSet<string> { ExternalID, RoleArn, SourceProfile, RoleSessionName },
                        new HashSet<string> { ExternalID, RoleArn, SourceProfile, RoleSessionName, AwsAccountId },
                        new HashSet<string> { ExternalID, RoleArn, SourceProfile, RoleSessionName, AwsAccountId, EndpointUrl },
                        new HashSet<string> { ExternalID, RoleArn, SourceProfile, RoleSessionName, AwsAccountId, EndpointUrl, Services },
                    } 
                },
                { 
                    CredentialProfileType.AssumeRoleExternalMFASessionName, new List<HashSet<string>>() 
                    { 
                        new HashSet<string> { ExternalID, MfaSerial, RoleArn, SourceProfile, RoleSessionName },
                        new HashSet<string> { ExternalID, MfaSerial, RoleArn, SourceProfile, RoleSessionName, AwsAccountId },
                        new HashSet<string> { ExternalID, MfaSerial, RoleArn, SourceProfile, RoleSessionName, AwsAccountId, Services },
                        new HashSet<string> { ExternalID, MfaSerial, RoleArn, SourceProfile, RoleSessionName, AwsAccountId, EndpointUrl },
                        new HashSet<string> { ExternalID, MfaSerial, RoleArn, SourceProfile, RoleSessionName, AwsAccountId, Services, EndpointUrl },
                    } 
                },
                { CredentialProfileType.SSO, new List<HashSet<string>>() { new HashSet<string> { SsoAccountId, SsoRegion, SsoRegistrationScopes, SsoRoleName, SsoStartUrl, SsoSession } } },
                { 
                    CredentialProfileType.AssumeRoleMFASessionName, new List<HashSet<string>>() 
                    { 
                        new HashSet<string> { MfaSerial, RoleArn, SourceProfile, RoleSessionName },
                        new HashSet<string> { MfaSerial, RoleArn, SourceProfile, RoleSessionName, AwsAccountId },
                        new HashSet<string> { MfaSerial, RoleArn, SourceProfile, RoleSessionName, AwsAccountId, EndpointUrl },
                        new HashSet<string> { MfaSerial, RoleArn, SourceProfile, RoleSessionName, AwsAccountId, Services },
                        new HashSet<string> { MfaSerial, RoleArn, SourceProfile, RoleSessionName, AwsAccountId, Services, EndpointUrl },
                    } 
                },
            };

        private static Dictionary<CredentialProfileType, string> CredentialTypeDictionary =
            new Dictionary<CredentialProfileType, string>()
            {
                { CredentialProfileType.AssumeRole, AssumeRoleCredentials },
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

            // Spec: If one or more of the SSO properties is present, the profile MUST be resolved by the SSO credential provider.
            if (propertyNames.Any(propertyName => SsoProperties.Contains(propertyName)))
            {
                return CredentialProfileType.SSO;
            }

            // brute force algorithm - but it's a very small set
            foreach (var pair in TypePropertyDictionary)
            {
                foreach (var item in pair.Value)
                {
                    if (item.SetEquals(propertyNames))
                    {
                        profileType = pair.Key;
                    }
                }
            }

            return profileType;
        }

        public static HashSet<string> GetPropertiesForProfileType(CredentialProfileType profileType)
        {
            return new HashSet<string>(TypePropertyDictionary[profileType].FirstOrDefault());
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
