using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using AWSSDK_DotNet.IntegrationTests.Tests;
using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.CloudFront;
using Amazon.CloudFront.Model;
using Amazon.S3.Model;
using Amazon.IdentityManagement.Model;
using System.IO;
using System.Net;
using System.Globalization;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class CloudFront : TestBase<AmazonCloudFrontClient>
    {
        [TestMethod]
        [TestCategory("CloudFront")]
        public void ListDistributions()
        {
            var response = Client.ListDistributions();
            Assert.IsNotNull(response.DistributionList);
        }

        [TestMethod]
        [TestCategory("CloudFront")]
        public void OriginTests()
        {
            var createRequest = new CreateCloudFrontOriginAccessIdentityRequest()
            {
                CloudFrontOriginAccessIdentityConfig = new CloudFrontOriginAccessIdentityConfig()
                {
                    CallerReference = Guid.NewGuid().ToString(),
                    Comment = UtilityMethods.SDK_TEST_PREFIX
                }
            };
            var createResponse = Client.CreateCloudFrontOriginAccessIdentity(createRequest);
            Assert.IsNotNull(createResponse.ETag);
            Assert.IsNotNull(createResponse.CloudFrontOriginAccessIdentity.Id);

            var updateRequest = new UpdateCloudFrontOriginAccessIdentityRequest()
            {
                CloudFrontOriginAccessIdentityConfig = new CloudFrontOriginAccessIdentityConfig()
                {
                    CallerReference = createRequest.CloudFrontOriginAccessIdentityConfig.CallerReference,
                    Comment = UtilityMethods.SDK_TEST_PREFIX + "update"
                },
                Id = createResponse.CloudFrontOriginAccessIdentity.Id,
                IfMatch = createResponse.ETag
            };
            var updateResponse = Client.UpdateCloudFrontOriginAccessIdentity(updateRequest);
            Assert.IsNotNull(updateResponse.ETag);
            Assert.IsNotNull(updateResponse.CloudFrontOriginAccessIdentity.CloudFrontOriginAccessIdentityConfig.Comment);


            var listResponse = Client.ListCloudFrontOriginAccessIdentities();
            Assert.IsTrue(listResponse.CloudFrontOriginAccessIdentityList.Items.Count > 0);

            var deleteRequest = new DeleteCloudFrontOriginAccessIdentityRequest()
            {
                Id = createResponse.CloudFrontOriginAccessIdentity.Id,
                IfMatch = updateResponse.ETag
            };
            var deleteResponse = Client.DeleteCloudFrontOriginAccessIdentity(deleteRequest);
            Assert.IsNotNull(deleteResponse.ResponseMetadata.RequestId);
        }

        // A CloudFront distribution with Trusted Signer needs to be created
        // to execute this test.
        //[TestMethod]
        //[TestCategory("CloudFront")]
        public void SignedCookieForCannedPolicyTest()
        {
            var cloudFrontKeyPairId = "";
            var privateKeyFile = new FileInfo(@"");
            var resourceUri = "";
            var distributionUri = new Uri("");
            var expectedResponseContent = "";

            var cookies = AmazonCloudFrontCookieSigner.GetCookiesForCannedPolicy(
                resourceUri,
                cloudFrontKeyPairId,
                privateKeyFile,
                DateTime.Today.AddYears(1));

            var request = (HttpWebRequest)HttpWebRequest.Create(resourceUri);
            var cookieContainer = new CookieContainer();
            cookieContainer.Add(distributionUri, new Cookie(cookies.Expires.Key, cookies.Expires.Value));
            cookieContainer.Add(distributionUri, new Cookie(cookies.Signature.Key, cookies.Signature.Value));
            cookieContainer.Add(distributionUri, new Cookie(cookies.KeyPairId.Key, cookies.KeyPairId.Value));
            request.CookieContainer = cookieContainer;

            var response = (HttpWebResponse)request.GetResponse();
            using (var responsestream = new StreamReader(response.GetResponseStream()))
            {
                var responseContent = responsestream.ReadToEnd();
                Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
                Assert.AreEqual(expectedResponseContent, responseContent);
            }
        }

        // A CloudFront distribution with Trusted Signer needs to be created
        // to execute this test.
        //[TestMethod]
        //[TestCategory("CloudFront")]
        public void SignedCookieForCustomPolicyTest()
        {
            var cloudFrontKeyPairId = "";
            var privateKeyFile = new FileInfo(@"");
            var resourceUri = "";
            var distributionUri = new Uri("");
            var distributionDomain = "";
            var expectedResponseContent = "";

            var cookies = AmazonCloudFrontCookieSigner.GetCookiesForCustomPolicy(
            AmazonCloudFrontCookieSigner.Protocols.Http |
            AmazonCloudFrontCookieSigner.Protocols.Https,
            distributionDomain,
            privateKeyFile,
            "*.txt",
            cloudFrontKeyPairId,
            DateTime.Today.AddDays(1),
            DateTime.Today,
            string.Empty);

            var request = (HttpWebRequest)HttpWebRequest.Create(resourceUri);
            var cookieContainer = new CookieContainer();
            cookieContainer.Add(new Cookie(cookies.Policy.Key, cookies.Policy.Value, "/", distributionDomain));
            cookieContainer.Add(new Cookie(cookies.Signature.Key, cookies.Signature.Value, "/", distributionDomain));
            cookieContainer.Add(new Cookie(cookies.KeyPairId.Key, cookies.KeyPairId.Value, "/", distributionDomain));
            request.CookieContainer = cookieContainer;

            var response = (HttpWebResponse)request.GetResponse();
            using (var responsestream = new StreamReader(response.GetResponseStream()))
            {
                var responseContent = responsestream.ReadToEnd();
                Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
                Assert.AreEqual(expectedResponseContent, responseContent);
            }
        }
    }
}
