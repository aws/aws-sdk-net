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

using Amazon.Runtime.Internal.Compression;
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Moq;
using Amazon.Runtime.Internal;
using Amazon.CloudFront.Model;
using Castle.Core.Internal;
using System.Runtime.Remoting.Messaging;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class CompressionAlgorithmUtilsTests
    {
        [DataRow("foo", "foo,gzip")]
        [DataRow(null, "gzip")]
        [DataTestMethod]
        public void SetRequestHeaderTest(string existingHeaderValue, string resultHeaderValue)
        {
            var mock = new Mock<IRequest>();
            var headers = new Dictionary<string, string>();
            var request = mock.Object;
            mock.SetupGet(x => x.Headers).Returns(headers);

            if (existingHeaderValue != null)
            {
                headers.Add("Content-Encoding", existingHeaderValue);
            }
            
            CompressionAlgorithmUtils.SetRequestHeader(request, CompressionEncodingAlgorithm.gzip);

            Assert.AreEqual(request.Headers["Content-Encoding"], resultHeaderValue);
        }

        [DataTestMethod]
        public void SetRequestHeaderNoneTest()
        {
            var mock = new Mock<IRequest>();
            var headers = new Dictionary<string, string>();
            var request = mock.Object;
            mock.SetupGet(x => x.Headers).Returns(headers);

            Assert.ThrowsException<ArgumentException>(
                () => CompressionAlgorithmUtils.SetRequestHeader(request, CompressionEncodingAlgorithm.NONE)
            );
        }

        [DataRow(CompressionEncodingAlgorithm.gzip)]
        [DataRow(CompressionEncodingAlgorithm.NONE)]
        [DataTestMethod]
        public void SetCompressionAlgorithmTest(CompressionEncodingAlgorithm encodingAlgorithm)
        {
            var mock = new Mock<IRequest>();
            var request = mock.Object;
            mock.SetupProperty(x => x.CompressionAlgorithm);

            CompressionAlgorithmUtils.SetCompressionAlgorithm(request, encodingAlgorithm);
            Assert.AreEqual(request.CompressionAlgorithm, encodingAlgorithm);
        }
    }
}
