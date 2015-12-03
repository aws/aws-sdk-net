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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
        static readonly ServiceModel service_model = Utils.LoadServiceModel("lambda-2015-03-31.normal.json", "lambda.customizations.json");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void AddPermissionMarshallTest()
        {
            var operation = service_model.FindOperation("AddPermission");

            var request = InstantiateClassGenerator.Execute<AddPermissionRequest>();
            var marshaller = new AddPermissionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("AddPermission", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = AddPermissionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as AddPermissionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void CreateAliasMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAlias");

            var request = InstantiateClassGenerator.Execute<CreateAliasRequest>();
            var marshaller = new CreateAliasRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateAlias", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateAliasResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateAliasResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void CreateEventSourceMappingMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSourceMapping");

            var request = InstantiateClassGenerator.Execute<CreateEventSourceMappingRequest>();
            var marshaller = new CreateEventSourceMappingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateEventSourceMapping", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateEventSourceMappingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateEventSourceMappingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void CreateFunctionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFunction");

            var request = InstantiateClassGenerator.Execute<CreateFunctionRequest>();
            var marshaller = new CreateFunctionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateFunction", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateFunctionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateFunctionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void DeleteAliasMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAlias");

            var request = InstantiateClassGenerator.Execute<DeleteAliasRequest>();
            var marshaller = new DeleteAliasRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteAlias", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void DeleteEventSourceMappingMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEventSourceMapping");

            var request = InstantiateClassGenerator.Execute<DeleteEventSourceMappingRequest>();
            var marshaller = new DeleteEventSourceMappingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteEventSourceMapping", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteEventSourceMappingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteEventSourceMappingResponse;   
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
        public void GetAliasMarshallTest()
        {
            var operation = service_model.FindOperation("GetAlias");

            var request = InstantiateClassGenerator.Execute<GetAliasRequest>();
            var marshaller = new GetAliasRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetAlias", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetAliasResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetAliasResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void GetEventSourceMappingMarshallTest()
        {
            var operation = service_model.FindOperation("GetEventSourceMapping");

            var request = InstantiateClassGenerator.Execute<GetEventSourceMappingRequest>();
            var marshaller = new GetEventSourceMappingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetEventSourceMapping", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetEventSourceMappingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetEventSourceMappingResponse;   
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
        public void GetPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetPolicy");

            var request = InstantiateClassGenerator.Execute<GetPolicyRequest>();
            var marshaller = new GetPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetPolicy", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetPolicyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void InvokeMarshallTest()
        {
            var operation = service_model.FindOperation("Invoke");

            var request = InstantiateClassGenerator.Execute<InvokeRequest>();
            var marshaller = new InvokeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("Invoke", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"X-Amz-Function-Error","X-Amz-Function-Error_Value"},
                    {"X-Amz-Log-Result","X-Amz-Log-Result_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = InvokeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as InvokeResponse;   
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
        public void ListAliasesMarshallTest()
        {
            var operation = service_model.FindOperation("ListAliases");

            var request = InstantiateClassGenerator.Execute<ListAliasesRequest>();
            var marshaller = new ListAliasesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListAliases", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListAliasesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListAliasesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void ListEventSourceMappingsMarshallTest()
        {
            var operation = service_model.FindOperation("ListEventSourceMappings");

            var request = InstantiateClassGenerator.Execute<ListEventSourceMappingsRequest>();
            var marshaller = new ListEventSourceMappingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListEventSourceMappings", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListEventSourceMappingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListEventSourceMappingsResponse;   
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
        public void ListVersionsByFunctionMarshallTest()
        {
            var operation = service_model.FindOperation("ListVersionsByFunction");

            var request = InstantiateClassGenerator.Execute<ListVersionsByFunctionRequest>();
            var marshaller = new ListVersionsByFunctionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListVersionsByFunction", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListVersionsByFunctionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListVersionsByFunctionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void PublishVersionMarshallTest()
        {
            var operation = service_model.FindOperation("PublishVersion");

            var request = InstantiateClassGenerator.Execute<PublishVersionRequest>();
            var marshaller = new PublishVersionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("PublishVersion", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PublishVersionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PublishVersionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void RemovePermissionMarshallTest()
        {
            var operation = service_model.FindOperation("RemovePermission");

            var request = InstantiateClassGenerator.Execute<RemovePermissionRequest>();
            var marshaller = new RemovePermissionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("RemovePermission", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void UpdateAliasMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAlias");

            var request = InstantiateClassGenerator.Execute<UpdateAliasRequest>();
            var marshaller = new UpdateAliasRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateAlias", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateAliasResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateAliasResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void UpdateEventSourceMappingMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateEventSourceMapping");

            var request = InstantiateClassGenerator.Execute<UpdateEventSourceMappingRequest>();
            var marshaller = new UpdateEventSourceMappingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateEventSourceMapping", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateEventSourceMappingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateEventSourceMappingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void UpdateFunctionCodeMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFunctionCode");

            var request = InstantiateClassGenerator.Execute<UpdateFunctionCodeRequest>();
            var marshaller = new UpdateFunctionCodeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateFunctionCode", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateFunctionCodeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateFunctionCodeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
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

            }
}