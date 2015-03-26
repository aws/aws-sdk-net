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
 * Do not modify this file. This file is generated from the config-2014-10-17.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.ConfigService;
using Amazon.ConfigService.Model;
using Amazon.ConfigService.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class ConfigServiceMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("config-2014-10-17.normal.json", "config.customizations.json");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ConfigService")]
        public void DeleteDeliveryChannelMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeleteDeliveryChannelRequest>();
            var marshaller = new DeleteDeliveryChannelRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DeleteDeliveryChannelRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ConfigService")]
        public void DeliverConfigSnapshotMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeliverConfigSnapshotRequest>();
            var marshaller = new DeliverConfigSnapshotRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DeliverConfigSnapshotRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DeliverConfigSnapshot").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DeliverConfigSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as DeliverConfigSnapshotResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ConfigService")]
        public void DescribeConfigurationRecordersMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConfigurationRecordersRequest>();
            var marshaller = new DescribeConfigurationRecordersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeConfigurationRecordersRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeConfigurationRecorders").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeConfigurationRecordersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeConfigurationRecordersResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ConfigService")]
        public void DescribeConfigurationRecorderStatusMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConfigurationRecorderStatusRequest>();
            var marshaller = new DescribeConfigurationRecorderStatusRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeConfigurationRecorderStatusRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeConfigurationRecorderStatus").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeConfigurationRecorderStatusResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeConfigurationRecorderStatusResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ConfigService")]
        public void DescribeDeliveryChannelsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDeliveryChannelsRequest>();
            var marshaller = new DescribeDeliveryChannelsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeDeliveryChannelsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeDeliveryChannels").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeDeliveryChannelsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDeliveryChannelsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ConfigService")]
        public void DescribeDeliveryChannelStatusMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDeliveryChannelStatusRequest>();
            var marshaller = new DescribeDeliveryChannelStatusRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeDeliveryChannelStatusRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeDeliveryChannelStatus").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeDeliveryChannelStatusResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDeliveryChannelStatusResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ConfigService")]
        public void GetResourceConfigHistoryMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetResourceConfigHistoryRequest>();
            var marshaller = new GetResourceConfigHistoryRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<GetResourceConfigHistoryRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetResourceConfigHistory").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetResourceConfigHistoryResponseUnmarshaller.Instance.Unmarshall(context)
                as GetResourceConfigHistoryResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ConfigService")]
        public void PutConfigurationRecorderMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<PutConfigurationRecorderRequest>();
            var marshaller = new PutConfigurationRecorderRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<PutConfigurationRecorderRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ConfigService")]
        public void PutDeliveryChannelMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<PutDeliveryChannelRequest>();
            var marshaller = new PutDeliveryChannelRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<PutDeliveryChannelRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ConfigService")]
        public void StartConfigurationRecorderMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<StartConfigurationRecorderRequest>();
            var marshaller = new StartConfigurationRecorderRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<StartConfigurationRecorderRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ConfigService")]
        public void StopConfigurationRecorderMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<StopConfigurationRecorderRequest>();
            var marshaller = new StopConfigurationRecorderRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<StopConfigurationRecorderRequest>(request,jsonRequest);

        }

            }
}