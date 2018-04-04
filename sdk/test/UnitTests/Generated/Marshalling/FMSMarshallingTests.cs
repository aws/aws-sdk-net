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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.FMS;
using Amazon.FMS.Model;
using Amazon.FMS.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class FMSMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("fms");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("FMS")]
        public void AssociateAdminAccountMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<AssociateAdminAccountRequest>();
            var marshaller = new AssociateAdminAccountRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<AssociateAdminAccountRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("FMS")]
        public void DeleteNotificationChannelMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeleteNotificationChannelRequest>();
            var marshaller = new DeleteNotificationChannelRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DeleteNotificationChannelRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("FMS")]
        public void DeletePolicyMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeletePolicyRequest>();
            var marshaller = new DeletePolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DeletePolicyRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("FMS")]
        public void DisassociateAdminAccountMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DisassociateAdminAccountRequest>();
            var marshaller = new DisassociateAdminAccountRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DisassociateAdminAccountRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("FMS")]
        public void GetAdminAccountMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetAdminAccountRequest>();
            var marshaller = new GetAdminAccountRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<GetAdminAccountRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetAdminAccount").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetAdminAccountResponseUnmarshaller.Instance.Unmarshall(context)
                as GetAdminAccountResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("FMS")]
        public void GetComplianceDetailMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetComplianceDetailRequest>();
            var marshaller = new GetComplianceDetailRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<GetComplianceDetailRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetComplianceDetail").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetComplianceDetailResponseUnmarshaller.Instance.Unmarshall(context)
                as GetComplianceDetailResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("FMS")]
        public void GetNotificationChannelMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetNotificationChannelRequest>();
            var marshaller = new GetNotificationChannelRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<GetNotificationChannelRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetNotificationChannel").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetNotificationChannelResponseUnmarshaller.Instance.Unmarshall(context)
                as GetNotificationChannelResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("FMS")]
        public void GetPolicyMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetPolicyRequest>();
            var marshaller = new GetPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<GetPolicyRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetPolicy").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as GetPolicyResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("FMS")]
        public void ListComplianceStatusMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListComplianceStatusRequest>();
            var marshaller = new ListComplianceStatusRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<ListComplianceStatusRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListComplianceStatus").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListComplianceStatusResponseUnmarshaller.Instance.Unmarshall(context)
                as ListComplianceStatusResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("FMS")]
        public void ListPoliciesMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListPoliciesRequest>();
            var marshaller = new ListPoliciesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<ListPoliciesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListPolicies").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListPoliciesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListPoliciesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("FMS")]
        public void PutNotificationChannelMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<PutNotificationChannelRequest>();
            var marshaller = new PutNotificationChannelRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<PutNotificationChannelRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("FMS")]
        public void PutPolicyMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<PutPolicyRequest>();
            var marshaller = new PutPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<PutPolicyRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("PutPolicy").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = PutPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as PutPolicyResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

            }
}