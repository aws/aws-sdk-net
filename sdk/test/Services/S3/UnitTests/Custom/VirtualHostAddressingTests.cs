/*
 * Copyright 2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.IO;
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.S3;
using Amazon.S3.Internal;
using Amazon.S3.Model;
using Amazon.Util;
using AWSSDK.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class VirtualHostAddressingTests
    {
        private static IEnumerable<object[]> Testcases =>
            new List<object[]> {
                new object[] {"bucket-name", RegionEndpoint.USEast1, null, false, false, "https://bucket-name.s3.amazonaws.com"},
                new object[] {"bucket-name", RegionEndpoint.USWest1, null, false, false, "https://bucket-name.s3.us-west-1.amazonaws.com"},
                new object[] {"bucket-with-number-1", RegionEndpoint.USWest1, null, false, false, "https://bucket-with-number-1.s3.us-west-1.amazonaws.com"},
                new object[] {"bucket-name", RegionEndpoint.CNNorth1, null, false, false, "https://bucket-name.s3.cn-north-1.amazonaws.com.cn"},
                new object[] {"BucketName", RegionEndpoint.USEast1, null, false, false, "https://s3.amazonaws.com/BucketName"},
                new object[] {"bucket_name", RegionEndpoint.USWest1, null, false, false, "https://s3.us-west-1.amazonaws.com/bucket_name"},
                new object[] {"bucket.name", RegionEndpoint.USWest1, null, false, false, "https://s3.us-west-1.amazonaws.com/bucket.name"},
                new object[] {"-bucket-name", RegionEndpoint.USWest1, null, false, false, "https://s3.us-west-1.amazonaws.com/-bucket-name"},
                new object[] {"bucket-name-", RegionEndpoint.USWest1, null, false, false, "https://s3.us-west-1.amazonaws.com/bucket-name-"},
                new object[] {"aa", RegionEndpoint.USWest1, null, false, false, "https://s3.us-west-1.amazonaws.com/aa"},
                new object[] {new string('a',64), RegionEndpoint.USWest1, null, false, false, "https://s3.us-west-1.amazonaws.com/"+ new string('a', 64)},
                new object[] {"bucket-name", RegionEndpoint.USEast1, null, true, false, "https://bucket-name.s3-accelerate.amazonaws.com"},
                new object[] {"bucket-name", RegionEndpoint.USWest1, null, true, false, "https://bucket-name.s3-accelerate.amazonaws.com"},
                new object[] {"bucket-name", RegionEndpoint.USEast1, null, false, true, "https://bucket-name.s3.dualstack.us-east-1.amazonaws.com"},
                new object[] {"bucket-name", RegionEndpoint.USWest2, null, false, true, "https://bucket-name.s3.dualstack.us-west-2.amazonaws.com"},
                new object[] {"bucket.name", RegionEndpoint.USWest2, null, false, true, "https://s3.dualstack.us-west-2.amazonaws.com/bucket.name"},
                new object[] {"bucket-name", RegionEndpoint.USEast1, null, true, true, "https://bucket-name.s3-accelerate.dualstack.amazonaws.com"},
                new object[] {"bucket-name", RegionEndpoint.USEast1, true, false, false, "https://s3.amazonaws.com/bucket-name"},
                new object[] {"bucket-name", RegionEndpoint.USEast1, true, false, true, "https://s3.dualstack.us-east-1.amazonaws.com/bucket-name"}
            };

        
        [DataTestMethod]
        [DynamicData(nameof(Testcases))]
        [TestCategory("S3")]
        public void AddressingTests(string bucketName, RegionEndpoint regionEndpoint, bool? usePathStyle,
            bool useAccelerate, bool useDualstack, string expectedUri)
        {

            TestAddressingForConfig(bucketName, regionEndpoint, usePathStyle, useAccelerate, useDualstack, expectedUri);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestPathStyleAddressingWithAccelerateEnabled()
        {
            var exception = Assert.ThrowsException<AmazonClientException>(() => TestAddressingForConfig("bucket-name", RegionEndpoint.USEast1, true, true, false, "https://bucket-name.s3-accelerate.amazonaws.com"));
            Assert.AreEqual("S3 accelerate is not compatible with Path style requests. Disable Path style requests using AmazonS3Config.ForcePathStyle property to use S3 accelerate.", exception.Message);
        }


        [TestMethod]
        [TestCategory("S3")]
        public void TestPathStyleAddressingWithAccelerateAndDualstackEnabled()
        {
            var exception = Assert.ThrowsException<AmazonClientException>(() => TestAddressingForConfig("bucket-name", RegionEndpoint.USEast1, true, true, true, "https://bucket-name.s3-accelerate.dualstack.amazonaws.com"));
            Assert.AreEqual("S3 accelerate is not compatible with Path style requests. Disable Path style requests using AmazonS3Config.ForcePathStyle property to use S3 accelerate.", exception.Message);
        }

        private void TestAddressingForConfig(string bucketName, RegionEndpoint regionEndpoint, bool? usePathStyle,
            bool useAccelerate, bool useDualstack, string expectedUri)
        {
            var clientConfig = new AmazonS3Config
            {
                RegionEndpoint = regionEndpoint,
                UseAccelerateEndpoint = useAccelerate,
                UseDualstackEndpoint = useDualstack
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