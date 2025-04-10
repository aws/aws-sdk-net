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

using Amazon;
using Amazon.RDS;
using Amazon.RDS.Util;
using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Identity;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;

namespace AWSSDK.UnitTests.RDS
{
    [TestClass]
    public class RDSAuthTokenGeneratorTest
    {
        private const string DBHost = "db_host";
        private const int DBPort = 12345;
        private const string DBUser = "db_user";
        private const string AccessKey = "access_key";
        private const string SecretKey = "secret_key";
        private const string SessionToken = "session_token";

        private static readonly RegionEndpoint AWSRegion = RegionEndpoint.GetBySystemName("us-east-1");
        private static readonly AWSCredentials BasicCredentials = new BasicAWSCredentials(AccessKey, SecretKey);
        private static readonly AWSCredentials SessionCredentials = new SessionAWSCredentials(AccessKey, SecretKey, SessionToken);

        private Dictionary<Type, IIdentityResolver> originalIdentityResolvers;

        [TestInitialize]
        public void Initialize()
        {
            AWSConfigs.AWSRegion = AWSRegion.SystemName;

            FieldInfo field = typeof(DefaultIdentityResolverConfiguration).GetField
                ("identityResolvers", BindingFlags.Static | BindingFlags.NonPublic);

            originalIdentityResolvers = field.GetValue(null) as Dictionary<Type, IIdentityResolver>;

            var mockIdentityResolver = new Mock<IIdentityResolver>();
            mockIdentityResolver.Setup(i => i.ResolveIdentity(null)).Returns(BasicCredentials);

            field.SetValue(null, new Dictionary<Type, IIdentityResolver>()
            {
                { typeof(AWSCredentials), mockIdentityResolver.Object },
            });
        }

        [TestCleanup]
        public void Cleanup()
        {
            FieldInfo field = typeof(DefaultIdentityResolverConfiguration).GetField
                ("identityResolvers", BindingFlags.Static | BindingFlags.NonPublic);

            field.SetValue(null, originalIdentityResolvers);
        }

#if ASYNC_AWAIT
        [TestMethod]
        [TestCategory("RDS")]
        public async System.Threading.Tasks.Task GenerateAuthTokenBasicAsync()
        {
            AssertAuthToken(await RDSAuthTokenGenerator.GenerateAuthTokenAsync(BasicCredentials,
                AWSRegion, DBHost, DBPort, DBUser), AccessKey, AWSRegion);
        }

        [TestMethod]
        [TestCategory("RDS")]
        public async System.Threading.Tasks.Task GenerateAuthTokenSessionAsync()
        {
            AssertAuthToken(await RDSAuthTokenGenerator.GenerateAuthTokenAsync(SessionCredentials,
                AWSRegion, DBHost, DBPort, DBUser), AccessKey, AWSRegion, true);
        }
#endif

        [TestMethod]
        [TestCategory("RDS")]
        public void GenerateAuthTokenBasic()
        {
            AssertAuthToken(RDSAuthTokenGenerator.GenerateAuthToken(BasicCredentials,
                AWSRegion, DBHost, DBPort, DBUser), AccessKey, AWSRegion);
        }

        [TestMethod]
        [TestCategory("RDS")]
        public void GenerateAuthTokenSession()
        {
            AssertAuthToken(RDSAuthTokenGenerator.GenerateAuthToken(SessionCredentials,
                AWSRegion, DBHost, DBPort, DBUser), AccessKey, AWSRegion, true);
        }

        [TestMethod]
        [TestCategory("RDS")]
        public void GenerateAuthTokenNoRegion()
        {
            AssertAuthToken(RDSAuthTokenGenerator.GenerateAuthToken(BasicCredentials, DBHost, DBPort, DBUser), AccessKey, FallbackRegionFactory.GetRegionEndpoint());
        }

        [TestMethod]
        [TestCategory("RDS")]
        public void GenerateAuthTokenNoCredentials()
        {
            AssertAuthToken(RDSAuthTokenGenerator.GenerateAuthToken(AWSRegion, DBHost, DBPort, DBUser), AccessKey, AWSRegion);
        }

        [TestMethod]
        [TestCategory("RDS")]
        public void GenerateAuthTokenNoRegionNoCredentials()
        {
            AssertAuthToken(RDSAuthTokenGenerator.GenerateAuthToken(DBHost, DBPort, DBUser), AccessKey, FallbackRegionFactory.GetRegionEndpoint());
        }

