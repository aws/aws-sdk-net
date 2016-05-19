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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.APIGateway;
using Amazon.APIGateway.Model;
using Amazon.APIGateway.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class APIGatewayMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("apigateway-2015-07-09.normal.json", "apigateway.customizations.json");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void CreateApiKeyMarshallTest()
        {
            var operation = service_model.FindOperation("CreateApiKey");

            var request = InstantiateClassGenerator.Execute<CreateApiKeyRequest>();
            var marshaller = new CreateApiKeyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateApiKey", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateApiKeyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateApiKeyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void CreateAuthorizerMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAuthorizer");

            var request = InstantiateClassGenerator.Execute<CreateAuthorizerRequest>();
            var marshaller = new CreateAuthorizerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateAuthorizer", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateAuthorizerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void CreateBasePathMappingMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBasePathMapping");

            var request = InstantiateClassGenerator.Execute<CreateBasePathMappingRequest>();
            var marshaller = new CreateBasePathMappingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateBasePathMapping", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateBasePathMappingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateBasePathMappingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void CreateDeploymentMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDeployment");

            var request = InstantiateClassGenerator.Execute<CreateDeploymentRequest>();
            var marshaller = new CreateDeploymentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateDeployment", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateDeploymentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void CreateDomainNameMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDomainName");

            var request = InstantiateClassGenerator.Execute<CreateDomainNameRequest>();
            var marshaller = new CreateDomainNameRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateDomainName", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateDomainNameResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateDomainNameResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void CreateModelMarshallTest()
        {
            var operation = service_model.FindOperation("CreateModel");

            var request = InstantiateClassGenerator.Execute<CreateModelRequest>();
            var marshaller = new CreateModelRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateModel", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateModelResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateModelResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void CreateResourceMarshallTest()
        {
            var operation = service_model.FindOperation("CreateResource");

            var request = InstantiateClassGenerator.Execute<CreateResourceRequest>();
            var marshaller = new CreateResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateResource", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateResourceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void CreateRestApiMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRestApi");

            var request = InstantiateClassGenerator.Execute<CreateRestApiRequest>();
            var marshaller = new CreateRestApiRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateRestApi", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateRestApiResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateRestApiResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void CreateStageMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStage");

            var request = InstantiateClassGenerator.Execute<CreateStageRequest>();
            var marshaller = new CreateStageRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateStage", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateStageResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateStageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void DeleteApiKeyMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteApiKey");

            var request = InstantiateClassGenerator.Execute<DeleteApiKeyRequest>();
            var marshaller = new DeleteApiKeyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteApiKey", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void DeleteAuthorizerMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAuthorizer");

            var request = InstantiateClassGenerator.Execute<DeleteAuthorizerRequest>();
            var marshaller = new DeleteAuthorizerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteAuthorizer", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void DeleteBasePathMappingMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBasePathMapping");

            var request = InstantiateClassGenerator.Execute<DeleteBasePathMappingRequest>();
            var marshaller = new DeleteBasePathMappingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteBasePathMapping", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void DeleteClientCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClientCertificate");

            var request = InstantiateClassGenerator.Execute<DeleteClientCertificateRequest>();
            var marshaller = new DeleteClientCertificateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteClientCertificate", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void DeleteDeploymentMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDeployment");

            var request = InstantiateClassGenerator.Execute<DeleteDeploymentRequest>();
            var marshaller = new DeleteDeploymentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteDeployment", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void DeleteDomainNameMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDomainName");

            var request = InstantiateClassGenerator.Execute<DeleteDomainNameRequest>();
            var marshaller = new DeleteDomainNameRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteDomainName", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void DeleteIntegrationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteIntegration");

            var request = InstantiateClassGenerator.Execute<DeleteIntegrationRequest>();
            var marshaller = new DeleteIntegrationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteIntegration", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void DeleteIntegrationResponseMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteIntegrationResponse");

            var request = InstantiateClassGenerator.Execute<DeleteIntegrationResponseRequest>();
            var marshaller = new DeleteIntegrationResponseRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteIntegrationResponse", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void DeleteMethodMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMethod");

            var request = InstantiateClassGenerator.Execute<DeleteMethodRequest>();
            var marshaller = new DeleteMethodRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteMethod", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void DeleteMethodResponseMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMethodResponse");

            var request = InstantiateClassGenerator.Execute<DeleteMethodResponseRequest>();
            var marshaller = new DeleteMethodResponseRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteMethodResponse", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void DeleteModelMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteModel");

            var request = InstantiateClassGenerator.Execute<DeleteModelRequest>();
            var marshaller = new DeleteModelRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteModel", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void DeleteResourceMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteResource");

            var request = InstantiateClassGenerator.Execute<DeleteResourceRequest>();
            var marshaller = new DeleteResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteResource", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void DeleteRestApiMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRestApi");

            var request = InstantiateClassGenerator.Execute<DeleteRestApiRequest>();
            var marshaller = new DeleteRestApiRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteRestApi", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void DeleteStageMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStage");

            var request = InstantiateClassGenerator.Execute<DeleteStageRequest>();
            var marshaller = new DeleteStageRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteStage", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void FlushStageAuthorizersCacheMarshallTest()
        {
            var operation = service_model.FindOperation("FlushStageAuthorizersCache");

            var request = InstantiateClassGenerator.Execute<FlushStageAuthorizersCacheRequest>();
            var marshaller = new FlushStageAuthorizersCacheRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("FlushStageAuthorizersCache", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void FlushStageCacheMarshallTest()
        {
            var operation = service_model.FindOperation("FlushStageCache");

            var request = InstantiateClassGenerator.Execute<FlushStageCacheRequest>();
            var marshaller = new FlushStageCacheRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("FlushStageCache", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GenerateClientCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("GenerateClientCertificate");

            var request = InstantiateClassGenerator.Execute<GenerateClientCertificateRequest>();
            var marshaller = new GenerateClientCertificateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GenerateClientCertificate", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GenerateClientCertificateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GenerateClientCertificateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetAccountMarshallTest()
        {
            var operation = service_model.FindOperation("GetAccount");

            var request = InstantiateClassGenerator.Execute<GetAccountRequest>();
            var marshaller = new GetAccountRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetAccount", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetAccountResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetAccountResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetApiKeyMarshallTest()
        {
            var operation = service_model.FindOperation("GetApiKey");

            var request = InstantiateClassGenerator.Execute<GetApiKeyRequest>();
            var marshaller = new GetApiKeyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetApiKey", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetApiKeyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetApiKeyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetApiKeysMarshallTest()
        {
            var operation = service_model.FindOperation("GetApiKeys");

            var request = InstantiateClassGenerator.Execute<GetApiKeysRequest>();
            var marshaller = new GetApiKeysRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetApiKeys", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetApiKeysResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetApiKeysResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetAuthorizerMarshallTest()
        {
            var operation = service_model.FindOperation("GetAuthorizer");

            var request = InstantiateClassGenerator.Execute<GetAuthorizerRequest>();
            var marshaller = new GetAuthorizerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetAuthorizer", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetAuthorizerResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetAuthorizerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetAuthorizersMarshallTest()
        {
            var operation = service_model.FindOperation("GetAuthorizers");

            var request = InstantiateClassGenerator.Execute<GetAuthorizersRequest>();
            var marshaller = new GetAuthorizersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetAuthorizers", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetAuthorizersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetAuthorizersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetBasePathMappingMarshallTest()
        {
            var operation = service_model.FindOperation("GetBasePathMapping");

            var request = InstantiateClassGenerator.Execute<GetBasePathMappingRequest>();
            var marshaller = new GetBasePathMappingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetBasePathMapping", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetBasePathMappingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBasePathMappingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetBasePathMappingsMarshallTest()
        {
            var operation = service_model.FindOperation("GetBasePathMappings");

            var request = InstantiateClassGenerator.Execute<GetBasePathMappingsRequest>();
            var marshaller = new GetBasePathMappingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetBasePathMappings", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetBasePathMappingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBasePathMappingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetClientCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("GetClientCertificate");

            var request = InstantiateClassGenerator.Execute<GetClientCertificateRequest>();
            var marshaller = new GetClientCertificateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetClientCertificate", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetClientCertificateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetClientCertificateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetClientCertificatesMarshallTest()
        {
            var operation = service_model.FindOperation("GetClientCertificates");

            var request = InstantiateClassGenerator.Execute<GetClientCertificatesRequest>();
            var marshaller = new GetClientCertificatesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetClientCertificates", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetClientCertificatesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetClientCertificatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetDeploymentMarshallTest()
        {
            var operation = service_model.FindOperation("GetDeployment");

            var request = InstantiateClassGenerator.Execute<GetDeploymentRequest>();
            var marshaller = new GetDeploymentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetDeployment", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetDeploymentResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDeploymentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetDeploymentsMarshallTest()
        {
            var operation = service_model.FindOperation("GetDeployments");

            var request = InstantiateClassGenerator.Execute<GetDeploymentsRequest>();
            var marshaller = new GetDeploymentsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetDeployments", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetDeploymentsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDeploymentsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetDomainNameMarshallTest()
        {
            var operation = service_model.FindOperation("GetDomainName");

            var request = InstantiateClassGenerator.Execute<GetDomainNameRequest>();
            var marshaller = new GetDomainNameRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetDomainName", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetDomainNameResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDomainNameResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetDomainNamesMarshallTest()
        {
            var operation = service_model.FindOperation("GetDomainNames");

            var request = InstantiateClassGenerator.Execute<GetDomainNamesRequest>();
            var marshaller = new GetDomainNamesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetDomainNames", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetDomainNamesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDomainNamesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetExportMarshallTest()
        {
            var operation = service_model.FindOperation("GetExport");

            var request = InstantiateClassGenerator.Execute<GetExportRequest>();
            var marshaller = new GetExportRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetExport", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Disposition","Content-Disposition_Value"},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetExportResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetExportResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetIntegrationMarshallTest()
        {
            var operation = service_model.FindOperation("GetIntegration");

            var request = InstantiateClassGenerator.Execute<GetIntegrationRequest>();
            var marshaller = new GetIntegrationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetIntegration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetIntegrationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetIntegrationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetIntegrationResponseMarshallTest()
        {
            var operation = service_model.FindOperation("GetIntegrationResponse");

            var request = InstantiateClassGenerator.Execute<GetIntegrationResponseRequest>();
            var marshaller = new GetIntegrationResponseRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetIntegrationResponse", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetIntegrationResponseResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetMethodMarshallTest()
        {
            var operation = service_model.FindOperation("GetMethod");

            var request = InstantiateClassGenerator.Execute<GetMethodRequest>();
            var marshaller = new GetMethodRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetMethod", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetMethodResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetMethodResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetMethodResponseMarshallTest()
        {
            var operation = service_model.FindOperation("GetMethodResponse");

            var request = InstantiateClassGenerator.Execute<GetMethodResponseRequest>();
            var marshaller = new GetMethodResponseRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetMethodResponse", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetMethodResponseResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetMethodResponseResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetModelMarshallTest()
        {
            var operation = service_model.FindOperation("GetModel");

            var request = InstantiateClassGenerator.Execute<GetModelRequest>();
            var marshaller = new GetModelRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetModel", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetModelResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetModelResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetModelsMarshallTest()
        {
            var operation = service_model.FindOperation("GetModels");

            var request = InstantiateClassGenerator.Execute<GetModelsRequest>();
            var marshaller = new GetModelsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetModels", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetModelsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetModelsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetModelTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("GetModelTemplate");

            var request = InstantiateClassGenerator.Execute<GetModelTemplateRequest>();
            var marshaller = new GetModelTemplateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetModelTemplate", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetModelTemplateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetModelTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetResourceMarshallTest()
        {
            var operation = service_model.FindOperation("GetResource");

            var request = InstantiateClassGenerator.Execute<GetResourceRequest>();
            var marshaller = new GetResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetResource", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetResourceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetResourcesMarshallTest()
        {
            var operation = service_model.FindOperation("GetResources");

            var request = InstantiateClassGenerator.Execute<GetResourcesRequest>();
            var marshaller = new GetResourcesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetResources", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetResourcesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetResourcesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetRestApiMarshallTest()
        {
            var operation = service_model.FindOperation("GetRestApi");

            var request = InstantiateClassGenerator.Execute<GetRestApiRequest>();
            var marshaller = new GetRestApiRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetRestApi", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetRestApiResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetRestApiResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetRestApisMarshallTest()
        {
            var operation = service_model.FindOperation("GetRestApis");

            var request = InstantiateClassGenerator.Execute<GetRestApisRequest>();
            var marshaller = new GetRestApisRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetRestApis", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetRestApisResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetRestApisResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetSdkMarshallTest()
        {
            var operation = service_model.FindOperation("GetSdk");

            var request = InstantiateClassGenerator.Execute<GetSdkRequest>();
            var marshaller = new GetSdkRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetSdk", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Disposition","Content-Disposition_Value"},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetSdkResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetSdkResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetStageMarshallTest()
        {
            var operation = service_model.FindOperation("GetStage");

            var request = InstantiateClassGenerator.Execute<GetStageRequest>();
            var marshaller = new GetStageRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetStage", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetStageResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetStageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void GetStagesMarshallTest()
        {
            var operation = service_model.FindOperation("GetStages");

            var request = InstantiateClassGenerator.Execute<GetStagesRequest>();
            var marshaller = new GetStagesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetStages", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetStagesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetStagesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void ImportRestApiMarshallTest()
        {
            var operation = service_model.FindOperation("ImportRestApi");

            var request = InstantiateClassGenerator.Execute<ImportRestApiRequest>();
            var marshaller = new ImportRestApiRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ImportRestApi", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ImportRestApiResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ImportRestApiResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void PutIntegrationMarshallTest()
        {
            var operation = service_model.FindOperation("PutIntegration");

            var request = InstantiateClassGenerator.Execute<PutIntegrationRequest>();
            var marshaller = new PutIntegrationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("PutIntegration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutIntegrationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutIntegrationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void PutIntegrationResponseMarshallTest()
        {
            var operation = service_model.FindOperation("PutIntegrationResponse");

            var request = InstantiateClassGenerator.Execute<PutIntegrationResponseRequest>();
            var marshaller = new PutIntegrationResponseRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("PutIntegrationResponse", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutIntegrationResponseResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutIntegrationResponseResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void PutMethodMarshallTest()
        {
            var operation = service_model.FindOperation("PutMethod");

            var request = InstantiateClassGenerator.Execute<PutMethodRequest>();
            var marshaller = new PutMethodRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("PutMethod", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutMethodResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutMethodResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void PutMethodResponseMarshallTest()
        {
            var operation = service_model.FindOperation("PutMethodResponse");

            var request = InstantiateClassGenerator.Execute<PutMethodResponseRequest>();
            var marshaller = new PutMethodResponseRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("PutMethodResponse", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutMethodResponseResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutMethodResponseResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void PutRestApiMarshallTest()
        {
            var operation = service_model.FindOperation("PutRestApi");

            var request = InstantiateClassGenerator.Execute<PutRestApiRequest>();
            var marshaller = new PutRestApiRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("PutRestApi", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutRestApiResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutRestApiResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void TestInvokeAuthorizerMarshallTest()
        {
            var operation = service_model.FindOperation("TestInvokeAuthorizer");

            var request = InstantiateClassGenerator.Execute<TestInvokeAuthorizerRequest>();
            var marshaller = new TestInvokeAuthorizerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("TestInvokeAuthorizer", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = TestInvokeAuthorizerResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as TestInvokeAuthorizerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void TestInvokeMethodMarshallTest()
        {
            var operation = service_model.FindOperation("TestInvokeMethod");

            var request = InstantiateClassGenerator.Execute<TestInvokeMethodRequest>();
            var marshaller = new TestInvokeMethodRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("TestInvokeMethod", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = TestInvokeMethodResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as TestInvokeMethodResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void UpdateAccountMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAccount");

            var request = InstantiateClassGenerator.Execute<UpdateAccountRequest>();
            var marshaller = new UpdateAccountRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateAccount", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateAccountResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateAccountResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void UpdateApiKeyMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateApiKey");

            var request = InstantiateClassGenerator.Execute<UpdateApiKeyRequest>();
            var marshaller = new UpdateApiKeyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateApiKey", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateApiKeyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateApiKeyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void UpdateAuthorizerMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAuthorizer");

            var request = InstantiateClassGenerator.Execute<UpdateAuthorizerRequest>();
            var marshaller = new UpdateAuthorizerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateAuthorizer", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateAuthorizerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void UpdateBasePathMappingMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBasePathMapping");

            var request = InstantiateClassGenerator.Execute<UpdateBasePathMappingRequest>();
            var marshaller = new UpdateBasePathMappingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateBasePathMapping", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateBasePathMappingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateBasePathMappingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void UpdateClientCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateClientCertificate");

            var request = InstantiateClassGenerator.Execute<UpdateClientCertificateRequest>();
            var marshaller = new UpdateClientCertificateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateClientCertificate", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateClientCertificateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateClientCertificateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void UpdateDeploymentMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDeployment");

            var request = InstantiateClassGenerator.Execute<UpdateDeploymentRequest>();
            var marshaller = new UpdateDeploymentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateDeployment", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateDeploymentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void UpdateDomainNameMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDomainName");

            var request = InstantiateClassGenerator.Execute<UpdateDomainNameRequest>();
            var marshaller = new UpdateDomainNameRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateDomainName", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateDomainNameResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void UpdateIntegrationMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateIntegration");

            var request = InstantiateClassGenerator.Execute<UpdateIntegrationRequest>();
            var marshaller = new UpdateIntegrationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateIntegration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateIntegrationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void UpdateIntegrationResponseMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateIntegrationResponse");

            var request = InstantiateClassGenerator.Execute<UpdateIntegrationResponseRequest>();
            var marshaller = new UpdateIntegrationResponseRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateIntegrationResponse", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateIntegrationResponseResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void UpdateMethodMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateMethod");

            var request = InstantiateClassGenerator.Execute<UpdateMethodRequest>();
            var marshaller = new UpdateMethodRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateMethod", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateMethodResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateMethodResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void UpdateMethodResponseMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateMethodResponse");

            var request = InstantiateClassGenerator.Execute<UpdateMethodResponseRequest>();
            var marshaller = new UpdateMethodResponseRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateMethodResponse", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateMethodResponseResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateMethodResponseResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void UpdateModelMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateModel");

            var request = InstantiateClassGenerator.Execute<UpdateModelRequest>();
            var marshaller = new UpdateModelRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateModel", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateModelResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateModelResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void UpdateResourceMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateResource");

            var request = InstantiateClassGenerator.Execute<UpdateResourceRequest>();
            var marshaller = new UpdateResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateResource", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateResourceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void UpdateRestApiMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateRestApi");

            var request = InstantiateClassGenerator.Execute<UpdateRestApiRequest>();
            var marshaller = new UpdateRestApiRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateRestApi", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateRestApiResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateRestApiResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("APIGateway")]
        public void UpdateStageMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStage");

            var request = InstantiateClassGenerator.Execute<UpdateStageRequest>();
            var marshaller = new UpdateStageRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateStage", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateStageResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateStageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}