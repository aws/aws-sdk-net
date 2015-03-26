/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lambda-2014-11-11.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Lambda;
using Amazon.Lambda.Model;
using Amazon.Lambda.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class LambdaMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("lambda-2014-11-11.normal.json", "lambda.customizations.json");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void AddEventSourceMarshallTest()
        {
            var operation = service_model.FindOperation("AddEventSource");

            var request = InstantiateClassGenerator.Execute<AddEventSourceRequest>();
            var marshaller = new AddEventSourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("AddEventSource", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = AddEventSourceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as AddEventSourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void DeleteFunctionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFunction");

            var request = InstantiateClassGenerator.Execute<DeleteFunctionRequest>();
            var marshaller = new DeleteFunctionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteFunction", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void GetEventSourceMarshallTest()
        {
            var operation = service_model.FindOperation("GetEventSource");

            var request = InstantiateClassGenerator.Execute<GetEventSourceRequest>();
            var marshaller = new GetEventSourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetEventSource", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetEventSourceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetEventSourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void GetFunctionMarshallTest()
        {
            var operation = service_model.FindOperation("GetFunction");

            var request = InstantiateClassGenerator.Execute<GetFunctionRequest>();
            var marshaller = new GetFunctionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetFunction", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetFunctionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetFunctionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void GetFunctionConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("GetFunctionConfiguration");

            var request = InstantiateClassGenerator.Execute<GetFunctionConfigurationRequest>();
            var marshaller = new GetFunctionConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetFunctionConfiguration", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetFunctionConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetFunctionConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void InvokeAsyncMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeAsync");

            var request = InstantiateClassGenerator.Execute<InvokeAsyncRequest>();
            var marshaller = new InvokeAsyncRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("InvokeAsync", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = InvokeAsyncResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as InvokeAsyncResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void ListEventSourcesMarshallTest()
        {
            var operation = service_model.FindOperation("ListEventSources");

            var request = InstantiateClassGenerator.Execute<ListEventSourcesRequest>();
            var marshaller = new ListEventSourcesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListEventSources", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListEventSourcesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListEventSourcesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void ListFunctionsMarshallTest()
        {
            var operation = service_model.FindOperation("ListFunctions");

            var request = InstantiateClassGenerator.Execute<ListFunctionsRequest>();
            var marshaller = new ListFunctionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListFunctions", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListFunctionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListFunctionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void RemoveEventSourceMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveEventSource");

            var request = InstantiateClassGenerator.Execute<RemoveEventSourceRequest>();
            var marshaller = new RemoveEventSourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("RemoveEventSource", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void UpdateFunctionConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFunctionConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateFunctionConfigurationRequest>();
            var marshaller = new UpdateFunctionConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateFunctionConfiguration", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateFunctionConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateFunctionConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void UploadFunctionMarshallTest()
        {
            var operation = service_model.FindOperation("UploadFunction");

            var request = InstantiateClassGenerator.Execute<UploadFunctionRequest>();
            var marshaller = new UploadFunctionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UploadFunction", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UploadFunctionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UploadFunctionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}