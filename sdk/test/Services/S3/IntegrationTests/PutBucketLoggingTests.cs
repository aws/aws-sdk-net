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


using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class PutBucketLoggingTests : TestBase<AmazonS3Client>
    {
        public static string bucketName;

        [TestInitialize]
        public void Init()
        {
            bucketName = S3TestUtils.CreateBucketWithWait(Client, true);
        }

        [TestCleanup]
        public void Cleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
        }

        [TestMethod]
        public void TestPutBucketLogging()
        {
            S3Grant grant = new S3Grant
            {
                Grantee = new S3Grantee() { URI = "http://acs.amazonaws.com/groups/s3/LogDelivery" },
                Permission = S3Permission.READ
            };
            List<S3Grant> grantList = new List<S3Grant>();
            grantList.Add(grant);
            var putBucketLoggingRequest = new PutBucketLoggingRequest
            {
                BucketName = bucketName,
                LoggingConfig = new S3BucketLoggingConfig
                {
                    TargetBucketName = bucketName,
                    Grants = grantList
                }
            };
            var response = Client.PutBucketLogging(putBucketLoggingRequest);
            Assert.IsNotNull(response);
        }
    }
}
