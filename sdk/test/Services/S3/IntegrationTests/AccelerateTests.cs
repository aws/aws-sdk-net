 using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System.Diagnostics;
using Amazon.Util;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Summary description for PutObjectTest
    /// </summary>
    [TestClass]
    public class AccelerateTests : TestBase<AmazonS3Client>
    {
        private static RegionEndpoint TestRegionEndpoint = RegionEndpoint.USEast1;
        private static string AuthRegion = "us-east-1";
        private static string bucketName;
        private static string testContent = "This is the content body!";
        private static IAmazonS3 s3Client = null;
        private static List<string> leftoverBuckets = new List<string>();

        private Random random = new Random();

        [ClassInitialize()]
        public static void Initialize(TestContext a)
        {
            s3Client = new AmazonS3Client(TestRegionEndpoint);
            bucketName = S3TestUtils.CreateBucketWithWait(s3Client, true);
            BucketAccelerateStatus bucketStatus = null;

            s3Client.PutBucketAccelerateConfiguration(new PutBucketAccelerateConfigurationRequest
            {
                BucketName = bucketName,
                AccelerateConfiguration = new AccelerateConfiguration
                {
                    Status = BucketAccelerateStatus.Enabled
                }
            });

            var response = S3TestUtils.WaitForConsistency(() =>
            {
                var res = s3Client.GetBucketAccelerateConfiguration(bucketName);
                return res.Status == BucketAccelerateStatus.Enabled ? res : null;
            });

            bucketStatus = response.Status;
            Assert.AreEqual(BucketAccelerateStatus.Enabled, bucketStatus);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            if (leftoverBuckets.Any())
            {
                foreach (var bucket in leftoverBuckets)
                {
                    AmazonS3Util.DeleteS3BucketWithObjects(s3Client, bucket);
                }
            }

            AmazonS3Util.DeleteS3BucketWithObjects(s3Client, bucketName);
            s3Client.Dispose();
            BaseClean();
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestAccelerateEnabledClient()
        {
            using (var client = new AmazonS3Client(
                new AmazonS3Config
                {
                    UseAccelerateEndpoint = true,
                    RegionEndpoint = TestRegionEndpoint
                }))
            {

                TestAccelerateUnsupportedOperations(client);
                TestControlPlaneOperations(client);
                TestDataPlaneOperations(client);

                // Test error scenarios
                var exception1 = AssertExtensions.ExpectException<AmazonClientException>(
                    () => client.ListObjects("accelerate.incompatible.bucket"));
            }

            var exception2 = AssertExtensions.ExpectException<AmazonClientException>(
                () => new AmazonS3Client( new AmazonS3Config
                {
                    ForcePathStyle = true,
                    UseAccelerateEndpoint = true,
                    RegionEndpoint = TestRegionEndpoint
                }));

            using (var sigV4Client = new AmazonS3Client( new AmazonS3Config
            {
                UseAccelerateEndpoint = true,
                RegionEndpoint = TestRegionEndpoint
            }))
            {

                TestAccelerateUnsupportedOperations(sigV4Client);
                TestControlPlaneOperations(sigV4Client);
                TestDataPlaneOperations(sigV4Client);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestClientWithExplicitRegionEndpointAndAccelerateEnabled()
        {
            using (var explicitAccelerateEndpointClient = new AmazonS3Client( new AmazonS3Config
            {
                RegionEndpoint = TestRegionEndpoint,
                UseAccelerateEndpoint = true
            }))
            {
                TestAccelerateUnsupportedOperations(explicitAccelerateEndpointClient);
                TestControlPlaneOperations(explicitAccelerateEndpointClient);
                TestDataPlaneOperations(explicitAccelerateEndpointClient);
            }
            using (var dualstackAccelerateEndpointClient = new AmazonS3Client( new AmazonS3Config
            {
                RegionEndpoint = TestRegionEndpoint,
                UseAccelerateEndpoint = true,
                UseDualstackEndpoint = true
            }))
            {
                TestAccelerateUnsupportedOperations(dualstackAccelerateEndpointClient);
                TestControlPlaneOperations(dualstackAccelerateEndpointClient);
                TestDataPlaneOperations(dualstackAccelerateEndpointClient);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestClientWithExplicitAccelerateEndpoint()
        {
            AssertExtensions.ExpectException<AmazonClientException>(
                () => new AmazonS3Client( new AmazonS3Config
                {
                    ServiceURL = "https://s3-accelerate.amazonaws.com"
                }));

            AssertExtensions.ExpectException<AmazonClientException>(
                () => new AmazonS3Client( new AmazonS3Config
                {
                    ServiceURL = "https://s3-accelerate.dualstack.amazonaws.com"
                }));

            using (var explicitAccelerateEndpointAndAuthRegionClient = new AmazonS3Client( new AmazonS3Config
                {
                    ServiceURL = "https://s3-accelerate.amazonaws.com",
                    AuthenticationRegion = AuthRegion
                }))
            {

                TestAccelerateUnsupportedOperations(explicitAccelerateEndpointAndAuthRegionClient);
                TestControlPlaneOperations(explicitAccelerateEndpointAndAuthRegionClient);
                TestDataPlaneOperations(explicitAccelerateEndpointAndAuthRegionClient);
            }

            using (var explicitAccelerateEndpointAndAuthRegionClient = new AmazonS3Client( new AmazonS3Config
            {
                ServiceURL = "https://s3-accelerate.dualstack.amazonaws.com",
                AuthenticationRegion = AuthRegion
            }))
            {

                TestAccelerateUnsupportedOperations(explicitAccelerateEndpointAndAuthRegionClient);
                TestControlPlaneOperations(explicitAccelerateEndpointAndAuthRegionClient);
                TestDataPlaneOperations(explicitAccelerateEndpointAndAuthRegionClient);
            }

            using (var explicitAccelerateEndpointAndRegionEndpoint = new AmazonS3Client( new AmazonS3Config
                {
                    ServiceURL = "https://s3-accelerate.amazonaws.com",
                    RegionEndpoint = TestRegionEndpoint
                }))
            {

                TestAccelerateUnsupportedOperations(explicitAccelerateEndpointAndRegionEndpoint);
                TestControlPlaneOperations(explicitAccelerateEndpointAndRegionEndpoint);
                TestDataPlaneOperations(explicitAccelerateEndpointAndRegionEndpoint);
            }

        }
        void TestDataPlaneOperations(IAmazonS3 client)
        {
            var key = "contentBodyPut" + random.Next();
            PutObjectRequest putRequest = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = testContent,
                CannedACL = S3CannedACL.AuthenticatedRead
            };
            client.PutObject(putRequest);

            var getRequest = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = key
            };
            using (var response = client.GetObject(getRequest))
            using (StreamReader reader = new StreamReader(response.ResponseStream))
            {
                var responseData = reader.ReadToEnd();
                Assert.AreEqual(testContent, responseData);
            }
        }

        void TestControlPlaneOperations(IAmazonS3 client)
        {
            // All other operations should hit accelerate endpoint
            var objects = client.ListObjects(bucketName).S3Objects;

            if (objects == null)
                Assert.IsFalse(AWSConfigs.InitializeCollections);
            else
                Assert.IsNotNull(objects);
        }

        void TestAccelerateUnsupportedOperations(IAmazonS3 client)
        {
            // List, Put and Delete bucket should hit regional endpoint
            var buckets = client.ListBuckets().Buckets;
            Assert.IsNotNull(buckets);
            var newBucket = UtilityMethods.GenerateName();
            client.PutBucket(newBucket);

            S3TestUtils.WaitForConsistency(() =>
            {
                var result = client.ListBuckets().Buckets.Any(b => b.BucketName.Equals(newBucket, StringComparison.Ordinal));
                return result ? (bool?)true : null;
            });

            try
            {
                client.DeleteBucket(newBucket);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to clean up new bucket {newBucket}: {ex.Message}.");
                leftoverBuckets.Add(newBucket);
            }
        }        
    }
}