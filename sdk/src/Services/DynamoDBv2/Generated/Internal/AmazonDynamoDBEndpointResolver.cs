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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */

using System;
using System.Linq;
using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Util;
using Amazon.DynamoDBv2.Endpoints;

#pragma warning disable 1591

namespace Amazon.DynamoDBv2.Internal
{
    /// <summary>
    /// Amazon DynamoDB endpoint resolver.
    /// Custom PipelineHandler responsible for resolving endpoint and setting authentication parameters for DynamoDB service requests.
    /// Collects values for DynamoDBEndpointParameters and then tries to resolve endpoint by calling 
    /// ResolveEndpoint method on GlobalEndpoints.Provider if present, otherwise uses DynamoDBEndpointProvider.
    /// Responsible for setting authentication and http headers provided by resolved endpoint.
    /// </summary>
    public class AmazonDynamoDBEndpointResolver : BaseEndpointResolver
    {
        protected override void ServiceSpecificHandler(IExecutionContext executionContext, EndpointParameters parameters)
        {

            InjectHostPrefix(executionContext.RequestContext);
        }

        protected override EndpointParameters MapEndpointsParameters(IRequestContext requestContext)
        {
            var config = (AmazonDynamoDBConfig)requestContext.ClientConfig;
            var result = new DynamoDBEndpointParameters();
            result.Region = requestContext.Request.AlternateEndpoint?.SystemName ?? config.RegionEndpoint?.SystemName;;
            result.UseDualStack = config.UseDualstackEndpoint;
            result.UseFIPS = config.UseFIPSEndpoint;
            result.Endpoint = config.ServiceURL;
            result.AccountId = requestContext.Identity is AWSCredentials credentials ? credentials.GetCredentials()?.AccountId : null;
            result.AccountIdEndpointMode = config.AccountIdEndpointMode.ToString().ToLower();


            // The region needs to be determined from the ServiceURL if not set.
            var regionEndpoint = config.RegionEndpoint;
            if (regionEndpoint == null && !string.IsNullOrEmpty(config.ServiceURL))
            {
                // Use the specified signing region if it was provided alongside a custom ServiceURL
                if (!string.IsNullOrEmpty(config.AuthenticationRegion))
                {
                    result.Region = config.AuthenticationRegion;
                }
                else // try to extract a region from the custom ServiceURL
                {
                    var regionName = AWSSDKUtils.DetermineRegion(config.ServiceURL);
                    result.Region = RegionEndpoint.GetBySystemName(regionName).SystemName;
                }
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
            if (requestContext.RequestName == "BatchGetItemRequest") {
                var request = (BatchGetItemRequest)requestContext.OriginalRequest;
                result.ResourceArnList = request.RequestItems?.Keys.ToList();
                return result;
            }
            if (requestContext.RequestName == "BatchWriteItemRequest") {
                var request = (BatchWriteItemRequest)requestContext.OriginalRequest;
                result.ResourceArnList = request.RequestItems?.Keys.ToList();
                return result;
            }
            if (requestContext.RequestName == "CreateBackupRequest") {
                var request = (CreateBackupRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "CreateGlobalTableRequest") {
                var request = (CreateGlobalTableRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.GlobalTableName;
                return result;
            }
            if (requestContext.RequestName == "CreateTableRequest") {
                var request = (CreateTableRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBackupRequest") {
                var request = (DeleteBackupRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.BackupArn;
                return result;
            }
            if (requestContext.RequestName == "DeleteItemRequest") {
                var request = (DeleteItemRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "DeleteResourcePolicyRequest") {
                var request = (DeleteResourcePolicyRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.ResourceArn;
                return result;
            }
            if (requestContext.RequestName == "DeleteTableRequest") {
                var request = (DeleteTableRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "DescribeBackupRequest") {
                var request = (DescribeBackupRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.BackupArn;
                return result;
            }
            if (requestContext.RequestName == "DescribeContinuousBackupsRequest") {
                var request = (DescribeContinuousBackupsRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "DescribeContributorInsightsRequest") {
                var request = (DescribeContributorInsightsRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "DescribeExportRequest") {
                var request = (DescribeExportRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.ExportArn;
                return result;
            }
            if (requestContext.RequestName == "DescribeGlobalTableRequest") {
                var request = (DescribeGlobalTableRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.GlobalTableName;
                return result;
            }
            if (requestContext.RequestName == "DescribeGlobalTableSettingsRequest") {
                var request = (DescribeGlobalTableSettingsRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.GlobalTableName;
                return result;
            }
            if (requestContext.RequestName == "DescribeImportRequest") {
                var request = (DescribeImportRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.ImportArn;
                return result;
            }
            if (requestContext.RequestName == "DescribeKinesisStreamingDestinationRequest") {
                var request = (DescribeKinesisStreamingDestinationRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "DescribeTableRequest") {
                var request = (DescribeTableRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "DescribeTableReplicaAutoScalingRequest") {
                var request = (DescribeTableReplicaAutoScalingRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "DescribeTimeToLiveRequest") {
                var request = (DescribeTimeToLiveRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "DisableKinesisStreamingDestinationRequest") {
                var request = (DisableKinesisStreamingDestinationRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "EnableKinesisStreamingDestinationRequest") {
                var request = (EnableKinesisStreamingDestinationRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "ExportTableToPointInTimeRequest") {
                var request = (ExportTableToPointInTimeRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableArn;
                return result;
            }
            if (requestContext.RequestName == "GetItemRequest") {
                var request = (GetItemRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "GetResourcePolicyRequest") {
                var request = (GetResourcePolicyRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.ResourceArn;
                return result;
            }
            if (requestContext.RequestName == "ImportTableRequest") {
                var request = (ImportTableRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableCreationParameters?.TableName;
                return result;
            }
            if (requestContext.RequestName == "ListBackupsRequest") {
                var request = (ListBackupsRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "ListContributorInsightsRequest") {
                var request = (ListContributorInsightsRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "ListExportsRequest") {
                var request = (ListExportsRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableArn;
                return result;
            }
            if (requestContext.RequestName == "ListImportsRequest") {
                var request = (ListImportsRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableArn;
                return result;
            }
            if (requestContext.RequestName == "ListTagsOfResourceRequest") {
                var request = (ListTagsOfResourceRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.ResourceArn;
                return result;
            }
            if (requestContext.RequestName == "PutItemRequest") {
                var request = (PutItemRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "PutResourcePolicyRequest") {
                var request = (PutResourcePolicyRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.ResourceArn;
                return result;
            }
            if (requestContext.RequestName == "QueryRequest") {
                var request = (QueryRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "RestoreTableFromBackupRequest") {
                var request = (RestoreTableFromBackupRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TargetTableName;
                return result;
            }
            if (requestContext.RequestName == "RestoreTableToPointInTimeRequest") {
                var request = (RestoreTableToPointInTimeRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TargetTableName;
                return result;
            }
            if (requestContext.RequestName == "ScanRequest") {
                var request = (ScanRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "TagResourceRequest") {
                var request = (TagResourceRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.ResourceArn;
                return result;
            }
            if (requestContext.RequestName == "TransactGetItemsRequest") {
                var request = (TransactGetItemsRequest)requestContext.OriginalRequest;
                result.ResourceArnList = request.TransactItems?.Select(element => element?.Get?.TableName);
                return result;
            }
            if (requestContext.RequestName == "TransactWriteItemsRequest") {
                var request = (TransactWriteItemsRequest)requestContext.OriginalRequest;
                result.ResourceArnList = request.TransactItems?.Select(element => new [] { element?.ConditionCheck?.TableName, element?.Put?.TableName, element?.Delete?.TableName, element?.Update?.TableName })?.SelectMany(element => element).Where(element => element != null);
                return result;
            }
            if (requestContext.RequestName == "UntagResourceRequest") {
                var request = (UntagResourceRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.ResourceArn;
                return result;
            }
            if (requestContext.RequestName == "UpdateContinuousBackupsRequest") {
                var request = (UpdateContinuousBackupsRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "UpdateContributorInsightsRequest") {
                var request = (UpdateContributorInsightsRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "UpdateGlobalTableRequest") {
                var request = (UpdateGlobalTableRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.GlobalTableName;
                return result;
            }
            if (requestContext.RequestName == "UpdateGlobalTableSettingsRequest") {
                var request = (UpdateGlobalTableSettingsRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.GlobalTableName;
                return result;
            }
            if (requestContext.RequestName == "UpdateItemRequest") {
                var request = (UpdateItemRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "UpdateKinesisStreamingDestinationRequest") {
                var request = (UpdateKinesisStreamingDestinationRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "UpdateTableRequest") {
                var request = (UpdateTableRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "UpdateTableReplicaAutoScalingRequest") {
                var request = (UpdateTableReplicaAutoScalingRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }
            if (requestContext.RequestName == "UpdateTimeToLiveRequest") {
                var request = (UpdateTimeToLiveRequest)requestContext.OriginalRequest;
                result.ResourceArn = request.TableName;
                return result;
            }

            return result;
        }
    }
}