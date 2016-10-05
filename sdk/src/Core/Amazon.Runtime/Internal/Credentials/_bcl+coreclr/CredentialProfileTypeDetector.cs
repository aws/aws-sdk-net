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
using System.Linq;
using System.Reflection;
using System.Text;

namespace Amazon.Runtime.Internal
{
    public enum CredentialProfileType
    {
        AssumeRole,
        AssumeRoleExternal,
        AssumeRoleExternalMFA,
        AssumeRoleMFA,
        Basic,
        FullAssumeRole,
        FullAssumeRoleExternal,
        FullAssumeRoleExternalMFA,
        FullAssumeRoleMFA,
        Session,
    }

    public static class CredentialProfileTypeDetector
    {
        private const string AccessKey = "AccessKey";
        private const string ExternalID = "ExternalID";
        private const string MfaSerial = "MfaSerial";
        private const string RoleArn = "RoleArn";
        private const string SecretKey = "SecretKey";
        private const string SourceProfile = "SourceProfile";
        private const string Token = "Token";

        private static Dictionary<CredentialProfileType, HashSet<string>> TypePropertyDictionary =
            new Dictionary<CredentialProfileType, HashSet<string>>()
            {
                {
                    CredentialProfileType.AssumeRole, new HashSet<string>()
                    {
                        RoleArn,
                        SourceProfile,
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
                    CredentialProfileType.AssumeRoleExternalMFA, new HashSet<string>()
                    {
                        ExternalID,
                        MfaSerial,
                        RoleArn,
                        SourceProfile,
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
                    CredentialProfileType.Basic, new HashSet<string>()
                    {
                        AccessKey,
                        SecretKey,
                    }
                },
                {
                    CredentialProfileType.FullAssumeRole, new HashSet<string>()
                    {
                        AccessKey,
                        RoleArn,
                        SecretKey,
                    }
                },
                {
                    CredentialProfileType.FullAssumeRoleExternal, new HashSet<string>()
                    {
                        AccessKey,
                        ExternalID,
                        RoleArn,
                        SecretKey,
                    }
                },
                {
                    CredentialProfileType.FullAssumeRoleExternalMFA, new HashSet<string>()
                    {
                        AccessKey,
                        ExternalID,
                        MfaSerial,
                        RoleArn,
                        SecretKey,
                    }
                },
                {
                    CredentialProfileType.FullAssumeRoleMFA, new HashSet<string>()
                    {
                        AccessKey,
                        MfaSerial,
                        RoleArn,
                        SecretKey,
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
            };

        public static void DetectProfileTypes(CredentialProfileOptions profileOptions, out CredentialProfileType? profileType, out HashSet<CredentialProfileType> possibleMatches)
        {
            profileType = null;
            possibleMatches = new HashSet<CredentialProfileType>();

            HashSet<string> propertyNames = GetPropertyNames(profileOptions);

            // brute force algorithm - but it's a very small set
            foreach (var pair in TypePropertyDictionary)
            {
                if (pair.Value.SetEquals(propertyNames))
                {
                    // exact match
                    profileType = pair.Key;
                }
                else if (propertyNames.IsSubsetOf(pair.Value))
                {
                    // may be missing some properties for another profile type
                    possibleMatches.Add(pair.Key);
                }
            }
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
