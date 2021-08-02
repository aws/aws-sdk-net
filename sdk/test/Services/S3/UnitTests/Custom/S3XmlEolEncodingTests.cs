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
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3XmlEolEncodingTests
    {
        /// <summary>
        /// Tests that EOL characters in the body of an XML request are properly encoded
        /// </summary>
        /// <param name="objectKey">S3 object key containing one or more characters that are expected to be encoded</param>
        /// <param name="expectedEscapedKey">Expected value of the S3 object key after XML encoding</param>
        [DataTestMethod]
        [TestCategory("S3")]
        [DataRow("\n \n", "&#xA; &#xA;")]
        [DataRow("a\r\n b\n c\r", "a&#xD;&#xA; b&#xA; c&#xD;")]
        [DataRow("a\r\u0085 b\u0085", "a&#xD;&#x85; b&#x85;")]
        [DataRow("a\r\u2028 b\u0085 c\u2028", "a&#xD;&#x2028; b&#x85; c&#x2028;")]
        public void DeleteObjectsWithNewLinesTest(string objectKey, string expectedEscapedKey)
        {
            var request = new DeleteObjectsRequest
            {
                BucketName = "foo",
                Objects = new System.Collections.Generic.List<KeyVersion>
                {
                    new KeyVersion{ Key = objectKey }
                }
            };

            var internalRequest = S3ArnTestUtils.RunMockRequest(request, DeleteObjectsRequestMarshaller.Instance, new AmazonS3Config { RegionEndpoint = RegionEndpoint.USEast1 });
            var content = System.Text.Encoding.UTF8.GetString(internalRequest.Content);

            Assert.IsFalse(content.Contains(objectKey));
            Assert.IsTrue(content.Contains(expectedEscapedKey));
        }
    }
}
