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

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class RequiredUriParametersTest
    {
        [DataRow(null, null)]
        [DataRow("", "")]
        [DataRow("bucket", null)]
        [DataRow(null, "key")]
        [DataRow("bucket", "")]
        [DataRow("", "key")]
        [DataRow("bucket", "key")]
        [DataTestMethod]
        [TestCategory("S3")]
        public void RequiredUriParameters(string bucket, string key)
        {
            var request = new DeleteObjectRequest() { BucketName = bucket, Key = key };
            if (string.IsNullOrEmpty(bucket) || string.IsNullOrEmpty(key))
            {
                Assert.ThrowsException<ArgumentException>(() => DeleteObjectRequestMarshaller.Instance.Marshall(request));
            }
            else
            {
                DeleteObjectRequestMarshaller.Instance.Marshall(request);
            }
        }
    }
}