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
 * Do not modify this file. This file is generated from the runtime.sagemaker-2017-05-13.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SageMakerRuntime;
using Amazon.SageMakerRuntime.Model;
using Amazon.SageMakerRuntime.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class SageMakerRuntimeMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("runtime.sagemaker");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SageMakerRuntime")]
        public void InvokeEndpointMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeEndpoint");

            var request = InstantiateClassGenerator.Execute<InvokeEndpointRequest>();
            var marshaller = new InvokeEndpointRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("InvokeEndpoint", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"X-Amzn-SageMaker-Custom-Attributes","X-Amzn-SageMaker-Custom-Attributes_Value"},
                    {"x-Amzn-Invoked-Production-Variant","x-Amzn-Invoked-Production-Variant_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = InvokeEndpointResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as InvokeEndpointResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SageMakerRuntime")]
        public void InvokeEndpoint_InternalDependencyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeEndpoint");

            var request = InstantiateClassGenerator.Execute<InvokeEndpointRequest>();
            var marshaller = new InvokeEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("InvokeEndpoint", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalDependencyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"X-Amzn-SageMaker-Custom-Attributes","X-Amzn-SageMaker-Custom-Attributes_Value"},
                    {"x-Amzn-Invoked-Production-Variant","x-Amzn-Invoked-Production-Variant_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalDependencyException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = InvokeEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SageMakerRuntime")]
        public void InvokeEndpoint_InternalFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeEndpoint");

            var request = InstantiateClassGenerator.Execute<InvokeEndpointRequest>();
            var marshaller = new InvokeEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("InvokeEndpoint", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalFailureException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"X-Amzn-SageMaker-Custom-Attributes","X-Amzn-SageMaker-Custom-Attributes_Value"},
                    {"x-Amzn-Invoked-Production-Variant","x-Amzn-Invoked-Production-Variant_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalFailureException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = InvokeEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SageMakerRuntime")]
        public void InvokeEndpoint_ModelErrorExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeEndpoint");

            var request = InstantiateClassGenerator.Execute<InvokeEndpointRequest>();
            var marshaller = new InvokeEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("InvokeEndpoint", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ModelErrorException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"X-Amzn-SageMaker-Custom-Attributes","X-Amzn-SageMaker-Custom-Attributes_Value"},
                    {"x-Amzn-Invoked-Production-Variant","x-Amzn-Invoked-Production-Variant_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ModelErrorException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = InvokeEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SageMakerRuntime")]
        public void InvokeEndpoint_ModelNotReadyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeEndpoint");

            var request = InstantiateClassGenerator.Execute<InvokeEndpointRequest>();
            var marshaller = new InvokeEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("InvokeEndpoint", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ModelNotReadyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"X-Amzn-SageMaker-Custom-Attributes","X-Amzn-SageMaker-Custom-Attributes_Value"},
                    {"x-Amzn-Invoked-Production-Variant","x-Amzn-Invoked-Production-Variant_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ModelNotReadyException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = InvokeEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SageMakerRuntime")]
        public void InvokeEndpoint_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeEndpoint");

            var request = InstantiateClassGenerator.Execute<InvokeEndpointRequest>();
            var marshaller = new InvokeEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("InvokeEndpoint", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceUnavailableException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"X-Amzn-SageMaker-Custom-Attributes","X-Amzn-SageMaker-Custom-Attributes_Value"},
                    {"x-Amzn-Invoked-Production-Variant","x-Amzn-Invoked-Production-Variant_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceUnavailableException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = InvokeEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SageMakerRuntime")]
        public void InvokeEndpoint_ValidationErrorExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeEndpoint");

            var request = InstantiateClassGenerator.Execute<InvokeEndpointRequest>();
            var marshaller = new InvokeEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("InvokeEndpoint", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationErrorException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"X-Amzn-SageMaker-Custom-Attributes","X-Amzn-SageMaker-Custom-Attributes_Value"},
                    {"x-Amzn-Invoked-Production-Variant","x-Amzn-Invoked-Production-Variant_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ValidationErrorException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = InvokeEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SageMakerRuntime")]
        public void InvokeEndpointAsyncMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeEndpointAsync");

            var request = InstantiateClassGenerator.Execute<InvokeEndpointAsyncRequest>();
            var marshaller = new InvokeEndpointAsyncRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("InvokeEndpointAsync", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"X-Amzn-SageMaker-FailureLocation","X-Amzn-SageMaker-FailureLocation_Value"},
                    {"X-Amzn-SageMaker-OutputLocation","X-Amzn-SageMaker-OutputLocation_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = InvokeEndpointAsyncResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as InvokeEndpointAsyncResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SageMakerRuntime")]
        public void InvokeEndpointAsync_InternalFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeEndpointAsync");

            var request = InstantiateClassGenerator.Execute<InvokeEndpointAsyncRequest>();
            var marshaller = new InvokeEndpointAsyncRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("InvokeEndpointAsync", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalFailureException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"X-Amzn-SageMaker-FailureLocation","X-Amzn-SageMaker-FailureLocation_Value"},
                    {"X-Amzn-SageMaker-OutputLocation","X-Amzn-SageMaker-OutputLocation_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalFailureException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = InvokeEndpointAsyncResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SageMakerRuntime")]
        public void InvokeEndpointAsync_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeEndpointAsync");

            var request = InstantiateClassGenerator.Execute<InvokeEndpointAsyncRequest>();
            var marshaller = new InvokeEndpointAsyncRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("InvokeEndpointAsync", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceUnavailableException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"X-Amzn-SageMaker-FailureLocation","X-Amzn-SageMaker-FailureLocation_Value"},
                    {"X-Amzn-SageMaker-OutputLocation","X-Amzn-SageMaker-OutputLocation_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceUnavailableException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = InvokeEndpointAsyncResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SageMakerRuntime")]
        public void InvokeEndpointAsync_ValidationErrorExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeEndpointAsync");

            var request = InstantiateClassGenerator.Execute<InvokeEndpointAsyncRequest>();
            var marshaller = new InvokeEndpointAsyncRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("InvokeEndpointAsync", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationErrorException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"X-Amzn-SageMaker-FailureLocation","X-Amzn-SageMaker-FailureLocation_Value"},
                    {"X-Amzn-SageMaker-OutputLocation","X-Amzn-SageMaker-OutputLocation_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ValidationErrorException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = InvokeEndpointAsyncResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}