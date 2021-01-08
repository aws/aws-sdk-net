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
using System.Text;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class GeneralTests
    {
        private static HashSet<string> NamespacesToAnalyze = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "Amazon.S3.Model.Internal.MarshallTransformations"
            };
        private static HashSet<string> TypesToIgnore = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "Amazon.S3.Model.Internal.MarshallTransformations.HeadBucketRequestMarshaller",
                "Amazon.S3.Model.Internal.MarshallTransformations.HeadBucketResponseUnmarshaller"
            };

        [TestMethod]
        [TestCategory("S3")]
        public void PublicMarshallersTest()
        {
            var nonPublicTypes = new List<Type>();
            var allS3Types = typeof(Amazon.S3.AmazonS3Client).Assembly.GetTypes();
            foreach(var s3t in allS3Types)
            {
                // only check some namespaces
                if (!NamespacesToAnalyze.Contains(s3t.Namespace))
                    continue;

                // ignore specific types that we are keeping internal
                if (TypesToIgnore.Contains(s3t.FullName))
                    continue;

                if (!s3t.IsPublic)
                    nonPublicTypes.Add(s3t);
            }

            Assert.IsTrue(nonPublicTypes.Count == 0, "Non-public types are: " + string.Join(", ", nonPublicTypes));
        }

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

            // Sanity test to make sure we haven't messed up the == operator
            Assert.IsTrue(EventType.ObjectCreatedPut == EventType.ObjectCreatedPut);
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
            var expectedPayload = "<ServerSideEncryptionConfiguration><Rule><BucketKeyEnabled>true</BucketKeyEnabled></Rule></ServerSideEncryptionConfiguration>";
            var payloadChecksum = Amazon.Util.AWSSDKUtils.GenerateChecksumForContent(expectedPayload, true);
            var response = S3ArnTestUtils.RunMockRequest(request, PutBucketEncryptionRequestMarshaller.Instance);
            Assert.IsTrue(response.Headers.ContainsKey(Amazon.Util.HeaderKeys.ContentMD5Header));
            Assert.AreEqual(payloadChecksum, response.Headers[Amazon.Util.HeaderKeys.ContentMD5Header]);
        }
    }
}