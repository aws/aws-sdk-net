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
using System.Xml;
using Amazon.Runtime.Credentials.Internal;
using AWSSDK_DotNet.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Tests for <see cref="SsoTokenUtils"/>
    /// </summary>
    [TestClass]
    public class SsoTokenUtilsTests
    {
        [TestMethod]
        [DataRow("2022-08-30 10:00:00Z", "2022-08-30 09:00:00Z", false)] // expires in 1 hours
        [DataRow("2022-08-30 09:10:00Z", "2022-08-30 09:00:00Z", false)] // expires in 10 minutes
        [DataRow("2022-08-30 09:05:00Z", "2022-08-30 09:00:00Z", true)]  // expires in 5 minutes
        [DataRow("2022-08-30 09:00:10Z", "2022-08-30 09:00:00Z", true)]  // expires in 10 seconds
        [DataRow("2022-08-30 09:00:00Z", "2022-08-30 09:05:00Z", true)]  // expired 5 minutes ago
        [DataRow("2022-08-30 09:00:00Z", "2022-08-30 10:00:00Z", true)]  // expired 1 hour ago
        public void NeedsRefresh(string expirationTime, string currentTime, bool expectNeedRefresh)
        {
            using (new AWSConfigsDateFaker(() => DateTime.Parse(currentTime)))
            {
                var ssoToken = new SsoToken
                {
                    ExpiresAt = DateTime.Parse(expirationTime)
                };

                Assert.AreEqual(expectNeedRefresh, ssoToken.NeedsRefresh());
            }
        }
        [TestMethod]
        [DataRow("2022-08-30T10:00:00Z", "2022-08-30T09:00:00Z", false)] // expires in 1 hours
        [DataRow("2022-08-30T09:10:00Z", "2022-08-30T09:00:00Z", false)] // expires in 10 minutes
        [DataRow("2022-08-30T09:05:00Z", "2022-08-30T09:00:00Z", true)]  // expires in 5 minutes
        [DataRow("2022-08-30T09:00:10Z", "2022-08-30T09:00:00Z", true)]  // expires in 10 seconds
        [DataRow("2022-08-30T09:00:00Z", "2022-08-30T09:05:00Z", true)]  // expired 5 minutes ago
        [DataRow("2022-08-30T09:00:00Z", "2022-08-30T10:00:00Z", true)]  // expired 1 hour ago
        public void RegisteredClientExpiredTests(string registrationExpiresAt, string currentTime, bool expectedRegisteredClientExpired)
        {
            using (new AWSConfigsDateFaker(() => XmlConvert.ToDateTime(currentTime, XmlDateTimeSerializationMode.Utc)))
            {
                var ssoToken = new SsoToken
                {
                    RegistrationExpiresAt = registrationExpiresAt
                };
                Assert.AreEqual(expectedRegisteredClientExpired, ssoToken.RegisteredClientExpired());
            }
        }
    }
}
