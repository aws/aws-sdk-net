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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.IO;
using System.Net;
using static AWSSDK.UnitTests.HttpHandlerTests;
using Amazon.Runtime.Internal.Auth;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.S3.Model;
using Amazon.S3;
using System.Globalization;

namespace AWSSDK.UnitTests
{
    //This test class aligns with:
    //https://github.com/smithy-lang/smithy/blob/main/smithy-aws-protocol-tests/model/restJson1/http-labels.smithy#L43
    [TestClass]
    public class HttpLabelTests
    {
        //Smithy Tests asssume UNIX epoch time with no milliseconds in the ISO8601 format
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        DateTime StartDate = epoch.AddSeconds(1576540098);
        [TestMethod]
        public void RestJsonInputWithHeadersAndAllParamsSigV4()
        {

            HttpRequestWithLabelsInput request = new HttpRequestWithLabelsInput
            {
                StringProperty = "string",
                IntProperty = 2,
                LongProperty = 3,
                FloatProperty = 4.1F,
                DoubleProperty = 5.1,
                BooleanProperty = true,
                DateTimeProperty = StartDate,
                IsGreedy = false,
            };
            var requestContext = CreateRequestContextForHttpRequestWithLabelsInput(request);
            requestContext.Request.SignatureVersion = SignatureVersion.SigV4;
            var actualUrl = AmazonServiceClient.ComposeUrl(requestContext.Request);
            var expectedUrl = new Uri("http://testendpoint/HttpRequestWithLabels/string/2/3/4.1/5.1/true/2019-12-16T23%3A48%3A18Z");
            Assert.AreEqual(expectedUrl, actualUrl);
        }
        [TestMethod]
        public void RestJsonInputWithHeadersAndAllParamsSigV2()
        {

            HttpRequestWithLabelsInput request = new HttpRequestWithLabelsInput
            {
                StringProperty = "string",
                IntProperty = 2,
                LongProperty = 3,
                FloatProperty = 4.1F,
                DoubleProperty = 5.1,
                BooleanProperty = true,
                DateTimeProperty = StartDate,
                IsGreedy = false,
            };
            var requestContext = CreateRequestContextForHttpRequestWithLabelsInput(request);
            requestContext.Request.SignatureVersion = SignatureVersion.SigV2;
            var actualUrl = AmazonServiceClient.ComposeUrl(requestContext.Request);
            var expectedUrl = new Uri("http://testendpoint/HttpRequestWithLabels/string/2/3/4.1/5.1/true/2019-12-16T23%3A48%3A18Z");
            Assert.AreEqual(expectedUrl, actualUrl);
        }
        [TestMethod]
        public void RestJsonHttpRequestLabelEscapingSigV4()
        {
            HttpRequestWithLabelsInput request = new HttpRequestWithLabelsInput
            {
                StringProperty = " %:/?#[]@!$&'()*+,;=😹",
                IntProperty = 2,
                LongProperty = 3,
                FloatProperty = 4.1F,
                DoubleProperty = 5.1,
                BooleanProperty = true,
                DateTimeProperty = StartDate,
                IsGreedy = false
            };
            var requestContext = CreateRequestContextForHttpRequestWithLabelsInput(request);
            requestContext.Request.SignatureVersion = SignatureVersion.SigV4;
            var expectedUrl = new Uri("http://testendpoint/HttpRequestWithLabels/%20%25%3A%2F%3F%23%5B%5D%40%21%24%26%27%28%29%2A%2B%2C%3B%3D%F0%9F%98%B9/2/3/4.1/5.1/true/2019-12-16T23%3A48%3A18Z");
            var actualUrl = AmazonServiceClient.ComposeUrl(requestContext.Request);
            Assert.AreEqual(expectedUrl,actualUrl);
        }
        [TestMethod]
        public void RestJsonHttpRequestLabelEscapingSigV2()
        {
            HttpRequestWithLabelsInput request = new HttpRequestWithLabelsInput
            {
                StringProperty = " %:/?#[]@!$&'()*+,;=😹",
                IntProperty = 2,
                LongProperty = 3,
                FloatProperty = 4.1F,
                DoubleProperty = 5.1,
                BooleanProperty = true,
                DateTimeProperty = StartDate,
                IsGreedy = false
            };
            var requestContext = CreateRequestContextForHttpRequestWithLabelsInput(request);
            requestContext.Request.SignatureVersion = SignatureVersion.SigV2;
            var expectedUrl = new Uri("http://testendpoint/HttpRequestWithLabels/%20%25%3A%2F%3F%23%5B%5D%40%21%24%26%27%28%29%2A%2B%2C%3B%3D%F0%9F%98%B9/2/3/4.1/5.1/true/2019-12-16T23%3A48%3A18Z");
            var actualUrl = AmazonServiceClient.ComposeUrl(requestContext.Request);
            Assert.AreEqual(expectedUrl, actualUrl);
        }
        [TestMethod]
        public void HttpRequestWithGreedyLabelInPathSigV4()
        {
            HttpRequestWithLabelsInput request = new HttpRequestWithLabelsInput
            {
                IsGreedy = true,
                FooProperty = "hello/escape",
                BazProperty = "there/guy"
            };
            var requestContext = CreateRequestContextForHttpRequestWithLabelsInput(request);
            requestContext.Request.SignatureVersion = SignatureVersion.SigV4;
            var expectedUrl = new Uri("http://testendpoint/HttpRequestWithLabels/foo/hello%2Fescape/baz/there/guy");
            var actualUrl = AmazonServiceClient.ComposeUrl(requestContext.Request);
            Assert.AreEqual(expectedUrl, actualUrl);
        }
        [TestMethod]
        public void HttpRequestWithGreedyLabelInPathSigV2()
        {
            HttpRequestWithLabelsInput request = new HttpRequestWithLabelsInput
            {
                IsGreedy = true,
                FooProperty = "hello/escape",
                BazProperty = "there/guy"
            };
            var requestContext = CreateRequestContextForHttpRequestWithLabelsInput(request);
            requestContext.Request.SignatureVersion = SignatureVersion.SigV2;
            var expectedUrl = new Uri("http://testendpoint/HttpRequestWithLabels/foo/hello%2Fescape/baz/there/guy");
            var actualUrl = AmazonServiceClient.ComposeUrl(requestContext.Request);
            Assert.AreEqual(expectedUrl, actualUrl);
        }
        private IRequestContext CreateRequestContextForHttpRequestWithLabelsInput(HttpRequestWithLabelsInput request)
        {
            //no un marshaller necessary because we are only interested in the url
            var requestContext = new RequestContext(true, new NullSigner())
            {
                ClientConfig = null,
                Marshaller = new HttpRequestWithLabelsInputMarshaller(),
                OriginalRequest = request,
                Request = new HttpRequestWithLabelsInputMarshaller().Marshall(request)
            };
            requestContext.Request.Endpoint = new Uri(@"http://testendpoint");
            return requestContext;
        }
        public class HttpRequestWithLabelsInput : AmazonWebServiceRequest
        {
            public string StringProperty { get; set; }
            public int IntProperty { get; set; }
            public long LongProperty { get; set; }
            public float FloatProperty { get; set; }
            public double DoubleProperty { get; set; }
            public bool BooleanProperty { get; set; }
            public DateTime DateTimeProperty { get; set; }
            public bool IsGreedy { get; set; }

