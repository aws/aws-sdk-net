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
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
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

        [TestMethod]
        public void DetectProfileTypeBasic()
        {
            Assert.AreEqual(CredentialProfileType.Basic,
                CredentialProfileTypeDetector.DetectProfileType(BasicProfileOptions));
        }

        [TestMethod]
        public void DetectProfileTypeSso()
        {
            Assert.AreEqual(CredentialProfileType.SSO,
                CredentialProfileTypeDetector.DetectProfileType(SsoProfileOptions));
        }

        [TestMethod]
        public void DetectProfileTypeSsoIncomplete()
        {
            Assert.AreEqual(CredentialProfileType.SSO,
                CredentialProfileTypeDetector.DetectProfileType(SsoIncompleteProfileOptions));
        }

        [TestMethod]
        public void DetectProfileTypeSsoWithOtherProperties()
        {
            Assert.AreEqual(CredentialProfileType.SSO,
                CredentialProfileTypeDetector.DetectProfileType(SsoWithOtherPropertiesProfileOptions));
        }

        [TestMethod]
        public void DetectProfileTypeLogin()
        {
            Assert.AreEqual(CredentialProfileType.Login,
                CredentialProfileTypeDetector.DetectProfileType(LoginProfileOptions));
        }

        [TestMethod]
        public void DetectProfileTypeLoginMissingFields()
        {
            Assert.AreNotEqual(CredentialProfileType.Login,
                CredentialProfileTypeDetector.DetectProfileType(EmptyProfileOptions));
        }

        [TestMethod]
        public void DetectProfileTypeLoginWithBasicCredentials()
        {
            var options = new CredentialProfileOptions()
            {
                LoginSession = "arn:aws:signin::123456789012:identity/test-session",
                AccessKey = "access-key",
                SecretKey = "secret-key"
            };
            
            Assert.AreEqual(CredentialProfileType.Basic,
                CredentialProfileTypeDetector.DetectProfileType(options));
        }

        [TestMethod]
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
            
            Assert.AreEqual(CredentialProfileType.SSO,
                CredentialProfileTypeDetector.DetectProfileType(options));
        }

        [TestMethod]
        public void DetectProfileTypeLoginWithSessionCredentials()
        {
            var options = new CredentialProfileOptions()
            {
                LoginSession = "arn:aws:signin::123456789012:identity/test-session",
                AccessKey = "access-key",
                SecretKey = "secret-key",
                Token = "session-token"
            };
            
            Assert.AreEqual(CredentialProfileType.Session,
                CredentialProfileTypeDetector.DetectProfileType(options));
        }

        [TestMethod]
        public void DetectProfileTypeLoginWithAssumeRole()
        {
            var options = new CredentialProfileOptions()
            {
                LoginSession = "arn:aws:signin::123456789012:identity/test-session",
                RoleArn = "arn:aws:iam::123456789012:role/TestRole",
                SourceProfile = "default"
            };
            
            Assert.AreEqual(CredentialProfileType.AssumeRole,
                CredentialProfileTypeDetector.DetectProfileType(options));
        }

        [TestMethod]
        public void DetectProfileTypeLoginWithInvalidCombination()
        {
            var options = new CredentialProfileOptions()
            {
                LoginSession = "arn:aws:signin::123456789012:identity/test-session",
                AccessKey = "access-key"
                // Missing SecretKey - invalid Basic profile
            };
            
            Assert.AreEqual(CredentialProfileType.Login,
                CredentialProfileTypeDetector.DetectProfileType(options));
        }

        [TestMethod]
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
            
            Assert.AreEqual(CredentialProfileType.Login,
                CredentialProfileTypeDetector.DetectProfileType(loginOnlyOptions));
        }
    }
}
