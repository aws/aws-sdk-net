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
        static readonly ServiceModel service_model = Utils.LoadServiceModel("iot-2015-05-28.normal.json", "iot-2015-.customizations.json");
        
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
            RequestValidator.Validate("AcceptCertificateTransfer", request, internalRequest, service_model);            

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
            RequestValidator.Validate("AttachPrincipalPolicy", request, internalRequest, service_model);            

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
            RequestValidator.Validate("AttachThingPrincipal", request, internalRequest, service_model);            

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
            RequestValidator.Validate("CancelCertificateTransfer", request, internalRequest, service_model);            

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
            RequestValidator.Validate("CreateCertificateFromCsr", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateCertificateFromCsrResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateCertificateFromCsrResponse;   
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
            RequestValidator.Validate("CreateKeysAndCertificate", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateKeysAndCertificateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateKeysAndCertificateResponse;   
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
            RequestValidator.Validate("CreatePolicy", request, internalRequest, service_model);            

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
            RequestValidator.Validate("CreatePolicyVersion", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreatePolicyVersionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreatePolicyVersionResponse;   
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
            RequestValidator.Validate("CreateThing", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateThingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateThingResponse;   
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
            RequestValidator.Validate("CreateTopicRule", request, internalRequest, service_model);            

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
            RequestValidator.Validate("DeleteCACertificate", request, internalRequest, service_model);            

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
            RequestValidator.Validate("DeleteCertificate", request, internalRequest, service_model);            

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
            RequestValidator.Validate("DeletePolicy", request, internalRequest, service_model);            

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
            RequestValidator.Validate("DeletePolicyVersion", request, internalRequest, service_model);            

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
            RequestValidator.Validate("DeleteRegistrationCode", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteRegistrationCodeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteRegistrationCodeResponse;   
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
            RequestValidator.Validate("DeleteThing", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteThingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteThingResponse;   
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
            RequestValidator.Validate("DeleteTopicRule", request, internalRequest, service_model);            

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
            RequestValidator.Validate("DescribeCACertificate", request, internalRequest, service_model);            

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
            RequestValidator.Validate("DescribeCertificate", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeCertificateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeCertificateResponse;   
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
            RequestValidator.Validate("DescribeEndpoint", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeEndpointResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeEndpointResponse;   
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
            RequestValidator.Validate("DescribeThing", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeThingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeThingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
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
            RequestValidator.Validate("DetachPrincipalPolicy", request, internalRequest, service_model);            

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
            RequestValidator.Validate("DetachThingPrincipal", request, internalRequest, service_model);            

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
            RequestValidator.Validate("DisableTopicRule", request, internalRequest, service_model);            

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
            RequestValidator.Validate("EnableTopicRule", request, internalRequest, service_model);            

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
            RequestValidator.Validate("GetLoggingOptions", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetLoggingOptionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetLoggingOptionsResponse;   
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
        [TestCategory("IoT")]
        public void GetPolicyVersionMarshallTest()
        {
            var operation = service_model.FindOperation("GetPolicyVersion");

            var request = InstantiateClassGenerator.Execute<GetPolicyVersionRequest>();
            var marshaller = new GetPolicyVersionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetPolicyVersion", request, internalRequest, service_model);            

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
            RequestValidator.Validate("GetRegistrationCode", request, internalRequest, service_model);            

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
            RequestValidator.Validate("GetTopicRule", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetTopicRuleResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetTopicRuleResponse;   
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
            RequestValidator.Validate("ListCACertificates", request, internalRequest, service_model);            

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
            RequestValidator.Validate("ListCertificates", request, internalRequest, service_model);            

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
            RequestValidator.Validate("ListCertificatesByCA", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListCertificatesByCAResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListCertificatesByCAResponse;   
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
            RequestValidator.Validate("ListPolicies", request, internalRequest, service_model);            

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
            RequestValidator.Validate("ListPolicyPrincipals", request, internalRequest, service_model);            

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
            RequestValidator.Validate("ListPolicyVersions", request, internalRequest, service_model);            

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
            RequestValidator.Validate("ListPrincipalPolicies", request, internalRequest, service_model);            

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
            RequestValidator.Validate("ListPrincipalThings", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListPrincipalThingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListPrincipalThingsResponse;   
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
            RequestValidator.Validate("ListThingPrincipals", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListThingPrincipalsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListThingPrincipalsResponse;   
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
            RequestValidator.Validate("ListThings", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListThingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListThingsResponse;   
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
            RequestValidator.Validate("ListTopicRules", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListTopicRulesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListTopicRulesResponse;   
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
            RequestValidator.Validate("RegisterCACertificate", request, internalRequest, service_model);            

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
            RequestValidator.Validate("RegisterCertificate", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = RegisterCertificateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as RegisterCertificateResponse;   
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
            RequestValidator.Validate("RejectCertificateTransfer", request, internalRequest, service_model);            

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
            RequestValidator.Validate("ReplaceTopicRule", request, internalRequest, service_model);            

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
            RequestValidator.Validate("SetDefaultPolicyVersion", request, internalRequest, service_model);            

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
            RequestValidator.Validate("SetLoggingOptions", request, internalRequest, service_model);            

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
            RequestValidator.Validate("TransferCertificate", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = TransferCertificateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as TransferCertificateResponse;   
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
            RequestValidator.Validate("UpdateCACertificate", request, internalRequest, service_model);            

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
            RequestValidator.Validate("UpdateCertificate", request, internalRequest, service_model);            

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
            RequestValidator.Validate("UpdateThing", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateThingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateThingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}