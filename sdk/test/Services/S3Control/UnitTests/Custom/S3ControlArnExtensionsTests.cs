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
using Amazon.S3Control;
using Amazon.S3Control.Internal;
using Amazon.S3Control.Model;
using Amazon.S3Control.Model.Internal.MarshallTransformations;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

using Amazon;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3ControlArnExtensionsTests
    {
        [DataTestMethod]
        [TestCategory("S3Control")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint", "op-01234567890123456", "myaccesspoint", null)]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint", "op-01234567890123456", "myaccesspoint", "foo.txt")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket", "op-01234567890123456", "mybucket", null)]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket", "op-01234567890123456", "mybucket", "foo.txt")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket", "op-01234567890123456", "mybucket", "myfolder/foo.txt")]
        public void ParseOutpost(string outpostArn, string outpostId, string accessPointOrBucketName, string key)
        {
            TestParseOutpostWithKeySeparator(outpostArn, outpostId, accessPointOrBucketName, key, ':');

            // Test both : and / key separators
            if (!string.IsNullOrEmpty(key))
            {
                TestParseOutpostWithKeySeparator(outpostArn, outpostId, accessPointOrBucketName, key, '/');
            }
        }

        internal void TestParseOutpostWithKeySeparator(string outpostArn, string outpostId, string accessPointOrBucketName, string key, char keySeparator)
        {
            Arn arn;
            IS3Resource outpost;
            arn = Arn.Parse($"{outpostArn}{(!string.IsNullOrEmpty(key) ? keySeparator + key : "")}");
            outpost = arn.ParseOutpost();
            Assert.IsTrue(arn.IsOutpostArn());
            Assert.AreEqual(outpostId, ((S3OutpostResource)outpost).OutpostId);
            Assert.AreEqual(accessPointOrBucketName, outpost.Name);
            Assert.AreEqual(outpostArn, outpost.FullResourceName);
        }

        [DataTestMethod]
        [TestCategory("S3Control")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accespoint:myaccesspoint")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-012345678.90123456:accesspoint:myaccesspoint")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456/accespoindt/myaccesspoint")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost::accespoint:myaccesspoint")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:buckt:mybucket")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost::bucket:mybucket")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outposta:op-01234567890123456:accesspoint:myaccesspointt")]
        [ExpectedException(typeof(AmazonClientException))]
        public void ParseOutpostBadInput(string input)
        {
            Arn.Parse(input).ParseOutpost();
        }

    }
}
