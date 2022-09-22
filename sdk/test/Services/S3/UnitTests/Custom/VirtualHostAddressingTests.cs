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
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class VirtualHostAddressingTests
    {
        private static IEnumerable<object[]> Testcases =>
            new List<object[]> {
                // Legacy behavior, global endpoint
                new object[] {"bucket-name", RegionEndpoint.USEast1, null, false, false, S3UsEast1RegionalEndpointValue.Legacy, "https://bucket-name.s3.amazonaws.com" },
                // Flag set to Regional and region is us-east-1 so the endpoint is overridden.
                new object[] {"bucket-name", RegionEndpoint.USEast1, null, false, false, S3UsEast1RegionalEndpointValue.Regional, "https://bucket-name.s3.us-east-1.amazonaws.com" },
                // Flag not set, so no impact
                new object[] {"bucket-name", RegionEndpoint.USEast1, null, false, false, null, "https://bucket-name.s3.amazonaws.com" },
                new object[] {"bucket-name", RegionEndpoint.USWest1, null, false, false, S3UsEast1RegionalEndpointValue.Legacy, "https://bucket-name.s3.us-west-1.amazonaws.com" },
                // Flag set to Regional, but the region is not us-east-1 so no impact:
                new object[] {"bucket-name", RegionEndpoint.USWest1, null, false, false, S3UsEast1RegionalEndpointValue.Regional, "https://bucket-name.s3.us-west-1.amazonaws.com" },
                new object[] {"bucket-with-number-1", RegionEndpoint.USWest1, null, false, false, S3UsEast1RegionalEndpointValue.Legacy, "https://bucket-with-number-1.s3.us-west-1.amazonaws.com" },
                new object[] {"bucket-name", RegionEndpoint.CNNorth1, null, false, false, S3UsEast1RegionalEndpointValue.Legacy, "https://bucket-name.s3.cn-north-1.amazonaws.com.cn" },
                new object[] {"BucketName", RegionEndpoint.USEast1, null, false, false, S3UsEast1RegionalEndpointValue.Legacy, "https://s3.amazonaws.com/BucketName/" },
                new object[] {"bucket_name", RegionEndpoint.USWest1, null, false, false, S3UsEast1RegionalEndpointValue.Legacy, "https://s3.us-west-1.amazonaws.com/bucket_name/" },
                new object[] {"bucket.name", RegionEndpoint.USWest1, null, false, false, S3UsEast1RegionalEndpointValue.Legacy, "https://s3.us-west-1.amazonaws.com/bucket.name/" },
                new object[] {"-bucket-name", RegionEndpoint.USWest1, null, false, false, S3UsEast1RegionalEndpointValue.Legacy, "https://s3.us-west-1.amazonaws.com/-bucket-name/" },
                new object[] {"bucket-name-", RegionEndpoint.USWest1, null, false, false, S3UsEast1RegionalEndpointValue.Legacy, "https://s3.us-west-1.amazonaws.com/bucket-name-/" },
                new object[] {"aa", RegionEndpoint.USWest1, null, false, false, S3UsEast1RegionalEndpointValue.Legacy, "https://s3.us-west-1.amazonaws.com/aa/" },
                new object[] {new string('a',64), RegionEndpoint.USWest1, null, false, false, S3UsEast1RegionalEndpointValue.Legacy, "https://s3.us-west-1.amazonaws.com/" + new string('a', 64) + "/"},
                new object[] {"bucket-name", RegionEndpoint.USEast1, null, true, false, S3UsEast1RegionalEndpointValue.Legacy, "https://bucket-name.s3-accelerate.amazonaws.com" },
                // Flag set to Regional, but accelerate is true, so the endpoint should stay at s3-accelerate.amazonaws.com
                new object[] {"bucket-name", RegionEndpoint.USEast1, null, true, false, S3UsEast1RegionalEndpointValue.Regional, "https://bucket-name.s3-accelerate.amazonaws.com" },
                // Flag not set, on accelerate, no impact
                new object[] {"bucket-name", RegionEndpoint.USEast1, null, true, false, null, "https://bucket-name.s3-accelerate.amazonaws.com" },
                new object[] {"bucket-name", RegionEndpoint.USWest1, null, true, false, S3UsEast1RegionalEndpointValue.Legacy, "https://bucket-name.s3-accelerate.amazonaws.com" },
                new object[] {"bucket-name", RegionEndpoint.USEast1, null, false, true, S3UsEast1RegionalEndpointValue.Legacy, "https://bucket-name.s3.dualstack.us-east-1.amazonaws.com" },
                // Flag set to Regional so the region should be present.
                new object[] {"bucket-name", RegionEndpoint.USEast1, null, false, true, S3UsEast1RegionalEndpointValue.Regional, "https://bucket-name.s3.dualstack.us-east-1.amazonaws.com" },
                new object[] {"bucket-name", RegionEndpoint.USWest2, null, false, true, S3UsEast1RegionalEndpointValue.Legacy, "https://bucket-name.s3.dualstack.us-west-2.amazonaws.com" },
                new object[] {"bucket.name", RegionEndpoint.USWest2, null, false, true, S3UsEast1RegionalEndpointValue.Legacy, "https://s3.dualstack.us-west-2.amazonaws.com/bucket.name/" },
                new object[] {"bucket-name", RegionEndpoint.USEast1, null, true, true, S3UsEast1RegionalEndpointValue.Legacy, "https://bucket-name.s3-accelerate.dualstack.amazonaws.com" },
                // Flag set to Regional on accelerate and dual stack, no impact
                new object[] {"bucket-name", RegionEndpoint.USEast1, null, true, true, S3UsEast1RegionalEndpointValue.Regional, "https://bucket-name.s3-accelerate.dualstack.amazonaws.com" },
                // Flag not set, on accelerate and dual stack, no impact
                new object[] {"bucket-name", RegionEndpoint.USEast1, null, true, true, null, "https://bucket-name.s3-accelerate.dualstack.amazonaws.com" },
                new object[] {"bucket-name", RegionEndpoint.USEast1, true, false, false, S3UsEast1RegionalEndpointValue.Legacy, "https://s3.amazonaws.com/bucket-name/" },
                new object[] {"bucket-name", RegionEndpoint.USEast1, true, false, true, S3UsEast1RegionalEndpointValue.Legacy, "https://s3.dualstack.us-east-1.amazonaws.com/bucket-name/" }
            };

        
        [DataTestMethod]
        [DynamicData(nameof(Testcases))]
        [TestCategory("S3")]
        public void AddressingTests(string bucketName, RegionEndpoint regionEndpoint, bool? usePathStyle,
            bool useAccelerate, bool useDualstack, S3UsEast1RegionalEndpointValue s3EndpointValue, string expectedUri)
        {
            TestAddressingForConfig(bucketName, regionEndpoint, usePathStyle, useAccelerate, useDualstack, s3EndpointValue, expectedUri);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestPathStyleAddressingWithAccelerateEnabled()
        {
            var exception = Assert.ThrowsException<AmazonClientException>(() => TestAddressingForConfig("bucket-name", RegionEndpoint.USEast1, true, true, false, S3UsEast1RegionalEndpointValue.Legacy, "https://bucket-name.s3-accelerate.amazonaws.com"));
            Assert.AreEqual("S3 accelerate is not compatible with Path style requests. Disable Path style requests using AmazonS3Config.ForcePathStyle property to use S3 accelerate.", exception.Message);
        }


        [TestMethod]
        [TestCategory("S3")]
        public void TestPathStyleAddressingWithAccelerateAndDualstackEnabled()
        {
            var exception = Assert.ThrowsException<AmazonClientException>(() => TestAddressingForConfig("bucket-name", RegionEndpoint.USEast1, true, true, true, S3UsEast1RegionalEndpointValue.Legacy, "https://bucket-name.s3-accelerate.dualstack.amazonaws.com"));
            Assert.AreEqual("S3 accelerate is not compatible with Path style requests. Disable Path style requests using AmazonS3Config.ForcePathStyle property to use S3 accelerate.", exception.Message);
        }

        private void TestAddressingForConfig(string bucketName, RegionEndpoint regionEndpoint, bool? usePathStyle,
            bool useAccelerate, bool useDualstack, S3UsEast1RegionalEndpointValue s3EndpointValue, string expectedUri)
        {
            var clientConfig = new AmazonS3Config
            {
                RegionEndpoint = regionEndpoint,
                UseAccelerateEndpoint = useAccelerate,
                UseDualstackEndpoint = useDualstack,
                USEast1RegionalEndpointValue = s3EndpointValue
            };

            if (usePathStyle.HasValue)
            {
                clientConfig.ForcePathStyle = usePathStyle.Value;
            }

            var client = new MockS3Client(clientConfig);
            var response = client.ListObjects(new ListObjectsRequest
            {
                BucketName = bucketName
            });

            var expected = new Uri(expectedUri);
            var actual = client.LastRequestUri;
            Assert.AreEqual(expected.AbsoluteUri, actual.AbsoluteUri);
        }

        class MockS3Client : AmazonS3Client
        {
            public Mock<IHttpRequestFactory<Stream>> MockFactory { get; private set; }
            public Uri LastRequestUri { get; private set; }

            public MockS3Client(AmazonS3Config config) : base(config)
            {
            }

            protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
            {
                base.CustomizeRuntimePipeline(pipeline);

                this.MockFactory = new Mock<IHttpRequestFactory<Stream>>();
                this.MockFactory.Setup(foo => foo.CreateHttpRequest(It.IsAny<Uri>()))
                    .Returns((Uri uri) =>
                    {
                        var request = new Mock<IHttpRequest<Stream>>();
                        request.Setup(foo => foo.GetResponse())
                            .Returns(new HttpWebRequestResponseData(MockWebResponse.CreateFromResource("ListObjectsResponse.txt")));
                        return request.Object;
                    })
                    .Callback((Uri uri) => this.LastRequestUri = uri);
                pipeline.ReplaceHandler<HttpHandler<Stream>>(new HttpHandler<Stream>(this.MockFactory.Object, this));
            }
        }
    }
}