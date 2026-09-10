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
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3;
using Amazon.S3.Internal;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Util;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Verifies that a cross-Region HeadBucket (and any other S3 operation) issued against a
    /// client configured for a Region that differs from the bucket's Region follows the region
    /// redirect instead of surfacing the error. When the bucket is in us-east-1 and the client is
    /// not, S3 answers with a 301 MovedPermanently (rather than a 400) that carries the correct
    /// Region in the x-amz-bucket-region header; the SDK must route that response through the
    /// existing bucket-region detection so the request is retried against the correct Region.
    ///
    /// Reproduces https://github.com/aws/aws-tools-for-powershell/issues/413 (DOTNET-8539).
    /// </summary>
    [TestClass]
    public class HeadBucketRegionRedirectTests
    {
        private const string BucketName = "my-bucket-12345";
        private const string BucketActualRegion = "us-west-2";

        [TestInitialize]
        public void ClearCache()
        {
            BucketRegionDetector.BucketRegionCache.Clear();
        }

        private static IWebResponseData CreateErrorResponse(HttpStatusCode statusCode, string bucketRegion)
        {
            var mock = new Mock<IWebResponseData>();
            var headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            if (bucketRegion != null)
                headers[HeaderKeys.XAmzBucketRegion] = bucketRegion;

            mock.Setup(r => r.StatusCode).Returns(statusCode);
            mock.Setup(r => r.ContentLength).Returns(0);
            mock.Setup(r => r.IsHeaderPresent(It.IsAny<string>()))
                .Returns((string name) => headers.ContainsKey(name));
            mock.Setup(r => r.GetHeaderValue(It.IsAny<string>()))
                .Returns((string name) => headers.TryGetValue(name, out var value) ? value : null);
            return mock.Object;
        }

        private static AmazonS3Exception CreateS3Exception(HttpStatusCode statusCode, string bucketRegion)
        {
            var innerHttpException = new HttpErrorResponseException(CreateErrorResponse(statusCode, bucketRegion));
            return new AmazonS3Exception(
                "Error making request.",
                innerHttpException,
                ErrorType.Unknown,
                statusCode.ToString(),
                "TEST-REQUEST-ID",
                statusCode);
        }

        private static IExecutionContext CreateContext(AmazonWebServiceRequest originalRequest, Uri endpoint)
        {
            var requestContext = new RequestContext(false, new NullSigner())
            {
                OriginalRequest = originalRequest,
                Request = new DefaultRequest(originalRequest, "S3") { Endpoint = endpoint },
                ClientConfig = new AmazonS3Config { RegionEndpoint = RegionEndpoint.USWest1 }
            };
            return new ExecutionContext(requestContext, new ResponseContext());
        }

        /// <summary>
        /// The synchronous portion of the retry check must report "inconclusive" (null) for the
        /// redirect statuses so the async path runs the bucket-region detection. Previously only
        /// 400 BadRequest did this, so a 301 fell through to the base retry policy and the region
        /// mismatch was never detected.
        /// </summary>
        [TestMethod]
        [DataRow(HttpStatusCode.MovedPermanently)]
        [DataRow(HttpStatusCode.PermanentRedirect)]
        [TestCategory("S3")]
        public void RedirectStatus_IsRoutedToRegionDetection(HttpStatusCode statusCode)
        {
            var exception = CreateS3Exception(statusCode, BucketActualRegion);
            var context = CreateContext(
                new HeadBucketRequest { BucketName = BucketName },
                new Uri("https://" + BucketName + ".s3.us-west-1.amazonaws.com"));

            var result = AmazonS3RetryPolicy.SharedRetryForExceptionSync(
                context, exception, Amazon.Runtime.Internal.Util.Logger.GetLogger(typeof(HeadBucketRegionRedirectTests)), (_, __) => false);

            Assert.IsNull(result,
                "A redirect response must be treated as inconclusive so region detection runs.");
        }

        /// <summary>
        /// End-to-end of the shared async retry logic: a 301 carrying x-amz-bucket-region should
        /// cause the request to be retried against the correct Region (AuthenticationRegion set,
        /// request marked unsigned, cache populated), rather than being surfaced as an error.
        /// </summary>
        [TestMethod]
        [DataRow(HttpStatusCode.MovedPermanently)]
        [DataRow(HttpStatusCode.BadRequest)]
        [TestCategory("S3")]
        public async Task CrossRegionHeadBucket_RetriesAgainstCorrectRegion(HttpStatusCode statusCode)
        {
            var exception = CreateS3Exception(statusCode, BucketActualRegion);
            var context = CreateContext(
                new HeadBucketRequest { BucketName = BucketName },
                new Uri("https://" + BucketName + ".s3.us-west-1.amazonaws.com"));

            var shouldRetry = await AmazonS3RetryPolicy.SharedRetryForExceptionAsync(
                context,
                exception,
                (ctx, ex) => AmazonS3RetryPolicy.SharedRetryForExceptionSync(ctx, ex, Amazon.Runtime.Internal.Util.Logger.GetLogger(typeof(HeadBucketRegionRedirectTests)), (_, __) => false),
                (_, __) => false);

            Assert.IsTrue(shouldRetry, "The request should be retried against the correct Region.");
            Assert.AreEqual(BucketActualRegion, context.RequestContext.Request.AuthenticationRegion);
            Assert.IsFalse(context.RequestContext.IsSigned, "The retried request must be re-signed.");
            Assert.IsTrue(
                BucketRegionDetector.BucketRegionCache.TryGetValue(BucketName, out var cachedRegion),
                "The detected bucket region should be cached.");
            Assert.AreEqual(RegionEndpoint.GetBySystemName(BucketActualRegion), cachedRegion);

            // The critical assertion: the request ENDPOINT must actually move to the corrected
            // Region, not just the signing region. The S3 endpoint resolver runs once, outside the
            // retry loop, so correcting only AuthenticationRegion would leave the request pointed at
            // the original endpoint and S3 would keep returning the redirect until retries exhaust.
            var endpointHost = context.RequestContext.Request.Endpoint.Host;
            StringAssert.Contains(endpointHost, "s3." + BucketActualRegion + ".amazonaws.com",
                "The retried request endpoint must target the bucket's actual Region.");
            Assert.IsFalse(endpointHost.Contains("us-west-1"),
                "The retried request endpoint must no longer target the original (client) Region.");
            Assert.AreEqual(RegionEndpoint.GetBySystemName(BucketActualRegion),
                context.RequestContext.Request.AlternateEndpoint,
                "AlternateEndpoint should reflect the corrected Region.");
        }

        /// <summary>
        /// A genuine failure that is not a region redirect (e.g. 404 with no region header) must
        /// not be routed into region detection; it should defer to the base retry policy.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void NonRedirectStatus_DefersToBaseRetryPolicy()
        {
            var exception = CreateS3Exception(HttpStatusCode.NotFound, bucketRegion: null);
            var context = CreateContext(
                new HeadBucketRequest { BucketName = BucketName },
                new Uri("https://" + BucketName + ".s3.us-west-1.amazonaws.com"));

            var baseInvoked = false;
            var result = AmazonS3RetryPolicy.SharedRetryForExceptionSync(
                context, exception, Amazon.Runtime.Internal.Util.Logger.GetLogger(typeof(HeadBucketRegionRedirectTests)), (_, __) => { baseInvoked = true; return false; });

            Assert.IsFalse(result.Value, "A 404 should not be retried by the S3-specific logic.");
            Assert.IsTrue(baseInvoked, "A non-redirect status should defer to the base retry policy.");
        }
    }
}
