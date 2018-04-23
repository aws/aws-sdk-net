using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Text.RegularExpressions;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class BucketRegionTests
    {
        [TestMethod]
        [TestCategory("S3")]
        public void HappyCaseSigV2()
        {
            // make sure we're not using the cache with SigV2 requests
            using (var runner = new BucketRegionTestRunner(false))
            {
                if (runner.TestBucketIsReady)
                {
                    runner.USEast1Client.PutObject(runner.PutObjectRequest);
                    RegionEndpoint cachedRegion;
                    Assert.IsFalse(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out cachedRegion));
                    Assert.AreEqual(null, cachedRegion);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void HappyCaseSigV4()
        {
            // make sure the cache works when it gets the region from the response body
            using (var runner = new BucketRegionTestRunner(true))
            {
                if (runner.TestBucketIsReady)
                {
                    runner.USEast1Client.PutObject(runner.PutObjectRequest);
                    RegionEndpoint cachedRegion;
                    Assert.IsTrue(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out cachedRegion));
                    Assert.AreEqual(RegionEndpoint.USWest1, cachedRegion);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void HappyCaseGetObjectMetedata()
        {
            // make sure the cache works when it gets the region from a HEAD bucket request
            using (var runner = new BucketRegionTestRunner(true))
            {
                if (runner.TestBucketIsReady)
                {
                    // ensure the object exists then clear the cache
                    runner.USEast1Client.PutObject(runner.PutObjectRequest);
                    BucketRegionDetector.BucketRegionCache.Clear();
                    runner.USEast1Client.GetObjectMetadata(runner.GetObjectMetadataRequest);
                    RegionEndpoint cachedRegion;
                    Assert.IsTrue(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out cachedRegion));
                    Assert.AreEqual(RegionEndpoint.USWest1, cachedRegion);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetObjectMetedataSessionCredentials()
        {
            // make sure the cache works when it gets the region from a HEAD bucket request
            using (var runner = new BucketRegionTestRunner(true))
            {
                if (runner.TestBucketIsReady)
                {
                    // ensure the object exists then clear the cache
                    runner.USEast1ClientWithSessionCredentials.PutObject(runner.PutObjectRequest);
                    BucketRegionDetector.BucketRegionCache.Clear();
                    runner.USEast1ClientWithSessionCredentials.GetObjectMetadata(runner.GetObjectMetadataRequest);
                    RegionEndpoint cachedRegion;
                    Assert.IsTrue(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out cachedRegion));
                    Assert.AreEqual(RegionEndpoint.USWest1, cachedRegion);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void HappyCaseDoesS3BucketExist()
        {
            // make sure the cache works when it gets the region from the x-amz-bucket-region header
            using (var runner = new BucketRegionTestRunner(true, true))
            {
                if (runner.TestBucketIsReady)
                {
                    Assert.IsTrue(AmazonS3Util.DoesS3BucketExist(runner.USEast1Client, runner.BucketName));
                    RegionEndpoint cachedRegion;
                    Assert.IsTrue(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out cachedRegion));
                    Assert.AreEqual(RegionEndpoint.USWest1, cachedRegion);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void BucketRecreatedInDifferentRegion()
        {
            // make sure the cache gets refreshed when it should
            using (var runner = new BucketRegionTestRunner(true))
            {
                if (runner.TestBucketIsReady)
                {
                    BucketRegionDetector.BucketRegionCache.AddOrUpdate(runner.BucketName, RegionEndpoint.APNortheast2);
                    runner.USEast1Client.PutObject(runner.PutObjectRequest);
                    RegionEndpoint cachedRegion;
                    Assert.IsTrue(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out cachedRegion));
                    Assert.AreEqual(RegionEndpoint.USWest1, cachedRegion);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetPreSignedUrlSigV2()
        {
            using (var runner = new BucketRegionTestRunner(false))
            {
                if (runner.TestBucketIsReady)
                {
                    Assert.AreEqual(HttpStatusCode.OK, GetHttpStatusCode(runner.USEast1Client.GetPreSignedURL(runner.PreSignedUrlRequest)));
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetPreSignedUrlSigV4ImplicitlySet()
        {
            using (var runner = new BucketRegionTestRunner(true))
            {
                if (runner.TestBucketIsReady)
                {
                    Assert.AreEqual(HttpStatusCode.OK, GetHttpStatusCode(runner.USEast1Client.GetPreSignedURL(runner.PreSignedUrlRequest)));
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetPreSignedUrlSigV4ExplicitlySet()
        {
            using (var runner = new BucketRegionTestRunner(true, true))
            {
                if (runner.TestBucketIsReady)
                {
                    Assert.AreEqual(HttpStatusCode.BadRequest, GetHttpStatusCode(runner.USEast1Client.GetPreSignedURL(runner.PreSignedUrlRequest)));
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void NoCredentialsOnContext()
        {
            var request = new AssumeRoleRequest()
            {
                DurationSeconds = 0 // invalid value for DurationSeconds - credentials will be null when retrying request
            };
            // keep this unit test even though STSAssumeRoleAWSCredentials is obsolete
            // the condition it's testing doesn't exist when AssumeRoleAWSCredentials (STSAssumeRoleAWSCredentials's replacement) is used
#pragma warning disable 0618
            var credentials = new STSAssumeRoleAWSCredentials(new AmazonSecurityTokenServiceClient(), request);
            var s3Client = new AmazonS3Client(credentials);
            AssertExtensions.ExpectException(() => { s3Client.ListBuckets(); }, typeof(AmazonSecurityTokenServiceException), new Regex("3 validation errors detected"));
        }

        private HttpStatusCode GetHttpStatusCode(string url)
        {
            var httpRequest = WebRequest.Create(url) as HttpWebRequest;
            try
            {
                using (var httpResponse = httpRequest.GetResponse() as HttpWebResponse)
                {
                    return httpResponse.StatusCode;
                }
            }
            catch (WebException we)
            {
                using (var errorResponse = we.Response as HttpWebResponse)
                {
                    return errorResponse.StatusCode;
                }
            }
        }
    }
}