            public string FooProperty { get; set; }
            public string BazProperty { get; set; } 
        }
        public class HttpRequestWithLabelsInputMarshaller : IMarshaller<IRequest, HttpRequestWithLabelsInput>, IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
        {
            public IRequest Marshall(AmazonWebServiceRequest input)
            {
                return this.Marshall((HttpRequestWithLabelsInput)input);
            }
            public IRequest Marshall(HttpRequestWithLabelsInput publicRequest)
            {
                IRequest request = new DefaultRequest(publicRequest, "Amazon.FakeService");
                request.HttpMethod = "GET";
                if (!publicRequest.IsGreedy)
                {
                    request.AddPathResource("{StringProperty}", StringUtils.FromString(publicRequest.StringProperty));
                    request.AddPathResource("{IntProperty}", StringUtils.FromInt(publicRequest.IntProperty));
                    request.AddPathResource("{LongProperty}", StringUtils.FromLong(publicRequest.LongProperty));
                    request.AddPathResource("{FloatProperty}", StringUtils.FromFloat(publicRequest.FloatProperty));
                    request.AddPathResource("{DoubleProperty}", StringUtils.FromDouble(publicRequest.DoubleProperty));
                    request.AddPathResource("{BooleanProperty}", StringUtils.FromBool(publicRequest.BooleanProperty));
                    request.AddPathResource("{DateTimeProperty}", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.DateTimeProperty));
                    request.ResourcePath = "/HttpRequestWithLabels/{StringProperty}/{IntProperty}/{LongProperty}/{FloatProperty}/{DoubleProperty}/{BooleanProperty}/{DateTimeProperty}";
                }
                if (publicRequest.IsGreedy)
                {
                    request.AddPathResource("{FooProperty}", StringUtils.FromString(publicRequest.FooProperty));
                    request.AddPathResource("{BazProperty+}", StringUtils.FromString(publicRequest.BazProperty));
                    request.ResourcePath = "/HttpRequestWithLabels/foo/{FooProperty}/baz/{BazProperty+}";
                }
                return request;
            }
            private static HttpRequestWithLabelsInputMarshaller _instance = new HttpRequestWithLabelsInputMarshaller();

            internal static HttpRequestWithLabelsInputMarshaller GetInstance()
            {
                return _instance;
            }

            /// <summary>
            /// Gets the singleton.
            /// </summary>  
            public static HttpRequestWithLabelsInputMarshaller Instance
            {
                get
                {
                    return _instance;
                }
            }
        }
    }
    
}
