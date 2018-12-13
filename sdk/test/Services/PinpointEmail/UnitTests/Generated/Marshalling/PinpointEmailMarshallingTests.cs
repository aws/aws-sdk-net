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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.PinpointEmail;
using Amazon.PinpointEmail.Model;
using Amazon.PinpointEmail.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class PinpointEmailMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("pinpoint-email");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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
        [TestCategory("PinpointEmail")]
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