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
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class BucketOwnershipControlsTests : TestBase<AmazonS3Client>
    {
        public static string bucketName;
        private IAmazonS3 s3Client;

        [TestInitialize]
        public async Task Init()
        {
            s3Client = new AmazonS3Client();
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(s3Client);
        }

        [TestCleanup]
        public async Task Cleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(s3Client, bucketName);
            s3Client.Dispose();
        }

        [TestMethod]
        public async Task TestGetBucketOwnershipControls_ObjectWriter()
        {
            await PutAndGetBucketOwnershipControls(ObjectOwnership.ObjectWriter);
        }

        [TestMethod]
        public async Task TestGetBucketOwnershipControls_BucketOwnerPreferred()
        {
            await PutAndGetBucketOwnershipControls(ObjectOwnership.BucketOwnerPreferred);
        }

        [TestMethod]
        public async Task TestDeleteBucketOwnershipControls()
        {
            await PutAndGetBucketOwnershipControls(ObjectOwnership.BucketOwnerPreferred);

            await s3Client.DeleteBucketOwnershipControlsAsync(new DeleteBucketOwnershipControlsRequest
            {
                BucketName = bucketName
            });

            await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() =>
                s3Client.GetBucketOwnershipControlsAsync(new GetBucketOwnershipControlsRequest
                {
                    BucketName = bucketName
                })
            );
        }

        private async Task PutAndGetBucketOwnershipControls(ObjectOwnership objectOwnership)
        {
            await s3Client.PutBucketOwnershipControlsAsync(new PutBucketOwnershipControlsRequest
            {
                BucketName = bucketName,
                OwnershipControls = new OwnershipControls
                {
                    Rules = new List<OwnershipControlsRule> { new OwnershipControlsRule { ObjectOwnership = objectOwnership } }
                }
            });

            var getResponse = await s3Client.GetBucketOwnershipControlsAsync(new GetBucketOwnershipControlsRequest
            {
                BucketName = bucketName
            });
            Assert.IsNotNull(getResponse.OwnershipControls);
            Assert.AreEqual(1, getResponse.OwnershipControls.Rules.Count());
            Assert.AreEqual(objectOwnership, getResponse.OwnershipControls.Rules[0].ObjectOwnership);
        }
    }
}
