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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3Control;
using Amazon.S3Control.Model;
using Amazon.S3Control.Model.Internal.MarshallTransformations;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3OutpostsBucketArnTests
    {
        public static IEnumerable<object[]> S3OutpostBucketARNTestsData()
        {
            var testDataFromSpecMarkDown =
                // | BucketNameOrARN Input | Client Region | Additional Flags | use arn region | Expected Endpoint | Expected Headers | Expected Signed By |
                // | --------------------- | ------------- | ---------------- | -------------- | ----------------- | ---------------  | ------------------ |
                @"
                | arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket | us-west-2 | none | no  | s3-outposts.us-west-2.amazonaws.com | x-amz-outpost-id: ""op-01234567890123456"", x-amz-account-id: ""123456789012"" | s3-outposts |
                | arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket | us-west-2 | none | yes | s3-outposts.us-east-1.amazonaws.com | x-amz-outpost-id: ""op-01234567890123456"", x-amz-account-id: ""123456789012"" | s3-outposts |
                | arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket | us-west-2 | none | no  | Invalid configuration: region from ARN `us-east-1` does not match client region `us-west-2` and UseArnRegion is `false` | - | - |
                | arn:aws-cn:s3-outposts:cn-north-1:123456789012:outpost:op-01234567890123456:bucket:mybucket | us-west-2  | none | yes | Client was configured for partition `aws` but ARN has `aws-cn` | - | - |
                | arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket | us-gov-east-1  | none | yes | s3-outposts.us-gov-east-1.amazonaws.com | x-amz-outpost-id: ""op-01234567890123456"", x-amz-account-id: ""123456789012"" | s3-outposts |
                | arn:aws-us-gov:s3-outposts:us-gov-west-1:123456789012:outpost:op-01234567890123456:bucket:mybucket | us-gov-west-1 | fips | no | s3-outposts-fips.us-gov-west-1.amazonaws.com |  x-amz-outpost-id: ""op-01234567890123456"", x-amz-account-id: ""123456789012"" | s3-outposts |
                | arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket | us-gov-west-1 | fips | yes | s3-outposts-fips.us-gov-east-1.amazonaws.com |  x-amz-outpost-id: ""op-01234567890123456"", x-amz-account-id: ""123456789012"" | s3-outposts |
                | arn:aws:s3-outposts:us-west-2:123456789012:outpost | us-west-2 | n/a  | n/a | Invalid ARN: The Outpost Id was not set | - | - |
                | arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456 | us-west-2 | n/a  | n/a | Invalid ARN: Expected a 4-component resource | - | - |
                | arn:aws:s3-outposts:us-west-2:123456789012:outpost:bucket | us-west-2 | n/a  | n/a | Invalid ARN: Expected a 4-component resource | - | - |
                | arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket | us-west-2 | n/a  | n/a | Invalid ARN: expected a bucket name | - | - |
                ";

            var data = testDataFromSpecMarkDown
                .StandardDataClean()
                .ParseMarkdownTable();

            return data;
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        [DynamicData(nameof(S3OutpostBucketARNTestsData), DynamicDataSourceType.Method)]
        public void S3OutpostBucketARNTests(string bucketNameOrARNInput, string clientRegion, string additionalFlags, string useArnRegion, string expectedEndpoint, string expectedHeaders, string expectedSignedBy)
        {
            Console.WriteLine(string.Join(" | ", bucketNameOrARNInput, clientRegion, additionalFlags, useArnRegion, expectedEndpoint, expectedHeaders, expectedSignedBy));
            Console.WriteLine();

            // ARRANGE

            // expectedEndpoint can be overloaded with the expected error message
            var expectSuccess = expectedEndpoint.Contains("amazonaws.com");
            // outputs to assert against:
            IRequest s3Request = null;
            Exception exception = null;

            var request = new GetBucketRequest
            {
                Bucket = bucketNameOrARNInput,
                AccountId = "123456789012"
            };

            var config = new AmazonS3ControlConfig
            {
                RegionEndpoint = clientRegion == "" ? null : RegionEndpoint.GetBySystemName(clientRegion),
                UseArnRegion = useArnRegion == "" ? false : bool.Parse(useArnRegion)
            };

            if (additionalFlags.Contains("dualstack"))
                config.UseDualstackEndpoint = true;

            if (additionalFlags.Contains("fips"))
                config.UseFIPSEndpoint = true;

            if (additionalFlags.Contains("accelerate") && !expectSuccess)
                // S3 Control Config does not allow setting accelerate, so it will not generate the expected error
                return;

            // ACT
            try
            {
                s3Request = S3ControlArnTestUtils.RunMockRequest(request, GetBucketRequestMarshaller.Instance, config);
                Console.WriteLine(s3Request.Endpoint.ToString());
                Console.WriteLine();
            }
            catch (Exception e)
            {
                exception = e;
            }

            // ASSERT
            if (expectSuccess)
            {
                Assert.IsNull(exception, exception?.Message + "\r\n" + exception?.StackTrace);
                Assert.IsNotNull(s3Request);
                AssertExtensions.UrlSuffixMatches(expectedEndpoint, s3Request.Endpoint);
                AssertExtensions.ContainsHeaders(SpecMarkdownTestDataHelper.ParseExpectedHeaders(expectedHeaders), s3Request.Headers);
            }
            else
            {
                Assert.IsNull(s3Request);
                Assert.IsNotNull(exception);
                // reminder, expectedEndpoint also contains expected error message.
                Assert.AreEqual(expectedEndpoint, exception.Message);
            }
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsBucketInputUSGovWest1UseArnRegionFalseWithFips()
        {
            var outpostsBucketArn = "arn:aws-us-gov:s3-outposts:us-gov-west-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.GetBySystemName("us-gov-west-1-fips"),
                UseArnRegion = false
            };
            var getBucketRequest = new GetBucketRequest
            {
                Bucket = outpostsBucketArn
            };
            var marshalledRequest = S3ControlArnTestUtils.RunMockRequest(getBucketRequest, GetBucketRequestMarshaller.Instance, s3ControlConfig);
            Assert.AreEqual(new Uri("https://s3-outposts-fips.us-gov-west-1.amazonaws.com"), marshalledRequest.Endpoint);
            Assert.AreEqual("op-01234567890123456", marshalledRequest.Headers[HeaderKeys.XAmzOutpostId]);
            Assert.AreEqual("123456789012", marshalledRequest.Headers[HeaderKeys.XAmzAccountId]);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsBucketInputUSGovWest1UseArnRegionTrueWithFips()
        {
            var outpostsBucketArn = "arn:aws-us-gov:s3-outposts:us-gov-west-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.GetBySystemName("us-gov-west-1-fips"),
                UseArnRegion = true
            };
            var getBucketRequest = new GetBucketRequest
            {
                Bucket = outpostsBucketArn
            };
            var marshalledRequest = S3ControlArnTestUtils.RunMockRequest(getBucketRequest, GetBucketRequestMarshaller.Instance, s3ControlConfig);
            Assert.AreEqual(new Uri("https://s3-outposts-fips.us-gov-west-1.amazonaws.com"), marshalledRequest.Endpoint);
            Assert.AreEqual("op-01234567890123456", marshalledRequest.Headers[HeaderKeys.XAmzOutpostId]);
            Assert.AreEqual("123456789012", marshalledRequest.Headers[HeaderKeys.XAmzAccountId]);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsBucketInputUSGovEast1UseArnRegionFalseFipsCrossRegionException()
        {
            var outpostsBucketArn = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.GetBySystemName("us-gov-west-1-fips"),
                UseArnRegion = false
            };
            var getBucketRequest = new GetBucketRequest
            {
                Bucket = outpostsBucketArn
            };
            var exception = Assert.ThrowsException<AmazonClientException>(() =>
            {
                S3ControlArnTestUtils.RunMockRequest(getBucketRequest, GetBucketRequestMarshaller.Instance, s3ControlConfig);
            });
            Assert.AreEqual("Invalid configuration: region from ARN `us-gov-east-1` does not match client region `us-gov-west-1` and UseArnRegion is `false`", exception.Message);
        }
    }
}
