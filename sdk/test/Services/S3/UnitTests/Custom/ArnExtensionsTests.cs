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

using Amazon;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class ArnExtensionsTests
    {
        [TestMethod]
        [TestCategory("S3")]
        public void ParseAccessPoint()
        {
            Arn arn;
            string accessPoint;

            accessPoint = null;
            arn = Arn.Parse("arn:aws:s3:us-east-1:000011112222:accesspoint/testpoint");
            Assert.IsTrue(arn.TryParseAccessPoint(out accessPoint));
            Assert.AreEqual("testpoint", accessPoint);

            accessPoint = null;
            arn = Arn.Parse("arn:aws:s3:us-east-1:000011112222:accesspoint:testpoint");
            Assert.IsTrue(arn.TryParseAccessPoint(out accessPoint));
            Assert.AreEqual("testpoint", accessPoint);

            accessPoint = "shouldbecomenull";
            arn = Arn.Parse("arn:aws:s3:::mybucket");
            Assert.IsFalse(arn.TryParseAccessPoint(out accessPoint));
            Assert.IsNull(accessPoint);

            accessPoint = null;
            arn = Arn.Parse("arn:aws:s3:::accesspointbucketprefix");
            Assert.IsFalse(arn.TryParseAccessPoint(out accessPoint));
            Assert.IsNull(accessPoint);

            accessPoint = null;
            arn = Arn.Parse("arn:aws:s3:::accesspoint");
            Assert.IsFalse(arn.TryParseAccessPoint(out accessPoint));
            Assert.IsNull(accessPoint);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ParseBucketName()
        {
            Arn arn;
            string bucketName;

            bucketName = null;
            arn = Arn.Parse("arn:aws:s3:us-east-1:000011112222:bucket_name/testpoint");
            Assert.IsTrue(arn.TryParseBucket(out bucketName));
            Assert.AreEqual("testpoint", bucketName);

            bucketName = null;
            arn = Arn.Parse("arn:aws:s3:us-east-1:000011112222:bucket_name:testpoint");
            Assert.IsTrue(arn.TryParseBucket(out bucketName));
            Assert.AreEqual("testpoint", bucketName);

            bucketName = "shouldbecomenull";
            arn = Arn.Parse("arn:aws:s3:::mybucket");
            Assert.IsFalse(arn.TryParseBucket(out bucketName));
            Assert.IsNull(bucketName);

            bucketName = null;
            arn = Arn.Parse("arn:aws:s3:::bucket_name");
            Assert.IsFalse(arn.TryParseBucket(out bucketName));
            Assert.IsNull(bucketName);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ParseOutpost()
        {
            Arn arn;
            S3OutpostResource outpost;

            arn = Arn.Parse("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint");
            outpost = arn.ParseOutpost();
            Assert.IsTrue(arn.IsOutpostArn());
            Assert.AreEqual("op-01234567890123456", outpost.OutpostId);
            Assert.AreEqual("myaccesspoint", outpost.AccessPointName);
            Assert.AreEqual("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint", outpost.FullAccessPointName);

            arn = Arn.Parse("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint/foo.txt");
            outpost = arn.ParseOutpost();
            Assert.IsTrue(arn.IsOutpostArn());
            Assert.AreEqual("op-01234567890123456", outpost.OutpostId);
            Assert.AreEqual("myaccesspoint", outpost.AccessPointName);
            Assert.AreEqual("foo.txt", outpost.Key);
            Assert.AreEqual("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint", outpost.FullAccessPointName);

            arn = Arn.Parse("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint/myaccesspoint");
            outpost = arn.ParseOutpost();
            Assert.IsTrue(arn.IsOutpostArn());
            Assert.AreEqual("op-01234567890123456", outpost.OutpostId);
            Assert.AreEqual("myaccesspoint", outpost.AccessPointName);
            Assert.AreEqual("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint", outpost.FullAccessPointName);

            arn = Arn.Parse("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint/myaccesspoint/foo.txt");
            outpost = arn.ParseOutpost();
            Assert.IsTrue(arn.IsOutpostArn());
            Assert.AreEqual("op-01234567890123456", outpost.OutpostId);
            Assert.AreEqual("myaccesspoint", outpost.AccessPointName);
            Assert.AreEqual("foo.txt", outpost.Key);
            Assert.AreEqual("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint", outpost.FullAccessPointName);

            arn = Arn.Parse("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint/myaccesspoint/folder/foo.txt");
            outpost = arn.ParseOutpost();
            Assert.IsTrue(arn.IsOutpostArn());
            Assert.AreEqual("op-01234567890123456", outpost.OutpostId);
            Assert.AreEqual("myaccesspoint", outpost.AccessPointName);
            Assert.AreEqual("folder/foo.txt", outpost.Key);
            Assert.AreEqual("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint", outpost.FullAccessPointName);
        }

        [DataTestMethod]
        [TestCategory("S3")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accespoint:myaccesspoint")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-012345678.90123456:accespoint:myaccesspoint")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456/accespoindt/myaccesspoint")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost::accespoint:myaccesspoint")]
        [ExpectedException(typeof(AmazonClientException))]
        public void ParseOutpostBadInput(string input)
        {
            Arn.Parse(input).ParseOutpost();
        }
    }
}