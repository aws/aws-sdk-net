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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */

using System;
using Amazon.Kinesis.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Util;
using Amazon.Kinesis.Endpoints;

#pragma warning disable 1591

namespace Amazon.Kinesis.Internal
{
    /// <summary>
    /// Amazon Kinesis endpoint resolver.
    /// Custom PipelineHandler responsible for resolving endpoint and setting authentication parameters for Kinesis service requests.
    /// Collects values for KinesisEndpointParameters and then tries to resolve endpoint by calling 
    /// ResolveEndpoint method on GlobalEndpoints.Provider if present, otherwise uses KinesisEndpointProvider.
    /// Responsible for setting authentication and http headers provided by resolved endpoint.
    /// </summary>
    public class AmazonKinesisEndpointResolver : BaseEndpointResolver
    {
        protected override void ServiceSpecificHandler(IExecutionContext executionContext, EndpointParameters parameters)
        {

            InjectHostPrefix(executionContext.RequestContext);
        }

        protected override EndpointParameters MapEndpointsParameters(IRequestContext requestContext)
        {
            var config = (AmazonKinesisConfig)requestContext.ClientConfig;
            var result = new KinesisEndpointParameters();
            result.Region = config.RegionEndpoint?.SystemName;
            result.UseDualStack = config.UseDualstackEndpoint;
            result.UseFIPS = config.UseFIPSEndpoint;
            result.Endpoint = config.ServiceURL;


            // The region needs to be determined from the ServiceURL if not set.
            var regionEndpoint = config.RegionEndpoint;
            if (regionEndpoint == null && !string.IsNullOrEmpty(config.ServiceURL))
            {
                var regionName = AWSSDKUtils.DetermineRegion(config.ServiceURL);
                result.Region = RegionEndpoint.GetBySystemName(regionName).SystemName;
            }

            // To support legacy endpoint overridding rules in the endpoints.json
            if (result.Region == "us-east-1-regional")
            {
                result.Region = "us-east-1";
            }

            // Use AlternateEndpoint region override if set
            if (requestContext.Request.AlternateEndpoint != null)
            {
                result.Region = requestContext.Request.AlternateEndpoint.SystemName;
            }


            // Assign staticContextParams and contextParam per operation
            if (requestContext.RequestName == "AddTagsToStreamRequest") {
                result.OperationType = "control";
                var request = (AddTagsToStreamRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "DecreaseStreamRetentionPeriodRequest") {
                result.OperationType = "control";
                var request = (DecreaseStreamRetentionPeriodRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "DeleteStreamRequest") {
                result.OperationType = "control";
                var request = (DeleteStreamRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "DeregisterStreamConsumerRequest") {
                result.OperationType = "control";
                var request = (DeregisterStreamConsumerRequest)requestContext.OriginalRequest;
                result.ConsumerARN = request.ConsumerARN;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "DescribeStreamRequest") {
                result.OperationType = "control";
                var request = (DescribeStreamRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "DescribeStreamConsumerRequest") {
                result.OperationType = "control";
                var request = (DescribeStreamConsumerRequest)requestContext.OriginalRequest;
                result.ConsumerARN = request.ConsumerARN;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "DescribeStreamSummaryRequest") {
                result.OperationType = "control";
                var request = (DescribeStreamSummaryRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "DisableEnhancedMonitoringRequest") {
                result.OperationType = "control";
                var request = (DisableEnhancedMonitoringRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "EnableEnhancedMonitoringRequest") {
                result.OperationType = "control";
                var request = (EnableEnhancedMonitoringRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "GetRecordsRequest") {
                result.OperationType = "data";
                var request = (GetRecordsRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "GetShardIteratorRequest") {
                result.OperationType = "data";
                var request = (GetShardIteratorRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "IncreaseStreamRetentionPeriodRequest") {
                result.OperationType = "control";
                var request = (IncreaseStreamRetentionPeriodRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "ListShardsRequest") {
                result.OperationType = "control";
                var request = (ListShardsRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "ListStreamConsumersRequest") {
                result.OperationType = "control";
                var request = (ListStreamConsumersRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "ListTagsForStreamRequest") {
                result.OperationType = "control";
                var request = (ListTagsForStreamRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "MergeShardsRequest") {
                result.OperationType = "control";
                var request = (MergeShardsRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "PutRecordRequest") {
                result.OperationType = "data";
                var request = (PutRecordRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "PutRecordsRequest") {
                result.OperationType = "data";
                var request = (PutRecordsRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "RegisterStreamConsumerRequest") {
                result.OperationType = "control";
                var request = (RegisterStreamConsumerRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "RemoveTagsFromStreamRequest") {
                result.OperationType = "control";
                var request = (RemoveTagsFromStreamRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "SplitShardRequest") {
                result.OperationType = "control";
                var request = (SplitShardRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "StartStreamEncryptionRequest") {
                result.OperationType = "control";
                var request = (StartStreamEncryptionRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "StopStreamEncryptionRequest") {
                result.OperationType = "control";
                var request = (StopStreamEncryptionRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "UpdateShardCountRequest") {
                result.OperationType = "control";
                var request = (UpdateShardCountRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }
            if (requestContext.RequestName == "UpdateStreamModeRequest") {
                result.OperationType = "control";
                var request = (UpdateStreamModeRequest)requestContext.OriginalRequest;
                result.StreamARN = request.StreamARN;
                return result;
            }

            return result;
        }
    }
}