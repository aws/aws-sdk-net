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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */

using System;
using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Util;
using Amazon.S3.Endpoints;

#pragma warning disable 1591

namespace Amazon.S3.Internal
{
    /// <summary>
    /// Amazon S3 endpoint resolver.
    /// Custom PipelineHandler responsible for resolving endpoint and setting authentication parameters for S3 service requests.
    /// Collects values for S3EndpointParameters and then tries to resolve endpoint by calling 
    /// ResolveEndpoint method on GlobalEndpoints.Provider if present, otherwise uses S3EndpointProvider.
    /// Responsible for setting authentication and http headers provided by resolved endpoint.
    /// </summary>
    public class AmazonS3EndpointResolver : BaseEndpointResolver
    {
        protected override void ServiceSpecificHandler(IExecutionContext executionContext, EndpointParameters parameters)
        {
            // Special handling of SigV2 for S3
            if (parameters["Bucket"] != null)
            {
                // SigV2 support, CanonicalResourcePrefix required for proper signing
                executionContext.RequestContext.Request.CanonicalResourcePrefix = "/" + parameters["Bucket"];
            }

            // Special handling of SigV2
            if (executionContext.RequestContext.ClientConfig.SignatureVersion == "2")
            {
                executionContext.RequestContext.Request.SignatureVersion = SignatureVersion.SigV2;
            }

            // If the marshalled request has the SSE header and it is set to KMS, force SigV4 for this request.
            // Current operations that may set this header: CopyObject, CopyPart, InitiateMultipart, PutObject
            string sseHeaderValue;
            if (executionContext.RequestContext.Request.Headers.TryGetValue(HeaderKeys.XAmzServerSideEncryptionHeader, out sseHeaderValue) &&
                string.Equals(sseHeaderValue, ServerSideEncryptionMethod.AWSKMS.Value, StringComparison.Ordinal))
            {
                executionContext.RequestContext.Request.SignatureVersion = SignatureVersion.SigV4;
            }

            InjectHostPrefix(executionContext.RequestContext);
        }

