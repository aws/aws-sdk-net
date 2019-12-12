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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SimpleEmailV2;
using Amazon.SimpleEmailV2.Model;
using Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class SimpleEmailServiceV2MarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("sesv2");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void CreateConfigurationSetMarshallTest()
        {
            var operation = service_model.FindOperation("CreateConfigurationSet");

            var request = InstantiateClassGenerator.Execute<CreateConfigurationSetRequest>();
            var marshaller = new CreateConfigurationSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateConfigurationSet", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateConfigurationSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void CreateConfigurationSetEventDestinationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateConfigurationSetEventDestination");

            var request = InstantiateClassGenerator.Execute<CreateConfigurationSetEventDestinationRequest>();
            var marshaller = new CreateConfigurationSetEventDestinationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateConfigurationSetEventDestination", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateConfigurationSetEventDestinationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateConfigurationSetEventDestinationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void CreateDedicatedIpPoolMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDedicatedIpPool");

            var request = InstantiateClassGenerator.Execute<CreateDedicatedIpPoolRequest>();
            var marshaller = new CreateDedicatedIpPoolRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateDedicatedIpPool", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateDedicatedIpPoolResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateDedicatedIpPoolResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void CreateDeliverabilityTestReportMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDeliverabilityTestReport");

            var request = InstantiateClassGenerator.Execute<CreateDeliverabilityTestReportRequest>();
            var marshaller = new CreateDeliverabilityTestReportRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateDeliverabilityTestReport", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateDeliverabilityTestReportResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateDeliverabilityTestReportResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void CreateEmailIdentityMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEmailIdentity");

            var request = InstantiateClassGenerator.Execute<CreateEmailIdentityRequest>();
            var marshaller = new CreateEmailIdentityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateEmailIdentity", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateEmailIdentityResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateEmailIdentityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void DeleteConfigurationSetMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteConfigurationSet");

            var request = InstantiateClassGenerator.Execute<DeleteConfigurationSetRequest>();
            var marshaller = new DeleteConfigurationSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteConfigurationSet", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteConfigurationSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void DeleteConfigurationSetEventDestinationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteConfigurationSetEventDestination");

            var request = InstantiateClassGenerator.Execute<DeleteConfigurationSetEventDestinationRequest>();
            var marshaller = new DeleteConfigurationSetEventDestinationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteConfigurationSetEventDestination", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteConfigurationSetEventDestinationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteConfigurationSetEventDestinationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void DeleteDedicatedIpPoolMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDedicatedIpPool");

            var request = InstantiateClassGenerator.Execute<DeleteDedicatedIpPoolRequest>();
            var marshaller = new DeleteDedicatedIpPoolRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteDedicatedIpPool", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteDedicatedIpPoolResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteDedicatedIpPoolResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void DeleteEmailIdentityMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEmailIdentity");

            var request = InstantiateClassGenerator.Execute<DeleteEmailIdentityRequest>();
            var marshaller = new DeleteEmailIdentityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteEmailIdentity", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteEmailIdentityResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteEmailIdentityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void DeleteSuppressedDestinationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSuppressedDestination");

            var request = InstantiateClassGenerator.Execute<DeleteSuppressedDestinationRequest>();
            var marshaller = new DeleteSuppressedDestinationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteSuppressedDestination", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteSuppressedDestinationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteSuppressedDestinationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void GetAccountMarshallTest()
        {
            var operation = service_model.FindOperation("GetAccount");

            var request = InstantiateClassGenerator.Execute<GetAccountRequest>();
            var marshaller = new GetAccountRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetAccount", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetAccountResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetAccountResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void GetBlacklistReportsMarshallTest()
        {
            var operation = service_model.FindOperation("GetBlacklistReports");

            var request = InstantiateClassGenerator.Execute<GetBlacklistReportsRequest>();
            var marshaller = new GetBlacklistReportsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBlacklistReports", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetBlacklistReportsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBlacklistReportsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void GetConfigurationSetMarshallTest()
        {
            var operation = service_model.FindOperation("GetConfigurationSet");

            var request = InstantiateClassGenerator.Execute<GetConfigurationSetRequest>();
            var marshaller = new GetConfigurationSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetConfigurationSet", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetConfigurationSetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetConfigurationSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void GetConfigurationSetEventDestinationsMarshallTest()
        {
            var operation = service_model.FindOperation("GetConfigurationSetEventDestinations");

            var request = InstantiateClassGenerator.Execute<GetConfigurationSetEventDestinationsRequest>();
            var marshaller = new GetConfigurationSetEventDestinationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetConfigurationSetEventDestinations", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetConfigurationSetEventDestinationsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetConfigurationSetEventDestinationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void GetDedicatedIpMarshallTest()
        {
            var operation = service_model.FindOperation("GetDedicatedIp");

            var request = InstantiateClassGenerator.Execute<GetDedicatedIpRequest>();
            var marshaller = new GetDedicatedIpRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetDedicatedIp", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetDedicatedIpResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDedicatedIpResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void GetDedicatedIpsMarshallTest()
        {
            var operation = service_model.FindOperation("GetDedicatedIps");

            var request = InstantiateClassGenerator.Execute<GetDedicatedIpsRequest>();
            var marshaller = new GetDedicatedIpsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetDedicatedIps", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetDedicatedIpsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDedicatedIpsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void GetDeliverabilityDashboardOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("GetDeliverabilityDashboardOptions");

            var request = InstantiateClassGenerator.Execute<GetDeliverabilityDashboardOptionsRequest>();
            var marshaller = new GetDeliverabilityDashboardOptionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetDeliverabilityDashboardOptions", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetDeliverabilityDashboardOptionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDeliverabilityDashboardOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void GetDeliverabilityTestReportMarshallTest()
        {
            var operation = service_model.FindOperation("GetDeliverabilityTestReport");

            var request = InstantiateClassGenerator.Execute<GetDeliverabilityTestReportRequest>();
            var marshaller = new GetDeliverabilityTestReportRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetDeliverabilityTestReport", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetDeliverabilityTestReportResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDeliverabilityTestReportResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void GetDomainDeliverabilityCampaignMarshallTest()
        {
            var operation = service_model.FindOperation("GetDomainDeliverabilityCampaign");

            var request = InstantiateClassGenerator.Execute<GetDomainDeliverabilityCampaignRequest>();
            var marshaller = new GetDomainDeliverabilityCampaignRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetDomainDeliverabilityCampaign", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetDomainDeliverabilityCampaignResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDomainDeliverabilityCampaignResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void GetDomainStatisticsReportMarshallTest()
        {
            var operation = service_model.FindOperation("GetDomainStatisticsReport");

            var request = InstantiateClassGenerator.Execute<GetDomainStatisticsReportRequest>();
            var marshaller = new GetDomainStatisticsReportRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetDomainStatisticsReport", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetDomainStatisticsReportResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDomainStatisticsReportResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void GetEmailIdentityMarshallTest()
        {
            var operation = service_model.FindOperation("GetEmailIdentity");

            var request = InstantiateClassGenerator.Execute<GetEmailIdentityRequest>();
            var marshaller = new GetEmailIdentityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetEmailIdentity", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetEmailIdentityResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetEmailIdentityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void GetSuppressedDestinationMarshallTest()
        {
            var operation = service_model.FindOperation("GetSuppressedDestination");

            var request = InstantiateClassGenerator.Execute<GetSuppressedDestinationRequest>();
            var marshaller = new GetSuppressedDestinationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetSuppressedDestination", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetSuppressedDestinationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetSuppressedDestinationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void ListConfigurationSetsMarshallTest()
        {
            var operation = service_model.FindOperation("ListConfigurationSets");

            var request = InstantiateClassGenerator.Execute<ListConfigurationSetsRequest>();
            var marshaller = new ListConfigurationSetsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListConfigurationSets", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListConfigurationSetsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListConfigurationSetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void ListDedicatedIpPoolsMarshallTest()
        {
            var operation = service_model.FindOperation("ListDedicatedIpPools");

            var request = InstantiateClassGenerator.Execute<ListDedicatedIpPoolsRequest>();
            var marshaller = new ListDedicatedIpPoolsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListDedicatedIpPools", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListDedicatedIpPoolsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDedicatedIpPoolsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void ListDeliverabilityTestReportsMarshallTest()
        {
            var operation = service_model.FindOperation("ListDeliverabilityTestReports");

            var request = InstantiateClassGenerator.Execute<ListDeliverabilityTestReportsRequest>();
            var marshaller = new ListDeliverabilityTestReportsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListDeliverabilityTestReports", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListDeliverabilityTestReportsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDeliverabilityTestReportsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void ListDomainDeliverabilityCampaignsMarshallTest()
        {
            var operation = service_model.FindOperation("ListDomainDeliverabilityCampaigns");

            var request = InstantiateClassGenerator.Execute<ListDomainDeliverabilityCampaignsRequest>();
            var marshaller = new ListDomainDeliverabilityCampaignsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListDomainDeliverabilityCampaigns", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListDomainDeliverabilityCampaignsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDomainDeliverabilityCampaignsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void ListEmailIdentitiesMarshallTest()
        {
            var operation = service_model.FindOperation("ListEmailIdentities");

            var request = InstantiateClassGenerator.Execute<ListEmailIdentitiesRequest>();
            var marshaller = new ListEmailIdentitiesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListEmailIdentities", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListEmailIdentitiesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListEmailIdentitiesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void ListSuppressedDestinationsMarshallTest()
        {
            var operation = service_model.FindOperation("ListSuppressedDestinations");

            var request = InstantiateClassGenerator.Execute<ListSuppressedDestinationsRequest>();
            var marshaller = new ListSuppressedDestinationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListSuppressedDestinations", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListSuppressedDestinationsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListSuppressedDestinationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void ListTagsForResourceMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListTagsForResource", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListTagsForResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void PutAccountDedicatedIpWarmupAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("PutAccountDedicatedIpWarmupAttributes");

            var request = InstantiateClassGenerator.Execute<PutAccountDedicatedIpWarmupAttributesRequest>();
            var marshaller = new PutAccountDedicatedIpWarmupAttributesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutAccountDedicatedIpWarmupAttributes", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutAccountDedicatedIpWarmupAttributesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutAccountDedicatedIpWarmupAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void PutAccountSendingAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("PutAccountSendingAttributes");

            var request = InstantiateClassGenerator.Execute<PutAccountSendingAttributesRequest>();
            var marshaller = new PutAccountSendingAttributesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutAccountSendingAttributes", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutAccountSendingAttributesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutAccountSendingAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void PutAccountSuppressionAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("PutAccountSuppressionAttributes");

            var request = InstantiateClassGenerator.Execute<PutAccountSuppressionAttributesRequest>();
            var marshaller = new PutAccountSuppressionAttributesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutAccountSuppressionAttributes", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutAccountSuppressionAttributesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutAccountSuppressionAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void PutConfigurationSetDeliveryOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("PutConfigurationSetDeliveryOptions");

            var request = InstantiateClassGenerator.Execute<PutConfigurationSetDeliveryOptionsRequest>();
            var marshaller = new PutConfigurationSetDeliveryOptionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutConfigurationSetDeliveryOptions", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutConfigurationSetDeliveryOptionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutConfigurationSetDeliveryOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void PutConfigurationSetReputationOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("PutConfigurationSetReputationOptions");

            var request = InstantiateClassGenerator.Execute<PutConfigurationSetReputationOptionsRequest>();
            var marshaller = new PutConfigurationSetReputationOptionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutConfigurationSetReputationOptions", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutConfigurationSetReputationOptionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutConfigurationSetReputationOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void PutConfigurationSetSendingOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("PutConfigurationSetSendingOptions");

            var request = InstantiateClassGenerator.Execute<PutConfigurationSetSendingOptionsRequest>();
            var marshaller = new PutConfigurationSetSendingOptionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutConfigurationSetSendingOptions", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutConfigurationSetSendingOptionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutConfigurationSetSendingOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void PutConfigurationSetSuppressionOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("PutConfigurationSetSuppressionOptions");

            var request = InstantiateClassGenerator.Execute<PutConfigurationSetSuppressionOptionsRequest>();
            var marshaller = new PutConfigurationSetSuppressionOptionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutConfigurationSetSuppressionOptions", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutConfigurationSetSuppressionOptionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutConfigurationSetSuppressionOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void PutConfigurationSetTrackingOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("PutConfigurationSetTrackingOptions");

            var request = InstantiateClassGenerator.Execute<PutConfigurationSetTrackingOptionsRequest>();
            var marshaller = new PutConfigurationSetTrackingOptionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutConfigurationSetTrackingOptions", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutConfigurationSetTrackingOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void PutDedicatedIpInPoolMarshallTest()
        {
            var operation = service_model.FindOperation("PutDedicatedIpInPool");

            var request = InstantiateClassGenerator.Execute<PutDedicatedIpInPoolRequest>();
            var marshaller = new PutDedicatedIpInPoolRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutDedicatedIpInPool", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutDedicatedIpInPoolResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutDedicatedIpInPoolResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void PutDedicatedIpWarmupAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("PutDedicatedIpWarmupAttributes");

            var request = InstantiateClassGenerator.Execute<PutDedicatedIpWarmupAttributesRequest>();
            var marshaller = new PutDedicatedIpWarmupAttributesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutDedicatedIpWarmupAttributes", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutDedicatedIpWarmupAttributesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutDedicatedIpWarmupAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void PutDeliverabilityDashboardOptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutDeliverabilityDashboardOption");

            var request = InstantiateClassGenerator.Execute<PutDeliverabilityDashboardOptionRequest>();
            var marshaller = new PutDeliverabilityDashboardOptionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutDeliverabilityDashboardOption", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutDeliverabilityDashboardOptionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutDeliverabilityDashboardOptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void PutEmailIdentityDkimAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("PutEmailIdentityDkimAttributes");

            var request = InstantiateClassGenerator.Execute<PutEmailIdentityDkimAttributesRequest>();
            var marshaller = new PutEmailIdentityDkimAttributesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutEmailIdentityDkimAttributes", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutEmailIdentityDkimAttributesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutEmailIdentityDkimAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void PutEmailIdentityFeedbackAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("PutEmailIdentityFeedbackAttributes");

            var request = InstantiateClassGenerator.Execute<PutEmailIdentityFeedbackAttributesRequest>();
            var marshaller = new PutEmailIdentityFeedbackAttributesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutEmailIdentityFeedbackAttributes", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutEmailIdentityFeedbackAttributesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutEmailIdentityFeedbackAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void PutEmailIdentityMailFromAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("PutEmailIdentityMailFromAttributes");

            var request = InstantiateClassGenerator.Execute<PutEmailIdentityMailFromAttributesRequest>();
            var marshaller = new PutEmailIdentityMailFromAttributesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutEmailIdentityMailFromAttributes", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutEmailIdentityMailFromAttributesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutEmailIdentityMailFromAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void PutSuppressedDestinationMarshallTest()
        {
            var operation = service_model.FindOperation("PutSuppressedDestination");

            var request = InstantiateClassGenerator.Execute<PutSuppressedDestinationRequest>();
            var marshaller = new PutSuppressedDestinationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutSuppressedDestination", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PutSuppressedDestinationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutSuppressedDestinationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void SendEmailMarshallTest()
        {
            var operation = service_model.FindOperation("SendEmail");

            var request = InstantiateClassGenerator.Execute<SendEmailRequest>();
            var marshaller = new SendEmailRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("SendEmail", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = SendEmailResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as SendEmailResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void TagResourceMarshallTest()
        {
            var operation = service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>();
            var marshaller = new TagResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("TagResource", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = TagResourceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as TagResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void UntagResourceMarshallTest()
        {
            var operation = service_model.FindOperation("UntagResource");

            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>();
            var marshaller = new UntagResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UntagResource", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UntagResourceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UntagResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SimpleEmailV2")]
        public void UpdateConfigurationSetEventDestinationMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateConfigurationSetEventDestination");

            var request = InstantiateClassGenerator.Execute<UpdateConfigurationSetEventDestinationRequest>();
            var marshaller = new UpdateConfigurationSetEventDestinationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateConfigurationSetEventDestination", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateConfigurationSetEventDestinationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateConfigurationSetEventDestinationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}