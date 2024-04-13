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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.RestJsonProtocol;
using Amazon.RestJsonProtocol.Model;
using Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class RestJsonProtocolMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("restjson-tests-client");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void AllQueryStringTypesMarshallTest()
        {
            var operation = service_model.FindOperation("AllQueryStringTypes");

            var request = InstantiateClassGenerator.Execute<AllQueryStringTypesRequest>(operation);
            var marshaller = new AllQueryStringTypesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("AllQueryStringTypes", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void ConstantAndVariableQueryStringMarshallTest()
        {
            var operation = service_model.FindOperation("ConstantAndVariableQueryString");

            var request = InstantiateClassGenerator.Execute<ConstantAndVariableQueryStringRequest>(operation);
            var marshaller = new ConstantAndVariableQueryStringRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ConstantAndVariableQueryString", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void ConstantQueryStringMarshallTest()
        {
            var operation = service_model.FindOperation("ConstantQueryString");

            var request = InstantiateClassGenerator.Execute<ConstantQueryStringRequest>(operation);
            var marshaller = new ConstantQueryStringRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ConstantQueryString", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void DatetimeOffsetsMarshallTest()
        {
            var operation = service_model.FindOperation("DatetimeOffsets");

            var request = InstantiateClassGenerator.Execute<DatetimeOffsetsRequest>(operation);
            var marshaller = new DatetimeOffsetsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DatetimeOffsets", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DatetimeOffsetsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DatetimeOffsetsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void DocumentTypeMarshallTest()
        {
            var operation = service_model.FindOperation("DocumentType");

            var request = InstantiateClassGenerator.Execute<DocumentTypeRequest>(operation);
            var marshaller = new DocumentTypeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DocumentType", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DocumentTypeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DocumentTypeResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void DocumentTypeAsMapValueMarshallTest()
        {
            var operation = service_model.FindOperation("DocumentTypeAsMapValue");

            var request = InstantiateClassGenerator.Execute<DocumentTypeAsMapValueRequest>(operation);
            var marshaller = new DocumentTypeAsMapValueRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DocumentTypeAsMapValue", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DocumentTypeAsMapValueResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DocumentTypeAsMapValueResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void DocumentTypeAsPayloadMarshallTest()
        {
            var operation = service_model.FindOperation("DocumentTypeAsPayload");

            var request = InstantiateClassGenerator.Execute<DocumentTypeAsPayloadRequest>(operation);
            var marshaller = new DocumentTypeAsPayloadRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DocumentTypeAsPayload", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DocumentTypeAsPayloadResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DocumentTypeAsPayloadResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void EmptyInputAndEmptyOutputMarshallTest()
        {
            var operation = service_model.FindOperation("EmptyInputAndEmptyOutput");

            var request = InstantiateClassGenerator.Execute<EmptyInputAndEmptyOutputRequest>(operation);
            var marshaller = new EmptyInputAndEmptyOutputRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("EmptyInputAndEmptyOutput", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = EmptyInputAndEmptyOutputResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as EmptyInputAndEmptyOutputResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void EndpointOperationMarshallTest()
        {
            var operation = service_model.FindOperation("EndpointOperation");

            var request = InstantiateClassGenerator.Execute<EndpointOperationRequest>(operation);
            var marshaller = new EndpointOperationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("EndpointOperation", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void EndpointWithHostLabelOperationMarshallTest()
        {
            var operation = service_model.FindOperation("EndpointWithHostLabelOperation");

            var request = InstantiateClassGenerator.Execute<EndpointWithHostLabelOperationRequest>(operation);
            var marshaller = new EndpointWithHostLabelOperationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("EndpointWithHostLabelOperation", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void FractionalSecondsMarshallTest()
        {
            var operation = service_model.FindOperation("FractionalSeconds");

            var request = InstantiateClassGenerator.Execute<FractionalSecondsRequest>(operation);
            var marshaller = new FractionalSecondsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("FractionalSeconds", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = FractionalSecondsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as FractionalSecondsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void GreetingWithErrorsMarshallTest()
        {
            var operation = service_model.FindOperation("GreetingWithErrors");

            var request = InstantiateClassGenerator.Execute<GreetingWithErrorsRequest>(operation);
            var marshaller = new GreetingWithErrorsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GreetingWithErrors", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"X-Greeting","X-Greeting_Value"},
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GreetingWithErrorsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GreetingWithErrorsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void GreetingWithErrors_ComplexErrorExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GreetingWithErrors");

            var request = InstantiateClassGenerator.Execute<GreetingWithErrorsRequest>(operation);
            var marshaller = new GreetingWithErrorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GreetingWithErrors", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ComplexErrorException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"X-Greeting","X-Greeting_Value"},
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ComplexErrorException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GreetingWithErrorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void GreetingWithErrors_FooErrorExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GreetingWithErrors");

            var request = InstantiateClassGenerator.Execute<GreetingWithErrorsRequest>(operation);
            var marshaller = new GreetingWithErrorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GreetingWithErrors", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("FooErrorException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"X-Greeting","X-Greeting_Value"},
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"FooErrorException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GreetingWithErrorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void GreetingWithErrors_InvalidGreetingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GreetingWithErrors");

            var request = InstantiateClassGenerator.Execute<GreetingWithErrorsRequest>(operation);
            var marshaller = new GreetingWithErrorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GreetingWithErrors", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidGreetingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"X-Greeting","X-Greeting_Value"},
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidGreetingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GreetingWithErrorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void HostWithPathOperationMarshallTest()
        {
            var operation = service_model.FindOperation("HostWithPathOperation");

            var request = InstantiateClassGenerator.Execute<HostWithPathOperationRequest>(operation);
            var marshaller = new HostWithPathOperationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("HostWithPathOperation", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void HttpChecksumRequiredMarshallTest()
        {
            var operation = service_model.FindOperation("HttpChecksumRequired");

            var request = InstantiateClassGenerator.Execute<HttpChecksumRequiredRequest>(operation);
            var marshaller = new HttpChecksumRequiredRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("HttpChecksumRequired", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpChecksumRequiredResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpChecksumRequiredResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void HttpEnumPayloadMarshallTest()
        {
            var operation = service_model.FindOperation("HttpEnumPayload");

            var request = InstantiateClassGenerator.Execute<HttpEnumPayloadRequest>(operation);
            var marshaller = new HttpEnumPayloadRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("HttpEnumPayload", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpEnumPayloadResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpEnumPayloadResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void HttpPayloadTraitsMarshallTest()
        {
            var operation = service_model.FindOperation("HttpPayloadTraits");

            var request = InstantiateClassGenerator.Execute<HttpPayloadTraitsRequest>(operation);
            var marshaller = new HttpPayloadTraitsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("HttpPayloadTraits", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"X-Foo","X-Foo_Value"},
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpPayloadTraitsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpPayloadTraitsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void HttpPayloadWithStructureMarshallTest()
        {
            var operation = service_model.FindOperation("HttpPayloadWithStructure");

            var request = InstantiateClassGenerator.Execute<HttpPayloadWithStructureRequest>(operation);
            var marshaller = new HttpPayloadWithStructureRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("HttpPayloadWithStructure", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpPayloadWithStructureResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpPayloadWithStructureResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void HttpPayloadWithUnionMarshallTest()
        {
            var operation = service_model.FindOperation("HttpPayloadWithUnion");

            var request = InstantiateClassGenerator.Execute<HttpPayloadWithUnionRequest>(operation);
            var marshaller = new HttpPayloadWithUnionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("HttpPayloadWithUnion", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpPayloadWithUnionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpPayloadWithUnionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void HttpPrefixHeadersMarshallTest()
        {
            var operation = service_model.FindOperation("HttpPrefixHeaders");

            var request = InstantiateClassGenerator.Execute<HttpPrefixHeadersRequest>(operation);
            var marshaller = new HttpPrefixHeadersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("HttpPrefixHeaders", request, internalRequest, service_model);

            // Validate request headers in FooMap (prefix 'X-Foo-')
            foreach (var kvpFooMap in request.FooMap)
            {
                Assert.AreEqual(kvpFooMap.Value, internalRequest.Headers[$"X-Foo-{kvpFooMap.Key}"]);
            }
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"X-Foo","X-Foo_Value"},
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };

            // populate a dummy response object so we can copy the headers
            var dummyResponse = InstantiateClassGenerator.Execute<HttpPrefixHeadersResponse>();

            // Populate map of response headers for FooMap with prefix "X-Foo-".
            foreach (var kvpFooMap in dummyResponse.FooMap)
            {
                webResponse.Headers.Add($"X-Foo-{kvpFooMap.Key}", kvpFooMap.Value);
            }
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpPrefixHeadersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpPrefixHeadersResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
            // Validate response headers for FooMap with prefix "X-Foo-".
            foreach (var kvpFooMap in dummyResponse.FooMap)
            {
                Assert.AreEqual(response.FooMap[kvpFooMap.Key], kvpFooMap.Value);
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void HttpPrefixHeadersInResponseMarshallTest()
        {
            var operation = service_model.FindOperation("HttpPrefixHeadersInResponse");

            var request = InstantiateClassGenerator.Execute<HttpPrefixHeadersInResponseRequest>(operation);
            var marshaller = new HttpPrefixHeadersInResponseRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("HttpPrefixHeadersInResponse", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };

            // populate a dummy response object so we can copy the headers
            var dummyResponse = InstantiateClassGenerator.Execute<HttpPrefixHeadersInResponseResponse>();

            // Populate map of response headers for PrefixHeaders with prefix "".
            foreach (var kvpPrefixHeaders in dummyResponse.PrefixHeaders)
            {
                webResponse.Headers.Add($"{kvpPrefixHeaders.Key}", kvpPrefixHeaders.Value);
            }
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpPrefixHeadersInResponseResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpPrefixHeadersInResponseResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
            // Validate response headers for PrefixHeaders with prefix "".
            foreach (var kvpPrefixHeaders in dummyResponse.PrefixHeaders)
            {
                Assert.AreEqual(response.PrefixHeaders[kvpPrefixHeaders.Key], kvpPrefixHeaders.Value);
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void HttpRequestWithFloatLabelsMarshallTest()
        {
            var operation = service_model.FindOperation("HttpRequestWithFloatLabels");

            var request = InstantiateClassGenerator.Execute<HttpRequestWithFloatLabelsRequest>(operation);
            var marshaller = new HttpRequestWithFloatLabelsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("HttpRequestWithFloatLabels", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void HttpRequestWithGreedyLabelInPathMarshallTest()
        {
            var operation = service_model.FindOperation("HttpRequestWithGreedyLabelInPath");

            var request = InstantiateClassGenerator.Execute<HttpRequestWithGreedyLabelInPathRequest>(operation);
            var marshaller = new HttpRequestWithGreedyLabelInPathRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("HttpRequestWithGreedyLabelInPath", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void HttpRequestWithLabelsMarshallTest()
        {
            var operation = service_model.FindOperation("HttpRequestWithLabels");

            var request = InstantiateClassGenerator.Execute<HttpRequestWithLabelsRequest>(operation);
            var marshaller = new HttpRequestWithLabelsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("HttpRequestWithLabels", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void HttpRequestWithLabelsAndTimestampFormatMarshallTest()
        {
            var operation = service_model.FindOperation("HttpRequestWithLabelsAndTimestampFormat");

            var request = InstantiateClassGenerator.Execute<HttpRequestWithLabelsAndTimestampFormatRequest>(operation);
            var marshaller = new HttpRequestWithLabelsAndTimestampFormatRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("HttpRequestWithLabelsAndTimestampFormat", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void HttpRequestWithRegexLiteralMarshallTest()
        {
            var operation = service_model.FindOperation("HttpRequestWithRegexLiteral");

            var request = InstantiateClassGenerator.Execute<HttpRequestWithRegexLiteralRequest>(operation);
            var marshaller = new HttpRequestWithRegexLiteralRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("HttpRequestWithRegexLiteral", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void HttpResponseCodeMarshallTest()
        {
            var operation = service_model.FindOperation("HttpResponseCode");

            var request = InstantiateClassGenerator.Execute<HttpResponseCodeRequest>(operation);
            var marshaller = new HttpResponseCodeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("HttpResponseCode", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpResponseCodeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpResponseCodeResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void HttpStringPayloadMarshallTest()
        {
            var operation = service_model.FindOperation("HttpStringPayload");

            var request = InstantiateClassGenerator.Execute<HttpStringPayloadRequest>(operation);
            var marshaller = new HttpStringPayloadRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("HttpStringPayload", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpStringPayloadResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpStringPayloadResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void IgnoreQueryParamsInResponseMarshallTest()
        {
            var operation = service_model.FindOperation("IgnoreQueryParamsInResponse");

            var request = InstantiateClassGenerator.Execute<IgnoreQueryParamsInResponseRequest>(operation);
            var marshaller = new IgnoreQueryParamsInResponseRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("IgnoreQueryParamsInResponse", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = IgnoreQueryParamsInResponseResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as IgnoreQueryParamsInResponseResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void InputAndOutputWithHeadersMarshallTest()
        {
            var operation = service_model.FindOperation("InputAndOutputWithHeaders");

            var request = InstantiateClassGenerator.Execute<InputAndOutputWithHeadersRequest>(operation);
            var marshaller = new InputAndOutputWithHeadersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("InputAndOutputWithHeaders", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"X-BooleanList",$"{bool.TrueString}, {bool.TrueString}"},
                    {"X-Byte",int.MaxValue.ToString(CultureInfo.InvariantCulture)},
                    {"X-Double",double.MaxValue.ToString(CultureInfo.InvariantCulture)},
                    {"X-Enum","X-Enum_Value"},
                    {"X-EnumList","X-EnumList_Value1, X-EnumList_Value2"},
                    {"X-Boolean2",bool.TrueString},
                    {"X-Float",float.MaxValue.ToString(CultureInfo.InvariantCulture)},
                    {"X-Integer",int.MaxValue.ToString(CultureInfo.InvariantCulture)},
                    {"X-IntegerEnum",int.MaxValue.ToString(CultureInfo.InvariantCulture)},
                    {"X-IntegerEnumList",$"{int.MaxValue.ToString(CultureInfo.InvariantCulture)}, {int.MaxValue.ToString(CultureInfo.InvariantCulture)}"},
                    {"X-IntegerList",$"{int.MaxValue.ToString(CultureInfo.InvariantCulture)}, {int.MaxValue.ToString(CultureInfo.InvariantCulture)}"},
                    {"X-Long",long.MaxValue.ToString(CultureInfo.InvariantCulture)},
                    {"X-Short",int.MaxValue.ToString(CultureInfo.InvariantCulture)},
                    {"X-String","X-String_Value"},
                    {"X-StringList","X-StringList_Value1, X-StringList_Value2"},
                    {"X-StringSet","X-StringSet_Value1, X-StringSet_Value2"},
                    {"X-TimestampList",$"{ValidatorUtils.GetTestDate(TimestampFormat.UnixTimestamp)}, {ValidatorUtils.GetTestDate(TimestampFormat.UnixTimestamp)}"},
                    {"X-Boolean1",bool.TrueString},
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = InputAndOutputWithHeadersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as InputAndOutputWithHeadersResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void JsonBlobsMarshallTest()
        {
            var operation = service_model.FindOperation("JsonBlobs");

            var request = InstantiateClassGenerator.Execute<JsonBlobsRequest>(operation);
            var marshaller = new JsonBlobsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("JsonBlobs", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = JsonBlobsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as JsonBlobsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void JsonEnumsMarshallTest()
        {
            var operation = service_model.FindOperation("JsonEnums");

            var request = InstantiateClassGenerator.Execute<JsonEnumsRequest>(operation);
            var marshaller = new JsonEnumsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("JsonEnums", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = JsonEnumsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as JsonEnumsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void JsonIntEnumsMarshallTest()
        {
            var operation = service_model.FindOperation("JsonIntEnums");

            var request = InstantiateClassGenerator.Execute<JsonIntEnumsRequest>(operation);
            var marshaller = new JsonIntEnumsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("JsonIntEnums", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = JsonIntEnumsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as JsonIntEnumsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void JsonListsMarshallTest()
        {
            var operation = service_model.FindOperation("JsonLists");

            var request = InstantiateClassGenerator.Execute<JsonListsRequest>(operation);
            var marshaller = new JsonListsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("JsonLists", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = JsonListsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as JsonListsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void JsonMapsMarshallTest()
        {
            var operation = service_model.FindOperation("JsonMaps");

            var request = InstantiateClassGenerator.Execute<JsonMapsRequest>(operation);
            var marshaller = new JsonMapsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("JsonMaps", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = JsonMapsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as JsonMapsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void JsonTimestampsMarshallTest()
        {
            var operation = service_model.FindOperation("JsonTimestamps");

            var request = InstantiateClassGenerator.Execute<JsonTimestampsRequest>(operation);
            var marshaller = new JsonTimestampsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("JsonTimestamps", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = JsonTimestampsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as JsonTimestampsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void JsonUnionsMarshallTest()
        {
            var operation = service_model.FindOperation("JsonUnions");

            var request = InstantiateClassGenerator.Execute<JsonUnionsRequest>(operation);
            var marshaller = new JsonUnionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("JsonUnions", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = JsonUnionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as JsonUnionsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void MediaTypeHeaderMarshallTest()
        {
            var operation = service_model.FindOperation("MediaTypeHeader");

            var request = InstantiateClassGenerator.Execute<MediaTypeHeaderRequest>(operation);
            var marshaller = new MediaTypeHeaderRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("MediaTypeHeader", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"X-Json",Convert.ToBase64String(Encoding.UTF8.GetBytes("X-Json_Value"))},
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = MediaTypeHeaderResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as MediaTypeHeaderResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void NoInputAndNoOutputMarshallTest()
        {
            var operation = service_model.FindOperation("NoInputAndNoOutput");

            var request = InstantiateClassGenerator.Execute<NoInputAndNoOutputRequest>(operation);
            var marshaller = new NoInputAndNoOutputRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("NoInputAndNoOutput", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void NoInputAndOutputMarshallTest()
        {
            var operation = service_model.FindOperation("NoInputAndOutput");

            var request = InstantiateClassGenerator.Execute<NoInputAndOutputRequest>(operation);
            var marshaller = new NoInputAndOutputRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("NoInputAndOutput", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = NoInputAndOutputResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as NoInputAndOutputResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void NullAndEmptyHeadersClientMarshallTest()
        {
            var operation = service_model.FindOperation("NullAndEmptyHeadersClient");

            var request = InstantiateClassGenerator.Execute<NullAndEmptyHeadersClientRequest>(operation);
            var marshaller = new NullAndEmptyHeadersClientRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("NullAndEmptyHeadersClient", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"X-A","X-A_Value"},
                    {"X-B","X-B_Value"},
                    {"X-C","X-C_Value1, X-C_Value2"},
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = NullAndEmptyHeadersClientResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as NullAndEmptyHeadersClientResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void NullAndEmptyHeadersServerMarshallTest()
        {
            var operation = service_model.FindOperation("NullAndEmptyHeadersServer");

            var request = InstantiateClassGenerator.Execute<NullAndEmptyHeadersServerRequest>(operation);
            var marshaller = new NullAndEmptyHeadersServerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("NullAndEmptyHeadersServer", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"X-A","X-A_Value"},
                    {"X-B","X-B_Value"},
                    {"X-C","X-C_Value1, X-C_Value2"},
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = NullAndEmptyHeadersServerResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as NullAndEmptyHeadersServerResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void OmitsNullSerializesEmptyStringMarshallTest()
        {
            var operation = service_model.FindOperation("OmitsNullSerializesEmptyString");

            var request = InstantiateClassGenerator.Execute<OmitsNullSerializesEmptyStringRequest>(operation);
            var marshaller = new OmitsNullSerializesEmptyStringRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("OmitsNullSerializesEmptyString", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void OmitsSerializingEmptyListsMarshallTest()
        {
            var operation = service_model.FindOperation("OmitsSerializingEmptyLists");

            var request = InstantiateClassGenerator.Execute<OmitsSerializingEmptyListsRequest>(operation);
            var marshaller = new OmitsSerializingEmptyListsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("OmitsSerializingEmptyLists", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void PostUnionWithJsonNameMarshallTest()
        {
            var operation = service_model.FindOperation("PostUnionWithJsonName");

            var request = InstantiateClassGenerator.Execute<PostUnionWithJsonNameRequest>(operation);
            var marshaller = new PostUnionWithJsonNameRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PostUnionWithJsonName", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = PostUnionWithJsonNameResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as PostUnionWithJsonNameResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void PutWithContentEncodingMarshallTest()
        {
            var operation = service_model.FindOperation("PutWithContentEncoding");

            var request = InstantiateClassGenerator.Execute<PutWithContentEncodingRequest>(operation);
            var marshaller = new PutWithContentEncodingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutWithContentEncoding", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void QueryIdempotencyTokenAutoFillMarshallTest()
        {
            var operation = service_model.FindOperation("QueryIdempotencyTokenAutoFill");

            var request = InstantiateClassGenerator.Execute<QueryIdempotencyTokenAutoFillRequest>(operation);
            var marshaller = new QueryIdempotencyTokenAutoFillRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("QueryIdempotencyTokenAutoFill", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void QueryParamsAsStringListMapMarshallTest()
        {
            var operation = service_model.FindOperation("QueryParamsAsStringListMap");

            var request = InstantiateClassGenerator.Execute<QueryParamsAsStringListMapRequest>(operation);
            var marshaller = new QueryParamsAsStringListMapRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("QueryParamsAsStringListMap", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void QueryPrecedenceMarshallTest()
        {
            var operation = service_model.FindOperation("QueryPrecedence");

            var request = InstantiateClassGenerator.Execute<QueryPrecedenceRequest>(operation);
            var marshaller = new QueryPrecedenceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("QueryPrecedence", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void RecursiveShapesMarshallTest()
        {
            var operation = service_model.FindOperation("RecursiveShapes");

            var request = InstantiateClassGenerator.Execute<RecursiveShapesRequest>(operation);
            var marshaller = new RecursiveShapesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("RecursiveShapes", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = RecursiveShapesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as RecursiveShapesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void SimpleScalarPropertiesMarshallTest()
        {
            var operation = service_model.FindOperation("SimpleScalarProperties");

            var request = InstantiateClassGenerator.Execute<SimpleScalarPropertiesRequest>(operation);
            var marshaller = new SimpleScalarPropertiesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("SimpleScalarProperties", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"X-Foo","X-Foo_Value"},
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = SimpleScalarPropertiesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as SimpleScalarPropertiesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void TestBodyStructureMarshallTest()
        {
            var operation = service_model.FindOperation("TestBodyStructure");

            var request = InstantiateClassGenerator.Execute<TestBodyStructureRequest>(operation);
            var marshaller = new TestBodyStructureRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("TestBodyStructure", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-test-id","x-amz-test-id_Value"},
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = TestBodyStructureResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as TestBodyStructureResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void TestNoPayloadMarshallTest()
        {
            var operation = service_model.FindOperation("TestNoPayload");

            var request = InstantiateClassGenerator.Execute<TestNoPayloadRequest>(operation);
            var marshaller = new TestNoPayloadRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("TestNoPayload", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"X-Amz-Test-Id","X-Amz-Test-Id_Value"},
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = TestNoPayloadResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as TestNoPayloadResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void TestPayloadBlobMarshallTest()
        {
            var operation = service_model.FindOperation("TestPayloadBlob");

            var request = InstantiateClassGenerator.Execute<TestPayloadBlobRequest>(operation);
            var marshaller = new TestPayloadBlobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("TestPayloadBlob", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = TestPayloadBlobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as TestPayloadBlobResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void TestPayloadStructureMarshallTest()
        {
            var operation = service_model.FindOperation("TestPayloadStructure");

            var request = InstantiateClassGenerator.Execute<TestPayloadStructureRequest>(operation);
            var marshaller = new TestPayloadStructureRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("TestPayloadStructure", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-test-id","x-amz-test-id_Value"},
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = TestPayloadStructureResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as TestPayloadStructureResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void TimestampFormatHeadersMarshallTest()
        {
            var operation = service_model.FindOperation("TimestampFormatHeaders");

            var request = InstantiateClassGenerator.Execute<TimestampFormatHeadersRequest>(operation);
            var marshaller = new TimestampFormatHeadersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("TimestampFormatHeaders", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"X-defaultFormat",ValidatorUtils.GetTestDate(TimestampFormat.RFC822)},
                    {"X-memberDateTime",ValidatorUtils.GetTestDate(TimestampFormat.ISO8601)},
                    {"X-memberEpochSeconds",ValidatorUtils.GetTestDate(TimestampFormat.UnixTimestamp)},
                    {"X-memberHttpDate",ValidatorUtils.GetTestDate(TimestampFormat.RFC822)},
                    {"X-targetDateTime",ValidatorUtils.GetTestDate(TimestampFormat.ISO8601)},
                    {"X-targetEpochSeconds",ValidatorUtils.GetTestDate(TimestampFormat.UnixTimestamp)},
                    {"X-targetHttpDate",ValidatorUtils.GetTestDate(TimestampFormat.RFC822)},
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = TimestampFormatHeadersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as TimestampFormatHeadersResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonProtocol")]
        public void UnitInputAndOutputMarshallTest()
        {
            var operation = service_model.FindOperation("UnitInputAndOutput");

            var request = InstantiateClassGenerator.Execute<UnitInputAndOutputRequest>(operation);
            var marshaller = new UnitInputAndOutputRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UnitInputAndOutput", request, internalRequest, service_model);

        }
    }
}