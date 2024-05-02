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
 * Do not modify this file. This file is generated from the json-rpc-10-2020-07-14.normal.json service model.
 */


using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.JSONRPC10;
using Amazon.JSONRPC10.Model;
using Amazon.JSONRPC10.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet.UnitTests.TestTools;

namespace AWSSDK_DotNet.UnitTests.Marshalling
{
    [TestClass]
    public class JSONRPC10MarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("json10-tests-client");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("JSONRPC10")]
        public void EmptyInputAndEmptyOutputMarshallTest()
        {
            var operation = service_model.FindOperation("EmptyInputAndEmptyOutput");

            var request = InstantiateClassGenerator.Execute<EmptyInputAndEmptyOutputRequest>(operation);
            var marshaller = new EmptyInputAndEmptyOutputRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<EmptyInputAndEmptyOutputRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = EmptyInputAndEmptyOutputResponseUnmarshaller.Instance.Unmarshall(context) as EmptyInputAndEmptyOutputResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("JSONRPC10")]
        public void EndpointOperationMarshallTest()
        {
            var operation = service_model.FindOperation("EndpointOperation");

            var request = InstantiateClassGenerator.Execute<EndpointOperationRequest>(operation);
            var marshaller = new EndpointOperationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("JSONRPC10")]
        public void EndpointWithHostLabelOperationMarshallTest()
        {
            var operation = service_model.FindOperation("EndpointWithHostLabelOperation");

            var request = InstantiateClassGenerator.Execute<EndpointWithHostLabelOperationRequest>(operation);
            var marshaller = new EndpointWithHostLabelOperationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<EndpointWithHostLabelOperationRequest>(request,jsonRequest);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("JSONRPC10")]
        public void GreetingWithErrorsMarshallTest()
        {
            var operation = service_model.FindOperation("GreetingWithErrors");

            var request = InstantiateClassGenerator.Execute<GreetingWithErrorsRequest>(operation);
            var marshaller = new GreetingWithErrorsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GreetingWithErrorsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GreetingWithErrorsResponseUnmarshaller.Instance.Unmarshall(context) as GreetingWithErrorsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("JSONRPC10")]
        public void GreetingWithErrors_ComplexErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GreetingWithErrors");

            var request = InstantiateClassGenerator.Execute<GreetingWithErrorsRequest>(operation);
            var marshaller = new GreetingWithErrorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GreetingWithErrorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ComplexErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ComplexErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GreetingWithErrorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("JSONRPC10")]
        public void GreetingWithErrors_FooErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GreetingWithErrors");

            var request = InstantiateClassGenerator.Execute<GreetingWithErrorsRequest>(operation);
            var marshaller = new GreetingWithErrorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GreetingWithErrorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("FooErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"FooErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GreetingWithErrorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("JSONRPC10")]
        public void GreetingWithErrors_InvalidGreetingExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GreetingWithErrors");

            var request = InstantiateClassGenerator.Execute<GreetingWithErrorsRequest>(operation);
            var marshaller = new GreetingWithErrorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GreetingWithErrorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidGreetingException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidGreetingException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GreetingWithErrorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("JSONRPC10")]
        public void HostWithPathOperationMarshallTest()
        {
            var operation = service_model.FindOperation("HostWithPathOperation");

            var request = InstantiateClassGenerator.Execute<HostWithPathOperationRequest>(operation);
            var marshaller = new HostWithPathOperationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("JSONRPC10")]
        public void JsonUnionsMarshallTest()
        {
            var operation = service_model.FindOperation("JsonUnions");

            var request = InstantiateClassGenerator.Execute<JsonUnionsRequest>(operation);
            var marshaller = new JsonUnionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<JsonUnionsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = JsonUnionsResponseUnmarshaller.Instance.Unmarshall(context) as JsonUnionsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("JSONRPC10")]
        public void NoInputAndNoOutputMarshallTest()
        {
            var operation = service_model.FindOperation("NoInputAndNoOutput");

            var request = InstantiateClassGenerator.Execute<NoInputAndNoOutputRequest>(operation);
            var marshaller = new NoInputAndNoOutputRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("JSONRPC10")]
        public void NoInputAndOutputMarshallTest()
        {
            var operation = service_model.FindOperation("NoInputAndOutput");

            var request = InstantiateClassGenerator.Execute<NoInputAndOutputRequest>(operation);
            var marshaller = new NoInputAndOutputRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = NoInputAndOutputResponseUnmarshaller.Instance.Unmarshall(context) as NoInputAndOutputResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("JSONRPC10")]
        public void PutWithContentEncodingMarshallTest()
        {
            var operation = service_model.FindOperation("PutWithContentEncoding");

            var request = InstantiateClassGenerator.Execute<PutWithContentEncodingRequest>(operation);
            var marshaller = new PutWithContentEncodingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<PutWithContentEncodingRequest>(request,jsonRequest);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("JSONRPC10")]
        public void SimpleScalarPropertiesMarshallTest()
        {
            var operation = service_model.FindOperation("SimpleScalarProperties");

            var request = InstantiateClassGenerator.Execute<SimpleScalarPropertiesRequest>(operation);
            var marshaller = new SimpleScalarPropertiesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<SimpleScalarPropertiesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = SimpleScalarPropertiesResponseUnmarshaller.Instance.Unmarshall(context) as SimpleScalarPropertiesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}