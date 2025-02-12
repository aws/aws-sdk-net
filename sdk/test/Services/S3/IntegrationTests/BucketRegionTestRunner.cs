using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.SecurityToken;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Reflection;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{

    /// <summary>
    /// Encapsulate common things necessary for all bucket region tests.
    /// 
    /// Tests require a bucket where the DNS has propagated and
    /// S3 has stopped issuing 301 for the bucket.
    ///
    /// This is done by ensuring the bucket is well over 4 hours old.
    /// Tests must check the TestBucketIsReady property before running.
    ///
    /// </summary>
    public class BucketRegionTestRunner : IDisposable
    {
        private bool _disposedValue;
        private const string TestObjectKey = "test.txt";
        private const string TestContent = "some stuff";
        private const int TemporaryRedirectMaxExpirationHours = 5;

        private string BucketPrefix = "s3-region-bucket-tests-";
        
        public AmazonS3Client USEast1ClientWithSessionCredentials { get; private set; }
        public AmazonS3Client USEast1Client { get; private set; }
        public AmazonS3Client USWest1Client { get; private set; }
        public S3Bucket TestBucket { get; private set; }
        public bool TestBucketIsReady { get; private set; }
        public GetObjectMetadataRequest GetObjectMetadataRequest { get; private set; }
        public PutObjectRequest PutObjectRequest { get; private set; }
        public GetPreSignedUrlRequest PreSignedUrlRequest { get; private set; }
        public GetPreSignedUrlRequest PreSignedUrlRequestExtendedExpiration { get; private set; }
        public string BucketName
        {
            get
            {
                return TestBucket == null ? null : TestBucket.BucketName;
            }
        }

        public BucketRegionTestRunner(bool setupClientWithSessionCredentials = false)
        {
            var usEast1ClientConfig = new AmazonS3Config()
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                USEast1RegionalEndpointValue = S3UsEast1RegionalEndpointValue.Legacy,
            };
            USEast1Client = new AmazonS3Client(usEast1ClientConfig);

            if (setupClientWithSessionCredentials)
            {
                var sessionCredentials = new AmazonSecurityTokenServiceClient().GetSessionToken().Credentials;
                USEast1ClientWithSessionCredentials = new AmazonS3Client(sessionCredentials, usEast1ClientConfig);
            }

            USWest1Client = new AmazonS3Client(new AmazonS3Config()
            {
                RegionEndpoint = RegionEndpoint.USWest1
            });


            CreateAndCheckTestBucket();
            if (TestBucketIsReady)
            {
                GetObjectMetadataRequest = new GetObjectMetadataRequest()
                {
                    BucketName = TestBucket.BucketName,
                    Key = TestObjectKey
                };
                PutObjectRequest = new PutObjectRequest()
                {
                    BucketName = TestBucket.BucketName,
                    Key = TestObjectKey,
                    ContentBody = TestContent
                };
                PreSignedUrlRequest = new GetPreSignedUrlRequest
                {
                    BucketName = BucketName,
                    Key = BucketRegionTestRunner.TestObjectKey,
                    Expires = DateTime.UtcNow.AddHours(1)
                };
                PreSignedUrlRequestExtendedExpiration = new GetPreSignedUrlRequest
                {
                    BucketName = BucketName,
                    Key = BucketRegionTestRunner.TestObjectKey,
                    Expires = DateTime.UtcNow.AddDays(8) // Greater than 7 days will force a SigV2 presigned URL.
                };
            }
        }

        private void CreateAndCheckTestBucket()
        {
            TestBucketIsReady = false;

            TestBucket = USWest1Client.ListBuckets().Buckets.Find(bucket => bucket.BucketName.StartsWith(BucketPrefix));
            if (TestBucket == null)
            {
                // add ticks to bucket name because the bucket namespace is shared globally
                var bucketName = BucketPrefix + DateTime.UtcNow.Ticks;
                // Create the bucket but don't run the test.
                // If the bucket is ready the next time this test runs we'll test then.
                USWest1Client.PutBucket(new PutBucketRequest()
                {
                    BucketRegion = S3Region.USWest1,
                    BucketName = bucketName,
                });
            }
            else if (TestBucket.CreationDate.Value.AddHours(TemporaryRedirectMaxExpirationHours) < DateTime.UtcNow)
            {
                BucketRegionDetector.BucketRegionCache.Clear();
                TestBucketIsReady = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    USEast1ClientWithSessionCredentials?.Dispose();
                    USEast1ClientWithSessionCredentials = null;
                    USEast1Client?.Dispose();
                    USEast1Client = null;
                    USWest1Client?.Dispose();
                    USWest1Client = null;
                }

                _disposedValue = true;
            }
        }
    }
}