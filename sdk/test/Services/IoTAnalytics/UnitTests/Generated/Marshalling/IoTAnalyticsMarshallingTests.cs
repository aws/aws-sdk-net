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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.IoTAnalytics;
using Amazon.IoTAnalytics.Model;
using Amazon.IoTAnalytics.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class IoTAnalyticsMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("iotanalytics");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void BatchPutMessageMarshallTest()
        {
            var operation = service_model.FindOperation("BatchPutMessage");

            var request = InstantiateClassGenerator.Execute<BatchPutMessageRequest>();
            var marshaller = new BatchPutMessageRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchPutMessage", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = BatchPutMessageResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as BatchPutMessageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void CancelPipelineReprocessingMarshallTest()
        {
            var operation = service_model.FindOperation("CancelPipelineReprocessing");

            var request = InstantiateClassGenerator.Execute<CancelPipelineReprocessingRequest>();
            var marshaller = new CancelPipelineReprocessingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CancelPipelineReprocessing", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CancelPipelineReprocessingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CancelPipelineReprocessingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void CreateChannelMarshallTest()
        {
            var operation = service_model.FindOperation("CreateChannel");

            var request = InstantiateClassGenerator.Execute<CreateChannelRequest>();
            var marshaller = new CreateChannelRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateChannel", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateChannelResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateChannelResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void CreateDatasetMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDataset");

            var request = InstantiateClassGenerator.Execute<CreateDatasetRequest>();
            var marshaller = new CreateDatasetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateDataset", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateDatasetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateDatasetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void CreateDatasetContentMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDatasetContent");

            var request = InstantiateClassGenerator.Execute<CreateDatasetContentRequest>();
            var marshaller = new CreateDatasetContentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateDatasetContent", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void CreateDatastoreMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDatastore");

            var request = InstantiateClassGenerator.Execute<CreateDatastoreRequest>();
            var marshaller = new CreateDatastoreRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateDatastore", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateDatastoreResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateDatastoreResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void CreatePipelineMarshallTest()
        {
            var operation = service_model.FindOperation("CreatePipeline");

            var request = InstantiateClassGenerator.Execute<CreatePipelineRequest>();
            var marshaller = new CreatePipelineRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreatePipeline", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreatePipelineResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreatePipelineResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void DeleteChannelMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteChannel");

            var request = InstantiateClassGenerator.Execute<DeleteChannelRequest>();
            var marshaller = new DeleteChannelRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteChannel", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void DeleteDatasetMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDataset");

            var request = InstantiateClassGenerator.Execute<DeleteDatasetRequest>();
            var marshaller = new DeleteDatasetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteDataset", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void DeleteDatasetContentMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDatasetContent");

            var request = InstantiateClassGenerator.Execute<DeleteDatasetContentRequest>();
            var marshaller = new DeleteDatasetContentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteDatasetContent", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void DeleteDatastoreMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDatastore");

            var request = InstantiateClassGenerator.Execute<DeleteDatastoreRequest>();
            var marshaller = new DeleteDatastoreRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteDatastore", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void DeletePipelineMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePipeline");

            var request = InstantiateClassGenerator.Execute<DeletePipelineRequest>();
            var marshaller = new DeletePipelineRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeletePipeline", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void DescribeChannelMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeChannel");

            var request = InstantiateClassGenerator.Execute<DescribeChannelRequest>();
            var marshaller = new DescribeChannelRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeChannel", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeChannelResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeChannelResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void DescribeDatasetMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDataset");

            var request = InstantiateClassGenerator.Execute<DescribeDatasetRequest>();
            var marshaller = new DescribeDatasetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeDataset", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeDatasetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeDatasetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void DescribeDatastoreMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDatastore");

            var request = InstantiateClassGenerator.Execute<DescribeDatastoreRequest>();
            var marshaller = new DescribeDatastoreRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeDatastore", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeDatastoreResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeDatastoreResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void DescribeLoggingOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLoggingOptions");

            var request = InstantiateClassGenerator.Execute<DescribeLoggingOptionsRequest>();
            var marshaller = new DescribeLoggingOptionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeLoggingOptions", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeLoggingOptionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeLoggingOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void DescribePipelineMarshallTest()
        {
            var operation = service_model.FindOperation("DescribePipeline");

            var request = InstantiateClassGenerator.Execute<DescribePipelineRequest>();
            var marshaller = new DescribePipelineRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribePipeline", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribePipelineResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribePipelineResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void GetDatasetContentMarshallTest()
        {
            var operation = service_model.FindOperation("GetDatasetContent");

            var request = InstantiateClassGenerator.Execute<GetDatasetContentRequest>();
            var marshaller = new GetDatasetContentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetDatasetContent", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetDatasetContentResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDatasetContentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void ListChannelsMarshallTest()
        {
            var operation = service_model.FindOperation("ListChannels");

            var request = InstantiateClassGenerator.Execute<ListChannelsRequest>();
            var marshaller = new ListChannelsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListChannels", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListChannelsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListChannelsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void ListDatasetsMarshallTest()
        {
            var operation = service_model.FindOperation("ListDatasets");

            var request = InstantiateClassGenerator.Execute<ListDatasetsRequest>();
            var marshaller = new ListDatasetsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListDatasets", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListDatasetsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDatasetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void ListDatastoresMarshallTest()
        {
            var operation = service_model.FindOperation("ListDatastores");

            var request = InstantiateClassGenerator.Execute<ListDatastoresRequest>();
            var marshaller = new ListDatastoresRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListDatastores", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListDatastoresResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDatastoresResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void ListPipelinesMarshallTest()
        {
            var operation = service_model.FindOperation("ListPipelines");

            var request = InstantiateClassGenerator.Execute<ListPipelinesRequest>();
            var marshaller = new ListPipelinesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListPipelines", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListPipelinesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListPipelinesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void PutLoggingOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("PutLoggingOptions");

            var request = InstantiateClassGenerator.Execute<PutLoggingOptionsRequest>();
            var marshaller = new PutLoggingOptionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutLoggingOptions", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void RunPipelineActivityMarshallTest()
        {
            var operation = service_model.FindOperation("RunPipelineActivity");

            var request = InstantiateClassGenerator.Execute<RunPipelineActivityRequest>();
            var marshaller = new RunPipelineActivityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("RunPipelineActivity", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = RunPipelineActivityResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as RunPipelineActivityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void SampleChannelDataMarshallTest()
        {
            var operation = service_model.FindOperation("SampleChannelData");

            var request = InstantiateClassGenerator.Execute<SampleChannelDataRequest>();
            var marshaller = new SampleChannelDataRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("SampleChannelData", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = SampleChannelDataResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as SampleChannelDataResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void StartPipelineReprocessingMarshallTest()
        {
            var operation = service_model.FindOperation("StartPipelineReprocessing");

            var request = InstantiateClassGenerator.Execute<StartPipelineReprocessingRequest>();
            var marshaller = new StartPipelineReprocessingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("StartPipelineReprocessing", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = StartPipelineReprocessingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as StartPipelineReprocessingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void UpdateChannelMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateChannel");

            var request = InstantiateClassGenerator.Execute<UpdateChannelRequest>();
            var marshaller = new UpdateChannelRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateChannel", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void UpdateDatasetMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDataset");

            var request = InstantiateClassGenerator.Execute<UpdateDatasetRequest>();
            var marshaller = new UpdateDatasetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateDataset", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void UpdateDatastoreMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDatastore");

            var request = InstantiateClassGenerator.Execute<UpdateDatastoreRequest>();
            var marshaller = new UpdateDatastoreRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateDatastore", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTAnalytics")]
        public void UpdatePipelineMarshallTest()
        {
            var operation = service_model.FindOperation("UpdatePipeline");

            var request = InstantiateClassGenerator.Execute<UpdatePipelineRequest>();
            var marshaller = new UpdatePipelineRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdatePipeline", request, internalRequest, service_model);            

        }

            }
}