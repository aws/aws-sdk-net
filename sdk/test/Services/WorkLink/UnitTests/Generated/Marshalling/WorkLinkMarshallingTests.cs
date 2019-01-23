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
 * Do not modify this file. This file is generated from the worklink-2018-09-25.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.WorkLink;
using Amazon.WorkLink.Model;
using Amazon.WorkLink.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class WorkLinkMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("worklink");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void AssociateWebsiteCertificateAuthorityMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateWebsiteCertificateAuthority");

            var request = InstantiateClassGenerator.Execute<AssociateWebsiteCertificateAuthorityRequest>();
            var marshaller = new AssociateWebsiteCertificateAuthorityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("AssociateWebsiteCertificateAuthority", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = AssociateWebsiteCertificateAuthorityResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as AssociateWebsiteCertificateAuthorityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void CreateFleetMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFleet");

            var request = InstantiateClassGenerator.Execute<CreateFleetRequest>();
            var marshaller = new CreateFleetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateFleet", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateFleetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateFleetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void DeleteFleetMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFleet");

            var request = InstantiateClassGenerator.Execute<DeleteFleetRequest>();
            var marshaller = new DeleteFleetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteFleet", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteFleetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteFleetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void DescribeAuditStreamConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAuditStreamConfiguration");

            var request = InstantiateClassGenerator.Execute<DescribeAuditStreamConfigurationRequest>();
            var marshaller = new DescribeAuditStreamConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeAuditStreamConfiguration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeAuditStreamConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeAuditStreamConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void DescribeCompanyNetworkConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeCompanyNetworkConfiguration");

            var request = InstantiateClassGenerator.Execute<DescribeCompanyNetworkConfigurationRequest>();
            var marshaller = new DescribeCompanyNetworkConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeCompanyNetworkConfiguration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeCompanyNetworkConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeCompanyNetworkConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void DescribeDeviceMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDevice");

            var request = InstantiateClassGenerator.Execute<DescribeDeviceRequest>();
            var marshaller = new DescribeDeviceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeDevice", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeDeviceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeDeviceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void DescribeDevicePolicyConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDevicePolicyConfiguration");

            var request = InstantiateClassGenerator.Execute<DescribeDevicePolicyConfigurationRequest>();
            var marshaller = new DescribeDevicePolicyConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeDevicePolicyConfiguration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeDevicePolicyConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeDevicePolicyConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void DescribeFleetMetadataMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeFleetMetadata");

            var request = InstantiateClassGenerator.Execute<DescribeFleetMetadataRequest>();
            var marshaller = new DescribeFleetMetadataRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeFleetMetadata", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeFleetMetadataResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeFleetMetadataResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void DescribeIdentityProviderConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeIdentityProviderConfiguration");

            var request = InstantiateClassGenerator.Execute<DescribeIdentityProviderConfigurationRequest>();
            var marshaller = new DescribeIdentityProviderConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeIdentityProviderConfiguration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeIdentityProviderConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeIdentityProviderConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void DescribeWebsiteCertificateAuthorityMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeWebsiteCertificateAuthority");

            var request = InstantiateClassGenerator.Execute<DescribeWebsiteCertificateAuthorityRequest>();
            var marshaller = new DescribeWebsiteCertificateAuthorityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeWebsiteCertificateAuthority", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeWebsiteCertificateAuthorityResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeWebsiteCertificateAuthorityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void DisassociateWebsiteCertificateAuthorityMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateWebsiteCertificateAuthority");

            var request = InstantiateClassGenerator.Execute<DisassociateWebsiteCertificateAuthorityRequest>();
            var marshaller = new DisassociateWebsiteCertificateAuthorityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DisassociateWebsiteCertificateAuthority", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DisassociateWebsiteCertificateAuthorityResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DisassociateWebsiteCertificateAuthorityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void ListDevicesMarshallTest()
        {
            var operation = service_model.FindOperation("ListDevices");

            var request = InstantiateClassGenerator.Execute<ListDevicesRequest>();
            var marshaller = new ListDevicesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListDevices", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListDevicesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDevicesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void ListFleetsMarshallTest()
        {
            var operation = service_model.FindOperation("ListFleets");

            var request = InstantiateClassGenerator.Execute<ListFleetsRequest>();
            var marshaller = new ListFleetsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListFleets", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListFleetsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListFleetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void ListWebsiteCertificateAuthoritiesMarshallTest()
        {
            var operation = service_model.FindOperation("ListWebsiteCertificateAuthorities");

            var request = InstantiateClassGenerator.Execute<ListWebsiteCertificateAuthoritiesRequest>();
            var marshaller = new ListWebsiteCertificateAuthoritiesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListWebsiteCertificateAuthorities", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListWebsiteCertificateAuthoritiesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListWebsiteCertificateAuthoritiesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void SignOutUserMarshallTest()
        {
            var operation = service_model.FindOperation("SignOutUser");

            var request = InstantiateClassGenerator.Execute<SignOutUserRequest>();
            var marshaller = new SignOutUserRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("SignOutUser", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = SignOutUserResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as SignOutUserResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void UpdateAuditStreamConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAuditStreamConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateAuditStreamConfigurationRequest>();
            var marshaller = new UpdateAuditStreamConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateAuditStreamConfiguration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateAuditStreamConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateAuditStreamConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void UpdateCompanyNetworkConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCompanyNetworkConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateCompanyNetworkConfigurationRequest>();
            var marshaller = new UpdateCompanyNetworkConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateCompanyNetworkConfiguration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateCompanyNetworkConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateCompanyNetworkConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void UpdateDevicePolicyConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDevicePolicyConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateDevicePolicyConfigurationRequest>();
            var marshaller = new UpdateDevicePolicyConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateDevicePolicyConfiguration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateDevicePolicyConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateDevicePolicyConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void UpdateFleetMetadataMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFleetMetadata");

            var request = InstantiateClassGenerator.Execute<UpdateFleetMetadataRequest>();
            var marshaller = new UpdateFleetMetadataRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateFleetMetadata", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateFleetMetadataResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateFleetMetadataResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("WorkLink")]
        public void UpdateIdentityProviderConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateIdentityProviderConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateIdentityProviderConfigurationRequest>();
            var marshaller = new UpdateIdentityProviderConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateIdentityProviderConfiguration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateIdentityProviderConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateIdentityProviderConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}