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
using static AWSSDK.UnitTests.AccessPointTests;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class OutpostsTests
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
                Assert.AreEqual("Invalid configuration, cross region outpost access point ARN", e.Message);
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
                Assert.AreEqual("Invalid configuration, cross partition outpost access point ARN", e.Message);
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
        public void FipsExceptionUseArnRegionFalse()
        {
            try
            {
                var outpostsArn = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
                var request = new PutObjectRequest
                {
                    BucketName = outpostsArn,
                    Key = "foo.txt",
                    ContentBody = "data"
                };

                var config = new AmazonS3Config
                {
                    RegionEndpoint = RegionEndpoint.GetBySystemName("fips-us-gov-east-1"),
                    UseArnRegion = false
                };
                S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, config);
                Assert.Fail("AmazonClientException expected");
            }
            catch (AmazonClientException e)
            {
                Assert.AreEqual("Invalid configuration outpost access points do not support Fips- regions", e.Message);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void FipsExceptionUseArnRegionTrue()
        {
            try
            {
                var outpostsArn = "arn:aws-us-gov:s3-outposts:fips-us-gov-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
                var request = new PutObjectRequest
                {
                    BucketName = outpostsArn,
                    Key = "foo.txt",
                    ContentBody = "data"
                };

                var config = new AmazonS3Config
                {
                    RegionEndpoint = RegionEndpoint.GetBySystemName("fips-us-gov-east-1"),
                    UseArnRegion = true
                };
                S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, config);
                Assert.Fail("AmazonClientException expected");
            }
            catch (AmazonClientException e)
            {
                Assert.AreEqual("Invalid configuration outpost access points do not support Fips- regions", e.Message);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void UseArnRegionTrueUsGovEast1WithFipsSystem()
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
                RegionEndpoint = RegionEndpoint.GetBySystemName("fips-us-gov-east-1"),
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
                Assert.AreEqual("Invalid configuration outpost access points do not support dualstack", e.Message);
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
                Assert.AreEqual("Invalid configuration outpost access points do not support accelerate", e.Message);
            }
        }

        [DataTestMethod]
        [TestCategory("S3")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:myaccesspoint")]
        public void InvalidArn(string invalidArn)
        {
            try
            {
                var outpostsArn = invalidArn;
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
                Assert.AreEqual($"Invalid ARN: {invalidArn}/foo.txt, outpost resource format is incorrect", e.Message);
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
                Assert.AreEqual("Invalid outpost ID: op-0123456.890123456. ID must contain only alphanumeric characters and dashes", e.Message);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PreSignedUrlTest()
        {
            var outpostsArn = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";

            var request = new GetPreSignedUrlRequest
            {
                BucketName = outpostsArn,
                Key = "foo.txt",
                Expires = DateTime.Now.AddDays(1),
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