        [TestMethod]
        [TestCategory("RDS")]
        public void GenerateAuthTokenNullCredentials()
        {
            AssertExtensions.ExpectException(() =>
            {
                RDSAuthTokenGenerator.GenerateAuthToken((AWSCredentials)null, DBHost, DBPort, DBUser);
            }, typeof(ArgumentNullException));
        }

        [TestMethod]
        [TestCategory("RDS")]
        public void GenerateAuthTokenNullRegion()
        {
            AssertExtensions.ExpectException(() =>
            {
                RDSAuthTokenGenerator.GenerateAuthToken((RegionEndpoint)null, DBHost, DBPort, DBUser);
            }, typeof(ArgumentNullException));
        }

        [TestMethod]
        [TestCategory("RDS")]
        public void GenerateAuthTokenNullHostname()
        {
            AssertExtensions.ExpectException(() =>
            {
                RDSAuthTokenGenerator.GenerateAuthToken(AWSRegion, null, DBPort, DBUser);
            }, typeof(ArgumentException));
        }

        [TestMethod]
        [TestCategory("RDS")]
        public void GenerateAuthTokenEmptyHostname()
        {
            AssertExtensions.ExpectException(() =>
            {
                RDSAuthTokenGenerator.GenerateAuthToken(AWSRegion, " ", DBPort, DBUser);
            }, typeof(ArgumentException));
        }

        [TestMethod]
        [TestCategory("RDS")]
        public void GenerateAuthTokenNullDBUser()
        {
            AssertExtensions.ExpectException(() =>
            {
                RDSAuthTokenGenerator.GenerateAuthToken(AWSRegion, DBHost, DBPort, null);
            }, typeof(ArgumentException));
        }

        [TestMethod]
        [TestCategory("RDS")]
        public void GenerateAuthTokenEmptyDBUser()
        {
            AssertExtensions.ExpectException(() =>
            {
                RDSAuthTokenGenerator.GenerateAuthToken(AWSRegion, DBHost, DBPort, " ");
            }, typeof(ArgumentException));
        }

        [TestMethod]
        [TestCategory("RDS")]
        public void GenerateAuthTokenLowPort()
        {
            AssertExtensions.ExpectException(() =>
            {
                RDSAuthTokenGenerator.GenerateAuthToken(AWSRegion, DBHost, -1, DBUser);
            }, typeof(ArgumentException));
        }

        [TestMethod]
        [TestCategory("RDS")]
        public void GenerateAuthTokenHighPort()
        {
            AssertExtensions.ExpectException(() =>
            {
                RDSAuthTokenGenerator.GenerateAuthToken(AWSRegion, DBHost, 100000, DBUser);
            }, typeof(ArgumentException));
        }

        private void AssertAuthToken(string token, string accessKey, RegionEndpoint region)
        {
            AssertAuthToken(token, accessKey, region, false);
        }

        private void AssertAuthToken(string token, string accessKey, RegionEndpoint region, bool hasSessionToken)
        {
            // Look for today or yesterday to cover the crazy case where the
            // token was generated utc yesterday but we're asserting utc today.
            DateTime utcNow = DateTime.UtcNow;
            var todayRegex = "(" + utcNow.ToString("yyyyMMdd") + "|" + utcNow.AddDays(-1).ToString("yyyyMMdd") + ")";

            var sessionTokenPart = hasSessionToken ? "X-Amz-Security-Token=" + AWSSDKUtils.UrlEncode(SessionToken, false) + "&" : "";
            var regex = Regex.Escape(string.Format(CultureInfo.InvariantCulture,
                "{0}:{1}/?Action=connect&DBUser={2}&X-Amz-Expires=900&{3}X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=" +
                "{4}%2FTODAYREGEX%2F{5}%2Frds-db%2Faws4_request&X-Amz-Date=TODAYREGEXTTIMEREGEXZ&X-Amz-SignedHeaders=host&X-Amz-Signature=SIGNATUREREGEX",
                DBHost, DBPort, DBUser, sessionTokenPart, accessKey, region.SystemName));
            regex = regex.Replace("TIMEREGEX", "[0-9]{6}").Replace("SIGNATUREREGEX", "[0-9a-f]{64}").Replace("TODAYREGEX", todayRegex);

            Assert.IsTrue(Regex.IsMatch(token, regex), token + " doesn't match regex " + regex);
        }

    }
}
