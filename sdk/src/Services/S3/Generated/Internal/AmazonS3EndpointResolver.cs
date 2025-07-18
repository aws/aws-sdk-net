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
using System.Linq;
using System.Collections.Generic;
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
            // If the marshalled request has the SSE header and it is set to KMS, force SigV4 for this request.
            // Current operations that may set this header: CopyObject, CopyPart, InitiateMultipart, PutObject
            string sseHeaderValue;
            if (executionContext.RequestContext.Request.Headers.TryGetValue(HeaderKeys.XAmzServerSideEncryptionHeader, out sseHeaderValue) &&
                (string.Equals(sseHeaderValue, ServerSideEncryptionMethod.AWSKMS.Value, StringComparison.Ordinal) || string.Equals(sseHeaderValue, ServerSideEncryptionMethod.AWSKMSDSSE.Value, StringComparison.Ordinal)))
            {
                executionContext.RequestContext.Request.SignatureVersion = SignatureVersion.SigV4;
            }

            InjectHostPrefix(executionContext.RequestContext);
        }

        protected override EndpointParameters MapEndpointsParameters(IRequestContext requestContext)
        {
            var config = (AmazonS3Config)requestContext.ClientConfig;
            var result = new S3EndpointParameters();
            result.Region = requestContext.Request.AlternateEndpoint?.SystemName ?? config.RegionEndpoint?.SystemName;;
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

            // Special handling of GetPreSignedUrlRequest
            if (requestContext.Request.RequestName == "GetPreSignedUrlRequest")
            {
                var request = (GetPreSignedUrlRequest)requestContext.Request.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            // Special handling of CreatePresignedPostRequest
            if (requestContext.Request.RequestName == "CreatePresignedPostRequest")
            {
                var request = (CreatePresignedPostRequest)requestContext.Request.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetACLRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetACLRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutACLRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutACLRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }

            // Assign staticContextParams and contextParam per operation
            if (requestContext.RequestName == "AbortMultipartUploadRequest") {
                var request = (AbortMultipartUploadRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                result.Key = request.Key;
                return result;
            }
            if (requestContext.RequestName == "CompleteMultipartUploadRequest") {
                var request = (CompleteMultipartUploadRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                result.Key = request.Key;
                return result;
            }
            if (requestContext.RequestName == "CopyObjectRequest") {
                result.DisableS3ExpressSessionAuth = true;
                var request = (CopyObjectRequest)requestContext.OriginalRequest;
                result.Bucket = request.DestinationBucket;
                result.Key = request.DestinationKey;
                result.CopySource = request.SourceKey;
                return result;
            }
            if (requestContext.RequestName == "CopyPartRequest") {
                result.DisableS3ExpressSessionAuth = true;
                var request = (CopyPartRequest)requestContext.OriginalRequest;
                result.Bucket = request.DestinationBucket;
                return result;
            }
            if (requestContext.RequestName == "CreateBucketMetadataConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (CreateBucketMetadataConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "CreateBucketMetadataTableConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (CreateBucketMetadataTableConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "CreateSessionRequest") {
                result.DisableS3ExpressSessionAuth = true;
                var request = (CreateSessionRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (DeleteBucketRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketAnalyticsConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (DeleteBucketAnalyticsConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketEncryptionRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (DeleteBucketEncryptionRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketIntelligentTieringConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (DeleteBucketIntelligentTieringConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketInventoryConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (DeleteBucketInventoryConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketMetadataConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (DeleteBucketMetadataConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketMetadataTableConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (DeleteBucketMetadataTableConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketMetricsConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (DeleteBucketMetricsConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketOwnershipControlsRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (DeleteBucketOwnershipControlsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketPolicyRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (DeleteBucketPolicyRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketReplicationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (DeleteBucketReplicationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketTaggingRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (DeleteBucketTaggingRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteBucketWebsiteRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (DeleteBucketWebsiteRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteCORSConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (DeleteCORSConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteLifecycleConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (DeleteLifecycleConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "DeleteObjectRequest") {
                var request = (DeleteObjectRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                result.Key = request.Key;
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
                result.UseS3ExpressControlEndpoint = true;
                var request = (DeletePublicAccessBlockRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketAccelerateConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketAccelerateConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketAclRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketAclRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketAnalyticsConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketAnalyticsConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketEncryptionRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketEncryptionRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketIntelligentTieringConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketIntelligentTieringConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketInventoryConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketInventoryConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketLocationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketLocationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketLoggingRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketLoggingRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketMetadataConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketMetadataConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketMetadataTableConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketMetadataTableConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketMetricsConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketMetricsConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketNotificationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketNotificationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketOwnershipControlsRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketOwnershipControlsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketPolicyRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketPolicyRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketPolicyStatusRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketPolicyStatusRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketReplicationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketReplicationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketRequestPaymentRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketRequestPaymentRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketTaggingRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketTaggingRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketVersioningRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketVersioningRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetBucketWebsiteRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetBucketWebsiteRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetCORSConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetCORSConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetLifecycleConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (GetLifecycleConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "GetObjectRequest") {
                var request = (GetObjectRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                result.Key = request.Key;
                return result;
            }
            if (requestContext.RequestName == "GetObjectAclRequest") {
                var request = (GetObjectAclRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                result.Key = request.Key;
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
                result.Key = request.Key;
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
                result.UseS3ExpressControlEndpoint = true;
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
                result.Key = request.Key;
                return result;
            }
            if (requestContext.RequestName == "ListBucketAnalyticsConfigurationsRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (ListBucketAnalyticsConfigurationsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "ListBucketIntelligentTieringConfigurationsRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (ListBucketIntelligentTieringConfigurationsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "ListBucketInventoryConfigurationsRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (ListBucketInventoryConfigurationsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "ListBucketMetricsConfigurationsRequest") {
                var request = (ListBucketMetricsConfigurationsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "ListDirectoryBucketsRequest") {
                result.UseS3ExpressControlEndpoint = true;
                return result;
            }
            if (requestContext.RequestName == "ListMultipartUploadsRequest") {
                var request = (ListMultipartUploadsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                result.Prefix = request.Prefix;
                return result;
            }
            if (requestContext.RequestName == "ListObjectsRequest") {
                var request = (ListObjectsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                result.Prefix = request.Prefix;
                return result;
            }
            if (requestContext.RequestName == "ListObjectsV2Request") {
                var request = (ListObjectsV2Request)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                result.Prefix = request.Prefix;
                return result;
            }
            if (requestContext.RequestName == "ListPartsRequest") {
                var request = (ListPartsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                result.Key = request.Key;
                return result;
            }
            if (requestContext.RequestName == "ListVersionsRequest") {
                var request = (ListVersionsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                result.Prefix = request.Prefix;
                return result;
            }
            if (requestContext.RequestName == "PutBucketRequest") {
                result.DisableAccessPoints = true;
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutBucketRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketAccelerateConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutBucketAccelerateConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketAclRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutBucketAclRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketAnalyticsConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutBucketAnalyticsConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketEncryptionRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutBucketEncryptionRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketIntelligentTieringConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutBucketIntelligentTieringConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketInventoryConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutBucketInventoryConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketLoggingRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutBucketLoggingRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketMetricsConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutBucketMetricsConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketNotificationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutBucketNotificationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketOwnershipControlsRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutBucketOwnershipControlsRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketPolicyRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutBucketPolicyRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketReplicationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutBucketReplicationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketRequestPaymentRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutBucketRequestPaymentRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketTaggingRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutBucketTaggingRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketVersioningRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutBucketVersioningRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutBucketWebsiteRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutBucketWebsiteRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutCORSConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutCORSConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutLifecycleConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutLifecycleConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "PutObjectRequest") {
                var request = (PutObjectRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                result.Key = request.Key;
                return result;
            }
            if (requestContext.RequestName == "PutObjectAclRequest") {
                var request = (PutObjectAclRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                result.Key = request.Key;
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
                result.UseS3ExpressControlEndpoint = true;
                var request = (PutPublicAccessBlockRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "RenameObjectRequest") {
                var request = (RenameObjectRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                result.Key = request.Key;
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
            if (requestContext.RequestName == "UpdateBucketMetadataInventoryTableConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (UpdateBucketMetadataInventoryTableConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "UpdateBucketMetadataJournalTableConfigurationRequest") {
                result.UseS3ExpressControlEndpoint = true;
                var request = (UpdateBucketMetadataJournalTableConfigurationRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                return result;
            }
            if (requestContext.RequestName == "UploadPartRequest") {
                var request = (UploadPartRequest)requestContext.OriginalRequest;
                result.Bucket = request.BucketName;
                result.Key = request.Key;
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