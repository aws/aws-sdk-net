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
using Amazon.S3Control;
using Amazon.S3Control.Internal;
using Amazon.S3Control.Model;
using Amazon.S3Control.Model.Internal.MarshallTransformations;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3ArnHelperMethodTests
    {

        [TestMethod]
        [TestCategory("S3Control")]
        public void TestNonArnOutpostRequestHasIdTrue()
        {
            var request = new CreateBucketRequest
            {
                Bucket = "test",
                OutpostId = "op-1234567890"
            };
            string outpostId = null;
            Assert.IsTrue(S3ArnUtils.DoesRequestHaveOutpostId(request, out outpostId));
            Assert.AreEqual("op-1234567890", outpostId);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        public void TestNonArnOutpostRequestHasIdFalse()
        {
            var request = new GetAccessPointRequest
            {
                Name = "test",
            };
            string outpostId = null;
            Assert.IsFalse(S3ArnUtils.DoesRequestHaveOutpostId(request, out outpostId));
            Assert.AreEqual(null, outpostId);
        }

        [DataTestMethod]
        [TestCategory("S3Control")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint", "myaccesspoint", "myaccesspoint")]
        [DataRow("noArn", "", "noArn")]
        public void TestReplacePathResourceArns(string originalValueOrArn, string extractedName, string expectedValue)
        {
            var testDict = new Dictionary<string, string>();
            testDict.Add("value", originalValueOrArn);
            S3ArnUtils.ReplacePathResourceArns(testDict, extractedName);
            Assert.AreEqual(expectedValue, testDict["value"]);
        }

        [DataTestMethod]
        [TestCategory("S3Control")]
        [DataRow("", false)]
        [DataRow("1+1=3", false)]
        [DataRow("op-12345", true)]
        [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", false)]
        [DataRow("123", true)]
        public void TestIsValidOutpostId(string outpostId, bool isValid)
        {
            Assert.AreEqual(isValid, S3ArnUtils.IsValidOutpostId(outpostId));
        }
    }
}
