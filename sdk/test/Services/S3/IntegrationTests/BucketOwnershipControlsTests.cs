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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Integration tests for the bucket ownership controls
    /// </summary>
    [TestClass]
    public class BucketOwnershipControlsTests : TestBase<AmazonS3Client>
    {
        public static string bucketName;
        private IAmazonS3 s3Client;

        [TestInitialize]
        public void Init()
        {
            s3Client = new AmazonS3Client();
            bucketName = S3TestUtils.CreateBucketWithWait(s3Client);
        }

        [TestCleanup]
        public void Cleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(s3Client, bucketName);
            s3Client.Dispose();
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestGetBucketOwnershipControls_ObjectWriter()
        {
            PutAndGetBucketOwnershipControls(ObjectOwnership.ObjectWriter);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestGetBucketOwnershipControls_BucketOwnerPreferred()
        {
            PutAndGetBucketOwnershipControls(ObjectOwnership.BucketOwnerPreferred);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(AmazonS3Exception), "The bucket ownership controls were not found")]
        public void TestDeleteBucketOwnershipControls()
        {
            PutAndGetBucketOwnershipControls(ObjectOwnership.BucketOwnerPreferred);

            var deleteRequest = new DeleteBucketOwnershipControlsRequest
            {
                BucketName = bucketName
            };

            s3Client.DeleteBucketOwnershipControls(deleteRequest);

            GetBucketOwnershipControlsRequest getRequest = new GetBucketOwnershipControlsRequest
            {
                BucketName = bucketName
            };

            var getResponse = s3Client.GetBucketOwnershipControls(getRequest);
        }

        private void PutAndGetBucketOwnershipControls(ObjectOwnership objectOwnership)
        {
            var putRequest = new PutBucketOwnershipControlsRequest
            {
                BucketName = bucketName,
                OwnershipControls = new OwnershipControls
                {
                    Rules = new List<OwnershipControlsRule> { new OwnershipControlsRule { ObjectOwnership = objectOwnership } }
                }
            };

            s3Client.PutBucketOwnershipControls(putRequest);

            GetBucketOwnershipControlsRequest getRequest = new GetBucketOwnershipControlsRequest
            {
                BucketName = bucketName
            };

            var getResponse = s3Client.GetBucketOwnershipControls(getRequest);
            Assert.IsNotNull(getResponse.OwnershipControls);
            Assert.AreEqual(1, getResponse.OwnershipControls.Rules.Count());
            Assert.AreEqual(objectOwnership, getResponse.OwnershipControls.Rules[0].ObjectOwnership);

        }
    }
}
