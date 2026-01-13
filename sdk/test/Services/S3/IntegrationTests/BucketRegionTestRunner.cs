using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using System;
using System.Threading.Tasks;

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
    /// </summary>
    public class BucketRegionTestRunner : IDisposable
    {
        private bool _disposedValue;
        private const string TestObjectKey = "test.txt";
        private const string TestContent = "some stuff";
        private const int TemporaryRedirectMaxExpirationHours = 5;
        private readonly string BucketPrefix = "s3-region-bucket-tests-";

        public AmazonS3Client USEast1Client { get; private set; }
        public AmazonS3Client USWest1Client { get; private set; }
        public S3Bucket TestBucket { get; private set; }
        public bool TestBucketIsReady { get; private set; }
        public GetObjectMetadataRequest GetObjectMetadataRequest { get; private set; }
        public PutObjectRequest PutObjectRequest { get; private set; }
        public GetPreSignedUrlRequest PreSignedUrlRequest { get; private set; }
        public GetPreSignedUrlRequest PreSignedUrlRequestExtendedExpiration { get; private set; }
        public string BucketName => TestBucket?.BucketName;

        private BucketRegionTestRunner()
        {
            // Private constructor - use CreateAsync factory method instead
        }

        /// <summary>
        /// Creates and initializes a new instance of BucketRegionTestRunner asynchronously.
        /// </summary>
        /// <returns>A fully initialized BucketRegionTestRunner instance</returns>
        public static async Task<BucketRegionTestRunner> CreateAsync()
        {
            var runner = new BucketRegionTestRunner();
            await runner.InitializeAsync();
            return runner;
        }

        private async Task InitializeAsync()
        {
            USEast1Client = new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                USEast1RegionalEndpointValue = S3UsEast1RegionalEndpointValue.Legacy,
            });

            USWest1Client = new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USWest1
            });

            await CreateAndCheckTestBucketAsync();
            if (TestBucketIsReady)
            {
                GetObjectMetadataRequest = new GetObjectMetadataRequest
                {
                    BucketName = TestBucket.BucketName,
                    Key = TestObjectKey
                };
                PutObjectRequest = new PutObjectRequest
                {
                    BucketName = TestBucket.BucketName,
                    Key = TestObjectKey,
                    ContentBody = TestContent
                };
                PreSignedUrlRequest = new GetPreSignedUrlRequest
                {
                    BucketName = BucketName,
                    Key = TestObjectKey,
                    Expires = DateTime.UtcNow.AddHours(1)
                };
                PreSignedUrlRequestExtendedExpiration = new GetPreSignedUrlRequest
                {
                    BucketName = BucketName,
                    Key = TestObjectKey,
                    Expires = DateTime.UtcNow.AddDays(8) // Greater than 7 days will force a SigV2 presigned URL.
                };
            }
        }

        private async Task CreateAndCheckTestBucketAsync()
        {
            TestBucketIsReady = false;

            var listBucketsResponse = await USWest1Client.ListBucketsAsync();
            TestBucket = listBucketsResponse.Buckets.Find(bucket => bucket.BucketName.StartsWith(BucketPrefix));
            if (TestBucket == null)
            {
                // add ticks to bucket name because the bucket namespace is shared globally
                var bucketName = BucketPrefix + DateTime.UtcNow.Ticks;

                // Create the bucket but don't run the test.
                // If the bucket is ready the next time this test runs we'll test then.
                await USWest1Client.PutBucketAsync(new PutBucketRequest
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