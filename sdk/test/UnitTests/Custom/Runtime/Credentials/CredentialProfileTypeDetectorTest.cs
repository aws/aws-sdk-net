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
    }
}
