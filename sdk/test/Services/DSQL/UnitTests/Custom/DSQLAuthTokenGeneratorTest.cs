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
using Amazon.DSQL;
using Amazon.DSQL.Util;
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

namespace AWSSDK.UnitTests.DSQL
{
    [TestClass]
    public class DSQLAuthTokenGeneratorTest
    {
        private const string DBCluster = "db_cluster";
        private const string DBConnectActionValue = "DbConnect";
        private const string DBConnectAdminActionValue = "DbConnectAdmin";
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

        // DbConnect

#if ASYNC_AWAIT
        [TestMethod]
        [TestCategory("DSQL")]
        public async System.Threading.Tasks.Task GenerateDbConnectAuthTokenBasicAsync()
        {
            AssertAuthToken(await DSQLAuthTokenGenerator.GenerateDbConnectAuthTokenAsync(BasicCredentials,
                AWSRegion, DBCluster), AccessKey, AWSRegion, DBConnectActionValue);
        }

        [TestMethod]
        [TestCategory("DSQL")]
        public async System.Threading.Tasks.Task GenerateDbConnectAuthTokenSessionAsync()
        {
            AssertAuthToken(await DSQLAuthTokenGenerator.GenerateDbConnectAuthTokenAsync(SessionCredentials,
                AWSRegion, DBCluster), AccessKey, AWSRegion, DBConnectActionValue, true);
        }
#endif

        [TestMethod]
        [TestCategory("DSQL")]
        public void GenerateDbConnectAuthTokenBasic()
        {
            AssertAuthToken(DSQLAuthTokenGenerator.GenerateDbConnectAuthToken(BasicCredentials,
                AWSRegion, DBCluster), AccessKey, AWSRegion, DBConnectActionValue);
        }

        [TestMethod]
        [TestCategory("DSQL")]
        public void GenerateDbConnectAuthTokenSession()
        {
            AssertAuthToken(DSQLAuthTokenGenerator.GenerateDbConnectAuthToken(SessionCredentials,
                AWSRegion, DBCluster), AccessKey, AWSRegion, DBConnectActionValue, true);
        }

        [TestMethod]
        [TestCategory("DSQL")]
        public void GenerateDbConnectAuthTokenNoRegion()
        {
            AssertAuthToken(DSQLAuthTokenGenerator.GenerateDbConnectAuthToken(BasicCredentials,
                DBCluster), AccessKey, FallbackRegionFactory.GetRegionEndpoint(), DBConnectActionValue);
        }

        [TestMethod]
        [TestCategory("DSQL")]
        public void GenerateDbConnectAuthTokenNoCredentials()
        {
            AssertAuthToken(DSQLAuthTokenGenerator.GenerateDbConnectAuthToken(AWSRegion,
                DBCluster), AccessKey, AWSRegion, DBConnectActionValue);
        }

        [TestMethod]
        [TestCategory("DSQL")]
        public void GenerateDbConnectAuthTokenNoRegionNoCredentials()
        {
            AssertAuthToken(DSQLAuthTokenGenerator.GenerateDbConnectAuthToken(DBCluster),
                AccessKey, FallbackRegionFactory.GetRegionEndpoint(), DBConnectActionValue);
        }

        [TestMethod]
        [TestCategory("DSQL")]
        public void GenerateDbConnectAuthTokenNullCredentials()
        {
            AssertExtensions.ExpectException(() =>
            {
                DSQLAuthTokenGenerator.GenerateDbConnectAuthToken((AWSCredentials)null, DBCluster);
            }, typeof(ArgumentNullException));
        }

        [TestMethod]
        [TestCategory("DSQL")]
        public void GenerateDbConnectAuthTokenNullRegion()
        {
            AssertExtensions.ExpectException(() =>
            {
                DSQLAuthTokenGenerator.GenerateDbConnectAuthToken((RegionEndpoint)null, DBCluster);
            }, typeof(ArgumentNullException));
        }

        [TestMethod]
        [TestCategory("DSQL")]
        public void GenerateDbConnectAuthTokenNullHostname()
        {
            AssertExtensions.ExpectException(() =>
            {
                DSQLAuthTokenGenerator.GenerateDbConnectAuthToken(AWSRegion, null);
            }, typeof(ArgumentException));
        }

        [TestMethod]
        [TestCategory("DSQL")]
        public void GenerateDbConnectAuthTokenEmptyHostname()
        {
            AssertExtensions.ExpectException(() =>
            {
                DSQLAuthTokenGenerator.GenerateDbConnectAuthToken(AWSRegion, " ");
            }, typeof(ArgumentException));
        }

        // DbConnectAdmin

        #if ASYNC_AWAIT
        [TestMethod]
        [TestCategory("DSQL")]
        public async System.Threading.Tasks.Task GenerateDbConnectAdminAuthTokenBasicAsync()
        {
            AssertAuthToken(await DSQLAuthTokenGenerator.GenerateDbConnectAdminAuthTokenAsync(BasicCredentials,
                AWSRegion, DBCluster), AccessKey, AWSRegion, DBConnectAdminActionValue);
        }

