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
using Amazon.Runtime.CredentialManagement.Internal;
using Xunit;

namespace AWSSDK.UnitTests
{
    public class CredentialProfileTypeDetectorTest
    {
        private static readonly CredentialProfileOptions BasicProfileOptions = new CredentialProfileOptions()
        {
            AccessKey = nameof(CredentialProfileOptions.AccessKey),
            SecretKey = nameof(CredentialProfileOptions.SecretKey),
        };

        private static readonly CredentialProfileOptions SsoProfileOptions = new CredentialProfileOptions()
        {
            SsoAccountId = nameof(CredentialProfileOptions.SsoAccountId),
            SsoRegion = nameof(CredentialProfileOptions.SsoRegion),
            SsoRoleName = nameof(CredentialProfileOptions.SsoRoleName),
            SsoStartUrl = nameof(CredentialProfileOptions.SsoStartUrl),
        };

        private static readonly CredentialProfileOptions SsoIncompleteProfileOptions = new CredentialProfileOptions()
        {
            SsoAccountId = nameof(CredentialProfileOptions.SsoAccountId),
        };

        private static readonly CredentialProfileOptions SsoWithOtherPropertiesProfileOptions = new CredentialProfileOptions()
        {
            SsoAccountId = nameof(CredentialProfileOptions.SsoAccountId),
            SsoRegion = nameof(CredentialProfileOptions.SsoRegion),
            SsoRoleName = nameof(CredentialProfileOptions.SsoRoleName),
            SsoStartUrl = nameof(CredentialProfileOptions.SsoStartUrl),
            AccessKey = nameof(CredentialProfileOptions.AccessKey),
            SecretKey = nameof(CredentialProfileOptions.SecretKey),
        };

        private static readonly CredentialProfileOptions LoginProfileOptions = new CredentialProfileOptions()
        {
            LoginSession = "arn:aws:signin::123456789012:identity/test-session"
        };

        private static readonly CredentialProfileOptions EmptyProfileOptions = new CredentialProfileOptions();

        [Fact]
        public void DetectProfileTypeBasic()
        {
            Assert.Equal(CredentialProfileType.Basic,
                CredentialProfileTypeDetector.DetectProfileType(BasicProfileOptions));
        }

        [Fact]
        public void DetectProfileTypeSso()
        {
            Assert.Equal(CredentialProfileType.SSO,
                CredentialProfileTypeDetector.DetectProfileType(SsoProfileOptions));
        }

        [Fact]
        public void DetectProfileTypeSsoIncomplete()
        {
            Assert.Equal(CredentialProfileType.SSO,
                CredentialProfileTypeDetector.DetectProfileType(SsoIncompleteProfileOptions));
        }

        [Fact]
        public void DetectProfileTypeSsoWithOtherProperties()
        {
            Assert.Equal(CredentialProfileType.SSO,
                CredentialProfileTypeDetector.DetectProfileType(SsoWithOtherPropertiesProfileOptions));
        }

        [Fact]
        public void DetectProfileTypeLogin()
        {
            Assert.Equal(CredentialProfileType.Login,
                CredentialProfileTypeDetector.DetectProfileType(LoginProfileOptions));
        }

        [Fact]
        public void DetectProfileTypeLoginMissingFields()
        {
            Assert.NotEqual(CredentialProfileType.Login,
                CredentialProfileTypeDetector.DetectProfileType(EmptyProfileOptions));
        }

        [Fact]
        public void DetectProfileTypeLoginWithBasicCredentials()
        {
            var options = new CredentialProfileOptions()
            {
                LoginSession = "arn:aws:signin::123456789012:identity/test-session",
                AccessKey = "access-key",
                SecretKey = "secret-key"
            };
            
            Assert.Equal(CredentialProfileType.Basic,
                CredentialProfileTypeDetector.DetectProfileType(options));
        }

        [Fact]
        public void DetectProfileTypeLoginWithSsoCredentials()
        {
            var options = new CredentialProfileOptions()
            {
                LoginSession = "arn:aws:signin::123456789012:identity/test-session",
                SsoAccountId = "123456789012",
                SsoRegion = "us-east-1",
                SsoRoleName = "TestRole",
                SsoStartUrl = "https://test.awsapps.com/start"
            };
            
            Assert.Equal(CredentialProfileType.SSO,
                CredentialProfileTypeDetector.DetectProfileType(options));
        }

        [Fact]
        public void DetectProfileTypeLoginWithSessionCredentials()
        {
            var options = new CredentialProfileOptions()
            {
                LoginSession = "arn:aws:signin::123456789012:identity/test-session",
                AccessKey = "access-key",
                SecretKey = "secret-key",
                Token = "session-token"
            };
            
            Assert.Equal(CredentialProfileType.Session,
                CredentialProfileTypeDetector.DetectProfileType(options));
        }

        [Fact]
        public void DetectProfileTypeLoginWithAssumeRole()
        {
            var options = new CredentialProfileOptions()
            {
                LoginSession = "arn:aws:signin::123456789012:identity/test-session",
                RoleArn = "arn:aws:iam::123456789012:role/TestRole",
                SourceProfile = "default"
            };
            
            Assert.Equal(CredentialProfileType.AssumeRole,
                CredentialProfileTypeDetector.DetectProfileType(options));
        }

        [Fact]
        public void DetectProfileTypeLoginWithInvalidCombination()
        {
            var options = new CredentialProfileOptions()
            {
                LoginSession = "arn:aws:signin::123456789012:identity/test-session",
                AccessKey = "access-key"
                // Missing SecretKey - invalid Basic profile
            };
            
            Assert.Equal(CredentialProfileType.Login,
                CredentialProfileTypeDetector.DetectProfileType(options));
        }

        [Fact]
        public void DetectProfileTypeLoginPrecedenceOverOtherTypes()
        {
            // Test that Login has lower precedence than SSO, Basic, and CredentialProcess
            // but higher precedence than incomplete profiles
            
            // Login should be detected when no other valid profile type matches
            var loginOnlyOptions = new CredentialProfileOptions()
            {
                LoginSession = "arn:aws:signin::123456789012:identity/test-session",
                RoleArn = "arn:aws:iam::123456789012:role/TestRole"
                // Missing SourceProfile - invalid AssumeRole profile
            };
            
            Assert.Equal(CredentialProfileType.Login,
                CredentialProfileTypeDetector.DetectProfileType(loginOnlyOptions));
        }
    }
}