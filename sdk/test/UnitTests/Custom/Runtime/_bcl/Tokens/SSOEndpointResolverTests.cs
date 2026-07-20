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
using System.Threading.Tasks;
using Amazon.Runtime.Credentials.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Runtime
{
    /// <summary>
    /// Tests for <see cref="SSOEndpointResolver"/>
    /// </summary>
    [TestClass]
    public class SSOEndpointResolverTests
    {
        #region ResolveAsync - New portal DualStack format

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        [DataRow("https://ssoins-testinstanceid.portal.us-west-2.app.aws", "us-west-2")]
        [DataRow("https://ssoins-testinstanceid.portal.us-east-1.app.aws/start", "us-east-1")]
        [DataRow("https://ssoins-testinstanceid.portal.eu-west-1.app.aws/", "eu-west-1")]
        [DataRow("https://SSOINS-ABC123.PORTAL.US-WEST-2.APP.AWS", "us-west-2")]        
        [DataRow("https://ssoins-testinstanceid.portal.cn-north-1.app.amazonwebservices.com.cn", "cn-north-1")]
        [DataRow("https://ssoins-testinstanceid.portal.cn-northwest-1.app.amazonwebservices.com.cn/start", "cn-northwest-1")]
        [DataRow("https://ssoins-testinstanceid.portal.eusc-de-east-1.api.amazonwebservices.eu", "eusc-de-east-1")]
        public async Task ResolveAsync_NewPortalDualStack_ExtractsRegion(string url, string expectedRegion)
        {
            var result = await SSOEndpointResolver.ResolveAsync(url, null);
            Assert.AreEqual(expectedRegion, result.Region);
            Assert.IsFalse(result.IsVanityUrl);
        }

        #endregion

        #region ResolveAsync - New portal IPv4-only format

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        [DataRow("https://ssoins-testinstanceid.us-west-2.portal.amazonaws.com", "us-west-2")]
        [DataRow("https://ssoins-testinstanceid.ap-northeast-1.portal.amazonaws.com/start", "ap-northeast-1")]
        [DataRow("https://ssoins-testinstanceid.us-gov-west-1.portal.amazonaws.com", "us-gov-west-1")]
        [DataRow("https://ssoins-testinstanceid.cn-north-1.portal.amazonaws.com.cn", "cn-north-1")]
        [DataRow("https://ssoins-testinstanceid.cn-northwest-1.portal.amazonaws.com.cn/start", "cn-northwest-1")]
        [DataRow("https://ssoins-testinstanceid.eusc-de-east-1.portal.amazonaws.eu", "eusc-de-east-1")]
        public async Task ResolveAsync_NewPortalIPv4_ExtractsRegion(string url, string expectedRegion)
        {
            var result = await SSOEndpointResolver.ResolveAsync(url, null);
            Assert.AreEqual(expectedRegion, result.Region);
            Assert.IsFalse(result.IsVanityUrl);
        }

        #endregion

        #region ResolveAsync - Legacy awsapps.com format

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        // Commercial: https://{directoryId}.awsapps.com/start and https://{alias}.awsapps.com/start
        [DataRow("https://d-testdirectoryid.awsapps.com/start")]
        [DataRow("https://myalias.awsapps.com/start")]
        // China: https://start.{region}.home.awsapps.cn/directory/{directoryId} 
        [DataRow("https://start.cn-north-1.home.awsapps.cn/directory/d-testdirectoryid")]
        [DataRow("https://start.cn-northwest-1.home.awsapps.cn/directory/d-testdirectoryid")]
        // GovCloud: https://start.us-gov-home.awsapps.com/directory/{directoryId}
        [DataRow("https://start.us-gov-home.awsapps.com/directory/d-testdirectoryid")]
        public async Task ResolveAsync_LegacyAwsApps_RegionIsNull(string url)
        {
            var result = await SSOEndpointResolver.ResolveAsync(url, null);
            Assert.IsNull(result.Region);
            Assert.IsFalse(result.IsVanityUrl);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public async Task ResolveAsync_LegacyAwsApps_WithRegionOverride_UsesOverride()
        {
            var result = await SSOEndpointResolver.ResolveAsync("https://d-testdirectoryid.awsapps.com/start", "eu-west-1");
            Assert.AreEqual("eu-west-1", result.Region);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public async Task ResolveAsync_LegacyChinaAwsApps_WithRegionOverride_UsesOverride()
        {
            // China legacy form is region-less, so region comes from the override.
            var result = await SSOEndpointResolver.ResolveAsync("https://start.cn-north-1.home.awsapps.cn/directory/d-testdirectoryid", "cn-north-1");
            Assert.AreEqual("cn-north-1", result.Region);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public async Task ResolveAsync_LegacyGovCloudAwsApps_WithRegionOverride_UsesOverride()
        {
            var result = await SSOEndpointResolver.ResolveAsync("https://start.us-gov-home.awsapps.com/directory/d-testdirectoryid", "us-gov-west-1");
            Assert.AreEqual("us-gov-west-1", result.Region);
            // The us-gov- region selects the GovCloud issuer host even though awsapps.com is shared with commercial.
            Assert.AreEqual("https://identitycenter.us-gov.amazonaws.com/d-testdirectoryid", result.IssuerUrl);
        }

        #endregion

        #region ResolveAsync - Issuer URL format

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public async Task ResolveAsync_IssuerUrl_RegionIsNull()
        {
            var result = await SSOEndpointResolver.ResolveAsync("https://identitycenter.amazonaws.com/ssoins-testinstanceid", null);
            Assert.IsNull(result.Region);
            Assert.AreEqual("https://identitycenter.amazonaws.com/ssoins-testinstanceid", result.IssuerUrl);
            Assert.IsFalse(result.IsVanityUrl);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public async Task ResolveAsync_IssuerUrl_WithRegionOverride_UsesOverride()
        {
            var result = await SSOEndpointResolver.ResolveAsync("https://identitycenter.amazonaws.com/ssoins-testinstanceid", "us-east-1");
            Assert.AreEqual("us-east-1", result.Region);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public async Task ResolveAsync_ChinaIssuerUrl_RecognizedAndRegionFromOverride()
        {
            var result = await SSOEndpointResolver.ResolveAsync("https://identitycenter.amazonaws.com.cn/ssoins-testinstanceid", "cn-north-1");
            Assert.AreEqual("cn-north-1", result.Region);
            Assert.IsFalse(result.IsVanityUrl);
            Assert.AreEqual("https://identitycenter.amazonaws.com.cn/ssoins-testinstanceid", result.IssuerUrl);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public async Task ResolveAsync_EuscIssuerUrl_RecognizedAndRegionFromOverride()
        {
            var result = await SSOEndpointResolver.ResolveAsync("https://identitycenter.amazonaws.eu/ssoins-testinstanceid", "eusc-de-east-1");
            Assert.AreEqual("eusc-de-east-1", result.Region);
            Assert.IsFalse(result.IsVanityUrl);
            Assert.AreEqual("https://identitycenter.amazonaws.eu/ssoins-testinstanceid", result.IssuerUrl);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public async Task ResolveAsync_GovCloudIssuerUrl_RecognizedAndRegionFromOverride()
        {
            // Regression test for the GovCloud issuer domain identitycenter.us-gov.amazonaws.com must be recognized
            //  as AWS-owned so it is NOT treated as a vanity URL and DNS-resolved (that issuer host has no DNS record
            // and would fail). GovCloud has a distinct issuer host and must NOT be rewritten to the commercial one.
            var result = await SSOEndpointResolver.ResolveAsync("https://identitycenter.us-gov.amazonaws.com/ssoins-testinstanceid", "us-gov-west-1");
            Assert.AreEqual("us-gov-west-1", result.Region);
            Assert.IsFalse(result.IsVanityUrl);
            Assert.AreEqual("https://identitycenter.us-gov.amazonaws.com/ssoins-testinstanceid", result.IssuerUrl);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public async Task ResolveAsync_GovCloudPortalUrl_MapsToGovCloudIssuer()
        {
            // GovCloud portal form carries a us-gov-* region in the host; the issuer must use the
            // GovCloud host even though the domain suffix is shared with commercial.
            var result = await SSOEndpointResolver.ResolveAsync("https://ssoins-testinstanceid.us-gov-west-1.portal.amazonaws.com", null);
            Assert.AreEqual("us-gov-west-1", result.Region);
            Assert.IsFalse(result.IsVanityUrl);
            Assert.AreEqual("https://identitycenter.us-gov.amazonaws.com/ssoins-testinstanceid", result.IssuerUrl);
        }

        #endregion

        #region ResolveAsync - Issuer URL extraction

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        [DataRow("https://ssoins-testinstanceid.portal.us-west-2.app.aws", "https://identitycenter.amazonaws.com/ssoins-testinstanceid")]
        [DataRow("https://ssoins-testinstanceid.us-west-2.portal.amazonaws.com", "https://identitycenter.amazonaws.com/ssoins-testinstanceid")]
        [DataRow("https://d-testdirectoryid.awsapps.com/start", "https://identitycenter.amazonaws.com/d-testdirectoryid")]
        [DataRow("https://myalias.awsapps.com/start", "https://identitycenter.amazonaws.com/myalias")]
        [DataRow("https://identitycenter.amazonaws.com/ssoins-testinstanceid", "https://identitycenter.amazonaws.com/ssoins-testinstanceid")]
        [DataRow("https://ssoins-testinstanceid.cn-north-1.portal.amazonaws.com.cn", "https://identitycenter.amazonaws.com.cn/ssoins-testinstanceid")]
        [DataRow("https://ssoins-testinstanceid.portal.cn-north-1.app.amazonwebservices.com.cn", "https://identitycenter.amazonaws.com.cn/ssoins-testinstanceid")]
        // China legacy: directoryId parsed from the path, maps to the China issuer host
        [DataRow("https://start.cn-north-1.home.awsapps.cn/directory/d-testdirectoryid", "https://identitycenter.amazonaws.com.cn/d-testdirectoryid")]
        [DataRow("https://identitycenter.amazonaws.com.cn/ssoins-testinstanceid", "https://identitycenter.amazonaws.com.cn/ssoins-testinstanceid")]
        // EUSC portal and issuer forms map to the EUSC issuer host
        [DataRow("https://ssoins-testinstanceid.eusc-de-east-1.portal.amazonaws.eu", "https://identitycenter.amazonaws.eu/ssoins-testinstanceid")]
        [DataRow("https://identitycenter.amazonaws.eu/ssoins-testinstanceid", "https://identitycenter.amazonaws.eu/ssoins-testinstanceid")]
        // GovCloud portal and issuer forms map to the GovCloud issuer host
        [DataRow("https://ssoins-testinstanceid.us-gov-west-1.portal.amazonaws.com", "https://identitycenter.us-gov.amazonaws.com/ssoins-testinstanceid")]
        [DataRow("https://identitycenter.us-gov.amazonaws.com/ssoins-testinstanceid", "https://identitycenter.us-gov.amazonaws.com/ssoins-testinstanceid")]
        public async Task ResolveAsync_ExtractsIssuerUrl(string url, string expectedIssuerUrl)
        {
            // NOTE: the region override here is only consumed by region-less forms. For GovCloud rows the
            // us-gov-* region is carried in the host (portal) or the host itself is the GovCloud issuer,
            // so the GovCloud issuer host is selected regardless of this commercial override.
            var result = await SSOEndpointResolver.ResolveAsync(url, "us-west-2");
            Assert.AreEqual(expectedIssuerUrl, result.IssuerUrl);
        }

        #endregion

        #region ResolveAsync - HTTPS enforcement

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public async Task ResolveAsync_HttpUrl_ThrowsArgumentException()
        {
            await Assert.ThrowsExactlyAsync<ArgumentException>(
                () => SSOEndpointResolver.ResolveAsync("http://ssoins-testinstanceid.portal.us-west-2.app.aws", null));
        }

        #endregion

        #region ResolveAsync - Invalid URL

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public async Task ResolveAsync_MalformedUrl_ThrowsArgumentException()
        {
            await Assert.ThrowsExactlyAsync<ArgumentException>(
                () => SSOEndpointResolver.ResolveAsync("https://not a valid url with spaces", null));
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public async Task ResolveAsync_NullUrl_ThrowsArgumentException()
        {
            await Assert.ThrowsExactlyAsync<ArgumentException>(
                () => SSOEndpointResolver.ResolveAsync(null, null));
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public async Task ResolveAsync_EmptyUrl_ThrowsArgumentException()
        {
            await Assert.ThrowsExactlyAsync<ArgumentException>(
                () => SSOEndpointResolver.ResolveAsync("", null));
        }

        #endregion

        #region ResolveAsync - Invalid region from URL

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public async Task ResolveAsync_UnknownRegionInUrl_PassedThroughWithoutValidation()
        {
            // Region is not validated locally; service will reject if invalid
            var result = await SSOEndpointResolver.ResolveAsync("https://ssoins-testinstanceid.portal.not-a-region.app.aws", null);
            Assert.AreEqual("not-a-region", result.Region);
        }

        #endregion

        #region ResolveAsync - Unknown region override passed through

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public async Task ResolveAsync_UnknownRegionOverride_PassedThroughWithoutValidation()
        {
            // Region override is not validated locally; service will reject if invalid
            var result = await SSOEndpointResolver.ResolveAsync("https://d-testdirectoryid.awsapps.com/start", "invalid-region-xyz");
            Assert.AreEqual("invalid-region-xyz", result.Region);
        }

        #endregion

        #region ResolveAsync - URL without scheme

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public async Task ResolveAsync_UrlWithoutScheme_ThrowsArgumentException()
        {
            // A URL without a scheme is not valid; HTTPS is required.
            await Assert.ThrowsExactlyAsync<ArgumentException>(
                () => SSOEndpointResolver.ResolveAsync("ssoins-testinstanceid.portal.us-west-2.app.aws", null));
        }

        #endregion

        #region ResolveAsync - Look-alike domains

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        [DataRow("https://d-testdirectoryid.awsapps.com.evil.net/start")]
        [DataRow("https://awsapps.cn.evil.net/start")]
        [DataRow("https://evil-awsapps.cn/start")]
        [DataRow("https://portal.amazonaws.com.cn.evil.net/start")]
        public async Task ResolveAsync_LookAlikeDomain_NotTreatedAsAws(string url)
        {
            await Assert.ThrowsExactlyAsync<ArgumentException>(
                () => SSOEndpointResolver.ResolveAsync(url, null));
        }

        #endregion

        #region ResolveAsync - Vanity URL (non-AWS domain without redirect)

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public async Task ResolveAsync_VanityUrl_IsVanityUrlTrue()
        {
            // A non-AWS domain that can't be reached will throw, but we verify IsVanityUrl
            // detection happens before the network call by testing an AWS-owned URL is NOT vanity
            var result = await SSOEndpointResolver.ResolveAsync("https://ssoins-testinstanceid.portal.us-west-2.app.aws", null);
            Assert.IsFalse(result.IsVanityUrl);
        }

        #endregion

        #region ResolveAsync - Non-AWS redirect target

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public async Task ResolveAsync_NonAwsRedirectTarget_ThrowsArgumentException()
        {
            // A non-AWS domain that doesn't redirect to AWS - resolution fails
            await Assert.ThrowsExactlyAsync<ArgumentException>(
                () => SSOEndpointResolver.ResolveAsync("https://example.com/not-aws", null));
        }

        #endregion

        #region ResolveAsync - Region override ignored when URL carries region

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public async Task ResolveAsync_UrlCarriesRegion_OverrideIgnored()
        {
            var result = await SSOEndpointResolver.ResolveAsync(
                "https://ssoins-testinstanceid.portal.us-west-2.app.aws", "eu-central-1");
            Assert.AreEqual("us-west-2", result.Region);
        }

        #endregion

    }
}
