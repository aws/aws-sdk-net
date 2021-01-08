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
using Amazon.S3.Util;
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
    public class ExpectedBucketOwnerTests
    {
        [TestMethod]
        [TestCategory("S3")]
        public void ExpectedBucketOwnerSetTest()
        {
            string ExpectedBucketOwnerHeader = "x-amz-expected-bucket-owner";
            string ExpectedBucketOwnerValue = "testaccount";

            var requestObject = new GetObjectRequest 
            { 
                Key = "testKey",
                BucketName = "testBucket",
                ExpectedBucketOwner = ExpectedBucketOwnerValue
            };

            GetObjectRequestMarshaller marshaller = new GetObjectRequestMarshaller();
            var request = marshaller.Marshall(requestObject);

            Assert.IsTrue(request.Headers.ContainsKey(ExpectedBucketOwnerHeader));
            Assert.AreEqual(request.Headers[ExpectedBucketOwnerHeader], ExpectedBucketOwnerValue);
        }
    }
}
