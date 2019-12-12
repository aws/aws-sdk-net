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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.DataExchange;
using Amazon.DataExchange.Model;
using Amazon.DataExchange.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class DataExchangeMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("dataexchange");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("DataExchange")]
        public void CancelJobMarshallTest()
        {
            var operation = service_model.FindOperation("CancelJob");

            var request = InstantiateClassGenerator.Execute<CancelJobRequest>();
            var marshaller = new CancelJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CancelJob", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("DataExchange")]
        public void CreateDataSetMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDataSet");

            var request = InstantiateClassGenerator.Execute<CreateDataSetRequest>();
            var marshaller = new CreateDataSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateDataSet", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateDataSetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateDataSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("DataExchange")]
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
        [TestCategory("DataExchange")]
        public void CreateRevisionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRevision");

            var request = InstantiateClassGenerator.Execute<CreateRevisionRequest>();
            var marshaller = new CreateRevisionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateRevision", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateRevisionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateRevisionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("DataExchange")]
        public void DeleteAssetMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAsset");

            var request = InstantiateClassGenerator.Execute<DeleteAssetRequest>();
            var marshaller = new DeleteAssetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteAsset", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("DataExchange")]
        public void DeleteDataSetMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDataSet");

            var request = InstantiateClassGenerator.Execute<DeleteDataSetRequest>();
            var marshaller = new DeleteDataSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteDataSet", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("DataExchange")]
        public void DeleteRevisionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRevision");

            var request = InstantiateClassGenerator.Execute<DeleteRevisionRequest>();
            var marshaller = new DeleteRevisionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteRevision", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("DataExchange")]
        public void GetAssetMarshallTest()
        {
            var operation = service_model.FindOperation("GetAsset");

            var request = InstantiateClassGenerator.Execute<GetAssetRequest>();
            var marshaller = new GetAssetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetAsset", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetAssetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetAssetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("DataExchange")]
        public void GetDataSetMarshallTest()
        {
            var operation = service_model.FindOperation("GetDataSet");

            var request = InstantiateClassGenerator.Execute<GetDataSetRequest>();
            var marshaller = new GetDataSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetDataSet", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetDataSetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDataSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("DataExchange")]
        public void GetJobMarshallTest()
        {
            var operation = service_model.FindOperation("GetJob");

            var request = InstantiateClassGenerator.Execute<GetJobRequest>();
            var marshaller = new GetJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetJob", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetJobResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("DataExchange")]
        public void GetRevisionMarshallTest()
        {
            var operation = service_model.FindOperation("GetRevision");

            var request = InstantiateClassGenerator.Execute<GetRevisionRequest>();
            var marshaller = new GetRevisionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetRevision", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetRevisionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetRevisionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("DataExchange")]
        public void ListDataSetRevisionsMarshallTest()
        {
            var operation = service_model.FindOperation("ListDataSetRevisions");

            var request = InstantiateClassGenerator.Execute<ListDataSetRevisionsRequest>();
            var marshaller = new ListDataSetRevisionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListDataSetRevisions", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListDataSetRevisionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDataSetRevisionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("DataExchange")]
        public void ListDataSetsMarshallTest()
        {
            var operation = service_model.FindOperation("ListDataSets");

            var request = InstantiateClassGenerator.Execute<ListDataSetsRequest>();
            var marshaller = new ListDataSetsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListDataSets", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListDataSetsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDataSetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("DataExchange")]
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
        [TestCategory("DataExchange")]
        public void ListRevisionAssetsMarshallTest()
        {
            var operation = service_model.FindOperation("ListRevisionAssets");

            var request = InstantiateClassGenerator.Execute<ListRevisionAssetsRequest>();
            var marshaller = new ListRevisionAssetsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListRevisionAssets", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListRevisionAssetsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListRevisionAssetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("DataExchange")]
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
        [TestCategory("DataExchange")]
        public void StartJobMarshallTest()
        {
            var operation = service_model.FindOperation("StartJob");

            var request = InstantiateClassGenerator.Execute<StartJobRequest>();
            var marshaller = new StartJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("StartJob", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = StartJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as StartJobResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("DataExchange")]
        public void TagResourceMarshallTest()
        {
            var operation = service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>();
            var marshaller = new TagResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("TagResource", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("DataExchange")]
        public void UntagResourceMarshallTest()
        {
            var operation = service_model.FindOperation("UntagResource");

            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>();
            var marshaller = new UntagResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UntagResource", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("DataExchange")]
        public void UpdateAssetMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAsset");

            var request = InstantiateClassGenerator.Execute<UpdateAssetRequest>();
            var marshaller = new UpdateAssetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateAsset", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateAssetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateAssetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("DataExchange")]
        public void UpdateDataSetMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDataSet");

            var request = InstantiateClassGenerator.Execute<UpdateDataSetRequest>();
            var marshaller = new UpdateDataSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateDataSet", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateDataSetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateDataSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("DataExchange")]
        public void UpdateRevisionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateRevision");

            var request = InstantiateClassGenerator.Execute<UpdateRevisionRequest>();
            var marshaller = new UpdateRevisionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateRevision", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateRevisionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateRevisionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}