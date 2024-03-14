/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sagemaker-edge-2020-09-23.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SagemakerEdgeManager;
using Amazon.SagemakerEdgeManager.Model;
using Amazon.SagemakerEdgeManager.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet.UnitTests.TestTools;

namespace AWSSDK_DotNet.UnitTests.Marshalling
{
    [TestClass]
    public partial class SagemakerEdgeManagerMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("sagemaker-edge");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SagemakerEdgeManager")]
        public void GetDeploymentsMarshallTest()
        {
            var operation = service_model.FindOperation("GetDeployments");

            var request = InstantiateClassGenerator.Execute<GetDeploymentsRequest>(operation);
            var marshaller = new GetDeploymentsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetDeployments", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = GetDeploymentsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetDeploymentsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SagemakerEdgeManager")]
        public void GetDeployments_InternalServiceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetDeployments");

            var request = InstantiateClassGenerator.Execute<GetDeploymentsRequest>(operation);
            var marshaller = new GetDeploymentsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetDeployments", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServiceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServiceException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetDeploymentsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SagemakerEdgeManager")]
        public void GetDeviceRegistrationMarshallTest()
        {
            var operation = service_model.FindOperation("GetDeviceRegistration");

            var request = InstantiateClassGenerator.Execute<GetDeviceRegistrationRequest>(operation);
            var marshaller = new GetDeviceRegistrationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetDeviceRegistration", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = GetDeviceRegistrationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetDeviceRegistrationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SagemakerEdgeManager")]
        public void GetDeviceRegistration_InternalServiceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetDeviceRegistration");

            var request = InstantiateClassGenerator.Execute<GetDeviceRegistrationRequest>(operation);
            var marshaller = new GetDeviceRegistrationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetDeviceRegistration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServiceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServiceException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetDeviceRegistrationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SagemakerEdgeManager")]
        public void SendHeartbeatMarshallTest()
        {
            var operation = service_model.FindOperation("SendHeartbeat");

            var request = InstantiateClassGenerator.Execute<SendHeartbeatRequest>(operation);
            var marshaller = new SendHeartbeatRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("SendHeartbeat", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SagemakerEdgeManager")]
        public void SendHeartbeat_InternalServiceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SendHeartbeat");

            var request = InstantiateClassGenerator.Execute<SendHeartbeatRequest>(operation);
            var marshaller = new SendHeartbeatRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("SendHeartbeat", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServiceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServiceException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = SendHeartbeatResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}