        protected override EndpointParameters MapEndpointsParameters(IRequestContext requestContext)
        {
            var config = (AmazonS3Config)requestContext.ClientConfig;
            var result = new S3EndpointParameters();
            result.Region = config.RegionEndpoint?.SystemName;
            result.UseFIPS = config.UseFIPSEndpoint;
            result.UseDualStack = config.UseDualstackEndpoint;
            result.Endpoint = config.ServiceURL;
            result.ForcePathStyle = config.ForcePathStyle;
            result.Accelerate = config.UseAccelerateEndpoint;
            result.UseGlobalEndpoint = config.USEast1RegionalEndpointValue == S3UsEast1RegionalEndpointValue.Legacy;
            result.DisableMultiRegionAccessPoints = config.DisableMultiregionAccessPoints;
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

            // Special handling of GetPreSignedUrlRequest
            if (requestContext.Request.RequestName == "GetPreSignedUrlRequest")
            {
                var request = (GetPreSignedUrlRequest)requestContext.Request.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }

            // Assign staticContextParams and contextParam per operation
            if (requestContext.RequestName == "AbortMultipartUploadRequest") {
                var request = (AbortMultipartUploadRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "CompleteMultipartUploadRequest") {
                var request = (CompleteMultipartUploadRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "CopyObjectRequest") {
                var request = (CopyObjectRequest)requestContext.OriginalRequest;
                result.Bucket = request.DestinationBucket;
                return result;
            }
            if (requestContext.RequestName == "CopyPartRequest") {
                var request = (CopyPartRequest)requestContext.OriginalRequest;
                result.Bucket = request.DestinationBucket;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketRequest") {
                var request = (DeleteBucketRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketAnalyticsConfigurationRequest") {
                var request = (DeleteBucketAnalyticsConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketEncryptionRequest") {
                var request = (DeleteBucketEncryptionRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketIntelligentTieringConfigurationRequest") {
                var request = (DeleteBucketIntelligentTieringConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketInventoryConfigurationRequest") {
                var request = (DeleteBucketInventoryConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketMetricsConfigurationRequest") {
                var request = (DeleteBucketMetricsConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketOwnershipControlsRequest") {
                var request = (DeleteBucketOwnershipControlsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketPolicyRequest") {
                var request = (DeleteBucketPolicyRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketReplicationRequest") {
                var request = (DeleteBucketReplicationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketTaggingRequest") {
                var request = (DeleteBucketTaggingRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketWebsiteRequest") {
                var request = (DeleteBucketWebsiteRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteCORSConfigurationRequest") {
                var request = (DeleteCORSConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteLifecycleConfigurationRequest") {
                var request = (DeleteLifecycleConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteObjectRequest") {
                var request = (DeleteObjectRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteObjectsRequest") {
                var request = (DeleteObjectsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteObjectTaggingRequest") {
                var request = (DeleteObjectTaggingRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeletePublicAccessBlockRequest") {
                var request = (DeletePublicAccessBlockRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetACLRequest") {
                var request = (GetACLRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketAccelerateConfigurationRequest") {
                var request = (GetBucketAccelerateConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketAnalyticsConfigurationRequest") {
                var request = (GetBucketAnalyticsConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketEncryptionRequest") {
                var request = (GetBucketEncryptionRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketIntelligentTieringConfigurationRequest") {
                var request = (GetBucketIntelligentTieringConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketInventoryConfigurationRequest") {
                var request = (GetBucketInventoryConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketLocationRequest") {
                var request = (GetBucketLocationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketLoggingRequest") {
                var request = (GetBucketLoggingRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketMetricsConfigurationRequest") {
                var request = (GetBucketMetricsConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketNotificationRequest") {
                var request = (GetBucketNotificationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketOwnershipControlsRequest") {
                var request = (GetBucketOwnershipControlsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketPolicyRequest") {
                var request = (GetBucketPolicyRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketPolicyStatusRequest") {
                var request = (GetBucketPolicyStatusRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketReplicationRequest") {
                var request = (GetBucketReplicationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketRequestPaymentRequest") {
                var request = (GetBucketRequestPaymentRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketTaggingRequest") {
                var request = (GetBucketTaggingRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketVersioningRequest") {
                var request = (GetBucketVersioningRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketWebsiteRequest") {
                var request = (GetBucketWebsiteRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetCORSConfigurationRequest") {
                var request = (GetCORSConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetLifecycleConfigurationRequest") {
                var request = (GetLifecycleConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetObjectRequest") {
                var request = (GetObjectRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetObjectAttributesRequest") {
                var request = (GetObjectAttributesRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetObjectLegalHoldRequest") {
                var request = (GetObjectLegalHoldRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetObjectLockConfigurationRequest") {
                var request = (GetObjectLockConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetObjectMetadataRequest") {
                var request = (GetObjectMetadataRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetObjectRetentionRequest") {
                var request = (GetObjectRetentionRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetObjectTaggingRequest") {
                var request = (GetObjectTaggingRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetObjectTorrentRequest") {
                var request = (GetObjectTorrentRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetPublicAccessBlockRequest") {
                var request = (GetPublicAccessBlockRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "HeadBucketRequest") {
                var request = (HeadBucketRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "InitiateMultipartUploadRequest") {
                var request = (InitiateMultipartUploadRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "ListBucketAnalyticsConfigurationsRequest") {
                var request = (ListBucketAnalyticsConfigurationsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "ListBucketIntelligentTieringConfigurationsRequest") {
                var request = (ListBucketIntelligentTieringConfigurationsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "ListBucketInventoryConfigurationsRequest") {
                var request = (ListBucketInventoryConfigurationsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "ListBucketMetricsConfigurationsRequest") {
                var request = (ListBucketMetricsConfigurationsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "ListMultipartUploadsRequest") {
                var request = (ListMultipartUploadsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "ListObjectsRequest") {
                var request = (ListObjectsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "ListObjectsV2Request") {
                var request = (ListObjectsV2Request)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "ListPartsRequest") {
                var request = (ListPartsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "ListVersionsRequest") {
                var request = (ListVersionsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutACLRequest") {
                var request = (PutACLRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketRequest") {
                result.DisableAccessPoints = true;
                var request = (PutBucketRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketAccelerateConfigurationRequest") {
                var request = (PutBucketAccelerateConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketAnalyticsConfigurationRequest") {
                var request = (PutBucketAnalyticsConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketEncryptionRequest") {
                var request = (PutBucketEncryptionRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketIntelligentTieringConfigurationRequest") {
                var request = (PutBucketIntelligentTieringConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketInventoryConfigurationRequest") {
                var request = (PutBucketInventoryConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketLoggingRequest") {
                var request = (PutBucketLoggingRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketMetricsConfigurationRequest") {
                var request = (PutBucketMetricsConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketNotificationRequest") {
                var request = (PutBucketNotificationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketOwnershipControlsRequest") {
                var request = (PutBucketOwnershipControlsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketPolicyRequest") {
                var request = (PutBucketPolicyRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketReplicationRequest") {
                var request = (PutBucketReplicationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketRequestPaymentRequest") {
                var request = (PutBucketRequestPaymentRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketTaggingRequest") {
                var request = (PutBucketTaggingRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketVersioningRequest") {
                var request = (PutBucketVersioningRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketWebsiteRequest") {
                var request = (PutBucketWebsiteRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutCORSConfigurationRequest") {
                var request = (PutCORSConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutLifecycleConfigurationRequest") {
                var request = (PutLifecycleConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutObjectRequest") {
                var request = (PutObjectRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutObjectLegalHoldRequest") {
                var request = (PutObjectLegalHoldRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutObjectLockConfigurationRequest") {
                var request = (PutObjectLockConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutObjectRetentionRequest") {
                var request = (PutObjectRetentionRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutObjectTaggingRequest") {
                var request = (PutObjectTaggingRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutPublicAccessBlockRequest") {
                var request = (PutPublicAccessBlockRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "RestoreObjectRequest") {
                var request = (RestoreObjectRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "SelectObjectContentRequest") {
                var request = (SelectObjectContentRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "UploadPartRequest") {
                var request = (UploadPartRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "WriteGetObjectResponseRequest") {
                result.UseObjectLambdaEndpoint = true;
                return result;
            }

            return result;
        }
    }
}