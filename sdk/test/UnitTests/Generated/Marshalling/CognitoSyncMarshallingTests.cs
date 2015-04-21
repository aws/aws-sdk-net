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
 * Do not modify this file. This file is generated from the cognito-sync-2014-06-30.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.CognitoSync;
using Amazon.CognitoSync.Model;
using Amazon.CognitoSync.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class CognitoSyncMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("cognito-sync-2014-06-30.normal.json", "cognito-sync.customizations.json");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CognitoSync")]
        public void BulkPublishMarshallTest()
        {
            var operation = service_model.FindOperation("BulkPublish");

            var request = InstantiateClassGenerator.Execute<BulkPublishRequest>();
            var marshaller = new BulkPublishRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("BulkPublish", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = BulkPublishResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as BulkPublishResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CognitoSync")]
        public void DeleteDatasetMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDataset");

            var request = InstantiateClassGenerator.Execute<DeleteDatasetRequest>();
            var marshaller = new DeleteDatasetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteDataset", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteDatasetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteDatasetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CognitoSync")]
        public void DescribeDatasetMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDataset");

            var request = InstantiateClassGenerator.Execute<DescribeDatasetRequest>();
            var marshaller = new DescribeDatasetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DescribeDataset", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeDatasetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeDatasetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CognitoSync")]
        public void DescribeIdentityPoolUsageMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeIdentityPoolUsage");

            var request = InstantiateClassGenerator.Execute<DescribeIdentityPoolUsageRequest>();
            var marshaller = new DescribeIdentityPoolUsageRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DescribeIdentityPoolUsage", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeIdentityPoolUsageResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeIdentityPoolUsageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CognitoSync")]
        public void DescribeIdentityUsageMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeIdentityUsage");

            var request = InstantiateClassGenerator.Execute<DescribeIdentityUsageRequest>();
            var marshaller = new DescribeIdentityUsageRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DescribeIdentityUsage", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeIdentityUsageResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeIdentityUsageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CognitoSync")]
        public void GetBulkPublishDetailsMarshallTest()
        {
            var operation = service_model.FindOperation("GetBulkPublishDetails");

            var request = InstantiateClassGenerator.Execute<GetBulkPublishDetailsRequest>();
            var marshaller = new GetBulkPublishDetailsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetBulkPublishDetails", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetBulkPublishDetailsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBulkPublishDetailsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CognitoSync")]
        public void GetCognitoEventsMarshallTest()
        {
            var operation = service_model.FindOperation("GetCognitoEvents");

            var request = InstantiateClassGenerator.Execute<GetCognitoEventsRequest>();
            var marshaller = new GetCognitoEventsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetCognitoEvents", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetCognitoEventsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetCognitoEventsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CognitoSync")]
        public void GetIdentityPoolConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("GetIdentityPoolConfiguration");

            var request = InstantiateClassGenerator.Execute<GetIdentityPoolConfigurationRequest>();
            var marshaller = new GetIdentityPoolConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetIdentityPoolConfiguration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetIdentityPoolConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetIdentityPoolConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CognitoSync")]
        public void ListDatasetsMarshallTest()
        {
            var operation = service_model.FindOperation("ListDatasets");

            var request = InstantiateClassGenerator.Execute<ListDatasetsRequest>();
            var marshaller = new ListDatasetsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListDatasets", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListDatasetsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDatasetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CognitoSync")]
        public void ListIdentityPoolUsageMarshallTest()
        {
            var operation = service_model.FindOperation("ListIdentityPoolUsage");

            var request = InstantiateClassGenerator.Execute<ListIdentityPoolUsageRequest>();
            var marshaller = new ListIdentityPoolUsageRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListIdentityPoolUsage", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListIdentityPoolUsageResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListIdentityPoolUsageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CognitoSync")]
        public void ListRecordsMarshallTest()
        {
            var operation = service_model.FindOperation("ListRecords");

            var request = InstantiateClassGenerator.Execute<ListRecordsRequest>();
            var marshaller = new ListRecordsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListRecords", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListRecordsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListRecordsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CognitoSync")]
        public void RegisterDeviceMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterDevice");

            var request = InstantiateClassGenerator.Execute<RegisterDeviceRequest>();
            var marshaller = new RegisterDeviceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("RegisterDevice", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = RegisterDeviceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as RegisterDeviceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CognitoSync")]
        public void SetCognitoEventsMarshallTest()
        {
            var operation = service_model.FindOperation("SetCognitoEvents");

            var request = InstantiateClassGenerator.Execute<SetCognitoEventsRequest>();
            var marshaller = new SetCognitoEventsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("SetCognitoEvents", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CognitoSync")]
        public void SetIdentityPoolConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("SetIdentityPoolConfiguration");

            var request = InstantiateClassGenerator.Execute<SetIdentityPoolConfigurationRequest>();
            var marshaller = new SetIdentityPoolConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("SetIdentityPoolConfiguration", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = SetIdentityPoolConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as SetIdentityPoolConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CognitoSync")]
        public void SubscribeToDatasetMarshallTest()
        {
            var operation = service_model.FindOperation("SubscribeToDataset");

            var request = InstantiateClassGenerator.Execute<SubscribeToDatasetRequest>();
            var marshaller = new SubscribeToDatasetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("SubscribeToDataset", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = SubscribeToDatasetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as SubscribeToDatasetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CognitoSync")]
        public void UnsubscribeFromDatasetMarshallTest()
        {
            var operation = service_model.FindOperation("UnsubscribeFromDataset");

            var request = InstantiateClassGenerator.Execute<UnsubscribeFromDatasetRequest>();
            var marshaller = new UnsubscribeFromDatasetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UnsubscribeFromDataset", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UnsubscribeFromDatasetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UnsubscribeFromDatasetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CognitoSync")]
        public void UpdateRecordsMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateRecords");

            var request = InstantiateClassGenerator.Execute<UpdateRecordsRequest>();
            var marshaller = new UpdateRecordsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateRecords", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateRecordsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateRecordsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}