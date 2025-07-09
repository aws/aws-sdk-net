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
        public void HappyCaseSigV4()
        {
            // make sure the cache works when it gets the region from the response body
            using (var runner = new BucketRegionTestRunner())
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
            using (var runner = new BucketRegionTestRunner())
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
        [TestCategory("RequiresIAMUser")]
        public void GetObjectMetedataSessionCredentials()
        {
            // make sure the cache works when it gets the region from a HEAD bucket request
            using (var runner = new BucketRegionTestRunner(setupClientWithSessionCredentials: true))
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
            using (var runner = new BucketRegionTestRunner())
            {
                if (runner.TestBucketIsReady)
                {
                    Assert.IsTrue(AmazonS3Util.DoesS3BucketExistV2(runner.USEast1Client, runner.BucketName));
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
            using (var runner = new BucketRegionTestRunner())
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
        public void GetPreSignedUrlUSEast1SigV2()
        {
            using (var runner = new BucketRegionTestRunner())
            {
                if (runner.TestBucketIsReady)
                {
                    Assert.AreEqual(HttpStatusCode.OK, GetHttpStatusCode(runner.USEast1Client.GetPreSignedURL(runner.PreSignedUrlRequestExtendedExpiration)));
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetPreSignedUrlUSWest1SigV2()
        {
            using (var runner = new BucketRegionTestRunner())
            {
                if (runner.TestBucketIsReady)
                {
                    Assert.AreEqual(HttpStatusCode.OK, GetHttpStatusCode(runner.USWest1Client.GetPreSignedURL(runner.PreSignedUrlRequestExtendedExpiration)));
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetPreSignedUrlSigV4USWest1ClientUSWest2BucketOk()
        {
            using (var runner = new BucketRegionTestRunner())
            {
                if (runner.TestBucketIsReady)
                {
                    Assert.AreEqual(HttpStatusCode.OK, GetHttpStatusCode(runner.USWest1Client.GetPreSignedURL(runner.PreSignedUrlRequest)));
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetPreSignedUrlSigV4USEast1ClientUSWest2BucketFail()
        {
            using (var runner = new BucketRegionTestRunner())
            {
                if (runner.TestBucketIsReady)
                {
                    Assert.AreEqual(HttpStatusCode.BadRequest, GetHttpStatusCode(runner.USEast1Client.GetPreSignedURL(runner.PreSignedUrlRequest)));
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void DeleteBucketUsingS3RegionUSEast1Enum()
        {
            using (var runner = new BucketRegionTestRunner())
            {
                var bucketName = S3TestUtils.CreateBucketWithWait(runner.USEast1Client);

                runner.USWest1Client.DeleteBucket(new DeleteBucketRequest
                {
                    BucketName = bucketName,
                    BucketRegion = S3Region.USEast1
                });
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetBucketLocation()
        {
            using (var runner = new BucketRegionTestRunner())
            {
                var nonUsEast1Bucket = S3TestUtils.CreateBucketWithWait(runner.USWest1Client);
                try
                {
                    var nonNullocationResponse = runner.USWest1Client.GetBucketLocation(nonUsEast1Bucket);
                    Assert.IsNotNull(nonNullocationResponse.Location);
                    Assert.AreEqual(RegionEndpoint.USWest1.SystemName, nonNullocationResponse.Location.ToString());
                }
                finally
                {
                    runner.USWest1Client.DeleteBucket(new DeleteBucketRequest
                    {
                        BucketName = nonUsEast1Bucket
                    });
                }

                // Buckets in us-east-1 have a LocationConstraint of null.
                var usEast1Bucket = S3TestUtils.CreateBucketWithWait(runner.USEast1Client);
                try
                {
                    var nullLocationResponse = runner.USEast1Client.GetBucketLocation(usEast1Bucket);
                    Assert.IsTrue(string.IsNullOrEmpty(nullLocationResponse.Location));
                }
                finally
                {
                    runner.USEast1Client.DeleteBucket(new DeleteBucketRequest
                    {
                        BucketName = usEast1Bucket
                    });
                }
            }
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
