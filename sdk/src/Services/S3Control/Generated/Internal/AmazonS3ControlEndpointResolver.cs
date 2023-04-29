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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */

using System;
using Amazon.S3Control.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Util;
using Amazon.S3Control.Endpoints;

#pragma warning disable 1591

namespace Amazon.S3Control.Internal
{
    /// <summary>
    /// Amazon S3Control endpoint resolver.
    /// Custom PipelineHandler responsible for resolving endpoint and setting authentication parameters for S3Control service requests.
    /// Collects values for S3ControlEndpointParameters and then tries to resolve endpoint by calling 
    /// ResolveEndpoint method on GlobalEndpoints.Provider if present, otherwise uses S3ControlEndpointProvider.
    /// Responsible for setting authentication and http headers provided by resolved endpoint.
    /// </summary>
    public class AmazonS3ControlEndpointResolver : BaseEndpointResolver
    {
        protected override void ServiceSpecificHandler(IExecutionContext executionContext, EndpointParameters parameters)
        {

        }

        protected override EndpointParameters MapEndpointsParameters(IRequestContext requestContext)
        {
            var config = (AmazonS3ControlConfig)requestContext.ClientConfig;
            var result = new S3ControlEndpointParameters();
            result.Region = config.RegionEndpoint?.SystemName;
            result.UseFIPS = config.UseFIPSEndpoint;
            result.UseDualStack = config.UseDualstackEndpoint;
            result.Endpoint = config.ServiceURL;
            result.UseArnRegion = config.UseArnRegion;


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
            if (requestContext.RequestName == "CreateAccessPointRequest") {
                result.RequiresAccountId = true;
                var request = (CreateAccessPointRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.Bucket = request.Bucket;
                return result;
            }
            if (requestContext.RequestName == "CreateAccessPointForObjectLambdaRequest") {
                result.RequiresAccountId = true;
                var request = (CreateAccessPointForObjectLambdaRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "CreateBucketRequest") {
                var request = (CreateBucketRequest)requestContext.OriginalRequest;
                result.Bucket = request.Bucket;
                result.OutpostId = request.OutpostId;
                return result;
            }
            if (requestContext.RequestName == "CreateJobRequest") {
                result.RequiresAccountId = true;
                var request = (CreateJobRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "CreateMultiRegionAccessPointRequest") {
                result.RequiresAccountId = true;
                var request = (CreateMultiRegionAccessPointRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "DeleteAccessPointRequest") {
                result.RequiresAccountId = true;
                var request = (DeleteAccessPointRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.AccessPointName = request.Name;
                return result;
            }
            if (requestContext.RequestName == "DeleteAccessPointForObjectLambdaRequest") {
                result.RequiresAccountId = true;
                var request = (DeleteAccessPointForObjectLambdaRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "DeleteAccessPointPolicyRequest") {
                result.RequiresAccountId = true;
                var request = (DeleteAccessPointPolicyRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.AccessPointName = request.Name;
                return result;
            }
            if (requestContext.RequestName == "DeleteAccessPointPolicyForObjectLambdaRequest") {
                result.RequiresAccountId = true;
                var request = (DeleteAccessPointPolicyForObjectLambdaRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketRequest") {
                result.RequiresAccountId = true;
                var request = (DeleteBucketRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.Bucket = request.Bucket;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketLifecycleConfigurationRequest") {
                result.RequiresAccountId = true;
                var request = (DeleteBucketLifecycleConfigurationRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.Bucket = request.Bucket;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketPolicyRequest") {
                result.RequiresAccountId = true;
                var request = (DeleteBucketPolicyRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.Bucket = request.Bucket;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketReplicationRequest") {
                result.RequiresAccountId = true;
                var request = (DeleteBucketReplicationRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.Bucket = request.Bucket;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketTaggingRequest") {
                result.RequiresAccountId = true;
                var request = (DeleteBucketTaggingRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.Bucket = request.Bucket;
                return result;
            }
            if (requestContext.RequestName == "DeleteJobTaggingRequest") {
                result.RequiresAccountId = true;
                var request = (DeleteJobTaggingRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "DeleteMultiRegionAccessPointRequest") {
                result.RequiresAccountId = true;
                var request = (DeleteMultiRegionAccessPointRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "DeletePublicAccessBlockRequest") {
                result.RequiresAccountId = true;
                var request = (DeletePublicAccessBlockRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "DeleteStorageLensConfigurationRequest") {
                result.RequiresAccountId = true;
                var request = (DeleteStorageLensConfigurationRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "DeleteStorageLensConfigurationTaggingRequest") {
                result.RequiresAccountId = true;
                var request = (DeleteStorageLensConfigurationTaggingRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "DescribeJobRequest") {
                result.RequiresAccountId = true;
                var request = (DescribeJobRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "DescribeMultiRegionAccessPointOperationRequest") {
                result.RequiresAccountId = true;
                var request = (DescribeMultiRegionAccessPointOperationRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "GetAccessPointRequest") {
                result.RequiresAccountId = true;
                var request = (GetAccessPointRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.AccessPointName = request.Name;
                return result;
            }
            if (requestContext.RequestName == "GetAccessPointConfigurationForObjectLambdaRequest") {
                result.RequiresAccountId = true;
                var request = (GetAccessPointConfigurationForObjectLambdaRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "GetAccessPointForObjectLambdaRequest") {
                result.RequiresAccountId = true;
                var request = (GetAccessPointForObjectLambdaRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "GetAccessPointPolicyRequest") {
                result.RequiresAccountId = true;
                var request = (GetAccessPointPolicyRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.AccessPointName = request.Name;
                return result;
            }
            if (requestContext.RequestName == "GetAccessPointPolicyForObjectLambdaRequest") {
                result.RequiresAccountId = true;
                var request = (GetAccessPointPolicyForObjectLambdaRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "GetAccessPointPolicyStatusRequest") {
                result.RequiresAccountId = true;
                var request = (GetAccessPointPolicyStatusRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.AccessPointName = request.Name;
                return result;
            }
            if (requestContext.RequestName == "GetAccessPointPolicyStatusForObjectLambdaRequest") {
                result.RequiresAccountId = true;
                var request = (GetAccessPointPolicyStatusForObjectLambdaRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "GetBucketRequest") {
                result.RequiresAccountId = true;
                var request = (GetBucketRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.Bucket = request.Bucket;
                return result;
            }
            if (requestContext.RequestName == "GetBucketLifecycleConfigurationRequest") {
                result.RequiresAccountId = true;
                var request = (GetBucketLifecycleConfigurationRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.Bucket = request.Bucket;
                return result;
            }
            if (requestContext.RequestName == "GetBucketPolicyRequest") {
                result.RequiresAccountId = true;
                var request = (GetBucketPolicyRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.Bucket = request.Bucket;
                return result;
            }
            if (requestContext.RequestName == "GetBucketReplicationRequest") {
                result.RequiresAccountId = true;
                var request = (GetBucketReplicationRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.Bucket = request.Bucket;
                return result;
            }
            if (requestContext.RequestName == "GetBucketTaggingRequest") {
                result.RequiresAccountId = true;
                var request = (GetBucketTaggingRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.Bucket = request.Bucket;
                return result;
            }
            if (requestContext.RequestName == "GetBucketVersioningRequest") {
                result.RequiresAccountId = true;
                var request = (GetBucketVersioningRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.Bucket = request.Bucket;
                return result;
            }
            if (requestContext.RequestName == "GetJobTaggingRequest") {
                result.RequiresAccountId = true;
                var request = (GetJobTaggingRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "GetMultiRegionAccessPointRequest") {
                result.RequiresAccountId = true;
                var request = (GetMultiRegionAccessPointRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "GetMultiRegionAccessPointPolicyRequest") {
                result.RequiresAccountId = true;
                var request = (GetMultiRegionAccessPointPolicyRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "GetMultiRegionAccessPointPolicyStatusRequest") {
                result.RequiresAccountId = true;
                var request = (GetMultiRegionAccessPointPolicyStatusRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "GetMultiRegionAccessPointRoutesRequest") {
                result.RequiresAccountId = true;
                var request = (GetMultiRegionAccessPointRoutesRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "GetPublicAccessBlockRequest") {
                result.RequiresAccountId = true;
                var request = (GetPublicAccessBlockRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "GetStorageLensConfigurationRequest") {
                result.RequiresAccountId = true;
                var request = (GetStorageLensConfigurationRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "GetStorageLensConfigurationTaggingRequest") {
                result.RequiresAccountId = true;
                var request = (GetStorageLensConfigurationTaggingRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "ListAccessPointsRequest") {
                result.RequiresAccountId = true;
                var request = (ListAccessPointsRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.Bucket = request.Bucket;
                return result;
            }
            if (requestContext.RequestName == "ListAccessPointsForObjectLambdaRequest") {
                result.RequiresAccountId = true;
                var request = (ListAccessPointsForObjectLambdaRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "ListJobsRequest") {
                result.RequiresAccountId = true;
                var request = (ListJobsRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "ListMultiRegionAccessPointsRequest") {
                result.RequiresAccountId = true;
                var request = (ListMultiRegionAccessPointsRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "ListRegionalBucketsRequest") {
                result.RequiresAccountId = true;
                var request = (ListRegionalBucketsRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.OutpostId = request.OutpostId;
                return result;
            }
            if (requestContext.RequestName == "ListStorageLensConfigurationsRequest") {
                result.RequiresAccountId = true;
                var request = (ListStorageLensConfigurationsRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "PutAccessPointConfigurationForObjectLambdaRequest") {
                result.RequiresAccountId = true;
                var request = (PutAccessPointConfigurationForObjectLambdaRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "PutAccessPointPolicyRequest") {
                result.RequiresAccountId = true;
                var request = (PutAccessPointPolicyRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.AccessPointName = request.Name;
                return result;
            }
            if (requestContext.RequestName == "PutAccessPointPolicyForObjectLambdaRequest") {
                result.RequiresAccountId = true;
                var request = (PutAccessPointPolicyForObjectLambdaRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "PutBucketLifecycleConfigurationRequest") {
                result.RequiresAccountId = true;
                var request = (PutBucketLifecycleConfigurationRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.Bucket = request.Bucket;
                return result;
            }
            if (requestContext.RequestName == "PutBucketPolicyRequest") {
                result.RequiresAccountId = true;
                var request = (PutBucketPolicyRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.Bucket = request.Bucket;
                return result;
            }
            if (requestContext.RequestName == "PutBucketReplicationRequest") {
                result.RequiresAccountId = true;
                var request = (PutBucketReplicationRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.Bucket = request.Bucket;
                return result;
            }
            if (requestContext.RequestName == "PutBucketTaggingRequest") {
                result.RequiresAccountId = true;
                var request = (PutBucketTaggingRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.Bucket = request.Bucket;
                return result;
            }
            if (requestContext.RequestName == "PutBucketVersioningRequest") {
                result.RequiresAccountId = true;
                var request = (PutBucketVersioningRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                result.Bucket = request.Bucket;
                return result;
            }
            if (requestContext.RequestName == "PutJobTaggingRequest") {
                result.RequiresAccountId = true;
                var request = (PutJobTaggingRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "PutMultiRegionAccessPointPolicyRequest") {
                result.RequiresAccountId = true;
                var request = (PutMultiRegionAccessPointPolicyRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "PutPublicAccessBlockRequest") {
                result.RequiresAccountId = true;
                var request = (PutPublicAccessBlockRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "PutStorageLensConfigurationRequest") {
                result.RequiresAccountId = true;
                var request = (PutStorageLensConfigurationRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "PutStorageLensConfigurationTaggingRequest") {
                result.RequiresAccountId = true;
                var request = (PutStorageLensConfigurationTaggingRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "SubmitMultiRegionAccessPointRoutesRequest") {
                result.RequiresAccountId = true;
                var request = (SubmitMultiRegionAccessPointRoutesRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "UpdateJobPriorityRequest") {
                result.RequiresAccountId = true;
                var request = (UpdateJobPriorityRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }
            if (requestContext.RequestName == "UpdateJobStatusRequest") {
                result.RequiresAccountId = true;
                var request = (UpdateJobStatusRequest)requestContext.OriginalRequest;
                result.AccountId = request.AccountId;
                return result;
            }

            return result;
        }
    }
}