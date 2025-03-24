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
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static AWSSDK.UnitTests.Mocking.TestUtils;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class GeneralTests
    {
        [TestMethod]
        [TestCategory("S3")]
        public void HandleS3EventTypeLambdaDiscrepancy()
        {
            Assert.IsTrue("s3:ObjectCreated:Put" == EventType.ObjectCreatedPut);
            Assert.IsTrue("ObjectCreated:Put" == EventType.ObjectCreatedPut);
            Assert.IsTrue("ObjectCreated:Get" != EventType.ObjectCreatedPut);

            Assert.IsTrue(new EventType("s3:ObjectCreated:Put") == EventType.ObjectCreatedPut);
            Assert.IsTrue(new EventType("ObjectCreated:Put") == EventType.ObjectCreatedPut);
            Assert.IsTrue(new EventType("s3:ObjectCreated:Get") != EventType.ObjectCreatedPut);

#pragma warning disable CS1718
            // Sanity test to make sure we haven't messed up the == operator
            Assert.IsTrue(EventType.ObjectCreatedPut == EventType.ObjectCreatedPut);
#pragma warning restore CS1718			
        }

        [TestMethod]
        [TestCategory("S3")]
        public void EnsureResignOnRetriesIsEnabled()
        {
            var serviceClient = new AmazonS3Client("aaaa", "bbbb", Amazon.RegionEndpoint.USEast1);
            Assert.IsTrue(serviceClient.Config.ResignRetries);


            serviceClient = new AmazonS3Client("aaaa", "bbbb", new AmazonS3Config
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1,
                ResignRetries = false
            });
            Assert.IsTrue(serviceClient.Config.ResignRetries);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ChecksumHeaderIsSetToPayload()
        {
            var request = new PutBucketEncryptionRequest
            {
                BucketName = "test",
                ContentMD5 = "test",
                ServerSideEncryptionConfiguration = new ServerSideEncryptionConfiguration
                {
                    ServerSideEncryptionRules = new List<ServerSideEncryptionRule>() { new ServerSideEncryptionRule { BucketKeyEnabled = true } }
                }
            };

            var response = S3ArnTestUtils.RunMockRequest(request, PutBucketEncryptionRequestMarshaller.Instance);
            Assert.AreEqual(response.Headers[Amazon.Util.HeaderKeys.ContentMD5Header], "test");
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ChecksumHeaderIsSet()
        {
            var request = new PutBucketEncryptionRequest
            {
                BucketName = "test",
                ServerSideEncryptionConfiguration = new ServerSideEncryptionConfiguration
                {
                    ServerSideEncryptionRules = new List<ServerSideEncryptionRule>() { new ServerSideEncryptionRule { BucketKeyEnabled = true } }
                }
            };

            var response = S3ArnTestUtils.RunMockRequest(request, PutBucketEncryptionRequestMarshaller.Instance);

            Assert.IsTrue(response.Headers.Keys.Any(k => k.ToUpper().Contains("CHECKSUM")));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ChecksumDataIsSet()
        {
            var request = new PutBucketEncryptionRequest
            {
                BucketName = "test",
                ServerSideEncryptionConfiguration = new ServerSideEncryptionConfiguration
                {
                    ServerSideEncryptionRules = new List<ServerSideEncryptionRule>() { new ServerSideEncryptionRule { BucketKeyEnabled = true } }
                }
            };
            var response = S3ArnTestUtils.RunMockRequest(request, PutBucketEncryptionRequestMarshaller.Instance);

            Assert.IsTrue(response.ChecksumData != null);
            Assert.IsFalse(response.ChecksumData.FallbackToMD5.GetValueOrDefault());
            Assert.IsTrue(response.ChecksumData.SelectedChecksum == null);
        }
    }
}