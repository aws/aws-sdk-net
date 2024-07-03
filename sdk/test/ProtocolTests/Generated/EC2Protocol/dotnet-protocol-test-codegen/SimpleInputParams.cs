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

/*
 * Do not modify this file. This file is generated.
 */
using AWSSDK.ProtocolTests;
using AWSSDK.ProtocolTests.Utils;
using AWSSDK_DotNet.UnitTests.TestTools;
using Amazon.EC2Protocol;
using Amazon.EC2Protocol.Model;
using Amazon.EC2Protocol.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace AWSSDK.ProtocolTests.AwsEc2
{
    [TestClass]
    public class SimpleInputParams
    {
        /// <summary>
        /// Serializes strings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2SimpleInputParamsStringsRequest()
        {
            // Arrange
            var request = new SimpleInputParamsRequest
            {
                Foo = "val1",
                Bar = "val2",
            };
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&Foo=val1&Bar=val2");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// Serializes booleans that are true
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2SimpleInputParamsStringAndBooleanTrueRequest()
        {
            // Arrange
            var request = new SimpleInputParamsRequest
            {
                Foo = "val1",
                Baz = true,
            };
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&Foo=val1&Baz=true");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// Serializes booleans that are false
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2SimpleInputParamsStringsAndBooleanFalseRequest()
        {
            // Arrange
            var request = new SimpleInputParamsRequest
            {
                Baz = false,
            };
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&Baz=false");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// Serializes integers
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2SimpleInputParamsIntegerRequest()
        {
            // Arrange
            var request = new SimpleInputParamsRequest
            {
                Bam = 10,
            };
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&Bam=10");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// Serializes floats
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2SimpleInputParamsFloatRequest()
        {
            // Arrange
            var request = new SimpleInputParamsRequest
            {
                Boo = 10.8,
            };
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&Boo=10.8");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// Blobs are base64 encoded in the query string
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2SimpleInputParamsBlobRequest()
        {
            // Arrange
            var request = new SimpleInputParamsRequest
            {
                Qux = new MemoryStream(Encoding.UTF8.GetBytes("value")),
            };
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&Qux=dmFsdWU%3D");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// Serializes enums in the query string
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2EnumsRequest()
        {
            // Arrange
            var request = new SimpleInputParamsRequest
            {
                FooEnum = "Foo",
            };
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&FooEnum=Foo");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// Serializes query using ec2QueryName trait.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2QueryRequest()
        {
            // Arrange
            var request = new SimpleInputParamsRequest
            {
                HasQueryName = "Hi",
            };
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&HasQueryName=Hi");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// ec2QueryName trait is preferred over xmlName.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2QueryIsPreferredRequest()
        {
            // Arrange
            var request = new SimpleInputParamsRequest
            {
                HasQueryAndXmlName = "Hi",
            };
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&HasQueryAndXmlName=Hi");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// xmlName is used with the ec2 protocol, but the first character is
        /// uppercased
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2XmlNameIsUppercasedRequest()
        {
            // Arrange
            var request = new SimpleInputParamsRequest
            {
                UsesXmlName = "Hi",
            };
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&UsesXmlName=Hi");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// Supports handling NaN float values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2QuerySupportsNaNFloatInputsRequest()
        {
            // Arrange
            var request = new SimpleInputParamsRequest
            {
                FloatValue = float.NaN,
                Boo = double.NaN,
            };
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&FloatValue=NaN&Boo=NaN");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// Supports handling Infinity float values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2QuerySupportsInfinityFloatInputsRequest()
        {
            // Arrange
            var request = new SimpleInputParamsRequest
            {
                FloatValue = float.PositiveInfinity,
                Boo = double.PositiveInfinity,
            };
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&FloatValue=Infinity&Boo=Infinity");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// Supports handling -Infinity float values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2QuerySupportsNegativeInfinityFloatInputsRequest()
        {
            // Arrange
            var request = new SimpleInputParamsRequest
            {
                FloatValue = float.NegativeInfinity,
                Boo = double.NegativeInfinity,
            };
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&FloatValue=-Infinity&Boo=-Infinity");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

    }
}
