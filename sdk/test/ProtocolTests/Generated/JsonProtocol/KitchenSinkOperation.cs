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
using Amazon.JsonProtocol;
using Amazon.JsonProtocol.Model;
using Amazon.JsonProtocol.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AWSSDK.ProtocolTests.JsonProtocol
{
    [TestClass]
    public class KitchenSinkOperation
    {
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_string_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                String = "abc xyz",
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"String\":\"abc xyz\"}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_string_shapes_with_jsonvalue_traitRequest()
        {
            var request = new KitchenSinkOperationRequest{
                JsonValue = "{\"string\":\"value\",\"number\":1234.5,\"boolTrue\":true,\"boolFalse\":false,\"array\":[1,2,3,4],\"object\":{\"key\":\"value\"},\"null\":null}",
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"JsonValue\":\"{\\\"string\\\":\\\"value\\\",\\\"number\\\":1234.5,\\\"boolTrue\\\":true,\\\"boolFalse\\\":false,\\\"array\\\":[1,2,3,4],\\\"object\\\":{\\\"key\\\":\\\"value\\\"},\\\"null\\\":null}\"}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_integer_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                Integer = 1234,
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"Integer\":1234}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_long_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                Long = 999999999999,
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"Long\":999999999999}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_float_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                Float = 1234.5F,
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"Float\":1234.5}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_double_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                Double = 1234.5,
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"Double\":1234.5}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_blob_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                Blob = new MemoryStream(Encoding.UTF8.GetBytes("binary-value")),
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"Blob\":\"YmluYXJ5LXZhbHVl\"}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_boolean_shapes_trueRequest()
        {
            var request = new KitchenSinkOperationRequest{
                Boolean = true,
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"Boolean\":true}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_boolean_shapes_falseRequest()
        {
            var request = new KitchenSinkOperationRequest{
                Boolean = false,
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"Boolean\":false}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_timestamp_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                Timestamp = ProtocolTestConstants.epoch.AddSeconds(946845296),
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"Timestamp\":946845296}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_timestamp_shapes_with_iso8601_timestampformatRequest()
        {
            var request = new KitchenSinkOperationRequest{
                Iso8601Timestamp = ProtocolTestConstants.epoch.AddSeconds(946845296),
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"Iso8601Timestamp\":\"2000-01-02T20:34:56Z\"}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_timestamp_shapes_with_httpdate_timestampformatRequest()
        {
            var request = new KitchenSinkOperationRequest{
                HttpdateTimestamp = ProtocolTestConstants.epoch.AddSeconds(946845296),
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"HttpdateTimestamp\":\"Sun, 02 Jan 2000 20:34:56 GMT\"}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_timestamp_shapes_with_unixtimestamp_timestampformatRequest()
        {
            var request = new KitchenSinkOperationRequest{
                UnixTimestamp = ProtocolTestConstants.epoch.AddSeconds(946845296),
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"UnixTimestamp\":946845296}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_list_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                ListOfStrings =  new List<string>()
                {
                    "abc",
                    "mno",
                    "xyz",
                },
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"ListOfStrings\":[\"abc\",\"mno\",\"xyz\"]}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_empty_list_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                ListOfStrings =  new List<string>()
                {
                },
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"ListOfStrings\":[]}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_list_of_map_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                ListOfMapsOfStrings =  new List<Dictionary<string,string>>()
                {
                    new Dictionary<string, string>()
                    {
                        {"foo", "bar"},
                    },
                    new Dictionary<string, string>()
                    {
                        {"abc", "xyz"},
                    },
                    new Dictionary<string, string>()
                    {
                        {"red", "blue"},
                    },
                },
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"ListOfMapsOfStrings\":[{\"foo\":\"bar\"},{\"abc\":\"xyz\"},{\"red\":\"blue\"}]}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_list_of_structure_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                ListOfStructs =  new List<SimpleStruct>()
                {
                    new SimpleStruct{
                        Value = "abc",
                    },
                    new SimpleStruct{
                        Value = "mno",
                    },
                    new SimpleStruct{
                        Value = "xyz",
                    },
                },
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"ListOfStructs\":[{\"Value\":\"abc\"},{\"Value\":\"mno\"},{\"Value\":\"xyz\"}]}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_list_of_recursive_structure_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                RecursiveList =  new List<KitchenSink>()
                {
                    new KitchenSink{
                        RecursiveList =  new List<KitchenSink>()
                        {
                            new KitchenSink{
                                RecursiveList =  new List<KitchenSink>()
                                {
                                    new KitchenSink{
                                        Integer = 123,
                                    },
                                },
                            },
                        },
                    },
                },
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"RecursiveList\":[{\"RecursiveList\":[{\"RecursiveList\":[{\"Integer\":123}]}]}]}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_map_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                MapOfStrings = new Dictionary<string, string>()
                {
                    {"abc", "xyz"},
                    {"mno", "hjk"},
                },
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"MapOfStrings\":{\"abc\":\"xyz\",\"mno\":\"hjk\"}}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_empty_map_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                MapOfStrings = new Dictionary<string, string>()
                {
                },
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"MapOfStrings\":{}}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_map_of_list_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                MapOfListsOfStrings = new Dictionary<string, List<string>>()
                {
                    {"abc",  new List<string>()
                    {
                        "abc",
                        "xyz",
                    }},
                    {"mno",  new List<string>()
                    {
                        "xyz",
                        "abc",
                    }},
                },
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"MapOfListsOfStrings\":{\"abc\":[\"abc\",\"xyz\"],\"mno\":[\"xyz\",\"abc\"]}}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_map_of_structure_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                MapOfStructs = new Dictionary<string, SimpleStruct>()
                {
                    {"key1", new SimpleStruct{
                        Value = "value-1",
                    }},
                    {"key2", new SimpleStruct{
                        Value = "value-2",
                    }},
                },
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"MapOfStructs\":{\"key1\":{\"Value\":\"value-1\"},\"key2\":{\"Value\":\"value-2\"}}}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_map_of_recursive_structure_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                RecursiveMap = new Dictionary<string, KitchenSink>()
                {
                    {"key1", new KitchenSink{
                        RecursiveMap = new Dictionary<string, KitchenSink>()
                        {
                            {"key2", new KitchenSink{
                                RecursiveMap = new Dictionary<string, KitchenSink>()
                                {
                                    {"key3", new KitchenSink{
                                        Boolean = false,
                                    }},
                                },
                            }},
                        },
                    }},
                },
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"RecursiveMap\":{\"key1\":{\"RecursiveMap\":{\"key2\":{\"RecursiveMap\":{\"key3\":{\"Boolean\":false}}}}}}}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_structure_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                SimpleStruct = new SimpleStruct{
                    Value = "abc",
                },
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"SimpleStruct\":{\"Value\":\"abc\"}}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_structure_members_with_locationname_traitsRequest()
        {
            var request = new KitchenSinkOperationRequest{
                StructWithJsonName = new StructWithJsonName{
                    Value = "some-value",
                },
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"StructWithJsonName\":{\"Value\":\"some-value\"}}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_empty_structure_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                SimpleStruct = new SimpleStruct{
                },
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"SimpleStruct\":{}}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_structure_which_have_no_membersRequest()
        {
            var request = new KitchenSinkOperationRequest{
                EmptyStruct = new EmptyStruct{
                },
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"EmptyStruct\":{}}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void serializes_recursive_structure_shapesRequest()
        {
            var request = new KitchenSinkOperationRequest{
                String = "top-value",
                Boolean = false,
                RecursiveStruct = new KitchenSink{
                    String = "nested-value",
                    Boolean = true,
                    RecursiveList =  new List<KitchenSink>()
                    {
                        new KitchenSink{
                            String = "string-only",
                        },
                        new KitchenSink{
                            RecursiveStruct = new KitchenSink{
                                MapOfStrings = new Dictionary<string, string>()
                                {
                                    {"color", "red"},
                                    {"size", "large"},
                                },
                            },
                        },
                    },
                },
            };
            var config = new AmazonJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new KitchenSinkOperationRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
            JObject expectedJObj = JsonConvert.DeserializeObject<JObject>("{\"String\":\"top-value\",\"Boolean\":false,\"RecursiveStruct\":{\"String\":\"nested-value\",\"Boolean\":true,\"RecursiveList\":[{\"String\":\"string-only\"},{\"RecursiveStruct\":{\"MapOfStrings\":{\"color\":\"red\",\"size\":\"large\"}}}]}}");
            Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", actualUri.AbsolutePath);
            Assert.AreEqual( "application/x-amz-json-1.1", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "JsonProtocol.KitchenSinkOperation", marshalledRequest.Headers["X-Amz-Target"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_operations_with_empty_json_bodiesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_string_shapesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"String\":\"string-value\"}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                String = "string-value",
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_integer_shapesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"Integer\":1234}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                Integer = 1234,
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_long_shapesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"Long\":1234567890123456789}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                Long = 1234567890123456789,
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_float_shapesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"Float\":1234.5}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                Float = 1234.5F,
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_double_shapesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"Double\":123456789.12345679}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                Double = 1.2345678912345679E8,
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_boolean_shapes_trueResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"Boolean\":true}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                Boolean = true,
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_boolean_falseResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"Boolean\":false}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                Boolean = false,
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_blob_shapesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"Blob\":\"YmluYXJ5LXZhbHVl\"}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                Blob = new MemoryStream(Encoding.UTF8.GetBytes("binary-value")),
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_timestamp_shapesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"Timestamp\":946845296}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                Timestamp = ProtocolTestConstants.epoch.AddSeconds(946845296),
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_iso8601_timestampsResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"Iso8601Timestamp\":\"2000-01-02T20:34:56Z\"}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                Iso8601Timestamp = ProtocolTestConstants.epoch.AddSeconds(946845296),
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_httpdate_timestampsResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"HttpdateTimestamp\":\"Sun, 02 Jan 2000 20:34:56 GMT\"}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                HttpdateTimestamp = ProtocolTestConstants.epoch.AddSeconds(946845296),
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_list_shapesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"ListOfStrings\":[\"abc\",\"mno\",\"xyz\"]}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                ListOfStrings =  new List<string>()
                {
                    "abc",
                    "mno",
                    "xyz",
                },
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_list_of_map_shapesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"ListOfMapsOfStrings\":[{\"size\":\"large\"},{\"color\":\"red\"}]}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                ListOfMapsOfStrings =  new List<Dictionary<string,string>>()
                {
                    new Dictionary<string, string>()
                    {
                        {"size", "large"},
                    },
                    new Dictionary<string, string>()
                    {
                        {"color", "red"},
                    },
                },
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_list_of_list_shapesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"ListOfLists\":[[\"abc\",\"mno\",\"xyz\"],[\"hjk\",\"qrs\",\"tuv\"]]}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                ListOfLists =  new List<List<string>>()
                {
                     new List<string>()
                    {
                        "abc",
                        "mno",
                        "xyz",
                    },
                     new List<string>()
                    {
                        "hjk",
                        "qrs",
                        "tuv",
                    },
                },
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_list_of_structure_shapesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"ListOfStructs\":[{\"Value\":\"value-1\"},{\"Value\":\"value-2\"}]}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                ListOfStructs =  new List<SimpleStruct>()
                {
                    new SimpleStruct{
                        Value = "value-1",
                    },
                    new SimpleStruct{
                        Value = "value-2",
                    },
                },
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_list_of_recursive_structure_shapesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"RecursiveList\":[{\"RecursiveList\":[{\"RecursiveList\":[{\"String\":\"value\"}]}]}]}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                RecursiveList =  new List<KitchenSink>()
                {
                    new KitchenSink{
                        RecursiveList =  new List<KitchenSink>()
                        {
                            new KitchenSink{
                                RecursiveList =  new List<KitchenSink>()
                                {
                                    new KitchenSink{
                                        String = "value",
                                    },
                                },
                            },
                        },
                    },
                },
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_map_shapesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"MapOfStrings\":{\"size\":\"large\",\"color\":\"red\"}}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                MapOfStrings = new Dictionary<string, string>()
                {
                    {"size", "large"},
                    {"color", "red"},
                },
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_map_of_list_shapesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"MapOfListsOfStrings\":{\"sizes\":[\"large\",\"small\"],\"colors\":[\"red\",\"green\"]}}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                MapOfListsOfStrings = new Dictionary<string, List<string>>()
                {
                    {"sizes",  new List<string>()
                    {
                        "large",
                        "small",
                    }},
                    {"colors",  new List<string>()
                    {
                        "red",
                        "green",
                    }},
                },
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_map_of_map_shapesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"MapOfMaps\":{\"sizes\":{\"large\":\"L\",\"medium\":\"M\"},\"colors\":{\"red\":\"R\",\"blue\":\"B\"}}}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                MapOfMaps = new Dictionary<string, Dictionary<string,string>>()
                {
                    {"sizes", new Dictionary<string, string>()
                    {
                        {"large", "L"},
                        {"medium", "M"},
                    }},
                    {"colors", new Dictionary<string, string>()
                    {
                        {"red", "R"},
                        {"blue", "B"},
                    }},
                },
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_map_of_structure_shapesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"MapOfStructs\":{\"size\":{\"Value\":\"small\"},\"color\":{\"Value\":\"red\"}}}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                MapOfStructs = new Dictionary<string, SimpleStruct>()
                {
                    {"size", new SimpleStruct{
                        Value = "small",
                    }},
                    {"color", new SimpleStruct{
                        Value = "red",
                    }},
                },
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_map_of_recursive_structure_shapesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\"RecursiveMap\":{\"key-1\":{\"RecursiveMap\":{\"key-2\":{\"RecursiveMap\":{\"key-3\":{\"String\":\"value\"}}}}}}}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
                RecursiveMap = new Dictionary<string, KitchenSink>()
                {
                    {"key-1", new KitchenSink{
                        RecursiveMap = new Dictionary<string, KitchenSink>()
                        {
                            {"key-2", new KitchenSink{
                                RecursiveMap = new Dictionary<string, KitchenSink>()
                                {
                                    {"key-3", new KitchenSink{
                                        String = "value",
                                    }},
                                },
                            }},
                        },
                    }},
                },
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void parses_the_request_id_from_the_responseResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            webResponseData.Headers["X-Amzn-Requestid"] = "amazon-uniq-request-id";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new KitchenSinkOperationResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new KitchenSinkOperationResponse{
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (KitchenSinkOperationResponse)unmarshalledResponse;
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
        }
    }
}
