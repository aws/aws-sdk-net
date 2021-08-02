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
using Amazon.S3Control;
using Amazon.S3Control.Model;
using Amazon.S3Control.Model.Internal.MarshallTransformations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class XmlEolEncodingTests
    {
        /// <summary>
        /// Tests that EOL characters are properly encoded in XML requests.
        /// This is a proxy for all generated XML marshallers.
        /// </summary>
        /// <param name="toEncode">Value of an XML element containing one or more characters expected to be encoded</param>
        /// <param name="expectedEncoding">Expected value of the XML element after encoding</param>
        [DataTestMethod]
        [TestCategory("S3Control")]
        [DataRow("\n \n", "&#xA; &#xA;")]
        [DataRow("a\r\n b\n c\r", "a&#xD;&#xA; b&#xA; c&#xD;")]
        [DataRow("a\r\u0085 b\u0085", "a&#xD;&#x85; b&#x85;")]
        [DataRow("a\r\u2028 b\u0085 c\u2028", "a&#xD;&#x2028; b&#x85; c&#x2028;")]
        public void MarshallXMLWithExtraEncodingTest(string toEncode, string expectedEncoding)
        {
            var request = new PutBucketTaggingRequest() 
            {
                AccountId = "0123456789",
                Bucket = "foo",
                Tagging = new Tagging()
                {
                    TagSet = new List<S3Tag>()
                    {
                       new S3Tag{Key = "foo", Value = toEncode }
                    }
                }
            };

            var internalRequest = S3ControlArnTestUtils.RunMockRequest(request, PutBucketTaggingRequestMarshaller.Instance, new AmazonS3ControlConfig { RegionEndpoint = RegionEndpoint.USEast1 });
            var requestContent = System.Text.Encoding.UTF8.GetString(internalRequest.Content);

            Assert.IsFalse(requestContent.Contains(toEncode));
            Assert.IsTrue(requestContent.Contains(expectedEncoding));
        }
    }
}
