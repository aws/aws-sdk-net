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

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3AccessPointTests
    {
        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(AmazonClientException))]
        public void ThrowExceptionUsingServiceUrl()
        {
            var accessPointArn = "arn:aws:s3:eu-central-1:000011112222:accesspoint/testpoint";

            var request = new PutObjectRequest
            {
                BucketName = accessPointArn,
                Key = "foo.txt",
                ContentBody = "data"
            };

            var config = new AmazonS3Config
            {
                ServiceURL = "https://s3.amazonaws.com"
            };

            S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, config);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(AmazonClientException))]
        public void ThrowExceptionAccessPointAndServiceClientDifferentRegions()
        {
            var accessPointArn = "arn:aws:s3:eu-central-1:000011112222:accesspoint/testpoint";

            var request = new PutObjectRequest
            {
                BucketName = accessPointArn,
                Key = "foo.txt",
                ContentBody = "data"
            };

            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast2
            };

            S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, config);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void UseArnRegionDefaultToTrueForUSEast1()
        {
            var accessPointArn = "arn:aws:s3:eu-central-1:000011112222:accesspoint/testpoint";

            var request = new PutObjectRequest
            {
                BucketName = accessPointArn,
                Key = "foo.txt",
                ContentBody = "data"
            };

            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1
            };

            var internalRequest = S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, config);
            Assert.AreEqual(new Uri("https://testpoint-000011112222.s3-accesspoint.eu-central-1.amazonaws.com"), internalRequest.Endpoint);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(AmazonClientException))]
        public void ThrowExceptionWhenUsingDifferentPartitions()
        {
            var accessPointArn = "arn:aws-cn:s3:cn-north-1:000011112222:accesspoint/testpoint";

            var request = new PutObjectRequest
            {
                BucketName = accessPointArn,
                Key = "foo.txt",
                ContentBody = "data"
            };

            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast2,
                UseArnRegion = true
            };

            S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, config);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void AccessPointAndServiceClientDifferentRegionsUseArnRegionEnabled()
        {
            var accessPointArn = "arn:aws:s3:eu-central-1:000011112222:accesspoint/testpoint";

            var request = new PutObjectRequest
            {
                BucketName = accessPointArn,
                Key = "foo.txt",
                ContentBody = "data"
            };

            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                UseArnRegion = true
            };

            var internalRequest = S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, config);
            Assert.AreEqual(new Uri("https://testpoint-000011112222.s3-accesspoint.eu-central-1.amazonaws.com"), internalRequest.Endpoint);
            Assert.AreEqual("/foo.txt", internalRequest.ResourcePath);
            Assert.AreEqual("eu-central-1", internalRequest.AuthenticationRegion);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutObjectTest()
        {
            var accessPointArn = "arn:aws:s3:us-east-1:000011112222:accesspoint/testpoint";

            var request = new PutObjectRequest
            {
                BucketName = accessPointArn,
                Key = "foo.txt",
                ContentBody = "data"
            };

            var internalRequest = S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance);
            Assert.AreEqual(new Uri("https://testpoint-000011112222.s3-accesspoint.us-east-1.amazonaws.com"), internalRequest.Endpoint);
            Assert.AreEqual("/foo.txt", internalRequest.ResourcePath);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetObjectTest()
        {
            var accessPointArn = "arn:aws:s3:us-east-1:000011112222:accesspoint/testpoint";

            var request = new GetObjectRequest
            {
                BucketName = accessPointArn,
                Key = "foo.txt"
            };

            var internalRequest = S3ArnTestUtils.RunMockRequest(request, GetObjectRequestMarshaller.Instance);
            Assert.AreEqual(new Uri("https://testpoint-000011112222.s3-accesspoint.us-east-1.amazonaws.com"), internalRequest.Endpoint);
            Assert.AreEqual("/foo.txt", internalRequest.ResourcePath);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetObjectMetadataTest()
        {
            var accessPointArn = "arn:aws:s3:us-east-1:000011112222:accesspoint/testpoint";

            var request = new GetObjectMetadataRequest
            {
                BucketName = accessPointArn,
                Key = "foo.txt"
            };

            var internalRequest = S3ArnTestUtils.RunMockRequest(request, GetObjectMetadataRequestMarshaller.Instance);
            Assert.AreEqual(new Uri("https://testpoint-000011112222.s3-accesspoint.us-east-1.amazonaws.com"), internalRequest.Endpoint);
            Assert.AreEqual("/foo.txt", internalRequest.ResourcePath);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void DeleteObjectTest()
        {
            var accessPointArn = "arn:aws:s3:us-east-1:000011112222:accesspoint/testpoint";

            var request = new DeleteObjectRequest
            {
                BucketName = accessPointArn,
                Key = "foo.txt"
            };

            var internalRequest = S3ArnTestUtils.RunMockRequest(request, DeleteObjectRequestMarshaller.Instance);
            Assert.AreEqual(new Uri("https://testpoint-000011112222.s3-accesspoint.us-east-1.amazonaws.com"), internalRequest.Endpoint);
            Assert.AreEqual("/foo.txt", internalRequest.ResourcePath);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void DeleteObjectsTest()
        {
            var accessPointArn = "arn:aws:s3:us-east-1:000011112222:accesspoint/testpoint";

            var request = new DeleteObjectsRequest
            {
                BucketName = accessPointArn,
                Objects = new List<KeyVersion>
                {
                    new KeyVersion{Key = "foo1.txt" },
                    new KeyVersion{Key = "foo2.txt" }
                }
            };

            var internalRequest = S3ArnTestUtils.RunMockRequest(request, DeleteObjectsRequestMarshaller.Instance);
            Assert.AreEqual(new Uri("https://testpoint-000011112222.s3-accesspoint.us-east-1.amazonaws.com"), internalRequest.Endpoint);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void InitiateMultipartUploadTest()
        {
            var accessPointArn = "arn:aws:s3:us-east-1:000011112222:accesspoint/testpoint";

            var request = new InitiateMultipartUploadRequest
            {
                BucketName = accessPointArn,
                Key = "foo.txt"
            };

            var internalRequest = S3ArnTestUtils.RunMockRequest(request, InitiateMultipartUploadRequestMarshaller.Instance);
            Assert.AreEqual(new Uri("https://testpoint-000011112222.s3-accesspoint.us-east-1.amazonaws.com"), internalRequest.Endpoint);
            Assert.AreEqual("/foo.txt", internalRequest.ResourcePath);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CompleteMultipartUploadTest()
        {
            var accessPointArn = "arn:aws:s3:us-east-1:000011112222:accesspoint/testpoint";

            var request = new CompleteMultipartUploadRequest
            {
                BucketName = accessPointArn,
                Key = "foo.txt"
            };

            var internalRequest = S3ArnTestUtils.RunMockRequest(request, CompleteMultipartUploadRequestMarshaller.Instance);
            Assert.AreEqual(new Uri("https://testpoint-000011112222.s3-accesspoint.us-east-1.amazonaws.com"), internalRequest.Endpoint);
            Assert.AreEqual("/foo.txt", internalRequest.ResourcePath);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void AbortMultipartUploadTest()
        {
            var accessPointArn = "arn:aws:s3:us-east-1:000011112222:accesspoint/testpoint";

            var request = new AbortMultipartUploadRequest
            {
                BucketName = accessPointArn,
                Key = "foo.txt"
            };

            var internalRequest = S3ArnTestUtils.RunMockRequest(request, AbortMultipartUploadRequestMarshaller.Instance);
            Assert.AreEqual(new Uri("https://testpoint-000011112222.s3-accesspoint.us-east-1.amazonaws.com"), internalRequest.Endpoint);
            Assert.AreEqual("/foo.txt", internalRequest.ResourcePath);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void UploadPartTest()
        {
            var accessPointArn = "arn:aws:s3:us-east-1:000011112222:accesspoint/testpoint";

            var request = new UploadPartRequest
            {
                BucketName = accessPointArn,
                Key = "foo.txt",
                PartNumber = 1
            };

            var internalRequest = S3ArnTestUtils.RunMockRequest(request, UploadPartRequestMarshaller.Instance);
            Assert.AreEqual(new Uri("https://testpoint-000011112222.s3-accesspoint.us-east-1.amazonaws.com"), internalRequest.Endpoint);
            Assert.AreEqual("/foo.txt", internalRequest.ResourcePath);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CopyObjectValidAccessPoint()
        {
            var accessPointDestinationArn = "arn:aws:s3:us-east-1:000011112222:accesspoint/destinationpoint";
            var accessPointSourceArn = "arn:aws:s3:us-east-1:000011112222:accesspoint/sourcepoint";

            var request = new CopyObjectRequest
            {
                SourceBucket = accessPointSourceArn,
                SourceKey = "source.txt",
                DestinationBucket = accessPointDestinationArn,
                DestinationKey = "dest.txt"
            };

            var internalRequest = S3ArnTestUtils.RunMockRequest(request, CopyObjectRequestMarshaller.Instance);
            Assert.AreEqual(new Uri("https://destinationpoint-000011112222.s3-accesspoint.us-east-1.amazonaws.com"), internalRequest.Endpoint);
            Assert.AreEqual("/dest.txt", internalRequest.ResourcePath);
            Assert.AreEqual("arn%3Aaws%3As3%3Aus-east-1%3A000011112222%3Aaccesspoint%2Fsourcepoint%2Fobject%2Fsource.txt", internalRequest.Headers["x-amz-copy-source"]);
        }


        [TestMethod]
        [TestCategory("S3")]
        public void SelectObjectContentTest()
        {
            var accessPointArn = "arn:aws:s3:us-east-1:000011112222:accesspoint/testpoint";

            var request = new SelectObjectContentRequest
            {
                Bucket = accessPointArn,
                Key = "foo.txt",
                Expression = "crazy expression",
                ExpressionType = ExpressionType.SQL,
                InputSerialization = new InputSerialization
                {
                    
                },
                OutputSerialization = new OutputSerialization
                {

                }
            };

            var internalRequest = S3ArnTestUtils.RunMockRequest(request, SelectObjectContentRequestMarshaller.Instance);
            Assert.AreEqual(new Uri("https://testpoint-000011112222.s3-accesspoint.us-east-1.amazonaws.com"), internalRequest.Endpoint);
            Assert.AreEqual("/foo.txt", internalRequest.ResourcePath);
        }


        [TestMethod]
        [TestCategory("S3")]
        public void PreSignedUrlTest()
        {
            var accessPointArn = "arn:aws:s3:us-east-1:000011112222:accesspoint/testpoint";

            var request = new GetPreSignedUrlRequest
            {
                BucketName = accessPointArn,
                Key = "foo.txt",
                Expires = DateTime.Now.AddDays(1),
                Verb = HttpVerb.GET
            };

            var s3Client = new AmazonS3Client("access", "secret", RegionEndpoint.USEast1);

            var uri = new Uri(s3Client.GetPreSignedURL(request));

            Assert.AreEqual("testpoint-000011112222.s3-accesspoint.us-east-1.amazonaws.com", uri.Host);
            Assert.AreEqual("/foo.txt", uri.AbsolutePath);
            Assert.IsTrue(uri.Query.Contains("X-Amz-Algorithm=AWS4-HMAC-SHA256"));
        }

        [DataTestMethod]
        [TestCategory("S3")]
        [DataRow("arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint", "us-west-2", S3ConfigFlags.None, "myendpoint-123456789012.s3-accesspoint.us-west-2.amazonaws.com", "")]
        [DataRow("arn:aws:s3:us-east-1:123456789012:accesspoint:myendpoint", "us-west-2", S3ConfigFlags.ArnRegion, "myendpoint-123456789012.s3-accesspoint.us-east-1.amazonaws.com", "")]
        [DataRow("arn:aws:s3:us-east-1:123456789012:accesspoint:myendpoint", "us-west-2", S3ConfigFlags.None, "", "The S3 service client is configured for region us-west-2 but the access point is in us-east-1. By default the SDK doesn't allow cross region calls. If you want to enable cross region calls set the environment AWS_S3_USE_ARN_REGION or the AmazonS3Config.UseArnRegion property to value \"true\".")]
        [DataRow("arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint", "us-west-2", S3ConfigFlags.ArnRegion | S3ConfigFlags.Dualstack, "myendpoint-123456789012.s3-accesspoint.dualstack.us-west-2.amazonaws.com", "")]
        [DataRow("arn:aws-cn:s3:cn-north-1:123456789012:accesspoint:myendpoint", "us-west-2", S3ConfigFlags.ArnRegion, "", "The access point used in the request is in a different AWS partition then the region configured for the AmazonS3Client.")]
        [DataRow("arn:aws-cn:s3:cn-north-1:123456789012:accesspoint:myendpoint", "cn-north-1", S3ConfigFlags.ArnRegion, "myendpoint-123456789012.s3-accesspoint.cn-north-1.amazonaws.com.cn", "")]
        [DataRow("arn:aws-cn:s3:cn-north-1:123456789012:accesspoint:myendpoint", "cn-north-1", S3ConfigFlags.None, "myendpoint-123456789012.s3-accesspoint.cn-north-1.amazonaws.com.cn", "")]
        [DataRow("arn:aws-cn:s3:cn-northwest-1:123456789012:accesspoint:myendpoint", "cn-north-1", S3ConfigFlags.ArnRegion, "myendpoint-123456789012.s3-accesspoint.cn-northwest-1.amazonaws.com.cn", "")]
        [DataRow("arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint", "us-west-2", S3ConfigFlags.Accelerate, "", "The request is using an access point ARN for the bucket name and the S3 service client is configured to use accelerate endpoints which is not supported. To use this access point create a new S3 service client with the UseAccelerateEndpoint property set to false.")]
        [DataRow("arn:aws:sqs:us-west-2:123456789012:someresource", "us-west-2", S3ConfigFlags.None, "", "Invalid ARN specified for bucket name. Only access point ARNs are allowed for the value of bucket name.")] 
        [DataRow("arn:aws:s3:us-west-2:123456789012:bucket_name:mybucket", "us-west-2", S3ConfigFlags.None, "", "Invalid ARN specified for bucket name. Only access point ARNs are allowed for the value of bucket name.")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:myendpoint", "us-west-2", S3ConfigFlags.None, "", "AWS region is missing in access point ARN")] 
        [DataRow("arn:aws:s3:us-west-2::accesspoint:myendpoint", "us-west-2", S3ConfigFlags.None, "", "Account ID is missing in access point ARN")] 
        [DataRow("arn:aws:s3:us-west-2:123.45678.9012:accesspoint:mybucket", "us-west-2", S3ConfigFlags.None, "", "AccountId is invalid. The AccountId length should be 12 and only contain numeric characters with no spaces or periods.")]
        [DataRow("arn:aws-us-gov:s3:us-gov-east-1:123456789012:accesspoint:myendpoint","fips-us-gov-east-1", S3ConfigFlags.None, "myendpoint-123456789012.s3-accesspoint-fips.us-gov-east-1.amazonaws.com", "")]
        [DataRow("arn:aws-us-gov:s3:us-gov-east-1:123456789012:accesspoint:myendpoint","fips-us-gov-east-1", S3ConfigFlags.ArnRegion, "myendpoint-123456789012.s3-accesspoint-fips.us-gov-east-1.amazonaws.com", "")]
        [DataRow("arn:aws-us-gov:s3:us-gov-west-1:123456789012:accesspoint:myendpoint","fips-us-gov-east-1", S3ConfigFlags.None, "", "The S3 service client is configured for region fips-us-gov-east-1 but the access point is in us-gov-west-1. By default the SDK doesn't allow cross region calls. If you want to enable cross region calls set the environment AWS_S3_USE_ARN_REGION or the AmazonS3Config.UseArnRegion property to value \"true\".")]
        [DataRow("arn:aws-us-gov:s3:us-gov-west-1:123456789012:accesspoint:myendpoint","fips-us-gov-east-1", S3ConfigFlags.ArnRegion, "", "Invalid configuration, FIPS region does not match ARN region")]
        [DataRow("arn:aws-us-gov:s3:us-gov-east-1:123456789012:accesspoint:myendpoint","fips-us-gov-east-1",S3ConfigFlags.ArnRegion | S3ConfigFlags.Dualstack, "myendpoint-123456789012.s3-accesspoint-fips.dualstack.us-gov-east-1.amazonaws.com", "")]
        [DataRow("arn:aws:s3:us-east-1:123456789012:accesspoint:myendpoint","s3-external-1", S3ConfigFlags.ArnRegion, "myendpoint-123456789012.s3-accesspoint.us-east-1.amazonaws.com", "")]
        [DataRow("arn:aws:s3:us-east-1:123456789012:accesspoint:myendpoint","s3-external-1", S3ConfigFlags.None, "", "The S3 service client is configured for region s3-external-1 but the access point is in us-east-1. By default the SDK doesn't allow cross region calls. If you want to enable cross region calls set the environment AWS_S3_USE_ARN_REGION or the AmazonS3Config.UseArnRegion property to value \"true\".")]
        [DataRow("arn:aws:s3:us-east-1:123456789012:accesspoint:myendpoint","aws-global", S3ConfigFlags.ArnRegion, "myendpoint-123456789012.s3-accesspoint.us-east-1.amazonaws.com", "")]
        [DataRow("arn:aws:s3:us-east-1:123456789012:accesspoint:myendpoint","aws-global", S3ConfigFlags.None, "", "The S3 service client is configured for region aws-global but the access point is in us-east-1. By default the SDK doesn't allow cross region calls. If you want to enable cross region calls set the environment AWS_S3_USE_ARN_REGION or the AmazonS3Config.UseArnRegion property to value \"true\".")]
        public void TestAccessPointArnVariations(string accessPointArn, string region, S3ConfigFlags flags, string host, string errorMessage)
        {
            var request = new PutObjectRequest
            {
                BucketName = accessPointArn,
                Key = "foo.txt",
                ContentBody = "data"
            };

            var config = S3ArnTestUtils.BuildFromRegionSystemName(region, flags);

            Exception exception = null;
            IRequest result = null;

            try
            {
                result = S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, config);
            }
            catch (Exception e)
            {
                exception = e;
            }

            if (!string.IsNullOrEmpty(host))
            {
                Assert.IsNull(exception, "Exception was thrown: " + exception?.Message);

                Assert.AreEqual(new Uri($"https://{host}"), result.Endpoint);
                Assert.AreEqual("/foo.txt", result.ResourcePath);
            }
            else if (!string.IsNullOrEmpty(errorMessage))
            {
                Assert.IsNotNull(exception, "Expected exception, but got result " + result?.Endpoint);
                Assert.IsInstanceOfType(exception, typeof(AmazonClientException));
                Assert.AreEqual(errorMessage, exception.Message);
            }
            else
            {
                Assert.Fail($"Bad Test Data, you must provide either {nameof(host)} or {nameof(errorMessage)}");
            }
        }
    }
}