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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Kinesis;
using Amazon.Kinesis.Model;
using Amazon.Kinesis.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class KinesisMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("kinesis");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void AddTagsToStreamMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<AddTagsToStreamRequest>();
            var marshaller = new AddTagsToStreamRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<AddTagsToStreamRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void CreateStreamMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CreateStreamRequest>();
            var marshaller = new CreateStreamRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<CreateStreamRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void DecreaseStreamRetentionPeriodMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DecreaseStreamRetentionPeriodRequest>();
            var marshaller = new DecreaseStreamRetentionPeriodRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DecreaseStreamRetentionPeriodRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void DeleteStreamMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeleteStreamRequest>();
            var marshaller = new DeleteStreamRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DeleteStreamRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void DescribeLimitsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLimitsRequest>();
            var marshaller = new DescribeLimitsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeLimitsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeLimits").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeLimitsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLimitsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void DescribeStreamMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeStreamRequest>();
            var marshaller = new DescribeStreamRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeStreamRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeStream").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeStreamResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeStreamResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void DescribeStreamSummaryMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeStreamSummaryRequest>();
            var marshaller = new DescribeStreamSummaryRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeStreamSummaryRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeStreamSummary").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeStreamSummaryResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeStreamSummaryResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void DisableEnhancedMonitoringMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DisableEnhancedMonitoringRequest>();
            var marshaller = new DisableEnhancedMonitoringRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DisableEnhancedMonitoringRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DisableEnhancedMonitoring").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DisableEnhancedMonitoringResponseUnmarshaller.Instance.Unmarshall(context)
                as DisableEnhancedMonitoringResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void EnableEnhancedMonitoringMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<EnableEnhancedMonitoringRequest>();
            var marshaller = new EnableEnhancedMonitoringRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<EnableEnhancedMonitoringRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("EnableEnhancedMonitoring").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = EnableEnhancedMonitoringResponseUnmarshaller.Instance.Unmarshall(context)
                as EnableEnhancedMonitoringResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void GetRecordsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetRecordsRequest>();
            var marshaller = new GetRecordsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<GetRecordsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetRecords").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetRecordsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetRecordsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void GetShardIteratorMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetShardIteratorRequest>();
            var marshaller = new GetShardIteratorRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<GetShardIteratorRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetShardIterator").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetShardIteratorResponseUnmarshaller.Instance.Unmarshall(context)
                as GetShardIteratorResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void IncreaseStreamRetentionPeriodMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<IncreaseStreamRetentionPeriodRequest>();
            var marshaller = new IncreaseStreamRetentionPeriodRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<IncreaseStreamRetentionPeriodRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void ListShardsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListShardsRequest>();
            var marshaller = new ListShardsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<ListShardsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListShards").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListShardsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListShardsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void ListStreamsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListStreamsRequest>();
            var marshaller = new ListStreamsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<ListStreamsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListStreams").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListStreamsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListStreamsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void ListTagsForStreamMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForStreamRequest>();
            var marshaller = new ListTagsForStreamRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<ListTagsForStreamRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListTagsForStream").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListTagsForStreamResponseUnmarshaller.Instance.Unmarshall(context)
                as ListTagsForStreamResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void MergeShardsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<MergeShardsRequest>();
            var marshaller = new MergeShardsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<MergeShardsRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void PutRecordMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<PutRecordRequest>();
            var marshaller = new PutRecordRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<PutRecordRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("PutRecord").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = PutRecordResponseUnmarshaller.Instance.Unmarshall(context)
                as PutRecordResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void PutRecordsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<PutRecordsRequest>();
            var marshaller = new PutRecordsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<PutRecordsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("PutRecords").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = PutRecordsResponseUnmarshaller.Instance.Unmarshall(context)
                as PutRecordsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void RemoveTagsFromStreamMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RemoveTagsFromStreamRequest>();
            var marshaller = new RemoveTagsFromStreamRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<RemoveTagsFromStreamRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void SplitShardMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<SplitShardRequest>();
            var marshaller = new SplitShardRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<SplitShardRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void StartStreamEncryptionMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<StartStreamEncryptionRequest>();
            var marshaller = new StartStreamEncryptionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<StartStreamEncryptionRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void StopStreamEncryptionMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<StopStreamEncryptionRequest>();
            var marshaller = new StopStreamEncryptionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<StopStreamEncryptionRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("Kinesis")]
        public void UpdateShardCountMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UpdateShardCountRequest>();
            var marshaller = new UpdateShardCountRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<UpdateShardCountRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("UpdateShardCount").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = UpdateShardCountResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateShardCountResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

            }
}