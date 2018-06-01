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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.IoT;
using Amazon.IoT.Model;
using Amazon.IoT.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class IoTMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("iot");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void AcceptCertificateTransferMarshallTest()
        {
            var operation = service_model.FindOperation("AcceptCertificateTransfer");

            var request = InstantiateClassGenerator.Execute<AcceptCertificateTransferRequest>();
            var marshaller = new AcceptCertificateTransferRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("AcceptCertificateTransfer", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void AddThingToThingGroupMarshallTest()
        {
            var operation = service_model.FindOperation("AddThingToThingGroup");

            var request = InstantiateClassGenerator.Execute<AddThingToThingGroupRequest>();
            var marshaller = new AddThingToThingGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("AddThingToThingGroup", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = AddThingToThingGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as AddThingToThingGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void AssociateTargetsWithJobMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateTargetsWithJob");

            var request = InstantiateClassGenerator.Execute<AssociateTargetsWithJobRequest>();
            var marshaller = new AssociateTargetsWithJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("AssociateTargetsWithJob", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = AssociateTargetsWithJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as AssociateTargetsWithJobResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void AttachPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("AttachPolicy");

            var request = InstantiateClassGenerator.Execute<AttachPolicyRequest>();
            var marshaller = new AttachPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("AttachPolicy", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void AttachPrincipalPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("AttachPrincipalPolicy");

            var request = InstantiateClassGenerator.Execute<AttachPrincipalPolicyRequest>();
            var marshaller = new AttachPrincipalPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("AttachPrincipalPolicy", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void AttachThingPrincipalMarshallTest()
        {
            var operation = service_model.FindOperation("AttachThingPrincipal");

            var request = InstantiateClassGenerator.Execute<AttachThingPrincipalRequest>();
            var marshaller = new AttachThingPrincipalRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("AttachThingPrincipal", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = AttachThingPrincipalResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as AttachThingPrincipalResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void CancelCertificateTransferMarshallTest()
        {
            var operation = service_model.FindOperation("CancelCertificateTransfer");

            var request = InstantiateClassGenerator.Execute<CancelCertificateTransferRequest>();
            var marshaller = new CancelCertificateTransferRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CancelCertificateTransfer", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void CancelJobMarshallTest()
        {
            var operation = service_model.FindOperation("CancelJob");

            var request = InstantiateClassGenerator.Execute<CancelJobRequest>();
            var marshaller = new CancelJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CancelJob", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CancelJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CancelJobResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void CancelJobExecutionMarshallTest()
        {
            var operation = service_model.FindOperation("CancelJobExecution");

            var request = InstantiateClassGenerator.Execute<CancelJobExecutionRequest>();
            var marshaller = new CancelJobExecutionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CancelJobExecution", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ClearDefaultAuthorizerMarshallTest()
        {
            var operation = service_model.FindOperation("ClearDefaultAuthorizer");

            var request = InstantiateClassGenerator.Execute<ClearDefaultAuthorizerRequest>();
            var marshaller = new ClearDefaultAuthorizerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ClearDefaultAuthorizer", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ClearDefaultAuthorizerResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ClearDefaultAuthorizerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void CreateAuthorizerMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAuthorizer");

            var request = InstantiateClassGenerator.Execute<CreateAuthorizerRequest>();
            var marshaller = new CreateAuthorizerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateAuthorizer", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateAuthorizerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void CreateCertificateFromCsrMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCertificateFromCsr");

            var request = InstantiateClassGenerator.Execute<CreateCertificateFromCsrRequest>();
            var marshaller = new CreateCertificateFromCsrRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateCertificateFromCsr", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateCertificateFromCsrResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateCertificateFromCsrResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void CreateJobMarshallTest()
        {
            var operation = service_model.FindOperation("CreateJob");

            var request = InstantiateClassGenerator.Execute<CreateJobRequest>();
            var marshaller = new CreateJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateJob", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateJobResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void CreateKeysAndCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("CreateKeysAndCertificate");

            var request = InstantiateClassGenerator.Execute<CreateKeysAndCertificateRequest>();
            var marshaller = new CreateKeysAndCertificateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateKeysAndCertificate", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateKeysAndCertificateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateKeysAndCertificateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void CreateOTAUpdateMarshallTest()
        {
            var operation = service_model.FindOperation("CreateOTAUpdate");

            var request = InstantiateClassGenerator.Execute<CreateOTAUpdateRequest>();
            var marshaller = new CreateOTAUpdateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateOTAUpdate", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateOTAUpdateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateOTAUpdateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void CreatePolicyMarshallTest()
        {
            var operation = service_model.FindOperation("CreatePolicy");

            var request = InstantiateClassGenerator.Execute<CreatePolicyRequest>();
            var marshaller = new CreatePolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreatePolicy", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreatePolicyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreatePolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void CreatePolicyVersionMarshallTest()
        {
            var operation = service_model.FindOperation("CreatePolicyVersion");

            var request = InstantiateClassGenerator.Execute<CreatePolicyVersionRequest>();
            var marshaller = new CreatePolicyVersionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreatePolicyVersion", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreatePolicyVersionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreatePolicyVersionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void CreateRoleAliasMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRoleAlias");

            var request = InstantiateClassGenerator.Execute<CreateRoleAliasRequest>();
            var marshaller = new CreateRoleAliasRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateRoleAlias", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateRoleAliasResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateRoleAliasResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void CreateStreamMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStream");

            var request = InstantiateClassGenerator.Execute<CreateStreamRequest>();
            var marshaller = new CreateStreamRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateStream", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateStreamResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateStreamResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void CreateThingMarshallTest()
        {
            var operation = service_model.FindOperation("CreateThing");

            var request = InstantiateClassGenerator.Execute<CreateThingRequest>();
            var marshaller = new CreateThingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateThing", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateThingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateThingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void CreateThingGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateThingGroup");

            var request = InstantiateClassGenerator.Execute<CreateThingGroupRequest>();
            var marshaller = new CreateThingGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateThingGroup", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateThingGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateThingGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void CreateThingTypeMarshallTest()
        {
            var operation = service_model.FindOperation("CreateThingType");

            var request = InstantiateClassGenerator.Execute<CreateThingTypeRequest>();
            var marshaller = new CreateThingTypeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateThingType", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateThingTypeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateThingTypeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void CreateTopicRuleMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTopicRule");

            var request = InstantiateClassGenerator.Execute<CreateTopicRuleRequest>();
            var marshaller = new CreateTopicRuleRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateTopicRule", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DeleteAuthorizerMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAuthorizer");

            var request = InstantiateClassGenerator.Execute<DeleteAuthorizerRequest>();
            var marshaller = new DeleteAuthorizerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteAuthorizer", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteAuthorizerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DeleteCACertificateMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCACertificate");

            var request = InstantiateClassGenerator.Execute<DeleteCACertificateRequest>();
            var marshaller = new DeleteCACertificateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteCACertificate", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteCACertificateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteCACertificateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DeleteCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCertificate");

            var request = InstantiateClassGenerator.Execute<DeleteCertificateRequest>();
            var marshaller = new DeleteCertificateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteCertificate", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DeleteJobMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteJob");

            var request = InstantiateClassGenerator.Execute<DeleteJobRequest>();
            var marshaller = new DeleteJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteJob", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DeleteJobExecutionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteJobExecution");

            var request = InstantiateClassGenerator.Execute<DeleteJobExecutionRequest>();
            var marshaller = new DeleteJobExecutionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteJobExecution", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DeleteOTAUpdateMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteOTAUpdate");

            var request = InstantiateClassGenerator.Execute<DeleteOTAUpdateRequest>();
            var marshaller = new DeleteOTAUpdateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteOTAUpdate", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteOTAUpdateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteOTAUpdateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DeletePolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePolicy");

            var request = InstantiateClassGenerator.Execute<DeletePolicyRequest>();
            var marshaller = new DeletePolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeletePolicy", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DeletePolicyVersionMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePolicyVersion");

            var request = InstantiateClassGenerator.Execute<DeletePolicyVersionRequest>();
            var marshaller = new DeletePolicyVersionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeletePolicyVersion", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DeleteRegistrationCodeMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRegistrationCode");

            var request = InstantiateClassGenerator.Execute<DeleteRegistrationCodeRequest>();
            var marshaller = new DeleteRegistrationCodeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteRegistrationCode", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteRegistrationCodeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteRegistrationCodeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DeleteRoleAliasMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRoleAlias");

            var request = InstantiateClassGenerator.Execute<DeleteRoleAliasRequest>();
            var marshaller = new DeleteRoleAliasRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteRoleAlias", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteRoleAliasResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteRoleAliasResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DeleteStreamMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStream");

            var request = InstantiateClassGenerator.Execute<DeleteStreamRequest>();
            var marshaller = new DeleteStreamRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteStream", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteStreamResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteStreamResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DeleteThingMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteThing");

            var request = InstantiateClassGenerator.Execute<DeleteThingRequest>();
            var marshaller = new DeleteThingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteThing", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteThingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteThingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DeleteThingGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteThingGroup");

            var request = InstantiateClassGenerator.Execute<DeleteThingGroupRequest>();
            var marshaller = new DeleteThingGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteThingGroup", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteThingGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteThingGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DeleteThingTypeMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteThingType");

            var request = InstantiateClassGenerator.Execute<DeleteThingTypeRequest>();
            var marshaller = new DeleteThingTypeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteThingType", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteThingTypeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteThingTypeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DeleteTopicRuleMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTopicRule");

            var request = InstantiateClassGenerator.Execute<DeleteTopicRuleRequest>();
            var marshaller = new DeleteTopicRuleRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteTopicRule", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DeleteV2LoggingLevelMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteV2LoggingLevel");

            var request = InstantiateClassGenerator.Execute<DeleteV2LoggingLevelRequest>();
            var marshaller = new DeleteV2LoggingLevelRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteV2LoggingLevel", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DeprecateThingTypeMarshallTest()
        {
            var operation = service_model.FindOperation("DeprecateThingType");

            var request = InstantiateClassGenerator.Execute<DeprecateThingTypeRequest>();
            var marshaller = new DeprecateThingTypeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeprecateThingType", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeprecateThingTypeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeprecateThingTypeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DescribeAuthorizerMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAuthorizer");

            var request = InstantiateClassGenerator.Execute<DescribeAuthorizerRequest>();
            var marshaller = new DescribeAuthorizerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeAuthorizer", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeAuthorizerResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeAuthorizerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DescribeCACertificateMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeCACertificate");

            var request = InstantiateClassGenerator.Execute<DescribeCACertificateRequest>();
            var marshaller = new DescribeCACertificateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeCACertificate", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeCACertificateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeCACertificateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DescribeCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeCertificate");

            var request = InstantiateClassGenerator.Execute<DescribeCertificateRequest>();
            var marshaller = new DescribeCertificateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeCertificate", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeCertificateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeCertificateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DescribeDefaultAuthorizerMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDefaultAuthorizer");

            var request = InstantiateClassGenerator.Execute<DescribeDefaultAuthorizerRequest>();
            var marshaller = new DescribeDefaultAuthorizerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeDefaultAuthorizer", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeDefaultAuthorizerResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeDefaultAuthorizerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DescribeEndpointMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEndpoint");

            var request = InstantiateClassGenerator.Execute<DescribeEndpointRequest>();
            var marshaller = new DescribeEndpointRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeEndpoint", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeEndpointResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeEndpointResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DescribeEventConfigurationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEventConfigurations");

            var request = InstantiateClassGenerator.Execute<DescribeEventConfigurationsRequest>();
            var marshaller = new DescribeEventConfigurationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeEventConfigurations", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeEventConfigurationsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeEventConfigurationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DescribeIndexMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeIndex");

            var request = InstantiateClassGenerator.Execute<DescribeIndexRequest>();
            var marshaller = new DescribeIndexRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeIndex", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeIndexResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeIndexResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DescribeJobMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeJob");

            var request = InstantiateClassGenerator.Execute<DescribeJobRequest>();
            var marshaller = new DescribeJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeJob", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeJobResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DescribeJobExecutionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeJobExecution");

            var request = InstantiateClassGenerator.Execute<DescribeJobExecutionRequest>();
            var marshaller = new DescribeJobExecutionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeJobExecution", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeJobExecutionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeJobExecutionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DescribeRoleAliasMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeRoleAlias");

            var request = InstantiateClassGenerator.Execute<DescribeRoleAliasRequest>();
            var marshaller = new DescribeRoleAliasRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeRoleAlias", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeRoleAliasResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeRoleAliasResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DescribeStreamMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStream");

            var request = InstantiateClassGenerator.Execute<DescribeStreamRequest>();
            var marshaller = new DescribeStreamRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeStream", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeStreamResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeStreamResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DescribeThingMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeThing");

            var request = InstantiateClassGenerator.Execute<DescribeThingRequest>();
            var marshaller = new DescribeThingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeThing", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeThingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeThingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DescribeThingGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeThingGroup");

            var request = InstantiateClassGenerator.Execute<DescribeThingGroupRequest>();
            var marshaller = new DescribeThingGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeThingGroup", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeThingGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeThingGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DescribeThingRegistrationTaskMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeThingRegistrationTask");

            var request = InstantiateClassGenerator.Execute<DescribeThingRegistrationTaskRequest>();
            var marshaller = new DescribeThingRegistrationTaskRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeThingRegistrationTask", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeThingRegistrationTaskResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeThingRegistrationTaskResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DescribeThingTypeMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeThingType");

            var request = InstantiateClassGenerator.Execute<DescribeThingTypeRequest>();
            var marshaller = new DescribeThingTypeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeThingType", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeThingTypeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeThingTypeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DetachPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DetachPolicy");

            var request = InstantiateClassGenerator.Execute<DetachPolicyRequest>();
            var marshaller = new DetachPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DetachPolicy", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DetachPrincipalPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DetachPrincipalPolicy");

            var request = InstantiateClassGenerator.Execute<DetachPrincipalPolicyRequest>();
            var marshaller = new DetachPrincipalPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DetachPrincipalPolicy", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DetachThingPrincipalMarshallTest()
        {
            var operation = service_model.FindOperation("DetachThingPrincipal");

            var request = InstantiateClassGenerator.Execute<DetachThingPrincipalRequest>();
            var marshaller = new DetachThingPrincipalRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DetachThingPrincipal", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DetachThingPrincipalResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DetachThingPrincipalResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void DisableTopicRuleMarshallTest()
        {
            var operation = service_model.FindOperation("DisableTopicRule");

            var request = InstantiateClassGenerator.Execute<DisableTopicRuleRequest>();
            var marshaller = new DisableTopicRuleRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DisableTopicRule", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void EnableTopicRuleMarshallTest()
        {
            var operation = service_model.FindOperation("EnableTopicRule");

            var request = InstantiateClassGenerator.Execute<EnableTopicRuleRequest>();
            var marshaller = new EnableTopicRuleRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("EnableTopicRule", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void GetEffectivePoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("GetEffectivePolicies");

            var request = InstantiateClassGenerator.Execute<GetEffectivePoliciesRequest>();
            var marshaller = new GetEffectivePoliciesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetEffectivePolicies", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetEffectivePoliciesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetEffectivePoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void GetIndexingConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("GetIndexingConfiguration");

            var request = InstantiateClassGenerator.Execute<GetIndexingConfigurationRequest>();
            var marshaller = new GetIndexingConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetIndexingConfiguration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetIndexingConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetIndexingConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void GetJobDocumentMarshallTest()
        {
            var operation = service_model.FindOperation("GetJobDocument");

            var request = InstantiateClassGenerator.Execute<GetJobDocumentRequest>();
            var marshaller = new GetJobDocumentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetJobDocument", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetJobDocumentResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetJobDocumentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void GetLoggingOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("GetLoggingOptions");

            var request = InstantiateClassGenerator.Execute<GetLoggingOptionsRequest>();
            var marshaller = new GetLoggingOptionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetLoggingOptions", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetLoggingOptionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetLoggingOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void GetOTAUpdateMarshallTest()
        {
            var operation = service_model.FindOperation("GetOTAUpdate");

            var request = InstantiateClassGenerator.Execute<GetOTAUpdateRequest>();
            var marshaller = new GetOTAUpdateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetOTAUpdate", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetOTAUpdateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetOTAUpdateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void GetPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetPolicy");

            var request = InstantiateClassGenerator.Execute<GetPolicyRequest>();
            var marshaller = new GetPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetPolicy", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetPolicyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void GetPolicyVersionMarshallTest()
        {
            var operation = service_model.FindOperation("GetPolicyVersion");

            var request = InstantiateClassGenerator.Execute<GetPolicyVersionRequest>();
            var marshaller = new GetPolicyVersionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetPolicyVersion", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetPolicyVersionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetPolicyVersionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void GetRegistrationCodeMarshallTest()
        {
            var operation = service_model.FindOperation("GetRegistrationCode");

            var request = InstantiateClassGenerator.Execute<GetRegistrationCodeRequest>();
            var marshaller = new GetRegistrationCodeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetRegistrationCode", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetRegistrationCodeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetRegistrationCodeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void GetTopicRuleMarshallTest()
        {
            var operation = service_model.FindOperation("GetTopicRule");

            var request = InstantiateClassGenerator.Execute<GetTopicRuleRequest>();
            var marshaller = new GetTopicRuleRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetTopicRule", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetTopicRuleResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetTopicRuleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void GetV2LoggingOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("GetV2LoggingOptions");

            var request = InstantiateClassGenerator.Execute<GetV2LoggingOptionsRequest>();
            var marshaller = new GetV2LoggingOptionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetV2LoggingOptions", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetV2LoggingOptionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetV2LoggingOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListAttachedPoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("ListAttachedPolicies");

            var request = InstantiateClassGenerator.Execute<ListAttachedPoliciesRequest>();
            var marshaller = new ListAttachedPoliciesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListAttachedPolicies", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListAttachedPoliciesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListAttachedPoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListAuthorizersMarshallTest()
        {
            var operation = service_model.FindOperation("ListAuthorizers");

            var request = InstantiateClassGenerator.Execute<ListAuthorizersRequest>();
            var marshaller = new ListAuthorizersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListAuthorizers", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListAuthorizersResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListAuthorizersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListCACertificatesMarshallTest()
        {
            var operation = service_model.FindOperation("ListCACertificates");

            var request = InstantiateClassGenerator.Execute<ListCACertificatesRequest>();
            var marshaller = new ListCACertificatesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListCACertificates", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListCACertificatesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListCACertificatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListCertificatesMarshallTest()
        {
            var operation = service_model.FindOperation("ListCertificates");

            var request = InstantiateClassGenerator.Execute<ListCertificatesRequest>();
            var marshaller = new ListCertificatesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListCertificates", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListCertificatesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListCertificatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListCertificatesByCAMarshallTest()
        {
            var operation = service_model.FindOperation("ListCertificatesByCA");

            var request = InstantiateClassGenerator.Execute<ListCertificatesByCARequest>();
            var marshaller = new ListCertificatesByCARequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListCertificatesByCA", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListCertificatesByCAResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListCertificatesByCAResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListIndicesMarshallTest()
        {
            var operation = service_model.FindOperation("ListIndices");

            var request = InstantiateClassGenerator.Execute<ListIndicesRequest>();
            var marshaller = new ListIndicesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListIndices", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListIndicesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListIndicesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListJobExecutionsForJobMarshallTest()
        {
            var operation = service_model.FindOperation("ListJobExecutionsForJob");

            var request = InstantiateClassGenerator.Execute<ListJobExecutionsForJobRequest>();
            var marshaller = new ListJobExecutionsForJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListJobExecutionsForJob", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListJobExecutionsForJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListJobExecutionsForJobResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListJobExecutionsForThingMarshallTest()
        {
            var operation = service_model.FindOperation("ListJobExecutionsForThing");

            var request = InstantiateClassGenerator.Execute<ListJobExecutionsForThingRequest>();
            var marshaller = new ListJobExecutionsForThingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListJobExecutionsForThing", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListJobExecutionsForThingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListJobExecutionsForThingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListJobsMarshallTest()
        {
            var operation = service_model.FindOperation("ListJobs");

            var request = InstantiateClassGenerator.Execute<ListJobsRequest>();
            var marshaller = new ListJobsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListJobs", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListJobsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListJobsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListOTAUpdatesMarshallTest()
        {
            var operation = service_model.FindOperation("ListOTAUpdates");

            var request = InstantiateClassGenerator.Execute<ListOTAUpdatesRequest>();
            var marshaller = new ListOTAUpdatesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListOTAUpdates", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListOTAUpdatesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListOTAUpdatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListOutgoingCertificatesMarshallTest()
        {
            var operation = service_model.FindOperation("ListOutgoingCertificates");

            var request = InstantiateClassGenerator.Execute<ListOutgoingCertificatesRequest>();
            var marshaller = new ListOutgoingCertificatesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListOutgoingCertificates", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListOutgoingCertificatesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListOutgoingCertificatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListPoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("ListPolicies");

            var request = InstantiateClassGenerator.Execute<ListPoliciesRequest>();
            var marshaller = new ListPoliciesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListPolicies", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListPoliciesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListPoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListPolicyPrincipalsMarshallTest()
        {
            var operation = service_model.FindOperation("ListPolicyPrincipals");

            var request = InstantiateClassGenerator.Execute<ListPolicyPrincipalsRequest>();
            var marshaller = new ListPolicyPrincipalsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListPolicyPrincipals", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListPolicyPrincipalsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListPolicyPrincipalsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListPolicyVersionsMarshallTest()
        {
            var operation = service_model.FindOperation("ListPolicyVersions");

            var request = InstantiateClassGenerator.Execute<ListPolicyVersionsRequest>();
            var marshaller = new ListPolicyVersionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListPolicyVersions", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListPolicyVersionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListPolicyVersionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListPrincipalPoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("ListPrincipalPolicies");

            var request = InstantiateClassGenerator.Execute<ListPrincipalPoliciesRequest>();
            var marshaller = new ListPrincipalPoliciesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListPrincipalPolicies", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListPrincipalPoliciesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListPrincipalPoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListPrincipalThingsMarshallTest()
        {
            var operation = service_model.FindOperation("ListPrincipalThings");

            var request = InstantiateClassGenerator.Execute<ListPrincipalThingsRequest>();
            var marshaller = new ListPrincipalThingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListPrincipalThings", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListPrincipalThingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListPrincipalThingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListRoleAliasesMarshallTest()
        {
            var operation = service_model.FindOperation("ListRoleAliases");

            var request = InstantiateClassGenerator.Execute<ListRoleAliasesRequest>();
            var marshaller = new ListRoleAliasesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListRoleAliases", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListRoleAliasesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListRoleAliasesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListStreamsMarshallTest()
        {
            var operation = service_model.FindOperation("ListStreams");

            var request = InstantiateClassGenerator.Execute<ListStreamsRequest>();
            var marshaller = new ListStreamsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListStreams", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListStreamsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListStreamsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListTargetsForPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("ListTargetsForPolicy");

            var request = InstantiateClassGenerator.Execute<ListTargetsForPolicyRequest>();
            var marshaller = new ListTargetsForPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListTargetsForPolicy", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListTargetsForPolicyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListTargetsForPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListThingGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("ListThingGroups");

            var request = InstantiateClassGenerator.Execute<ListThingGroupsRequest>();
            var marshaller = new ListThingGroupsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListThingGroups", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListThingGroupsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListThingGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListThingGroupsForThingMarshallTest()
        {
            var operation = service_model.FindOperation("ListThingGroupsForThing");

            var request = InstantiateClassGenerator.Execute<ListThingGroupsForThingRequest>();
            var marshaller = new ListThingGroupsForThingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListThingGroupsForThing", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListThingGroupsForThingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListThingGroupsForThingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListThingPrincipalsMarshallTest()
        {
            var operation = service_model.FindOperation("ListThingPrincipals");

            var request = InstantiateClassGenerator.Execute<ListThingPrincipalsRequest>();
            var marshaller = new ListThingPrincipalsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListThingPrincipals", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListThingPrincipalsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListThingPrincipalsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListThingRegistrationTaskReportsMarshallTest()
        {
            var operation = service_model.FindOperation("ListThingRegistrationTaskReports");

            var request = InstantiateClassGenerator.Execute<ListThingRegistrationTaskReportsRequest>();
            var marshaller = new ListThingRegistrationTaskReportsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListThingRegistrationTaskReports", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListThingRegistrationTaskReportsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListThingRegistrationTaskReportsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListThingRegistrationTasksMarshallTest()
        {
            var operation = service_model.FindOperation("ListThingRegistrationTasks");

            var request = InstantiateClassGenerator.Execute<ListThingRegistrationTasksRequest>();
            var marshaller = new ListThingRegistrationTasksRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListThingRegistrationTasks", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListThingRegistrationTasksResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListThingRegistrationTasksResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListThingsMarshallTest()
        {
            var operation = service_model.FindOperation("ListThings");

            var request = InstantiateClassGenerator.Execute<ListThingsRequest>();
            var marshaller = new ListThingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListThings", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListThingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListThingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListThingsInThingGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ListThingsInThingGroup");

            var request = InstantiateClassGenerator.Execute<ListThingsInThingGroupRequest>();
            var marshaller = new ListThingsInThingGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListThingsInThingGroup", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListThingsInThingGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListThingsInThingGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListThingTypesMarshallTest()
        {
            var operation = service_model.FindOperation("ListThingTypes");

            var request = InstantiateClassGenerator.Execute<ListThingTypesRequest>();
            var marshaller = new ListThingTypesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListThingTypes", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListThingTypesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListThingTypesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListTopicRulesMarshallTest()
        {
            var operation = service_model.FindOperation("ListTopicRules");

            var request = InstantiateClassGenerator.Execute<ListTopicRulesRequest>();
            var marshaller = new ListTopicRulesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListTopicRules", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListTopicRulesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListTopicRulesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ListV2LoggingLevelsMarshallTest()
        {
            var operation = service_model.FindOperation("ListV2LoggingLevels");

            var request = InstantiateClassGenerator.Execute<ListV2LoggingLevelsRequest>();
            var marshaller = new ListV2LoggingLevelsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListV2LoggingLevels", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListV2LoggingLevelsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListV2LoggingLevelsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void RegisterCACertificateMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterCACertificate");

            var request = InstantiateClassGenerator.Execute<RegisterCACertificateRequest>();
            var marshaller = new RegisterCACertificateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("RegisterCACertificate", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = RegisterCACertificateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as RegisterCACertificateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void RegisterCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterCertificate");

            var request = InstantiateClassGenerator.Execute<RegisterCertificateRequest>();
            var marshaller = new RegisterCertificateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("RegisterCertificate", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = RegisterCertificateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as RegisterCertificateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void RegisterThingMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterThing");

            var request = InstantiateClassGenerator.Execute<RegisterThingRequest>();
            var marshaller = new RegisterThingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("RegisterThing", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = RegisterThingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as RegisterThingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void RejectCertificateTransferMarshallTest()
        {
            var operation = service_model.FindOperation("RejectCertificateTransfer");

            var request = InstantiateClassGenerator.Execute<RejectCertificateTransferRequest>();
            var marshaller = new RejectCertificateTransferRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("RejectCertificateTransfer", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void RemoveThingFromThingGroupMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveThingFromThingGroup");

            var request = InstantiateClassGenerator.Execute<RemoveThingFromThingGroupRequest>();
            var marshaller = new RemoveThingFromThingGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("RemoveThingFromThingGroup", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = RemoveThingFromThingGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as RemoveThingFromThingGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void ReplaceTopicRuleMarshallTest()
        {
            var operation = service_model.FindOperation("ReplaceTopicRule");

            var request = InstantiateClassGenerator.Execute<ReplaceTopicRuleRequest>();
            var marshaller = new ReplaceTopicRuleRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ReplaceTopicRule", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void SearchIndexMarshallTest()
        {
            var operation = service_model.FindOperation("SearchIndex");

            var request = InstantiateClassGenerator.Execute<SearchIndexRequest>();
            var marshaller = new SearchIndexRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("SearchIndex", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = SearchIndexResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as SearchIndexResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void SetDefaultAuthorizerMarshallTest()
        {
            var operation = service_model.FindOperation("SetDefaultAuthorizer");

            var request = InstantiateClassGenerator.Execute<SetDefaultAuthorizerRequest>();
            var marshaller = new SetDefaultAuthorizerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("SetDefaultAuthorizer", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = SetDefaultAuthorizerResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as SetDefaultAuthorizerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void SetDefaultPolicyVersionMarshallTest()
        {
            var operation = service_model.FindOperation("SetDefaultPolicyVersion");

            var request = InstantiateClassGenerator.Execute<SetDefaultPolicyVersionRequest>();
            var marshaller = new SetDefaultPolicyVersionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("SetDefaultPolicyVersion", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void SetLoggingOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("SetLoggingOptions");

            var request = InstantiateClassGenerator.Execute<SetLoggingOptionsRequest>();
            var marshaller = new SetLoggingOptionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("SetLoggingOptions", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void SetV2LoggingLevelMarshallTest()
        {
            var operation = service_model.FindOperation("SetV2LoggingLevel");

            var request = InstantiateClassGenerator.Execute<SetV2LoggingLevelRequest>();
            var marshaller = new SetV2LoggingLevelRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("SetV2LoggingLevel", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void SetV2LoggingOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("SetV2LoggingOptions");

            var request = InstantiateClassGenerator.Execute<SetV2LoggingOptionsRequest>();
            var marshaller = new SetV2LoggingOptionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("SetV2LoggingOptions", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void StartThingRegistrationTaskMarshallTest()
        {
            var operation = service_model.FindOperation("StartThingRegistrationTask");

            var request = InstantiateClassGenerator.Execute<StartThingRegistrationTaskRequest>();
            var marshaller = new StartThingRegistrationTaskRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("StartThingRegistrationTask", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = StartThingRegistrationTaskResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as StartThingRegistrationTaskResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void StopThingRegistrationTaskMarshallTest()
        {
            var operation = service_model.FindOperation("StopThingRegistrationTask");

            var request = InstantiateClassGenerator.Execute<StopThingRegistrationTaskRequest>();
            var marshaller = new StopThingRegistrationTaskRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("StopThingRegistrationTask", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = StopThingRegistrationTaskResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as StopThingRegistrationTaskResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void TestAuthorizationMarshallTest()
        {
            var operation = service_model.FindOperation("TestAuthorization");

            var request = InstantiateClassGenerator.Execute<TestAuthorizationRequest>();
            var marshaller = new TestAuthorizationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("TestAuthorization", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = TestAuthorizationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as TestAuthorizationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void TestInvokeAuthorizerMarshallTest()
        {
            var operation = service_model.FindOperation("TestInvokeAuthorizer");

            var request = InstantiateClassGenerator.Execute<TestInvokeAuthorizerRequest>();
            var marshaller = new TestInvokeAuthorizerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("TestInvokeAuthorizer", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = TestInvokeAuthorizerResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as TestInvokeAuthorizerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void TransferCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("TransferCertificate");

            var request = InstantiateClassGenerator.Execute<TransferCertificateRequest>();
            var marshaller = new TransferCertificateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("TransferCertificate", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = TransferCertificateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as TransferCertificateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void UpdateAuthorizerMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAuthorizer");

            var request = InstantiateClassGenerator.Execute<UpdateAuthorizerRequest>();
            var marshaller = new UpdateAuthorizerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateAuthorizer", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateAuthorizerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void UpdateCACertificateMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCACertificate");

            var request = InstantiateClassGenerator.Execute<UpdateCACertificateRequest>();
            var marshaller = new UpdateCACertificateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateCACertificate", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void UpdateCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCertificate");

            var request = InstantiateClassGenerator.Execute<UpdateCertificateRequest>();
            var marshaller = new UpdateCertificateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateCertificate", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void UpdateEventConfigurationsMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateEventConfigurations");

            var request = InstantiateClassGenerator.Execute<UpdateEventConfigurationsRequest>();
            var marshaller = new UpdateEventConfigurationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateEventConfigurations", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateEventConfigurationsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateEventConfigurationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void UpdateIndexingConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateIndexingConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateIndexingConfigurationRequest>();
            var marshaller = new UpdateIndexingConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateIndexingConfiguration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateIndexingConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateIndexingConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void UpdateRoleAliasMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateRoleAlias");

            var request = InstantiateClassGenerator.Execute<UpdateRoleAliasRequest>();
            var marshaller = new UpdateRoleAliasRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateRoleAlias", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateRoleAliasResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateRoleAliasResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void UpdateStreamMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStream");

            var request = InstantiateClassGenerator.Execute<UpdateStreamRequest>();
            var marshaller = new UpdateStreamRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateStream", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateStreamResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateStreamResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void UpdateThingMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateThing");

            var request = InstantiateClassGenerator.Execute<UpdateThingRequest>();
            var marshaller = new UpdateThingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateThing", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateThingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateThingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void UpdateThingGroupMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateThingGroup");

            var request = InstantiateClassGenerator.Execute<UpdateThingGroupRequest>();
            var marshaller = new UpdateThingGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateThingGroup", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateThingGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateThingGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT")]
        public void UpdateThingGroupsForThingMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateThingGroupsForThing");

            var request = InstantiateClassGenerator.Execute<UpdateThingGroupsForThingRequest>();
            var marshaller = new UpdateThingGroupsForThingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateThingGroupsForThing", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateThingGroupsForThingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateThingGroupsForThingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}