        [TestMethod]
        [TestCategory("DSQL")]
        public async System.Threading.Tasks.Task GenerateDbConnectAdminAuthTokenSessionAsync()
        {
            AssertAuthToken(await DSQLAuthTokenGenerator.GenerateDbConnectAdminAuthTokenAsync(SessionCredentials,
                AWSRegion, DBCluster), AccessKey, AWSRegion, DBConnectAdminActionValue, true);
        }
#endif

        [TestMethod]
        [TestCategory("DSQL")]
        public void GenerateDbConnectAdminAuthTokenBasic()
        {
            AssertAuthToken(DSQLAuthTokenGenerator.GenerateDbConnectAdminAuthToken(BasicCredentials,
                AWSRegion, DBCluster), AccessKey, AWSRegion, DBConnectAdminActionValue);
        }

        [TestMethod]
        [TestCategory("DSQL")]
        public void GenerateDbConnectAdminAuthTokenSession()
        {
            AssertAuthToken(DSQLAuthTokenGenerator.GenerateDbConnectAdminAuthToken(SessionCredentials,
                AWSRegion, DBCluster), AccessKey, AWSRegion, DBConnectAdminActionValue, true);
        }

        [TestMethod]
        [TestCategory("DSQL")]
        public void GenerateDbConnectAdminAuthTokenNoRegion()
        {
            AssertAuthToken(DSQLAuthTokenGenerator.GenerateDbConnectAdminAuthToken(BasicCredentials,
                DBCluster), AccessKey, FallbackRegionFactory.GetRegionEndpoint(), DBConnectAdminActionValue);
        }

        [TestMethod]
        [TestCategory("DSQL")]
        public void GenerateDbConnectAdminAuthTokenNoCredentials()
        {
            AssertAuthToken(DSQLAuthTokenGenerator.GenerateDbConnectAdminAuthToken(AWSRegion,
                DBCluster), AccessKey, AWSRegion, DBConnectAdminActionValue);
        }

        [TestMethod]
        [TestCategory("DSQL")]
        public void GenerateDbConnectAdminAuthTokenNoRegionNoCredentials()
        {
            AssertAuthToken(DSQLAuthTokenGenerator.GenerateDbConnectAdminAuthToken(DBCluster),
                AccessKey, FallbackRegionFactory.GetRegionEndpoint(), DBConnectAdminActionValue);
        }

        [TestMethod]
        [TestCategory("DSQL")]
        public void GenerateDbConnectAdminAuthTokenNullCredentials()
        {
            AssertExtensions.ExpectException(() =>
            {
                DSQLAuthTokenGenerator.GenerateDbConnectAdminAuthToken((AWSCredentials)null, DBCluster);
            }, typeof(ArgumentNullException));
        }

        [TestMethod]
        [TestCategory("DSQL")]
        public void GenerateDbConnectAdminAuthTokenNullRegion()
        {
            AssertExtensions.ExpectException(() =>
            {
                DSQLAuthTokenGenerator.GenerateDbConnectAdminAuthToken((RegionEndpoint)null, DBCluster);
            }, typeof(ArgumentNullException));
        }

        [TestMethod]
        [TestCategory("DSQL")]
        public void GenerateDbConnectAdminAuthTokenNullHostname()
        {
            AssertExtensions.ExpectException(() =>
            {
                DSQLAuthTokenGenerator.GenerateDbConnectAdminAuthToken(AWSRegion, null);
            }, typeof(ArgumentException));
        }

        [TestMethod]
        [TestCategory("DSQL")]
        public void GenerateDbConnectAdminAuthTokenEmptyHostname()
        {
            AssertExtensions.ExpectException(() =>
            {
                DSQLAuthTokenGenerator.GenerateDbConnectAdminAuthToken(AWSRegion, " ");
            }, typeof(ArgumentException));
        }

        private void AssertAuthToken(string token, string accessKey, RegionEndpoint region, string actionValue)
        {
            AssertAuthToken(token, accessKey, region, actionValue, false);
        }

        private void AssertAuthToken(string token, string accessKey, RegionEndpoint region, string actionValue, bool hasSessionToken)
        {
            // Look for today or yesterday to cover the crazy case where the
            // token was generated utc yesterday but we're asserting utc today.
            DateTime utcNow = DateTime.UtcNow;
            var todayRegex = "(" + utcNow.ToString("yyyyMMdd") + "|" + utcNow.AddDays(-1).ToString("yyyyMMdd") + ")";

            var sessionTokenPart = hasSessionToken ? "X-Amz-Security-Token=" + AWSSDKUtils.UrlEncode(SessionToken, false) + "&" : "";
            var regex = Regex.Escape(string.Format(CultureInfo.InvariantCulture,
                "{0}/?Action={1}&X-Amz-Expires=900&{2}X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=" +
                "{3}%2FTODAYREGEX%2F{4}%2Fdsql%2Faws4_request&X-Amz-Date=TODAYREGEXTTIMEREGEXZ&X-Amz-SignedHeaders=host&X-Amz-Signature=SIGNATUREREGEX",
                DBCluster, actionValue, sessionTokenPart, accessKey, region.SystemName));
            regex = regex.Replace("TIMEREGEX", "[0-9]{6}").Replace("SIGNATUREREGEX", "[0-9a-f]{64}").Replace("TODAYREGEX", todayRegex);

            Assert.IsTrue(Regex.IsMatch(token, regex), token + " doesn't match regex " + regex);
        }

    }
}
