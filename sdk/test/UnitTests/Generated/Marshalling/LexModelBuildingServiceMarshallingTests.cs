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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.LexModelBuildingService;
using Amazon.LexModelBuildingService.Model;
using Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class LexModelBuildingServiceMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("lex-models");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void CreateBotVersionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBotVersion");

            var request = InstantiateClassGenerator.Execute<CreateBotVersionRequest>();
            var marshaller = new CreateBotVersionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateBotVersion", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateBotVersionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateBotVersionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void CreateIntentVersionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateIntentVersion");

            var request = InstantiateClassGenerator.Execute<CreateIntentVersionRequest>();
            var marshaller = new CreateIntentVersionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateIntentVersion", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateIntentVersionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateIntentVersionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void CreateSlotTypeVersionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSlotTypeVersion");

            var request = InstantiateClassGenerator.Execute<CreateSlotTypeVersionRequest>();
            var marshaller = new CreateSlotTypeVersionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateSlotTypeVersion", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateSlotTypeVersionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateSlotTypeVersionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void DeleteBotMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBot");

            var request = InstantiateClassGenerator.Execute<DeleteBotRequest>();
            var marshaller = new DeleteBotRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteBot", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void DeleteBotAliasMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBotAlias");

            var request = InstantiateClassGenerator.Execute<DeleteBotAliasRequest>();
            var marshaller = new DeleteBotAliasRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteBotAlias", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void DeleteBotChannelAssociationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBotChannelAssociation");

            var request = InstantiateClassGenerator.Execute<DeleteBotChannelAssociationRequest>();
            var marshaller = new DeleteBotChannelAssociationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteBotChannelAssociation", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void DeleteBotVersionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBotVersion");

            var request = InstantiateClassGenerator.Execute<DeleteBotVersionRequest>();
            var marshaller = new DeleteBotVersionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteBotVersion", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void DeleteIntentMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteIntent");

            var request = InstantiateClassGenerator.Execute<DeleteIntentRequest>();
            var marshaller = new DeleteIntentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteIntent", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void DeleteIntentVersionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteIntentVersion");

            var request = InstantiateClassGenerator.Execute<DeleteIntentVersionRequest>();
            var marshaller = new DeleteIntentVersionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteIntentVersion", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void DeleteSlotTypeMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSlotType");

            var request = InstantiateClassGenerator.Execute<DeleteSlotTypeRequest>();
            var marshaller = new DeleteSlotTypeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteSlotType", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void DeleteSlotTypeVersionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSlotTypeVersion");

            var request = InstantiateClassGenerator.Execute<DeleteSlotTypeVersionRequest>();
            var marshaller = new DeleteSlotTypeVersionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteSlotTypeVersion", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void DeleteUtterancesMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteUtterances");

            var request = InstantiateClassGenerator.Execute<DeleteUtterancesRequest>();
            var marshaller = new DeleteUtterancesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteUtterances", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void GetBotMarshallTest()
        {
            var operation = service_model.FindOperation("GetBot");

            var request = InstantiateClassGenerator.Execute<GetBotRequest>();
            var marshaller = new GetBotRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBot", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBotResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void GetBotAliasMarshallTest()
        {
            var operation = service_model.FindOperation("GetBotAlias");

            var request = InstantiateClassGenerator.Execute<GetBotAliasRequest>();
            var marshaller = new GetBotAliasRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBotAlias", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBotAliasResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBotAliasResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void GetBotAliasesMarshallTest()
        {
            var operation = service_model.FindOperation("GetBotAliases");

            var request = InstantiateClassGenerator.Execute<GetBotAliasesRequest>();
            var marshaller = new GetBotAliasesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBotAliases", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBotAliasesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBotAliasesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void GetBotChannelAssociationMarshallTest()
        {
            var operation = service_model.FindOperation("GetBotChannelAssociation");

            var request = InstantiateClassGenerator.Execute<GetBotChannelAssociationRequest>();
            var marshaller = new GetBotChannelAssociationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBotChannelAssociation", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBotChannelAssociationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBotChannelAssociationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void GetBotChannelAssociationsMarshallTest()
        {
            var operation = service_model.FindOperation("GetBotChannelAssociations");

            var request = InstantiateClassGenerator.Execute<GetBotChannelAssociationsRequest>();
            var marshaller = new GetBotChannelAssociationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBotChannelAssociations", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBotChannelAssociationsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBotChannelAssociationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void GetBotsMarshallTest()
        {
            var operation = service_model.FindOperation("GetBots");

            var request = InstantiateClassGenerator.Execute<GetBotsRequest>();
            var marshaller = new GetBotsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBots", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBotsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBotsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void GetBotVersionsMarshallTest()
        {
            var operation = service_model.FindOperation("GetBotVersions");

            var request = InstantiateClassGenerator.Execute<GetBotVersionsRequest>();
            var marshaller = new GetBotVersionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBotVersions", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBotVersionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBotVersionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void GetBuiltinIntentMarshallTest()
        {
            var operation = service_model.FindOperation("GetBuiltinIntent");

            var request = InstantiateClassGenerator.Execute<GetBuiltinIntentRequest>();
            var marshaller = new GetBuiltinIntentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBuiltinIntent", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBuiltinIntentResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBuiltinIntentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void GetBuiltinIntentsMarshallTest()
        {
            var operation = service_model.FindOperation("GetBuiltinIntents");

            var request = InstantiateClassGenerator.Execute<GetBuiltinIntentsRequest>();
            var marshaller = new GetBuiltinIntentsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBuiltinIntents", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBuiltinIntentsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBuiltinIntentsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void GetBuiltinSlotTypesMarshallTest()
        {
            var operation = service_model.FindOperation("GetBuiltinSlotTypes");

            var request = InstantiateClassGenerator.Execute<GetBuiltinSlotTypesRequest>();
            var marshaller = new GetBuiltinSlotTypesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBuiltinSlotTypes", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBuiltinSlotTypesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBuiltinSlotTypesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void GetExportMarshallTest()
        {
            var operation = service_model.FindOperation("GetExport");

            var request = InstantiateClassGenerator.Execute<GetExportRequest>();
            var marshaller = new GetExportRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetExport", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetExportResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetExportResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void GetImportMarshallTest()
        {
            var operation = service_model.FindOperation("GetImport");

            var request = InstantiateClassGenerator.Execute<GetImportRequest>();
            var marshaller = new GetImportRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetImport", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetImportResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetImportResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void GetIntentMarshallTest()
        {
            var operation = service_model.FindOperation("GetIntent");

            var request = InstantiateClassGenerator.Execute<GetIntentRequest>();
            var marshaller = new GetIntentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetIntent", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetIntentResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetIntentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void GetIntentsMarshallTest()
        {
            var operation = service_model.FindOperation("GetIntents");

            var request = InstantiateClassGenerator.Execute<GetIntentsRequest>();
            var marshaller = new GetIntentsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetIntents", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetIntentsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetIntentsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void GetIntentVersionsMarshallTest()
        {
            var operation = service_model.FindOperation("GetIntentVersions");

            var request = InstantiateClassGenerator.Execute<GetIntentVersionsRequest>();
            var marshaller = new GetIntentVersionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetIntentVersions", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetIntentVersionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetIntentVersionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void GetSlotTypeMarshallTest()
        {
            var operation = service_model.FindOperation("GetSlotType");

            var request = InstantiateClassGenerator.Execute<GetSlotTypeRequest>();
            var marshaller = new GetSlotTypeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetSlotType", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetSlotTypeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetSlotTypeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void GetSlotTypesMarshallTest()
        {
            var operation = service_model.FindOperation("GetSlotTypes");

            var request = InstantiateClassGenerator.Execute<GetSlotTypesRequest>();
            var marshaller = new GetSlotTypesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetSlotTypes", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetSlotTypesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetSlotTypesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void GetSlotTypeVersionsMarshallTest()
        {
            var operation = service_model.FindOperation("GetSlotTypeVersions");

            var request = InstantiateClassGenerator.Execute<GetSlotTypeVersionsRequest>();
            var marshaller = new GetSlotTypeVersionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetSlotTypeVersions", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetSlotTypeVersionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetSlotTypeVersionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void GetUtterancesViewMarshallTest()
        {
            var operation = service_model.FindOperation("GetUtterancesView");

            var request = InstantiateClassGenerator.Execute<GetUtterancesViewRequest>();
            var marshaller = new GetUtterancesViewRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetUtterancesView", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetUtterancesViewResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetUtterancesViewResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void PutBotMarshallTest()
        {
            var operation = service_model.FindOperation("PutBot");

            var request = InstantiateClassGenerator.Execute<PutBotRequest>();
            var marshaller = new PutBotRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutBot", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = PutBotResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutBotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void PutBotAliasMarshallTest()
        {
            var operation = service_model.FindOperation("PutBotAlias");

            var request = InstantiateClassGenerator.Execute<PutBotAliasRequest>();
            var marshaller = new PutBotAliasRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutBotAlias", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = PutBotAliasResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutBotAliasResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void PutIntentMarshallTest()
        {
            var operation = service_model.FindOperation("PutIntent");

            var request = InstantiateClassGenerator.Execute<PutIntentRequest>();
            var marshaller = new PutIntentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutIntent", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = PutIntentResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutIntentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void PutSlotTypeMarshallTest()
        {
            var operation = service_model.FindOperation("PutSlotType");

            var request = InstantiateClassGenerator.Execute<PutSlotTypeRequest>();
            var marshaller = new PutSlotTypeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutSlotType", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = PutSlotTypeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutSlotTypeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexModelBuildingService")]
        public void StartImportMarshallTest()
        {
            var operation = service_model.FindOperation("StartImport");

            var request = InstantiateClassGenerator.Execute<StartImportRequest>();
            var marshaller = new StartImportRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("StartImport", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = StartImportResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as StartImportResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}