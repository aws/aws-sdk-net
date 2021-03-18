using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Model.Internal.MarshallTransformations;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

using Amazon;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System.IO;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3ObjectLambdaTests
    {
        [DataTestMethod]
        [TestCategory("S3")]
        [DataRow("arn:aws:s3-object-lambda:us-east-1:123456789012:accesspoint/mybanner", "us-east-1", false, "mybanner-123456789012.s3-object-lambda.us-east-1.amazonaws.com")]
        [DataRow("arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint/mybanner", "us-west-2", false, "mybanner-123456789012.s3-object-lambda.us-west-2.amazonaws.com")]
        [DataRow("arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint:mybanner", "us-west-2", false, "mybanner-123456789012.s3-object-lambda.us-west-2.amazonaws.com")]
        [DataRow("arn:aws:s3-object-lambda:us-east-1:123456789012:accesspoint/mybanner", "us-west-2", true, "mybanner-123456789012.s3-object-lambda.us-east-1.amazonaws.com")]
        [DataRow("arn:aws-cn:s3-object-lambda:cn-north-1:123456789012:accesspoint/mybanner", "cn-north-1", true, "mybanner-123456789012.s3-object-lambda.cn-north-1.amazonaws.com.cn")]
        [DataRow("arn:aws-cn:s3-object-lambda:cn-north-1:123456789012:accesspoint/mybanner", "cn-north-1", false, "mybanner-123456789012.s3-object-lambda.cn-north-1.amazonaws.com.cn")]
        [DataRow("arn:aws-cn:s3-object-lambda:cn-northwest-1:123456789012:accesspoint/mybanner", "cn-north-1", true, "mybanner-123456789012.s3-object-lambda.cn-northwest-1.amazonaws.com.cn")]
        [DataRow("arn:aws-us-gov:s3-object-lambda:us-gov-east-1:123456789012:accesspoint/mybanner", "us-gov-east-1", true, "mybanner-123456789012.s3-object-lambda.us-gov-east-1.amazonaws.com")]
        public void ValidConfigurationsTest(string arnString, string clientRegion, bool useArnRegion, string expectedEndpointHost)
        {
            var request = new GetObjectRequest
            {
                BucketName = arnString,
                Key = "foo.txt"
            };

            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.GetBySystemName(clientRegion),
                UseArnRegion = useArnRegion
            };
            var internalRequest = S3ArnTestUtils.RunMockRequest(request, GetObjectRequestMarshaller.Instance, config);
            Assert.AreEqual(expectedEndpointHost, internalRequest.Endpoint.Host);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void InvalidConfigurationCrossRegionTest()
        {
            var errorMessage = "Invalid configuration, cross region S3ObjectLambda access point ARN";
            try
            {
                var arnString = "arn:aws:s3-object-lambda:us-east-1:123456789012:accesspoint/mybanner";
                var request = new GetObjectRequest
                {
                    BucketName = arnString,
                    Key = "foo.txt"
                };

                var config = new AmazonS3Config
                {
                    RegionEndpoint = RegionEndpoint.USWest2,
                    UseArnRegion = false

                };
                S3ArnTestUtils.RunMockRequest(request, GetObjectRequestMarshaller.Instance, config);
                Assert.Fail("AmazonClientException expected");
            }
            catch (AmazonClientException e)
            {
                Assert.AreEqual(errorMessage, e.Message);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void InvalidConfigurationCrossPartitionTest()
        {
            var errorMessage = "Invalid configuration, cross partition S3ObjectLambda access point ARN";
            try
            {
                var arnString = "arn:aws-cn:s3-object-lambda:cn-north-1:123456789012:accesspoint/mybanner";
                var request = new GetObjectRequest
                {
                    BucketName = arnString,
                    Key = "foo.txt"
                };

                var config = new AmazonS3Config
                {
                    RegionEndpoint = RegionEndpoint.USWest2,
                    UseArnRegion = true
                };

                S3ArnTestUtils.RunMockRequest(request, GetObjectRequestMarshaller.Instance, config);
                Assert.Fail("AmazonClientException expected");
            }
            catch (AmazonClientException e)
            {
                Assert.AreEqual(errorMessage, e.Message);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void InvalidConfigurationDualstackTest()
        {
            var errorMessage = "Invalid configuration S3ObjectLambda access points do not support dualstack";
            try
            {
                var arnString = "arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint/mybanner";
                var request = new GetObjectRequest
                {
                    BucketName = arnString,
                    Key = "foo.txt"
                };

                var config = new AmazonS3Config
                {
                    RegionEndpoint = RegionEndpoint.USWest2,
                    UseArnRegion = true,
                    UseDualstackEndpoint = true

                };
                S3ArnTestUtils.RunMockRequest(request, GetObjectRequestMarshaller.Instance, config);
                Assert.Fail("AmazonClientException expected");
            }
            catch (AmazonClientException e)
            {
                Assert.AreEqual(errorMessage, e.Message);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void InvalidConfigurationAccelerateTest()
        {
            var errorMessage = "Invalid configuration S3ObjectLambda access points do not support accelerate";
            try
            {
                var arnString = "arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint/mybanner";
                var request = new GetObjectRequest
                {
                    BucketName = arnString,
                    Key = "foo.txt"
                };

                var config = new AmazonS3Config
                {
                    RegionEndpoint = RegionEndpoint.USWest2,
                    UseAccelerateEndpoint = true
                };
                S3ArnTestUtils.RunMockRequest(request, GetObjectRequestMarshaller.Instance, config);
                Assert.Fail("AmazonClientException expected");
            }
            catch (AmazonClientException e)
            {
                Assert.AreEqual(errorMessage, e.Message);
            }
        }

        [DataTestMethod]
        [TestCategory("S3")]
        [DataRow("arn:aws:sqs:us-west-2:123456789012:someresource", "Invalid ARN specified for bucket name. Only access point ARNs are allowed for the value of bucket name.")]
        [DataRow("arn:aws:s3-object-lambda:us-west-2:123456789012:bucket_name:mybucket", "Invalid ARN specified for bucket name. Only access point ARNs are allowed for the value of bucket name.")]
        [DataRow("arn:aws:s3-object-lambda::123456789012:accesspoint/mybanner", "AWS region is missing in S3ObjectLambda access point ARN")]
        [DataRow("arn:aws:s3-object-lambda:us-west-2::accesspoint/mybanner", "Account ID is missing in S3ObjectLambda access point ARN")]
        [DataRow("arn:aws:s3-object-lambda:us-west-2:123.45678.9012:accesspoint:mybucket", "AccountId is invalid. The AccountId length should be 12 and only contain numeric characters with no spaces or periods.")]
        [DataRow("arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint:*", "Invalid Arn. S3ObjectLambda arns can only contain alphanumeric characters, :, / and -")]
        [DataRow("arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint:my.bucket", "Invalid Arn. S3ObjectLambda arns can only contain alphanumeric characters, :, / and -")]
        [DataRow("arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint:mybucket:object:foo", "Invalid ARN, Access Point ARN contains sub resources")]
        public void InvalidArnAmazonClientExceptionTest(string invalidArn, string errorMessage)
        {
            try
            {
                var arnString = invalidArn;
                var request = new GetObjectRequest
                {
                    BucketName = arnString,
                    Key = "foo.txt"
                };

                var config = new AmazonS3Config
                {
                    RegionEndpoint = RegionEndpoint.USWest2,
                    UseArnRegion = true,
                };
                S3ArnTestUtils.RunMockRequest(request, GetObjectRequestMarshaller.Instance, config);
                Assert.Fail("AmazonClientException expected");
            }
            catch (AmazonClientException e)
            {
                Assert.AreEqual(errorMessage, e.Message);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void InvalidArnNoAccessPointName()
        {
            string accessPoint = "ShouldBecomeNull";
            var arnString = "arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint";
            var arn = Arn.Parse(arnString);
            Assert.IsFalse(arn.TryParseAccessPoint(out accessPoint));
            Assert.IsNull(accessPoint);
        }

        [DataTestMethod]
        [TestCategory("S3")]
        [DataRow("arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint/mybanner", "https://my-endpoint.com", true, "mybanner-123456789012.my-endpoint.com")]
        [DataRow("arn:aws:s3-object-lambda:us-east-1:123456789012:accesspoint/mybanner", "https://my-endpoint.com", false, "mybanner-123456789012.my-endpoint.com")]
        public void CustomEndpointUrlTest(string arnString, string serviceUrl, bool useArnRegion, string expectedEndpointHost)
        {
            var request = new GetObjectRequest
            {
                BucketName = arnString,
                Key = "foo.txt"
            };

            var config = new AmazonS3Config
            {
                ServiceURL = serviceUrl,
                UseArnRegion = useArnRegion
            };
            var internalRequest = S3ArnTestUtils.RunMockRequest(request, GetObjectRequestMarshaller.Instance, config);
            Assert.AreEqual(expectedEndpointHost, internalRequest.Endpoint.Host);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CopyObjectValidAccessPoint()
        {
            var accessPointDestinationArn = "arn:aws:s3-object-lambda:us-east-1:000011112222:accesspoint/destinationpoint";
            var accessPointSourceArn = "arn:aws:s3-object-lambda:us-east-1:000011112222:accesspoint/sourcepoint";

            var request = new CopyObjectRequest
            {
                SourceBucket = accessPointSourceArn,
                SourceKey = "source.txt",
                DestinationBucket = accessPointDestinationArn,
                DestinationKey = "dest.txt"
            };

            var internalRequest = S3ArnTestUtils.RunMockRequest(request, CopyObjectRequestMarshaller.Instance);
            Assert.AreEqual("destinationpoint-000011112222.s3-object-lambda.us-east-1.amazonaws.com", internalRequest.Endpoint.Host);
            Assert.AreEqual("/dest.txt", internalRequest.ResourcePath);
            Assert.AreEqual("arn%3Aaws%3As3-object-lambda%3Aus-east-1%3A000011112222%3Aaccesspoint%2Fsourcepoint%2Fobject%2Fsource.txt", internalRequest.Headers["x-amz-copy-source"]);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void S3ObjectLambdaSignerTest()
        {
            var signer = new S3Signer();

            var arnString = "arn:aws:s3-object-lambda:us-east-1:123456789012:accesspoint/mybanner";
            var request = new GetObjectRequest()
            {
                BucketName = arnString,
                Key = "foo.txt"
            };
            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1
            };
            var iRequest = S3ArnTestUtils.RunMockRequest(request, GetObjectRequestMarshaller.Instance, config);
            signer.Sign(iRequest, config, new RequestMetrics(), "ACCESS", "SECRET");

            Assert.IsTrue(iRequest.Headers.ContainsKey(HeaderKeys.AuthorizationHeader));
            Assert.IsTrue((iRequest.Headers["Authorization"]).Contains("s3-object-lambda"));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PreSignedUrlTest()
        {
            var arnString = "arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint:my-banner-ap-name";

            var request = new GetPreSignedUrlRequest
            {
                BucketName = arnString,
                Key = "test2.txt",
                Expires = DateTime.Now.AddDays(1),
                Verb = HttpVerb.GET
            };

            var s3Client = new AmazonS3Client("access", "secret", RegionEndpoint.USEast1);

            var uri = new Uri(s3Client.GetPreSignedURL(request));

            Assert.AreEqual("my-banner-ap-name-123456789012.s3-object-lambda.us-west-2.amazonaws.com", uri.Host);
            Assert.AreEqual("/test2.txt", uri.AbsolutePath);
            Assert.IsTrue(uri.Query.Contains("X-Amz-Algorithm=AWS4-HMAC-SHA256"));
        }

        [DataTestMethod]
        [TestCategory("S3")]
        [DataRow("us-east-1", "", "route.s3-object-lambda.us-east-1.amazonaws.com")]
        [DataRow("us-east-1-regional", "", "route.s3-object-lambda.us-east-1.amazonaws.com")]
        [DataRow("us-west-2", "", "route.s3-object-lambda.us-west-2.amazonaws.com")]
        [DataRow("us-west-2", "https://my-endpoint.com", "route.my-endpoint.com")]
        public void WriteGetObjectResponseTests(string clientRegion, string endpointUrl, string expectedEndpointHost)
        {
            var request = new WriteGetObjectResponseRequest
            {
                RequestRoute = "route",
                RequestToken = "token"
            };

            var config = new AmazonS3Config();
            config.RegionEndpoint = RegionEndpoint.GetBySystemName(clientRegion);
            if (!string.IsNullOrEmpty(endpointUrl))
                config.ServiceURL = endpointUrl;

            var internalRequest = S3ArnTestUtils.RunMockRequest(request, WriteGetObjectResponseRequestMarshaller.Instance, config);
            Assert.AreEqual(expectedEndpointHost, internalRequest.Endpoint.Host);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void WriteGetObjectResponseSignerTest()
        {
            var signer = new S3Signer();
            var request = new WriteGetObjectResponseRequest
            {
                RequestRoute = "route",
                RequestToken = "token"
            };

            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.EUWest1
            };

            var iRequest = S3ArnTestUtils.RunMockRequest(request, WriteGetObjectResponseRequestMarshaller.Instance, config);
            signer.Sign(iRequest, config, new RequestMetrics(), "ACCESS", "SECRET");

            Assert.IsTrue(iRequest.Headers.ContainsKey(HeaderKeys.AuthorizationHeader));
            Assert.IsTrue((iRequest.Headers["Authorization"]).Contains("s3-object-lambda"));
        }

        [DataTestMethod]
        [TestCategory("S3")]
        [DataRow(true, (long)100, true, "100")]
        [DataRow(false, (long)100, false, "100")]
        [DataRow(true, null, true, "90")]
        public void WriteGetObjectResponseWithNoChunkedEncodingTest(bool canseek, long? contentlength, bool expectedCanSeek, string expectedContentLength)
        {
            var request = new WriteGetObjectResponseRequest
            {
                RequestRoute = "route",
                RequestToken = "token",
                Body = new MyTestStream(90, canseek),
                ContentLength = contentlength
            };

            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USWest2
            };

            var internalRequest = S3ArnTestUtils.RunMockRequest(request, WriteGetObjectResponseRequestMarshaller.Instance, config);
            Assert.AreEqual(expectedCanSeek, internalRequest.ContentStream.CanSeek);
            Assert.IsTrue(internalRequest.Headers.ContainsKey("Content-Length"));
            Assert.AreEqual(expectedContentLength, internalRequest.Headers["Content-Length"]);
            Assert.IsTrue(!internalRequest.Headers.ContainsKey("transfer-encoding"));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void WriteGetObjectResponseWithWithChunkedEncodingTest()
        {
            var request = new WriteGetObjectResponseRequest
            {
                RequestRoute = "route",
                RequestToken = "token",
                Body = new MyTestStream(100, false),
            };

            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USWest2
            };

            var internalRequest = S3ArnTestUtils.RunMockRequest(request, WriteGetObjectResponseRequestMarshaller.Instance, config);
            Assert.AreEqual(false, internalRequest.ContentStream.CanSeek);
            Assert.IsTrue(!internalRequest.Headers.ContainsKey("Content-Length"));
            Assert.IsTrue(internalRequest.Headers.ContainsKey("transfer-encoding"));
            Assert.AreEqual("chunked", internalRequest.Headers["transfer-encoding"]);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void BlockTransferUtilityUploadTest()
        {
            var transferUtility = new TransferUtility(RegionEndpoint.USWest2);
            try
            {
                transferUtility.Upload(new TransferUtilityUploadRequest
                {
                    BucketName = "arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint/mybanner",
                    FilePath = "foo/bar/test.txt"
                });
            }
            catch(AmazonS3Exception e)
            {
                var expectedMessage = "Upload does not support S3 Object Lambda resources";
                Assert.AreEqual(expectedMessage, e.Message);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void BlockTransferUtilityDownloadTest()
        {
            var transferUtility = new TransferUtility(RegionEndpoint.USWest2);
            try
            {
                transferUtility.Download(new TransferUtilityDownloadRequest
                {
                    BucketName = "arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint/mybanner",
                    Key = "test.txt",
                    FilePath = @"c:\foo\bar\test.txt"
                });
            }
            catch (AmazonS3Exception e)
            {
                var expectedMessage = "Download does not support S3 Object Lambda resources";
                Assert.AreEqual(expectedMessage, e.Message);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void BlockTransferUtilityUploadDirectoryTest()
        {
            var transferUtility = new TransferUtility(RegionEndpoint.USWest2);
            try
            {
                transferUtility.UploadDirectory(new TransferUtilityUploadDirectoryRequest
                {
                    BucketName = "arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint/mybanner",
                    Directory = @"c:\foo\bar"
                });
            }
            catch (AmazonS3Exception e)
            {
                var expectedMessage = "UploadDirectory does not support S3 Object Lambda resources";
                Assert.AreEqual(expectedMessage, e.Message);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void BlockTransferUtilityDownloadDirectoryTest()
        {
            var transferUtility = new TransferUtility(RegionEndpoint.USWest2);
            try
            {
                transferUtility.DownloadDirectory(new TransferUtilityDownloadDirectoryRequest
                {
                    BucketName = "arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint/mybanner",
                    S3Directory = "myDirectory"
                });
            }
            catch (AmazonS3Exception e)
            {
                var expectedMessage = "DownloadDirectory does not support S3 Object Lambda resources";
                Assert.AreEqual(expectedMessage, e.Message);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void BlockTransferUtilityOpenStreamTest()
        {
            var transferUtility = new TransferUtility(RegionEndpoint.USWest2);
            try
            {
                transferUtility.OpenStream(new TransferUtilityOpenStreamRequest
                {
                    BucketName = "arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint/mybanner",
                    Key = "test.txt"
                });
            }
            catch (AmazonS3Exception e)
            {
                var expectedMessage = "OpenStream does not support S3 Object Lambda resources";
                Assert.AreEqual(expectedMessage, e.Message);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void BlockTransferUtilityAbortMultipartUploadsTest()
        {
            var transferUtility = new TransferUtility(RegionEndpoint.USWest2);
            try
            {
                transferUtility.AbortMultipartUploads("arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint/mybanner", DateTime.Now);
            }
            catch (AmazonS3Exception e)
            {
                var expectedMessage = "AbortMultipartUploads does not support S3 Object Lambda resources";
                Assert.AreEqual(expectedMessage, e.Message);
            }
        }
    }

    public class MyTestStream : Stream
    {
        public override bool CanRead { get; }

        public override bool CanSeek { get; }

        public override bool CanWrite { get; }

        public override long Length {get;}

        public override long Position { get ; set ; }

        public override void Flush()
        {
            throw new NotImplementedException();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public MyTestStream(int length, bool canSeek)
        {
            Length = length;
            CanSeek = canSeek;
        }
    }
}