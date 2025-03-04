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
                BucketName = accessPointArn,
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


        [DataTestMethod]
        [DataRow("arn:aws:s3:us-east-1:000011112222:accesspoint/testpoint", S3ConfigFlags.None, "testpoint-000011112222.s3-accesspoint.us-east-1.amazonaws.com", "X-Amz-Algorithm=AWS4-HMAC-SHA256", "")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap", S3ConfigFlags.None, "mfzwi23gnjvgw.mrap.accesspoint.s3-global.amazonaws.com", "X-Amz-Region-Set=%2A", "")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap", S3ConfigFlags.DisableMRAP, "", "", "Invalid configuration: Multi-Region Access Point ARNs are disabled.")]
        [TestCategory("S3")]
        public void PreSignedUrlTest(string accessPointArn, S3ConfigFlags flags, string expectedHost, string expectedQueryStringPiece, string expectedErrorMessage)
        {
            var request = new GetPreSignedUrlRequest
            {
                BucketName = accessPointArn,
                Key = "foo.txt",
                Expires = DateTime.UtcNow.AddDays(1),
                Verb = HttpVerb.GET
            };

            var config = S3ArnTestUtils.BuildFromRegionSystemName("us-east-1", flags);
            var s3Client = new AmazonS3Client("access", "secret", config);

            Exception exception = null;
            Uri uri = null;

            try
            {
                uri = new Uri(s3Client.GetPreSignedURL(request));
            }
            catch (AmazonClientException e)
            {
                exception = e;
            }

            if (!string.IsNullOrEmpty(expectedHost))
            {
                Assert.IsNull(exception, "Unexpected exception was thrown: " + exception?.Message);

                Assert.IsNotNull(uri);
                Assert.AreEqual(expectedHost, uri.Host);
                Assert.AreEqual("/foo.txt", uri.AbsolutePath);
                Assert.IsTrue(uri.Query.Contains(expectedQueryStringPiece), $"Expected to find {expectedQueryStringPiece} in {uri.Query}");
            }
            else if (!string.IsNullOrEmpty(expectedErrorMessage))
            {
                Assert.IsNotNull(exception);
                Assert.IsInstanceOfType(exception, typeof(AmazonClientException));
                Assert.AreEqual(expectedErrorMessage, exception.Message);
            }
            else
            {
                Assert.Fail($"Bad test setup, {nameof(expectedHost)} or {nameof(expectedErrorMessage)} must be provided");
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        [DataRow("arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint", "us-west-2", S3ConfigFlags.None, "myendpoint-123456789012.s3-accesspoint.us-west-2.amazonaws.com", "")]
        [DataRow("arn:aws:s3:us-east-1:123456789012:accesspoint:myendpoint", "us-west-2", S3ConfigFlags.ArnRegion, "myendpoint-123456789012.s3-accesspoint.us-east-1.amazonaws.com", "")]
        [DataRow("arn:aws:s3:us-east-1:123456789012:accesspoint:myendpoint", "us-west-2", S3ConfigFlags.None, "", "Invalid configuration: region from ARN `us-east-1` does not match client region `us-west-2` and UseArnRegion is `false`")]
        [DataRow("arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint", "us-west-2", S3ConfigFlags.ArnRegion | S3ConfigFlags.Dualstack, "myendpoint-123456789012.s3-accesspoint.dualstack.us-west-2.amazonaws.com", "")]
        [DataRow("arn:aws-cn:s3:cn-north-1:123456789012:accesspoint:myendpoint", "us-west-2", S3ConfigFlags.ArnRegion, "", "Client was configured for partition `aws` but ARN (`arn:aws-cn:s3:cn-north-1:123456789012:accesspoint:myendpoint`) has `aws-cn`")]
        [DataRow("arn:aws-cn:s3:cn-north-1:123456789012:accesspoint:myendpoint", "cn-north-1", S3ConfigFlags.ArnRegion, "myendpoint-123456789012.s3-accesspoint.cn-north-1.amazonaws.com.cn", "")]
        [DataRow("arn:aws-cn:s3:cn-north-1:123456789012:accesspoint:myendpoint", "cn-north-1", S3ConfigFlags.None, "myendpoint-123456789012.s3-accesspoint.cn-north-1.amazonaws.com.cn", "")]
        [DataRow("arn:aws-cn:s3:cn-northwest-1:123456789012:accesspoint:myendpoint", "cn-north-1", S3ConfigFlags.ArnRegion, "myendpoint-123456789012.s3-accesspoint.cn-northwest-1.amazonaws.com.cn", "")]
        [DataRow("arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint", "us-west-2", S3ConfigFlags.Accelerate, "", "Access Points do not support S3 Accelerate")]
        [DataRow("arn:aws:sqs:us-west-2:123456789012:someresource", "us-west-2", S3ConfigFlags.None, "", "Invalid ARN: Unrecognized format: arn:aws:sqs:us-west-2:123456789012:someresource (type: someresource)")]
        [DataRow("arn:aws:s3:us-west-2:123456789012:bucket_name:mybucket", "us-west-2", S3ConfigFlags.None, "", "Invalid ARN: Unrecognized format: arn:aws:s3:us-west-2:123456789012:bucket_name:mybucket (type: bucket_name)")]
        [DataRow("arn:aws:s3:us-west-2:123.45678.9012:accesspoint:mybucket", "us-west-2", S3ConfigFlags.None, "", "Invalid ARN: The account id may only contain a-z, A-Z, 0-9 and `-`. Found: `123.45678.9012`")]
        [DataRow("arn:aws-us-gov:s3:us-gov-east-1:123456789012:accesspoint:myendpoint", "fips-us-gov-east-1", S3ConfigFlags.None, "myendpoint-123456789012.s3-accesspoint-fips.us-gov-east-1.amazonaws.com", "")]
        [DataRow("arn:aws-us-gov:s3:us-gov-east-1:123456789012:accesspoint:myendpoint", "fips-us-gov-east-1", S3ConfigFlags.ArnRegion, "myendpoint-123456789012.s3-accesspoint-fips.us-gov-east-1.amazonaws.com", "")]
        [DataRow("arn:aws-us-gov:s3:us-gov-west-1:123456789012:accesspoint:myendpoint", "fips-us-gov-east-1", S3ConfigFlags.None, "", "Invalid configuration: region from ARN `us-gov-west-1` does not match client region `us-gov-east-1` and UseArnRegion is `false`")]
        [DataRow("arn:aws-us-gov:s3:us-gov-west-1:123456789012:accesspoint:myendpoint", "fips-us-gov-east-1", S3ConfigFlags.ArnRegion, "myendpoint-123456789012.s3-accesspoint-fips.us-gov-west-1.amazonaws.com", "")]
        [DataRow("arn:aws-us-gov:s3:us-gov-east-1:123456789012:accesspoint:myendpoint", "us-gov-east-1", S3ConfigFlags.Fips, "myendpoint-123456789012.s3-accesspoint-fips.us-gov-east-1.amazonaws.com", "")]
        [DataRow("arn:aws-us-gov:s3:us-gov-west-1:123456789012:accesspoint:myendpoint", "us-gov-east-1", S3ConfigFlags.Fips | S3ConfigFlags.ArnRegion, "myendpoint-123456789012.s3-accesspoint-fips.us-gov-west-1.amazonaws.com", "")]
        [DataRow("arn:aws-us-gov:s3:us-gov-east-1:123456789012:accesspoint:myendpoint", "fips-us-gov-east-1", S3ConfigFlags.ArnRegion | S3ConfigFlags.Dualstack, "myendpoint-123456789012.s3-accesspoint-fips.dualstack.us-gov-east-1.amazonaws.com", "")]
        [DataRow("arn:aws:s3:us-east-1:123456789012:accesspoint:myendpoint", "s3-external-1", S3ConfigFlags.ArnRegion, "myendpoint-123456789012.s3-accesspoint.us-east-1.amazonaws.com", "")]
        [DataRow("arn:aws:s3:us-east-1:123456789012:accesspoint:myendpoint", "s3-external-1", S3ConfigFlags.None, "", "Invalid configuration: region from ARN `us-east-1` does not match client region `s3-external-1` and UseArnRegion is `false`")]
        [DataRow("arn:aws:s3:us-east-1:123456789012:accesspoint:myendpoint", "aws-global", S3ConfigFlags.ArnRegion, "myendpoint-123456789012.s3-accesspoint.us-east-1.amazonaws.com", "")]
        [DataRow("arn:aws:s3:us-east-1:123456789012:accesspoint:myendpoint", "aws-global", S3ConfigFlags.None, "", "Invalid configuration: region from ARN `us-east-1` does not match client region `aws-global` and UseArnRegion is `false`")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap", "us-west-2", S3ConfigFlags.DisableMRAP, "", "Invalid configuration: Multi-Region Access Point ARNs are disabled.")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap", "aws-global", S3ConfigFlags.DisableMRAP, "", "Invalid configuration: Multi-Region Access Point ARNs are disabled.")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap", "us-west-2", S3ConfigFlags.Dualstack, "", "S3 MRAP does not support dual-stack")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap", "us-west-2", S3ConfigFlags.Accelerate, "", "S3 MRAP does not support S3 Accelerate")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:myendpoint", "us-west-2", S3ConfigFlags.DisableMRAP, "", "Invalid configuration: Multi-Region Access Point ARNs are disabled.")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap", "us-west-2", S3ConfigFlags.DisableMRAP, "", "Invalid configuration: Multi-Region Access Point ARNs are disabled.")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap", "aws-global", S3ConfigFlags.DisableMRAP, "", "Invalid configuration: Multi-Region Access Point ARNs are disabled.")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap", "us-west-2", S3ConfigFlags.Dualstack, "", "S3 MRAP does not support dual-stack")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap", "us-west-2", S3ConfigFlags.Accelerate, "", "S3 MRAP does not support S3 Accelerate")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:myendpoint", "us-west-2", S3ConfigFlags.DisableMRAP, "", "Invalid configuration: Multi-Region Access Point ARNs are disabled.")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:myendpoint", "us-west-2", S3ConfigFlags.None, "myendpoint.accesspoint.s3-global.amazonaws.com", "")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:my.bucket", "us-west-2", S3ConfigFlags.None, "my.bucket.accesspoint.s3-global.amazonaws.com", "")]
        public void TestAccessPointArnVariations(string accessPointArn, string region, S3ConfigFlags flags, string host, string errorMessage)
        {
            TestAccessPointArnVariationHelper(accessPointArn, region, flags, host, errorMessage);
        }

        [TestMethod]
        [TestCategory("S3")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap", "us-east-1", S3ConfigFlags.None, "mfzwi23gnjvgw.mrap.accesspoint.s3-global.amazonaws.com", HeaderKeys.XAmzRegionSetHeader, "*")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap", "us-west-2", S3ConfigFlags.None, "mfzwi23gnjvgw.mrap.accesspoint.s3-global.amazonaws.com", HeaderKeys.XAmzRegionSetHeader, "*")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap", "aws-global", S3ConfigFlags.None, "mfzwi23gnjvgw.mrap.accesspoint.s3-global.amazonaws.com", HeaderKeys.XAmzRegionSetHeader, "*")]
        [DataRow("arn:aws-cn:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap", "cn-north-1", S3ConfigFlags.None, "mfzwi23gnjvgw.mrap.accesspoint.s3-global.amazonaws.com.cn", HeaderKeys.XAmzRegionSetHeader, "*")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:myendpoint", "us-west-2", S3ConfigFlags.None, "myendpoint.accesspoint.s3-global.amazonaws.com", HeaderKeys.XAmzRegionSetHeader, "*")]
        [DataRow("arn:aws:s3::123456789012:accesspoint:my.bucket", "us-west-2", S3ConfigFlags.None, "my.bucket.accesspoint.s3-global.amazonaws.com", HeaderKeys.XAmzRegionSetHeader, "*")]
        public void TestAccessPointArnVariationsWithHeader(string accessPointArn, string region, S3ConfigFlags flags, string host, string expectedHeaderKey, string expectedHeaderValue)
        {
            var internalRequest = TestAccessPointArnVariationHelper(accessPointArn, region, flags, host, "");

            Assert.IsTrue(internalRequest.Headers.ContainsKey(expectedHeaderKey));
            Assert.AreEqual(expectedHeaderValue, internalRequest.Headers[expectedHeaderKey]);
        }

        /// <summary>
        /// Test helper for S3 access point tests
        /// </summary>
        /// <param name="accessPointArn">Access point ARN (BucketName on the request)</param>
        /// <param name="region">Region, to be set on AmazonS3Config's RegionEndpoint</param>
        /// <param name="flags">Bit field of additional AmazonS3Config settings</param>
        /// <param name="host">Expected hostname, will be asserted for valid test cases</param>
        /// <param name="errorMessage">Expected error message, will be asserted for invalid test cases</param>
        /// <returns></returns>
        private IRequest TestAccessPointArnVariationHelper(string accessPointArn, string region, S3ConfigFlags flags, string host, string errorMessage)
        {
            var request = new PutObjectRequest
            {
                BucketName = accessPointArn,
                Key = "foo.txt",
                ContentBody = "data"
            };

            var config = S3ArnTestUtils.BuildFromRegionSystemName(region, flags);

            Exception exception = null;
            IRequest marshalledRequest = null;

            try
            {
                marshalledRequest = S3ArnTestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, config);
            }
            catch (Exception e)
            {
                exception = e;
            }

            if (!string.IsNullOrEmpty(host))
            {
                Assert.IsNull(exception, "Exception was thrown: " + exception?.Message);

                Assert.AreEqual(new Uri($"https://{host}"), marshalledRequest.Endpoint);
                Assert.AreEqual("/foo.txt", marshalledRequest.ResourcePath);
            }
            else if (!string.IsNullOrEmpty(errorMessage))
            {
                Assert.IsNotNull(exception, "Expected exception, but got result " + marshalledRequest?.Endpoint);
                Assert.IsInstanceOfType(exception, typeof(AmazonClientException));
                Assert.AreEqual(errorMessage, exception.Message);
            }
            else
            {
                Assert.Fail($"Bad Test Data, you must provide either {nameof(host)} or {nameof(errorMessage)}");
            }
            return marshalledRequest;
        }
    }
}
