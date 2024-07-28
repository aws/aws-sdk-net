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
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.CredentialManagement.Internal;
using Amazon.Runtime.Internal.Settings;
using Amazon.Util;
using AWSSDK_DotNet.CommonTest.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class SAMLRoleSessionManagerTest
    {
        private const string RoleSessionsFilename = SettingsConstants.RegisteredRoleSessions + ".json";
        private const string RoleSessionName = "RoleSessionName";
        private const string InvalidRoleSessionText =
            "{" +
            "    \"RoleSessionName\" : {" +
            "        \"RoleSession\" : \"@#% - NO WAY THIS WILL PARSE AS JSON - ^&*\"" +
            "    }" +
            "}";

        private DateTime yesterday;
        private DateTime tomorrow;
        private DateTime nowToTheSecond;
        private SAMLImmutableCredentials samlCredentials;
        private SAMLImmutableCredentials expiredSamlCredentials;

        private EncryptedStoreTestFixture fixture;
        private SAMLRoleSessionManager manager;

        [TestInitialize]
        public void InitializeTest()
        {
            fixture = new EncryptedStoreTestFixture(RoleSessionsFilename);
            manager = new SAMLRoleSessionManager();

            DateTime now = DateTime.UtcNow;
            // The expiration is only stored to the second in our JSON
            nowToTheSecond = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second, DateTimeKind.Utc);
            yesterday = nowToTheSecond.AddDays(-1);
            tomorrow = nowToTheSecond.AddDays(1);

            samlCredentials = new SAMLImmutableCredentials("AccessKey", "SecretKey", "Token", tomorrow, "Subject");
            expiredSamlCredentials = new SAMLImmutableCredentials("AccessKey", "SecretKey", "Token", yesterday, "Subject");
        }

        [TestCleanup]
        public void CleanupTest()
        {
            fixture.Dispose();
        }

        [TestMethod]
        public void Register()
        {
            manager.RegisterRoleSession(RoleSessionName, samlCredentials);
            fixture.AssertJsonProperty(RoleSessionName, SettingsConstants.RoleSession,
                (string)ReflectionHelpers.Invoke(samlCredentials, "ToJson"));
        }

        [TestMethod]
        public void TryGetRoleSessionValid()
        {
            manager.RegisterRoleSession(RoleSessionName, samlCredentials);
            SAMLImmutableCredentials readCredentials;
            Assert.IsTrue(manager.TryGetRoleSession(RoleSessionName, out readCredentials));
            Assert.IsNotNull(readCredentials);
            Assert.AreEqual(samlCredentials.AccessKey, readCredentials.AccessKey);
            Assert.AreEqual(samlCredentials.Expires, readCredentials.Expires);
            Assert.AreEqual(samlCredentials.SecretKey, readCredentials.SecretKey);
            Assert.AreEqual(samlCredentials.Subject, readCredentials.Subject);
            Assert.AreEqual(samlCredentials.Token, readCredentials.Token);
        }

        [TestMethod]
        public void TryGetRoleSessionInvalid()
        {
            fixture.SetFileContents(InvalidRoleSessionText);
            SAMLImmutableCredentials readCredentials;
            Assert.IsFalse(manager.TryGetRoleSession(RoleSessionName, out readCredentials));
            Assert.IsNull(readCredentials);
        }

        [TestMethod]
        public void TryGetRoleSessionExpired()
        {
            manager.RegisterRoleSession(RoleSessionName, expiredSamlCredentials);
            SAMLImmutableCredentials readCredentials;
            Assert.IsFalse(manager.TryGetRoleSession(RoleSessionName, out readCredentials));
            Assert.IsNull(readCredentials);
        }

        [TestMethod]
        public void Unregister()
        {
            fixture.AssertFileExists(false);
            manager.RegisterRoleSession(RoleSessionName, samlCredentials);
            fixture.AssertObjectCount(1);
            manager.UnregisterRoleSession(RoleSessionName);
            fixture.AssertFileExists(false);

        }

        [TestMethod]
        public void Clear()
        {
            fixture.AssertFileExists(false);
            for (int i = 0; i < 10; i++)
            {
                manager.RegisterRoleSession(RoleSessionName + i, samlCredentials);
            }
            fixture.AssertObjectCount(10);
            manager.Clear();
            fixture.AssertFileExists(false);
        }
    }
}
