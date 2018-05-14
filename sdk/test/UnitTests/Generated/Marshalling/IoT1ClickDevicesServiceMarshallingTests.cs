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
 * Do not modify this file. This file is generated from the iot1click-devices-2018-05-14.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.IoT1ClickDevicesService;
using Amazon.IoT1ClickDevicesService.Model;
using Amazon.IoT1ClickDevicesService.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class IoT1ClickDevicesServiceMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("iot1click-devices");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT1ClickDevicesService")]
        public void ClaimDevicesByClaimCodeMarshallTest()
        {
            var operation = service_model.FindOperation("ClaimDevicesByClaimCode");

            var request = InstantiateClassGenerator.Execute<ClaimDevicesByClaimCodeRequest>();
            var marshaller = new ClaimDevicesByClaimCodeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ClaimDevicesByClaimCode", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ClaimDevicesByClaimCodeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ClaimDevicesByClaimCodeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT1ClickDevicesService")]
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
        [TestCategory("IoT1ClickDevicesService")]
        public void FinalizeDeviceClaimMarshallTest()
        {
            var operation = service_model.FindOperation("FinalizeDeviceClaim");

            var request = InstantiateClassGenerator.Execute<FinalizeDeviceClaimRequest>();
            var marshaller = new FinalizeDeviceClaimRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("FinalizeDeviceClaim", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = FinalizeDeviceClaimResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as FinalizeDeviceClaimResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT1ClickDevicesService")]
        public void GetDeviceMethodsMarshallTest()
        {
            var operation = service_model.FindOperation("GetDeviceMethods");

            var request = InstantiateClassGenerator.Execute<GetDeviceMethodsRequest>();
            var marshaller = new GetDeviceMethodsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetDeviceMethods", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetDeviceMethodsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDeviceMethodsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT1ClickDevicesService")]
        public void InitiateDeviceClaimMarshallTest()
        {
            var operation = service_model.FindOperation("InitiateDeviceClaim");

            var request = InstantiateClassGenerator.Execute<InitiateDeviceClaimRequest>();
            var marshaller = new InitiateDeviceClaimRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("InitiateDeviceClaim", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = InitiateDeviceClaimResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as InitiateDeviceClaimResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT1ClickDevicesService")]
        public void InvokeDeviceMethodMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeDeviceMethod");

            var request = InstantiateClassGenerator.Execute<InvokeDeviceMethodRequest>();
            var marshaller = new InvokeDeviceMethodRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("InvokeDeviceMethod", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = InvokeDeviceMethodResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as InvokeDeviceMethodResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT1ClickDevicesService")]
        public void ListDeviceEventsMarshallTest()
        {
            var operation = service_model.FindOperation("ListDeviceEvents");

            var request = InstantiateClassGenerator.Execute<ListDeviceEventsRequest>();
            var marshaller = new ListDeviceEventsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListDeviceEvents", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListDeviceEventsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDeviceEventsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT1ClickDevicesService")]
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
        [TestCategory("IoT1ClickDevicesService")]
        public void UnclaimDeviceMarshallTest()
        {
            var operation = service_model.FindOperation("UnclaimDevice");

            var request = InstantiateClassGenerator.Execute<UnclaimDeviceRequest>();
            var marshaller = new UnclaimDeviceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UnclaimDevice", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UnclaimDeviceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UnclaimDeviceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoT1ClickDevicesService")]
        public void UpdateDeviceStateMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDeviceState");

            var request = InstantiateClassGenerator.Execute<UpdateDeviceStateRequest>();
            var marshaller = new UpdateDeviceStateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateDeviceState", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateDeviceStateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateDeviceStateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}