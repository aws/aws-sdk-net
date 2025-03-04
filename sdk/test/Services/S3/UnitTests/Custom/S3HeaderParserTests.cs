using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using AWSSDK_DotNet.UnitTests.TestTools;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3HeaderParserTests
    {
        [TestCategory("S3")]
        [TestMethod]
        public void Expiration_ValidHeader()
        {
            var responseData = new WebResponseData
            {
                Headers = new Dictionary<string, string>
                {
                    { "x-amz-expiration", "expiry-date=\"Wed, 01 Jan 2025 00:00:00 GMT\", rule-id=\"id1\"" },
                    { "x-amzn-RequestId", "test-request-id" }
                }
            };

            var context = new XmlUnmarshallerContext(new MemoryStream(), false, responseData);
            var response = (GetObjectResponse) GetObjectResponseUnmarshaller.Instance.UnmarshallResponse(context);
            
            Assert.IsNotNull(response.Expiration);
            Assert.AreNotEqual(default, response.Expiration.ExpiryDate);
            Assert.AreEqual("id1", response.Expiration.RuleId);
        }

        [TestCategory("S3")]
        [DataTestMethod]
        [DataRow("NotImplemented")]
        [DataRow("expiry-date=, rule-id=")]
        [DataRow("expiry-date=\"foo\", rule-id=")]
        public void Expiration_InvalidHeader(string headerValue)
        {
            var responseData = new WebResponseData
            {
                Headers = new Dictionary<string, string>
                {
                    { "x-amz-expiration", headerValue },
                    { "x-amzn-RequestId", "test-request-id" }
                }
            };

            var context = new XmlUnmarshallerContext(new MemoryStream(), false, responseData);
            var response = (GetObjectResponse)GetObjectResponseUnmarshaller.Instance.UnmarshallResponse(context);

            Assert.IsNotNull(response.Expiration);
            Assert.AreEqual(default, response.Expiration.ExpiryDate);
            Assert.IsNull(response.Expiration.RuleId);
        }

        [TestCategory("S3")]
        [DataTestMethod]
        [DataRow("ongoing-request=\"false\", expiry-date=\"Fri, 21 Dec 2012 00:00:00 GMT\"", false)]
        [DataRow("ongoing-request=\"true\"", true)]
        public void Restore_ValidHeader(string headerValue, bool isOngoingRequest)
        {
            var responseData = new WebResponseData
            {
                Headers = new Dictionary<string, string>
                {
                    { "x-amz-restore", headerValue },
                    { "x-amzn-RequestId", "test-request-id" }
                }
            };

            var context = new XmlUnmarshallerContext(new MemoryStream(), false, responseData);
            var response = (GetObjectResponse)GetObjectResponseUnmarshaller.Instance.UnmarshallResponse(context);
            
            Assert.AreEqual(isOngoingRequest, response.RestoreInProgress);
            if (!isOngoingRequest)
            {
                Assert.IsNotNull(response.RestoreExpiration);
            }
        }

        [TestCategory("S3")]
        [DataTestMethod]
        [DataRow("")]
        [DataRow("NotImplemented")]
        [DataRow("ongoing-request=, expiry-date=")]
        public void Restore_InvalidHeader(string headerValue)
        {
            var responseData = new WebResponseData
            {
                Headers = new Dictionary<string, string>
                {
                    { "x-amz-restore", headerValue },
                    { "x-amzn-RequestId", "test-request-id" }
                }
            };

            var context = new XmlUnmarshallerContext(new MemoryStream(), false, responseData);
            var response = (GetObjectResponse)GetObjectResponseUnmarshaller.Instance.UnmarshallResponse(context);

            Assert.IsFalse(response.RestoreInProgress.GetValueOrDefault());
            Assert.IsNull(response.RestoreExpiration);
        }
    }
}
