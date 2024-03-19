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
using AWSSDK_DotNet35.UnitTests.TestTools;
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
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2SimpleInputParamsStringsRequest()
        {
            var request = new SimpleInputParamsRequest{
                Foo = "val1",
                Bar = "val2",
            };
            var config = new AmazonEC2ProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&Foo=val1&Bar=val2");
            foreach(var queryParam in expectedParams.Keys){
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2SimpleInputParamsStringAndBooleanTrueRequest()
        {
            var request = new SimpleInputParamsRequest{
                Foo = "val1",
                Baz = true,
            };
            var config = new AmazonEC2ProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&Foo=val1&Baz=true");
            foreach(var queryParam in expectedParams.Keys){
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2SimpleInputParamsStringsAndBooleanFalseRequest()
        {
            var request = new SimpleInputParamsRequest{
                Baz = false,
            };
            var config = new AmazonEC2ProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&Baz=false");
            foreach(var queryParam in expectedParams.Keys){
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2SimpleInputParamsIntegerRequest()
        {
            var request = new SimpleInputParamsRequest{
                Bam = 10,
            };
            var config = new AmazonEC2ProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&Bam=10");
            foreach(var queryParam in expectedParams.Keys){
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2SimpleInputParamsFloatRequest()
        {
            var request = new SimpleInputParamsRequest{
                Boo = 10.8,
            };
            var config = new AmazonEC2ProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&Boo=10.8");
            foreach(var queryParam in expectedParams.Keys){
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2SimpleInputParamsBlobRequest()
        {
            var request = new SimpleInputParamsRequest{
                Qux = new MemoryStream(Encoding.UTF8.GetBytes("value")),
            };
            var config = new AmazonEC2ProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&Qux=dmFsdWU%3D");
            foreach(var queryParam in expectedParams.Keys){
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2EnumsRequest()
        {
            var request = new SimpleInputParamsRequest{
                FooEnum = "Foo",
            };
            var config = new AmazonEC2ProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&FooEnum=Foo");
            foreach(var queryParam in expectedParams.Keys){
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2QueryRequest()
        {
            var request = new SimpleInputParamsRequest{
                HasQueryName = "Hi",
            };
            var config = new AmazonEC2ProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&A=Hi");
            foreach(var queryParam in expectedParams.Keys){
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2QueryIsPreferredRequest()
        {
            var request = new SimpleInputParamsRequest{
                HasQueryAndXmlName = "Hi",
            };
            var config = new AmazonEC2ProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&B=Hi");
            foreach(var queryParam in expectedParams.Keys){
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2XmlNameIsUppercasedRequest()
        {
            var request = new SimpleInputParamsRequest{
                UsesXmlName = "Hi",
            };
            var config = new AmazonEC2ProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&C=Hi");
            foreach(var queryParam in expectedParams.Keys){
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2QuerySupportsNaNFloatInputsRequest()
        {
            var request = new SimpleInputParamsRequest{
                FloatValue = float.NaN,
                Boo = double.NaN,
            };
            var config = new AmazonEC2ProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&FloatValue=NaN&Boo=NaN");
            foreach(var queryParam in expectedParams.Keys){
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2QuerySupportsInfinityFloatInputsRequest()
        {
            var request = new SimpleInputParamsRequest{
                FloatValue = float.PositiveInfinity,
                Boo = double.PositiveInfinity,
            };
            var config = new AmazonEC2ProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&FloatValue=Infinity&Boo=Infinity");
            foreach(var queryParam in expectedParams.Keys){
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2QuerySupportsNegativeInfinityFloatInputsRequest()
        {
            var request = new SimpleInputParamsRequest{
                FloatValue = float.NegativeInfinity,
                Boo = double.NegativeInfinity,
            };
            var config = new AmazonEC2ProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleInputParamsRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=SimpleInputParams&Version=2020-01-08&FloatValue=-Infinity&Boo=-Infinity");
            foreach(var queryParam in expectedParams.Keys){
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }
    }
}
