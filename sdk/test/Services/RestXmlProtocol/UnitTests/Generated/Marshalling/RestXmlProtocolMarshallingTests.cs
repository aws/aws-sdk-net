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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.RestXmlProtocol;
using Amazon.RestXmlProtocol.Model;
using Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class RestXmlProtocolMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("restxml-tests-client");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void BodyWithXmlNameMarshallTest()
        {
            var operation = service_model.FindOperation("BodyWithXmlName");

            var request = InstantiateClassGenerator.Execute<BodyWithXmlNameRequest>(operation);
            var marshaller = new BodyWithXmlNameRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BodyWithXmlName", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = BodyWithXmlNameResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as BodyWithXmlNameResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DatetimeOffsetsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DatetimeOffsetsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = EmptyInputAndEmptyOutputResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as EmptyInputAndEmptyOutputResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void EndpointWithHostLabelHeaderOperationMarshallTest()
        {
            var operation = service_model.FindOperation("EndpointWithHostLabelHeaderOperation");

            var request = InstantiateClassGenerator.Execute<EndpointWithHostLabelHeaderOperationRequest>(operation);
            var marshaller = new EndpointWithHostLabelHeaderOperationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("EndpointWithHostLabelHeaderOperation", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void FlattenedXmlMapMarshallTest()
        {
            var operation = service_model.FindOperation("FlattenedXmlMap");

            var request = InstantiateClassGenerator.Execute<FlattenedXmlMapRequest>(operation);
            var marshaller = new FlattenedXmlMapRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("FlattenedXmlMap", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = FlattenedXmlMapResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as FlattenedXmlMapResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void FlattenedXmlMapWithXmlNameMarshallTest()
        {
            var operation = service_model.FindOperation("FlattenedXmlMapWithXmlName");

            var request = InstantiateClassGenerator.Execute<FlattenedXmlMapWithXmlNameRequest>(operation);
            var marshaller = new FlattenedXmlMapWithXmlNameRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("FlattenedXmlMapWithXmlName", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = FlattenedXmlMapWithXmlNameResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as FlattenedXmlMapWithXmlNameResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void FlattenedXmlMapWithXmlNamespaceMarshallTest()
        {
            var operation = service_model.FindOperation("FlattenedXmlMapWithXmlNamespace");

            var request = InstantiateClassGenerator.Execute<FlattenedXmlMapWithXmlNamespaceRequest>(operation);
            var marshaller = new FlattenedXmlMapWithXmlNamespaceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("FlattenedXmlMapWithXmlNamespace", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = FlattenedXmlMapWithXmlNamespaceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as FlattenedXmlMapWithXmlNamespaceResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = FractionalSecondsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as FractionalSecondsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GreetingWithErrorsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GreetingWithErrorsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GreetingWithErrorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GreetingWithErrorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpEnumPayloadResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpEnumPayloadResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpPayloadTraitsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpPayloadTraitsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void HttpPayloadWithMemberXmlNameMarshallTest()
        {
            var operation = service_model.FindOperation("HttpPayloadWithMemberXmlName");

            var request = InstantiateClassGenerator.Execute<HttpPayloadWithMemberXmlNameRequest>(operation);
            var marshaller = new HttpPayloadWithMemberXmlNameRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("HttpPayloadWithMemberXmlName", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpPayloadWithMemberXmlNameResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpPayloadWithMemberXmlNameResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpPayloadWithStructureResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpPayloadWithStructureResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpPayloadWithUnionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpPayloadWithUnionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void HttpPayloadWithXmlNameMarshallTest()
        {
            var operation = service_model.FindOperation("HttpPayloadWithXmlName");

            var request = InstantiateClassGenerator.Execute<HttpPayloadWithXmlNameRequest>(operation);
            var marshaller = new HttpPayloadWithXmlNameRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("HttpPayloadWithXmlName", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpPayloadWithXmlNameResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpPayloadWithXmlNameResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void HttpPayloadWithXmlNamespaceMarshallTest()
        {
            var operation = service_model.FindOperation("HttpPayloadWithXmlNamespace");

            var request = InstantiateClassGenerator.Execute<HttpPayloadWithXmlNamespaceRequest>(operation);
            var marshaller = new HttpPayloadWithXmlNamespaceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("HttpPayloadWithXmlNamespace", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpPayloadWithXmlNamespaceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpPayloadWithXmlNamespaceResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void HttpPayloadWithXmlNamespaceAndPrefixMarshallTest()
        {
            var operation = service_model.FindOperation("HttpPayloadWithXmlNamespaceAndPrefix");

            var request = InstantiateClassGenerator.Execute<HttpPayloadWithXmlNamespaceAndPrefixRequest>(operation);
            var marshaller = new HttpPayloadWithXmlNamespaceAndPrefixRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("HttpPayloadWithXmlNamespaceAndPrefix", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpPayloadWithXmlNamespaceAndPrefixResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpPayloadWithXmlNamespaceAndPrefixResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            // populate a dummy response object so we can copy the headers
            var dummyResponse = InstantiateClassGenerator.Execute<HttpPrefixHeadersResponse>();

            // Populate map of response headers for FooMap with prefix "X-Foo-".
            foreach (var kvpFooMap in dummyResponse.FooMap)
            {
                webResponse.Headers.Add($"X-Foo-{kvpFooMap.Key}", kvpFooMap.Value);
            }
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpPrefixHeadersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpPrefixHeadersResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpResponseCodeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpResponseCodeResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = HttpStringPayloadResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as HttpStringPayloadResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = IgnoreQueryParamsInResponseResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as IgnoreQueryParamsInResponseResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"X-IntegerList",$"{int.MaxValue.ToString(CultureInfo.InvariantCulture)}, {int.MaxValue.ToString(CultureInfo.InvariantCulture)}"},
                    {"X-Long",long.MaxValue.ToString(CultureInfo.InvariantCulture)},
                    {"X-Short",int.MaxValue.ToString(CultureInfo.InvariantCulture)},
                    {"X-String","X-String_Value"},
                    {"X-StringList","X-StringList_Value1, X-StringList_Value2"},
                    {"X-StringSet","X-StringSet_Value1, X-StringSet_Value2"},
                    {"X-TimestampList",$"{ValidatorUtils.GetTestDate(TimestampFormat.ISO8601)}, {ValidatorUtils.GetTestDate(TimestampFormat.ISO8601)}"},
                    {"X-Boolean1",bool.TrueString},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = InputAndOutputWithHeadersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as InputAndOutputWithHeadersResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void NestedXmlMapsMarshallTest()
        {
            var operation = service_model.FindOperation("NestedXmlMaps");

            var request = InstantiateClassGenerator.Execute<NestedXmlMapsRequest>(operation);
            var marshaller = new NestedXmlMapsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("NestedXmlMaps", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = NestedXmlMapsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as NestedXmlMapsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = NoInputAndOutputResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as NoInputAndOutputResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = NullAndEmptyHeadersClientResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as NullAndEmptyHeadersClientResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = NullAndEmptyHeadersServerResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as NullAndEmptyHeadersServerResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = SimpleScalarPropertiesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as SimpleScalarPropertiesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
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
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = TimestampFormatHeadersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as TimestampFormatHeadersResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void XmlAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("XmlAttributes");

            var request = InstantiateClassGenerator.Execute<XmlAttributesRequest>(operation);
            var marshaller = new XmlAttributesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("XmlAttributes", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = XmlAttributesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as XmlAttributesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void XmlAttributesOnPayloadMarshallTest()
        {
            var operation = service_model.FindOperation("XmlAttributesOnPayload");

            var request = InstantiateClassGenerator.Execute<XmlAttributesOnPayloadRequest>(operation);
            var marshaller = new XmlAttributesOnPayloadRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("XmlAttributesOnPayload", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = XmlAttributesOnPayloadResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as XmlAttributesOnPayloadResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void XmlBlobsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlBlobs");

            var request = InstantiateClassGenerator.Execute<XmlBlobsRequest>(operation);
            var marshaller = new XmlBlobsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("XmlBlobs", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = XmlBlobsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as XmlBlobsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void XmlEmptyBlobsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlEmptyBlobs");

            var request = InstantiateClassGenerator.Execute<XmlEmptyBlobsRequest>(operation);
            var marshaller = new XmlEmptyBlobsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("XmlEmptyBlobs", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = XmlEmptyBlobsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as XmlEmptyBlobsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void XmlEmptyListsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlEmptyLists");

            var request = InstantiateClassGenerator.Execute<XmlEmptyListsRequest>(operation);
            var marshaller = new XmlEmptyListsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("XmlEmptyLists", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = XmlEmptyListsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as XmlEmptyListsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void XmlEmptyMapsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlEmptyMaps");

            var request = InstantiateClassGenerator.Execute<XmlEmptyMapsRequest>(operation);
            var marshaller = new XmlEmptyMapsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("XmlEmptyMaps", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = XmlEmptyMapsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as XmlEmptyMapsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void XmlEmptyStringsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlEmptyStrings");

            var request = InstantiateClassGenerator.Execute<XmlEmptyStringsRequest>(operation);
            var marshaller = new XmlEmptyStringsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("XmlEmptyStrings", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = XmlEmptyStringsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as XmlEmptyStringsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void XmlEnumsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlEnums");

            var request = InstantiateClassGenerator.Execute<XmlEnumsRequest>(operation);
            var marshaller = new XmlEnumsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("XmlEnums", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = XmlEnumsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as XmlEnumsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void XmlIntEnumsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlIntEnums");

            var request = InstantiateClassGenerator.Execute<XmlIntEnumsRequest>(operation);
            var marshaller = new XmlIntEnumsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("XmlIntEnums", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = XmlIntEnumsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as XmlIntEnumsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void XmlListsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlLists");

            var request = InstantiateClassGenerator.Execute<XmlListsRequest>(operation);
            var marshaller = new XmlListsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("XmlLists", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = XmlListsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as XmlListsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void XmlMapsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlMaps");

            var request = InstantiateClassGenerator.Execute<XmlMapsRequest>(operation);
            var marshaller = new XmlMapsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("XmlMaps", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = XmlMapsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as XmlMapsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void XmlMapsXmlNameMarshallTest()
        {
            var operation = service_model.FindOperation("XmlMapsXmlName");

            var request = InstantiateClassGenerator.Execute<XmlMapsXmlNameRequest>(operation);
            var marshaller = new XmlMapsXmlNameRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("XmlMapsXmlName", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = XmlMapsXmlNameResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as XmlMapsXmlNameResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void XmlMapWithXmlNamespaceMarshallTest()
        {
            var operation = service_model.FindOperation("XmlMapWithXmlNamespace");

            var request = InstantiateClassGenerator.Execute<XmlMapWithXmlNamespaceRequest>(operation);
            var marshaller = new XmlMapWithXmlNamespaceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("XmlMapWithXmlNamespace", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = XmlMapWithXmlNamespaceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as XmlMapWithXmlNamespaceResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void XmlNamespacesMarshallTest()
        {
            var operation = service_model.FindOperation("XmlNamespaces");

            var request = InstantiateClassGenerator.Execute<XmlNamespacesRequest>(operation);
            var marshaller = new XmlNamespacesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("XmlNamespaces", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = XmlNamespacesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as XmlNamespacesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("RestXmlProtocol")]
        public void XmlTimestampsMarshallTest()
        {
            var operation = service_model.FindOperation("XmlTimestamps");

            var request = InstantiateClassGenerator.Execute<XmlTimestampsRequest>(operation);
            var marshaller = new XmlTimestampsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("XmlTimestamps", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = XmlTimestampsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as XmlTimestampsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}