using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

using Amazon;
using Amazon.Util;
using Amazon.Runtime.Internal;
using Amazon.S3.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Transform;
using AWSSDK_DotNet.UnitTests.TestTools;
using static AWSSDK.UnitTests.S3AccessPointTests;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3OutpostsTests
    {
        [TestMethod]
        [TestCategory("S3")]
        public void UseArnRegionFalseUSWest2()
        {
            var outpostsArn = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            var expectedEndpoint = new Uri("https://myaccesspoint-123456789012.op-01234567890123456.s3-outposts.us-west-2.amazonaws.com");
            var request = new PutObjectRequest
            {
                BucketName = outpostsArn,
                Key = "foo.txt",
                ContentBody = "data"
            };

            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USWest2,
                UseArnRegion = false
            };
            var internalRequest = S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, config);
            Assert.AreEqual(expectedEndpoint, internalRequest.Endpoint);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void UseArnRegionTrueUsEast1()
        {
            var outpostsArn = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            var expectedEndpoint = new Uri("https://myaccesspoint-123456789012.op-01234567890123456.s3-outposts.us-east-1.amazonaws.com");
            var request = new PutObjectRequest
            {
                BucketName = outpostsArn,
                Key = "foo.txt",
                ContentBody = "data"
            };

            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USWest2,
                UseArnRegion = true
            };
            var internalRequest = S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, config);
            Assert.AreEqual(expectedEndpoint, internalRequest.Endpoint);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void UseArnRegionFalseUSWest2WithSlashes()
        {
            var outpostsArn = "arn:aws:s3-outposts:us-west-2:123456789012:outpost/op-01234567890123456/accesspoint/myaccesspoint";
            var expectedEndpoint = new Uri("https://myaccesspoint-123456789012.op-01234567890123456.s3-outposts.us-west-2.amazonaws.com");
            var request = new PutObjectRequest
            {
                BucketName = outpostsArn,
                Key = "foo.txt",
                ContentBody = "data"
            };

            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USWest2,
                UseArnRegion = false
            };
            var internalRequest = S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, config);
            Assert.AreEqual(expectedEndpoint, internalRequest.Endpoint);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void UseArnRegionTrueUsEast1WithSlashes()
        {
            var outpostsArn = "arn:aws:s3-outposts:us-east-1:123456789012:outpost/op-01234567890123456/accesspoint/myaccesspoint";
            var expectedEndpoint = new Uri("https://myaccesspoint-123456789012.op-01234567890123456.s3-outposts.us-east-1.amazonaws.com");
            var request = new PutObjectRequest
            {
                BucketName = outpostsArn,
                Key = "foo.txt",
                ContentBody = "data"
            };

            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USWest2,
                UseArnRegion = true
            };
            var internalRequest = S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, config);
            Assert.AreEqual(expectedEndpoint, internalRequest.Endpoint);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CrossRegionException()
        {
            try
            {
                var outpostsArn = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
                var request = new PutObjectRequest
                {
                    BucketName = outpostsArn,
                    Key = "foo.txt",
                    ContentBody = "data"
                };

                var config = new AmazonS3Config
                {
                    RegionEndpoint = RegionEndpoint.USWest2,
                    UseArnRegion = false
                };
                S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, config);
                Assert.Fail("AmazonClientException expected");
            } 
            catch (AmazonClientException e)
            {
                Assert.AreEqual("Invalid configuration: region from ARN `us-east-1` does not match client region `us-west-2` and UseArnRegion is `false`", e.Message);
            }
            
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CrossPartitionException()
        {
            try
            {
                var outpostsArn = "arn:aws-cn:s3-outposts:cn-north-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
                var request = new PutObjectRequest
                {
                    BucketName = outpostsArn,
                    Key = "foo.txt",
                    ContentBody = "data"
                };

                var config = new AmazonS3Config
                {
                    RegionEndpoint = RegionEndpoint.USWest2,
                    UseArnRegion = true
                };
                S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, config);
                Assert.Fail("AmazonClientException expected");
            } 
            catch (AmazonClientException e)
            {
                Assert.AreEqual("Client was configured for partition `aws` but ARN (`arn:aws-cn:s3-outposts:cn-north-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint`) has `aws-cn`", e.Message);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void UseArnRegionTrueUsGovEast1()
        {
            var outpostsArn = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            var expectedEndpoint = new Uri("https://myaccesspoint-123456789012.op-01234567890123456.s3-outposts.us-gov-east-1.amazonaws.com");
            var request = new PutObjectRequest
            {
                BucketName = outpostsArn,
                Key = "foo.txt",
                ContentBody = "data"
            };

            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USGovCloudEast1,
                UseArnRegion = true
            };
            var internalRequest = S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, config);
            Assert.AreEqual(expectedEndpoint, internalRequest.Endpoint);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void DualStackException()
        {
            try
            {
                var outpostsArn = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
                var request = new PutObjectRequest
                {
                    BucketName = outpostsArn,
                    Key = "foo.txt",
                    ContentBody = "data"
                };

                var config = new AmazonS3Config
                {
                    RegionEndpoint = RegionEndpoint.USWest2,
                    UseArnRegion = true,
                    UseDualstackEndpoint = true
                };
                S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, config);
                Assert.Fail("AmazonClientException expected");
            }
            catch (AmazonClientException e)
            {
                Assert.AreEqual("S3 Outposts does not support Dual-stack", e.Message);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void AccelerateException()
        {
            try
            {
                var outpostsArn = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
                var request = new PutObjectRequest
                {
                    BucketName = outpostsArn,
                    Key = "foo.txt",
                    ContentBody = "data"
                };

                var config = new AmazonS3Config
                {
                    RegionEndpoint = RegionEndpoint.USWest2,
                    UseArnRegion = true,
                    UseAccelerateEndpoint = true
                };
                S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, config);
                Assert.Fail("AmazonClientException expected");
            }
            catch (AmazonClientException e)
            {
                Assert.AreEqual("S3 Outposts does not support S3 Accelerate", e.Message);
            }
        }

        [DataTestMethod]
        [TestCategory("S3")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost", "us-west-2", S3ConfigFlags.ArnRegion, "", "Invalid ARN: The Outpost Id was not set")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:myaccesspoint", "us-west-2", S3ConfigFlags.ArnRegion, "", "Invalid ARN: Expected a 4-component resource")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456", "us-west-2", S3ConfigFlags.ArnRegion, "", "Invalid ARN: Expected a 4-component resource")]
        [DataRow("arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint", "fips-us-gov-east-1", S3ConfigFlags.None, "", "S3 Outposts does not support FIPS")]
        [DataRow("arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint", "fips-us-gov-east-1", S3ConfigFlags.ArnRegion, "", "S3 Outposts does not support FIPS")]
        public void TestOutpostArnVariations(string arnString, string region, S3ConfigFlags flags, string host, string errorMessage)
        {
            var request = new GetObjectRequest
            {
                BucketName = arnString,
                Key = "foo.txt"
            };

            var config = S3ArnTestUtils.BuildFromRegionSystemName(region, flags);

            Exception exception = null;
            IRequest result = null;

            try
            {
                result = S3ArnTestUtils.RunMockRequest(request, GetObjectRequestMarshaller.Instance, config);
            }
            catch (Exception e)
            {
                exception = e;
            }

            if (!string.IsNullOrEmpty(host))
            {
                Assert.IsNull(exception, "Exception was thrown");

                Assert.AreEqual(new Uri($"https://{host}"), result.Endpoint);
                Assert.AreEqual("/foo.txt", result.ResourcePath);
            }
            else if (!string.IsNullOrEmpty(errorMessage))
            {
                Assert.IsNotNull(exception);
                Assert.IsInstanceOfType(exception, typeof(AmazonClientException));
                Assert.AreEqual( errorMessage, exception.Message);
            }
            else
            {
                Assert.Fail($"Bad Test Data, you must provide either {nameof(host)} or {nameof(errorMessage)}");
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void InvalidArnOutpostId()
        {
            try
            {
                var outpostsArn = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-0123456.890123456:accesspoint:myaccesspoint";
                var request = new PutObjectRequest
                {
                    BucketName = outpostsArn,
                    Key = "foo.txt",
                    ContentBody = "data"
                };

                var config = new AmazonS3Config
                {
                    RegionEndpoint = RegionEndpoint.USWest2,
                    UseArnRegion = true,
                };
                S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, config);
                Assert.Fail("AmazonClientException expected");
            }
            catch (AmazonClientException e)
            {
                Assert.AreEqual("Invalid ARN: The outpost Id may only contain a-z, A-Z, 0-9 and `-`. Found: `op-0123456.890123456`", e.Message);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PreSignedUrlTestBasic()
        {
            var outpostsArn = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";

            var request = new GetPreSignedUrlRequest
            {
                BucketName = outpostsArn,
                Key = "foo.txt",
                Expires = DateTime.UtcNow.AddDays(1),
                Verb = HttpVerb.GET
            };

            var s3Client = new AmazonS3Client("access", "secret", RegionEndpoint.USEast1);

            var uri = new Uri(s3Client.GetPreSignedURL(request));

            Assert.AreEqual("myaccesspoint-123456789012.op-01234567890123456.s3-outposts.us-west-2.amazonaws.com", uri.Host);
            Assert.AreEqual("/foo.txt", uri.AbsolutePath);
            Assert.IsTrue(uri.Query.Contains("X-Amz-Algorithm=AWS4-HMAC-SHA256"));
        }
        
        [TestMethod]
        [TestCategory("S3")]
        [DataTestMethod]
        [DataRow(
            "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint", "obj", "us-west-2", true,
            "*,us-west-2",
            "66d74ad19ade14c8714c2dc973af61d787bca4e94409ef4aeac83f19bc74a26c")]
        [DataRow(
            "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint", "obj", "us-west-2", true, 
            "*,us-east-1",
            "08a4b92976443ec82f292103242a00bca42bdc3c009b7a39e9bcee09c4f01bd8")]
        public void PreSignedUrlTestAdvanced(string bucketFieldInput, string keyFieldInput, string clientRegion, bool useArnRegion, string allowedRegions, string signature)
        {
            // All tests assume a datetime of 08-27-2021
            var signedDate = new DateTime(2021, 08, 27, 0, 0, 0, DateTimeKind.Utc);
           
            var config = new AmazonS3Config
            {
                UseArnRegion = useArnRegion,
                RegionEndpoint = RegionEndpoint.GetBySystemName(clientRegion)
            };

            var client = new AmazonS3Client("ACCESS_KEY_ID", "SECRET_ACCESS_KEY", config);
            
            var url = string.Empty;
            DateFaker.Run(
                signedDate,
                () => {
                    url = client.GetPreSignedURL(new Amazon.S3.Model.GetPreSignedUrlRequest
                    {
                        BucketName = bucketFieldInput,
                        Key = keyFieldInput,
                        Verb = HttpVerb.GET,
                        Expires = signedDate.AddMinutes(15)
                    });
                });

            Assert.IsNotNull(url);

            // S3 on Outposts supports both SigV4 and SigV4A, and since this test project references the CRT directly it'll use SigV4A by default.
            // We'll check the region used in the pre-signed URL matches one of the expected values (the region for SigV4A may be "*", but if the CRT is
            // not available the ARN region should be used instead).
            bool isRegionValid = false;
            foreach (var expectedRegion in allowedRegions.Split(','))
            {
                var expectedEncodedValue = $"X-Amz-Credential={AWSSDKUtils.UrlEncode($"ACCESS_KEY_ID/20210827/{expectedRegion}/s3-outposts/aws4_request", false)}&";
                isRegionValid = isRegionValid || url.Contains(expectedEncodedValue);
            }

            Assert.IsTrue(isRegionValid);
            Assert.IsTrue(url.Contains($"&X-Amz-Signature={signature}"));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CopyObjectTest()
        {
            var outpostsArn = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            var expectedEndpoint = new Uri("https://myaccesspoint-123456789012.op-01234567890123456.s3-outposts.us-east-1.amazonaws.com");
            var expectedCopySource = "arn%3Aaws%3As3-outposts%3Aus-east-1%3A123456789012%3Aoutpost%3Aop-01234567890123456%3Aaccesspoint%3Amyaccesspoint%2Fobject%2Ffoo.txt";
            var request = new CopyObjectRequest
            {
                SourceBucket = outpostsArn,
                SourceKey = "foo.txt",
                DestinationBucket = outpostsArn,
                DestinationKey = "foo2.txt"
            };

            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.GetBySystemName("us-east-1"),
                UseArnRegion = true
            };
            var internalRequest = S3ArnTestUtils.RunMockRequest(request, CopyObjectRequestMarshaller.Instance, config);
            Assert.AreEqual(expectedEndpoint, internalRequest.Endpoint);
            Assert.AreEqual(expectedCopySource, internalRequest.Headers["x-amz-copy-source"]);
        }
    }
}
